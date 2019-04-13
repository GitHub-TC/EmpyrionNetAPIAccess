﻿using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EmpyrionNetAPITools
{
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
        public bool UseJSON { get; set; }

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
                if (UseJSON)
                {
                    Current = JsonConvert.DeserializeObject<T>(File.ReadAllText(ConfigFilename));
                }
                else
                {
                    var serializer = new XmlSerializer(typeof(T));
                    using (var reader = XmlReader.Create(ConfigFilename))
                    {
                        Current = (T)serializer.Deserialize(reader);
                    }
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
                if (UseJSON)
                {
                    File.WriteAllText(ConfigFilename, JsonConvert.SerializeObject(Current, Newtonsoft.Json.Formatting.Indented));
                }
                else {
                    var serializer = new XmlSerializer(typeof(T));
                    using (var writer = XmlWriter.Create(ConfigFilename, new XmlWriterSettings() { Indent = true, IndentChars = "  " }))
                    {
                        serializer.Serialize(writer, Current);
                    }
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
