using EmpyrionNetAPIDefinitions;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameIdMappingTools
{
    public class BlockNameIdMapping : IDisposable
    {
        Func<string> GetNameIdMappingFilename { get; }
        public string NameIdMappingFilename => GetNameIdMappingFilename();

        string LastNameIdMappingFilename { get; set; }

        public static Action<string, LogLevel> Log { get; set; } = (m, l) => Console.WriteLine($"[{l}]: {m}");

        public BlockNameIdMapping(Func<string> getNameIdMappingFilename)
        {
            GetNameIdMappingFilename = getNameIdMappingFilename;
        }

        public IReadOnlyDictionary<string, int> NameId
        {
            get {
                if ((_BlockNameIdMapping == null || (!string.IsNullOrEmpty(NameIdMappingFilename) && NameIdMappingFilename != LastNameIdMappingFilename)) && File.Exists(NameIdMappingFilename))
                {
                    LastNameIdMappingFilename = NameIdMappingFilename;

                    Log($"NameIdMapping:'{NameIdMappingFilename}' CurrentDirectory:{Directory.GetCurrentDirectory()}", LogLevel.Message);
                    try { 
                        _BlockNameIdMapping = JsonConvert.DeserializeObject<Dictionary<string, int>>(File.ReadAllText(NameIdMappingFilename));
                        if (_BlockNameIdMappingWatcher == null)
                        {
                            _BlockNameIdMappingWatcher = new FileSystemWatcher(Path.GetDirectoryName(NameIdMappingFilename), Path.GetFileName(NameIdMappingFilename));
                            _BlockNameIdMappingWatcher.Changed += (s, a) => { _BlockNameIdMapping = null; _BlockIdNameMapping = null; };
                            _BlockNameIdMappingWatcher.EnableRaisingEvents = true;
                        }
                    }
                    catch (Exception error) { Log($"NameIdMapping read failed:{error}", LogLevel.Error); }
                    Log($"NameIdMapping:#{_BlockNameIdMapping?.Count}", LogLevel.Message);
                }

                return _BlockNameIdMapping;
            }
        }

        IReadOnlyDictionary<string, int> _BlockNameIdMapping;
        private FileSystemWatcher _BlockNameIdMappingWatcher;

        public IReadOnlyDictionary<int, string> IdName
        {
            get {
                if (_BlockIdNameMapping == null && NameId != null)
                {
                    try { 
                        _BlockIdNameMapping = NameId?.ToDictionary(b => b.Value, b => b.Key);
                        Log($"BlockIdNameMapping convert:#{_BlockIdNameMapping?.Count}", LogLevel.Message);
                    }
                    catch (Exception error) { Log($"BlockIdNameMapping convert failed:{error}", LogLevel.Error); }
                }

                return _BlockIdNameMapping;
            }
        }
        IReadOnlyDictionary<int, string> _BlockIdNameMapping;

        public void Dispose()
        {
            if (_BlockNameIdMappingWatcher != null) _BlockNameIdMappingWatcher.EnableRaisingEvents = false;
        }
    }
}
