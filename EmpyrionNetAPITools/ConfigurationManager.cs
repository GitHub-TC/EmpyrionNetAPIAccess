using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EmpyrionNetAPITools
{
    public enum ConfigurationFileFormat
    {
        JSON,
        XML
    }

    public class ConfigurationManager<T>
    {
        public string ConfigFilename {
            get => _mConfigFilename;
            set {
                _mConfigFilename = value;
                try{ Directory.CreateDirectory(Path.GetDirectoryName(ConfigFilename)); } catch {}
                ActivateFileChangeWatcher();
            }
        }
        string _mConfigFilename;

        FileSystemWatcher mConfigFileChangedWatcher { get; set; }

        public T Current { get; set; }

        public static Action<string> Log { get; set; }
        public ConfigurationFileFormat FileFormat { get; set; } = ConfigurationFileFormat.JSON;

        private void ActivateFileChangeWatcher()
        {
            if (mConfigFileChangedWatcher != null) mConfigFileChangedWatcher.EnableRaisingEvents = false;
            mConfigFileChangedWatcher = new FileSystemWatcher
            {
                Path = Path.GetDirectoryName(ConfigFilename),
                NotifyFilter = NotifyFilters.LastWrite,
                Filter = Path.GetFileName(ConfigFilename)
            };
            mConfigFileChangedWatcher.Changed += (s, e) => Load();
            mConfigFileChangedWatcher.EnableRaisingEvents = true;
        }

        public void Load()
        {
            try
            {
                Log?.Invoke($"ConfigurationManager load '{ConfigFilename}'");
                switch (FileFormat)
                {
                    default:
                    case ConfigurationFileFormat.JSON:
                        Current = JsonConvert.DeserializeObject<T>(File.ReadAllText(ConfigFilename));
                        break;
                    case ConfigurationFileFormat.XML:
                        var serializer = new XmlSerializer(typeof(T));
                        using (var reader = XmlReader.Create(ConfigFilename))
                        {
                            Current = (T)serializer.Deserialize(reader);
                        }
                        break;
                }
            }
            catch (Exception Error)
            {
                Log?.Invoke($"ConfigurationManager load '{ConfigFilename}' error {Error}");
                Current = (T)Activator.CreateInstance(typeof(T));
            }
        }

        public void Save()
        {
            try
            {
                Log?.Invoke($"ConfigurationManager save '{ConfigFilename}'");
                mConfigFileChangedWatcher.EnableRaisingEvents = false;
                Directory.CreateDirectory(Path.GetDirectoryName(ConfigFilename));
                switch (FileFormat)
                {
                    default:
                    case ConfigurationFileFormat.JSON:
                        File.WriteAllText(ConfigFilename, JsonConvert.SerializeObject(Current, Newtonsoft.Json.Formatting.Indented));
                        break;
                    case ConfigurationFileFormat.XML:
                        var serializer = new XmlSerializer(typeof(T));
                        using (var writer = XmlWriter.Create(ConfigFilename, new XmlWriterSettings() { Indent = true, IndentChars = "  " }))
                        {
                            serializer.Serialize(writer, Current);
                        }
                        break;
                }
                Log?.Invoke($"ConfigurationManager saved '{ConfigFilename}'");
            }
            catch (Exception Error)
            {
                Log?.Invoke($"ConfigurationManager save '{ConfigFilename}' error {Error}");
            }
            finally
            {
                mConfigFileChangedWatcher.EnableRaisingEvents = true;
            }
        }

    }
}
