using FileCopy.Handle;
using FileCopy.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy.Config
{
    public class ConfigManager
    {
        private static readonly string _config = AppDomain.CurrentDomain.BaseDirectory + "\\config.json";

        private static readonly FileSystemWatcher _fileSystemWatcher;


        private static List<Options> _options;

        public static List<Options> Options 
        { 
            get
            {
                if(_options == null)
                    _options = new List<Options>();
                return _options;
            }
            private set
            {
                _options = value;
            }
        }

        static ConfigManager()
        {
            Load();
            _fileSystemWatcher = RegisterWatcher();
        }

        public static List<Options> Load()
        {
            if(!File.Exists(_config))
            {
                File.Create(_config);
            }
            var text = File.ReadAllText(_config);
            Options = JsonConvert.DeserializeObject<List<Options>>(text);
            return Options;
        }

        public static void Save()
        {
            var text = JsonConvert.SerializeObject(Options, Formatting.Indented);
            File.WriteAllText(_config, text);
        }

        private static FileSystemWatcher RegisterWatcher()
        {
            var watcher = new FileSystemWatcher(AppDomain.CurrentDomain.BaseDirectory, "*.json");
            watcher.EnableRaisingEvents = true;
            watcher.Changed += (s, e) =>
            {
                try
                {
                    if (e.FullPath != _config)
                    {
                        var text = File.ReadAllText(_config);
                        var options = JsonConvert.DeserializeObject<List<Options>>(text);
                        HandleFactory.Instance.Register(options);
                        HandleFactory.Instance.Start();
                    }
                }
                catch
                {
                    //忽略异常
                }
            };
            return watcher;
        }
    }
}
