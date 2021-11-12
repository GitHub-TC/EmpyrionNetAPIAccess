using EmpyrionNetAPITools.Extensions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using YamlDotNet.RepresentationModel;

namespace EmpyrionNetAPITools
{
    public class EmpyrionConfiguration
    {
        static Lazy<string> ProgramPathLazy { get; } = new Lazy<string>(() => Environment.GetCommandLineArgs().Contains("-GameDir")
                                                                            ? Environment.GetCommandLineArgs().SkipWhile(A => string.Compare(A, "-GameDir", StringComparison.InvariantCultureIgnoreCase) != 0).Skip(1).FirstOrDefault()
                                                                            : GetDirWith(Directory.GetCurrentDirectory(), "BuildNumber.txt"));
        public static string ProgramPath => ProgramPathLazy.Value;

        static Lazy<string> ModPathLazy { get; } = new Lazy<string>(() => Path.Combine(ProgramPath, @"Content\Mods"));
        public static string ModPath => ModPathLazy.Value;

        static Lazy<string> DedicatedFilenameLazy { get; } = new Lazy<string>(() => Environment.GetCommandLineArgs().Contains("-dedicated")
                                                                            ? Environment.GetCommandLineArgs().SkipWhile(A => string.Compare(A, "-dedicated", StringComparison.InvariantCultureIgnoreCase) != 0).Skip(1).FirstOrDefault()
                                                                            : (Environment.GetCommandLineArgs().Any(A => A.Contains("configFile="))
                                                                                ? Environment.GetCommandLineArgs().SkipWhile(A => !A.Contains("configFile=")).FirstOrDefault()?.Substring("configFile=".Length)
                                                                                : "dedicated.yaml"
                                                                                ));

        public static string DedicatedFilename => DedicatedFilenameLazy.Value;

        public static IReadOnlyDictionary<string, int> BlockNameIdMapping
        {
            get {
                if (_BlockNameIdMapping == null) 
                    try{ _BlockNameIdMapping = ReadBlockMapping(Path.Combine(SaveGamePath, @"blocksmap.dat")); }
                    catch (Exception error) { Console.WriteLine(error); } 

                return _BlockNameIdMapping;
            }
        }
        static IReadOnlyDictionary<string, int> _BlockNameIdMapping;

        public static IReadOnlyDictionary<int, string> BlockIdNameMapping
        {
            get {
                if (_BlockIdNameMapping == null)
                    try { _BlockIdNameMapping = BlockNameIdMapping.ToDictionary(b => b.Value, b => b.Key); }
                    catch (Exception error) { Console.WriteLine(error); }
                
                return _BlockIdNameMapping;
            }
        }
        static IReadOnlyDictionary<int, string> _BlockIdNameMapping;


        public static string GetDirWith(string aTestDir, string aTestFile)
        {
            if (aTestDir == null) return string.Empty;

            return File.Exists(Path.Combine(aTestDir, aTestFile))
                ? aTestDir
                : GetDirWith(Path.GetDirectoryName(aTestDir), aTestFile);
        }

        public static string SaveGamePath
        {
            get { return Path.Combine(ProgramPath ?? string.Empty, DedicatedYaml?.SaveDirectory ?? "Saves", "Games", DedicatedYaml?.SaveGameName ?? "");  }
        }

        public static string SaveGameCachePath
        {
            get { return Path.Combine(ProgramPath ?? string.Empty, DedicatedYaml?.SaveDirectory ?? "Saves", "Cache", DedicatedYaml?.SaveGameName ?? ""); }
        }

        public static string ModName { get; set; }

        public static string SaveGameModPath
        {
            get { return Path.Combine(SaveGamePath, "Mods", ModName ?? String.Empty); }
        }

        static Lazy<DedicatedYamlStruct> DedicatedYamlLazy { get; } = new Lazy<DedicatedYamlStruct>(() => new DedicatedYamlStruct(Path.Combine(ProgramPath, DedicatedFilename)));
        public static DedicatedYamlStruct DedicatedYaml => DedicatedYamlLazy.Value;
        static Lazy<AdminconfigYamlStruct> AdminconfigYamlLazy { get; } = new Lazy<AdminconfigYamlStruct>(() => new AdminconfigYamlStruct(Path.Combine(ProgramPath, "Saves", "adminconfig.yaml")));
        public static AdminconfigYamlStruct AdminconfigYaml => AdminconfigYamlLazy.Value;

        public static string Version
        {
            get {
                try
                {
                    var lines = File.ReadAllLines(Path.Combine(ProgramPath, "BuildNumber.txt"));
                    var version = lines.Skip(1).FirstOrDefault()?.Trim();
                    var versionStart = version.IndexOf("\"");
                    var versionEnd = version.IndexOf("\"", versionStart + 1);
                    return versionEnd == -1 ? version : version.Substring(versionStart + 1, versionEnd - versionStart - 1).Trim();
                }
                catch
                {
                    return "???";
                }
            }
        }

        public static string BuildVersion
        {
            get {
                try
                {
                    return File.ReadAllLines(Path.Combine(ProgramPath, "BuildNumber.txt"))
                        .FirstOrDefault()?
                        .Trim();
                }
                catch
                {
                    return "???";
                }
            }
        }

        public static IReadOnlyDictionary<string, int> ReadBlockMapping(string filename)
        {
            if (!File.Exists(filename)) return null;

            var result = new ConcurrentDictionary<string, int>();

            var fileContent = File.ReadAllBytes(filename);
            for (var currentOffset = 9; currentOffset < fileContent.Length;)
            {
                var len = fileContent[currentOffset++];
                var name = System.Text.Encoding.ASCII.GetString(fileContent, currentOffset, len);
                currentOffset += len;

                var id = fileContent[currentOffset++] | fileContent[currentOffset++] << 8;

                result.AddOrUpdate(name, id, (s, i) => id);
            }

            return result;
        }


        public class DedicatedYamlStruct
        {
            private FileSystemWatcher mDedicatedYamlFileWatcher;

            public string SaveGameName { get; private set; }
            public string CustomScenarioName { get; private set; }
            public string ServerName { get; private set; }
            public string SaveDirectory { get; private set; }

            public DedicatedYamlStruct(string aFilename)
            {
                if (!File.Exists(aFilename)) return;

                Load(aFilename);

                mDedicatedYamlFileWatcher = new FileSystemWatcher
                {
                    Path = Path.GetDirectoryName(aFilename),
                    NotifyFilter = NotifyFilters.LastWrite,
                    Filter = Path.GetFileName(aFilename)
                };
                mDedicatedYamlFileWatcher.Changed += (s, e) => TaskTools.Delay(10, () => Load(aFilename));
                mDedicatedYamlFileWatcher.EnableRaisingEvents = true;
            }

            private void Load(string aFilename)
            {
                using (var input = new StringReader(File.ReadAllText(aFilename)))
                {
                    var yaml = new YamlStream();
                    yaml.Load(input);

                    var Root = (YamlMappingNode)yaml.Documents[0].RootNode;

                    var ServerConfigNode = Root.GetChild<YamlMappingNode>("ServerConfig");

                    ServerName          = ServerConfigNode.GetChild<YamlNode>("Srv_Name")?.ToString();
                    SaveDirectory       = ServerConfigNode.GetChild<YamlNode>("SaveDirectory")?.ToString();

                    var GameConfigNode  = Root.GetChild<YamlMappingNode>("GameConfig");

                    SaveGameName        = GameConfigNode.GetChild<YamlNode>("GameName")?.ToString();
                    CustomScenarioName  = GameConfigNode.GetChild<YamlNode>("CustomScenario")?.ToString();
                }
            }
        }

        public class AdminconfigYamlStruct
        {
            private FileSystemWatcher mAdminconfigYamlFileWatcher;

            public IEnumerable<ElevatedUserStruct> ElevatedUsers { get; private set; }
            public IEnumerable<BannedUserStruct> BannedUsers { get; private set; }

            public class ElevatedUserStruct
            {
                public string SteamId { get; set; }
                public string Name { get; set; }
                public int Permission { get; set; }
            }
            public class BannedUserStruct
            {
                public string SteamId { get; set; }
                public DateTime Until { get; set; }
            }

            public AdminconfigYamlStruct(string aFilename)
            {
                if (!File.Exists(aFilename)) return;

                Load(aFilename);

                mAdminconfigYamlFileWatcher = new FileSystemWatcher
                {
                    Path = Path.GetDirectoryName(aFilename),
                    NotifyFilter = NotifyFilters.LastWrite,
                    Filter = Path.GetFileName(aFilename)
                };
                mAdminconfigYamlFileWatcher.Changed += (s, e) => TaskTools.Delay(10, () => Load(aFilename));
                mAdminconfigYamlFileWatcher.EnableRaisingEvents = true;
            }

            private void Load(string aFilename)
            {
                using (var input = new StringReader(File.ReadAllText(aFilename)))
                {
                    var yaml = new YamlStream();
                    yaml.Load(input);

                    var Root = (YamlMappingNode)yaml.Documents[0].RootNode;

                    var ElevatedNode = Root.GetChild<YamlSequenceNode>("Elevated")?.Children;

                    ElevatedUsers = ElevatedNode?.OfType<YamlMappingNode>().Select(N =>
                    {
                        return new ElevatedUserStruct()
                        {
                            SteamId = N.Children[new YamlScalarNode("Id")]?.ToString(),
                            Name = N.GetChild<YamlNode>("Name")?.ToString(),
                            Permission = int.TryParse(N.GetChild<YamlNode>("Permission")?.ToString(), out int Result) ? Result : 0,
                        };
                    }).ToArray();

                    var BannedNode = Root.GetChild<YamlSequenceNode>("Banned")?.Children;

                    BannedUsers = BannedNode?.OfType<YamlMappingNode>().Select(N =>
                    {
                        return new BannedUserStruct()
                        {
                            SteamId = N.GetChild<YamlNode>("Id")?.ToString(),
                            Until = DateTime.TryParse(N.GetChild<YamlNode>("Until")?.ToString(), out DateTime Result) ? Result : DateTime.MinValue,
                        };
                    }).ToArray();
                }
            }
        }
    }
}
