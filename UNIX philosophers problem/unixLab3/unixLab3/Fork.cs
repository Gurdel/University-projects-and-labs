using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unixLab3
{
    public class Fork
    {
        public bool enabled = true;

        public Fork()
        {
            enabled = true;
        }

        public Fork(bool e)
        {
            enabled = e;
        }
    }
}
