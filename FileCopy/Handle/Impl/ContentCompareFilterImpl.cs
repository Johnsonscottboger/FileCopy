using FileCopy.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy.Handle.Impl
{
    public class ContentCompareFilterImpl : IChangeFilter
    {
        public bool CanContinue(Options options, string fullPath)
        {
            var fileInfo = new FileInfo(fullPath);
            var targetPath = options.TargetPath;
            var subDir = fileInfo.Directory.FullName.Replace(options.SourcePath, "");
            var destPath = string.IsNullOrEmpty(subDir) ? targetPath : targetPath + subDir;

            var sourceFileName = fullPath;
            var destinFileName = Path.Combine(destPath, fileInfo.Name);

            if (!File.Exists(sourceFileName) || !File.Exists(destinFileName))
                return true;

            using (var sourceFs = new FileStream(sourceFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var destinFs = new FileStream(destinFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var sourceReader = new StreamReader(sourceFs))
                using (var destinReader = new StreamReader(destinFs))
                {
                    var c = sourceReader.Read();

                }
            }

            return true;
        }
    }
}
