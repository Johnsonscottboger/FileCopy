using FileCopy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy.Handle
{
    public interface IChangeFilter
    {
        bool CanContinue(Options options, string fullPath);
    }
}
