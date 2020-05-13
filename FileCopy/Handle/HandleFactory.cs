using FileCopy.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace FileCopy.Handle
{
    public class HandleFactory
    {
        private static readonly Lazy<HandleFactory> _instance = new Lazy<HandleFactory>(() => new HandleFactory(), true);

        private readonly BlockingCollection<FilePathPair> _queue = new BlockingCollection<FilePathPair>();

        private readonly Task _task;

        private HandleFactory()
        {
            this._task = new Task(Handle);
        }

        public static HandleFactory Instance { get { return _instance.Value; } }

        private IEnumerable<FileSystemWatcher> _fileSystemWatchers;

        public void Register(IEnumerable<Options> options)
        {
            Stop();
            var list = new List<FileSystemWatcher>();
            foreach (var option in options)
            {
                if (!option.Enable)
                    continue;
                if (!Directory.Exists(option.SourcePath))
                    continue;
                var watcher = new FileSystemWatcher()
                {
                    Path = option.SourcePath,
                    IncludeSubdirectories = option.IncludeSubDires
                };
                FileSystemEventHandler eventHandler = (sender, e) =>
                {
                    if (!File.Exists(e.FullPath))
                        return;
                    var fileInfo = new FileInfo(e.FullPath);
                    if (fileInfo.Attributes.HasFlag(FileAttributes.Hidden))
                        return;
                    if (!string.IsNullOrWhiteSpace(option.Filter))
                    {
                        var fileName = fileInfo.Name;
                        var regex = new Regex(option.Filter, RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
                        if (!regex.IsMatch(fileName))
                            return;
                    }
                    var targetPath = option.TargetPath;
                    var subDir = fileInfo.Directory.FullName.Replace(option.SourcePath, "");
                    var destPath = string.IsNullOrEmpty(subDir) ? targetPath : targetPath + subDir;
                    this._queue.Add(new FilePathPair(e.FullPath, destPath));
                };
                watcher.Changed += eventHandler;
                watcher.Created += eventHandler;
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
                if (this._task.Status == TaskStatus.Created)
                    this._task.Start();
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

        private void Handle()
        {
            foreach (var filePathPair in this._queue.GetConsumingEnumerable())
            {
                var handler = GetHandler();
                handler.Copy(filePathPair.SourceFileName, filePathPair.DestPath);
            }
        }

        private class FilePathPair
        {
            public string SourceFileName { get; private set; }

            public string DestPath { get; private set; }

            public FilePathPair(string sourceFileName, string destPath)
            {
                this.SourceFileName = sourceFileName;
                this.DestPath = destPath;
            }
        }
    }
}
