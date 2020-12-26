using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unixLab3
{
    public class Philosopher
    {
        public int timer = 1;
        public bool left = false;
        public bool right = false;
        public string status = "think";

        public Philosopher()
        {
            timer = 1;
            left = false;
            right = false;
            status = "think";
        }

        public Philosopher(int t, bool l, bool r, string s)
        {
            timer = t;
            left = l;
            right = r;
            status = s;
        }
    }
}
