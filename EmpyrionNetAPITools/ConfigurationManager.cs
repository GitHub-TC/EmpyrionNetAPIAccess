﻿using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EmpyrionNetAPITools
{
    public enum ConfigurationFileFormat
    {
        Default,
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
        public Action<T> CreateDefaults { get; set; }
        public ConfigurationFileFormat FileFormat { get; set; } = ConfigurationFileFormat.Default;
        public event EventHandler ConfigFileLoaded;

        public ConfigurationFileFormat SelectFileFormat
        {
            get {
                switch (FileFormat)
                {
                    case ConfigurationFileFormat.Default:
                        switch (Path.GetExtension(ConfigFilename).ToLower())
                        {
                            case ".json":   return ConfigurationFileFormat.JSON;
                            case ".xml":    return ConfigurationFileFormat.XML;
                            default:        return ConfigurationFileFormat.JSON;
                        }
                    default: return FileFormat;
                }
            }
        }

        public Exception LoadException { get; private set; }

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
                LoadException = null;

                if (!File.Exists(ConfigFilename))
                {
                    Log?.Invoke($"ConfigurationManager file not found '{ConfigFilename}' create defaults");
                    Current = (T)Activator.CreateInstance(typeof(T));
                    CreateDefaults?.Invoke(Current);
                    return;
                }

                switch (SelectFileFormat)
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

                ConfigFileLoaded?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception Error)
            {
                LoadException = Error;
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
                switch (SelectFileFormat)
                {
                    default:
                    case ConfigurationFileFormat.JSON:
                        var data = JsonConvert.SerializeObject(Current, Newtonsoft.Json.Formatting.Indented);
                        if (!File.Exists(ConfigFilename) || File.ReadAllText(ConfigFilename) != data) File.WriteAllText(ConfigFilename, data);
                        else                                                                          Log?.Invoke($"ConfigurationManager no change '{ConfigFilename}'");
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
