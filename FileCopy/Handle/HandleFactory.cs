using FileCopy.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileCopy.Handle
{
    public class HandleFactory
    {
        private static readonly Lazy<HandleFactory> _instance = new Lazy<HandleFactory>(() => new HandleFactory(), true);

        private HandleFactory()
        {

        }

        public static HandleFactory Instance { get { return _instance.Value; } }

        private IEnumerable<FileSystemWatcher> _fileSystemWatchers;

        public void Register(IEnumerable<Options> options)
        {
            Stop();
            var list = new List<FileSystemWatcher>();
            foreach (var option in options)
            {
                if (!Directory.Exists(option.SourcePath))
                    continue;
                var watcher = new FileSystemWatcher()
                {
                    Path = option.SourcePath,
                    IncludeSubdirectories = option.IncludeSubDires
                };
                watcher.Changed += (sender, e) =>
                {
                    if (!File.Exists(e.FullPath))
                        return;
                    var fileInfo = new FileInfo(e.FullPath);
                    if (!string.IsNullOrWhiteSpace(option.Filter))
                    {
                        var fileName = fileInfo.Name;
                        var regex = new Regex(option.Filter, RegexOptions.Compiled | RegexOptions.ExplicitCapture);
                        if (!regex.IsMatch(fileName))
                            return;
                    }
                    var targetPath = option.TargetPath;
                    var subDir = fileInfo.Directory.FullName.Replace(option.SourcePath, "");
                    var handler = GetHandler();
                    handler.Copy(e.FullPath, string.IsNullOrEmpty(subDir) ? targetPath : targetPath + subDir);
                };
                list.Add(watcher);
            }
            this._fileSystemWatchers = list;
        }

        public void Start()
        {
            if (this._fileSystemWatchers != null)
            {
                foreach (var item in this._fileSystemWatchers)
                {
                    item.EnableRaisingEvents = true;
                }
            }
        }

        public void Stop()
        {
            if (this._fileSystemWatchers != null)
            {
                foreach (var item in this._fileSystemWatchers)
                {
                    item.EnableRaisingEvents = false;
                }
            }
        }

        public IChangeHandle GetHandler()
        {
            return new ChangeHandleImpl();
        }
    }
}
