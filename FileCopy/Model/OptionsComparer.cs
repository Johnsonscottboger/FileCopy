using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy.Model
{
    public class OptionsComparer : IEqualityComparer<Options>
    {
        public bool Equals(Options x, Options y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;
            return x.SourcePath == y.SourcePath
                && x.TargetPath == y.TargetPath
                && x.Filter == y.Filter;
        }

        public int GetHashCode(Options obj)
        {
            if (obj == null)
                return 0;
            return (obj.SourcePath?.GetHashCode() ?? 0)
                 ^ (obj.TargetPath?.GetHashCode() ?? 0)
                 ^ (obj.Filter?.GetHashCode() ?? 0);
        }
    }
}
