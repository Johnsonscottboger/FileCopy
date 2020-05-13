using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy.Model
{
    public class Options
    {
        public string Name { get; set; }

        public string SourcePath { get; set; }

        public string TargetPath { get; set; }

        public string Filter { get; set; }

        public bool IncludeSubDires { get; set; }

        public bool Enable { get; set; } = true;
    }
}
