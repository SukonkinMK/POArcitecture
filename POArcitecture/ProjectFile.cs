using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    public class ProjectFile
    {
        public ProjectFile(string fileName)
        {
            FileName = fileName;
            Setting1 = 1;
            Setting2 = "asd";
            Setting3 = true;
        }

        public string FileName {  get; }
        public int Setting1 { get; }
        public string Setting2 { get; }
        public bool Setting3 { get; }
    }
}
