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
            this._task = new Task(Consumer);
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
                    IncludeSubdirectories = option.IncludeSubDires,
                    InternalBufferSize = 65536, //64KB
                    NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.FileName
                };
                FileSystemEventHandler eventHandler = (sender, e) =>
                {
                    Producer(option, e.FullPath);
                };
                RenamedEventHandler renamedEventHandler = (sender, e) =>
                {
                    Producer(option, e.FullPath);
                };
                watcher.Changed += eventHandler;
                watcher.Created += eventHandler;
                watcher.Renamed += renamedEventHandler;
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

        private void Producer(Options option, string fullPath)
        {
            Debug.WriteLine($"监听到的文件:{fullPath}");
            if (!File.Exists(fullPath))
                return;
            var fileInfo = new FileInfo(fullPath);
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
            this._queue.Add(new FilePathPair(fullPath, destPath));
        }

        private void Consumer()
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
