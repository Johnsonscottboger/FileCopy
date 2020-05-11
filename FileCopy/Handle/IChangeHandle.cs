using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy.Handle
{
    public interface IChangeHandle
    {
        void Copy(string sourceFileName, string destPath);
    }
}
