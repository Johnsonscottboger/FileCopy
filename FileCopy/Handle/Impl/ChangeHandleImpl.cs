using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopy.Handle.Impl
{
    public class ChangeHandleImpl : IChangeHandle
    {
        public void Copy(string sourceFileName, string destPath)
        {
            if (!Directory.Exists(destPath))
                Directory.CreateDirectory(destPath);
            var fileInfo = new FileInfo(sourceFileName);
            var destFileName = Path.Combine(destPath, fileInfo.Name);
            var e = 0;
            do
            {
                try
                {
                    File.Copy(sourceFileName, destFileName, true);
                    e = 0;
                }
                catch (Exception ex)
                {
                    if(ex is IOException && ex.Message.Contains(destFileName))
                    {
                        break;
                    }
                    Debug.WriteLine(ex);
                    e++;
                }
            } while (e > 0 && e < 10);
        }
    }
}
