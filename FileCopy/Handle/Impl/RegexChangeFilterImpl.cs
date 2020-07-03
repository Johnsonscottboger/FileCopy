using FileCopy.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileCopy.Handle.Impl
{
    public class RegexChangeFilterImpl : IChangeFilter
    {
        public bool CanContinue(Options options, string fullPath)
        {
            if (!string.IsNullOrWhiteSpace(options.Filter))
            {
                var fileInfo = new FileInfo(fullPath);
                var fileName = fileInfo.Name;
                var regex = new Regex(options.Filter, RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
                if (!regex.IsMatch(fileName))
                    return false;
            }
            return true;
        }
    }
}
