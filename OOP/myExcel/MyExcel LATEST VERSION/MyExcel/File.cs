using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyExcel
{
    public class File
    {
        private string FileName { get; set; }
        public string[] Lines { get; set; }

        public bool Open(string name)
        {
            FileName = name;
            Lines = System.IO.File.ReadAllLines(FileName);
            return true;
        }
    }
}
