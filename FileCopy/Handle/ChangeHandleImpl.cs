using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy.Handle
{
    public class ChangeHandleImpl : IChangeHandle
    {
        public void Copy(string sourceFileName, string destPath)
        {
            if (!Directory.Exists(destPath))
                Directory.CreateDirectory(destPath);
            var fileInfo = new FileInfo(sourceFileName);
            var destFileName = Path.Combine(destPath, fileInfo.Name);
            try
            {
                File.Copy(sourceFileName, destFileName, true);
            }
            catch
            {
                //忽略异常
            }
        }
    }
}
