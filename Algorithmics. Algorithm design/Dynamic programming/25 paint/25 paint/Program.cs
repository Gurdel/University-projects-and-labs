using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_paint
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            string line = sr.ReadLine();
            string[] split = line.Split(' ');
            sr.Close();
            int a = Convert.ToInt32(split[0]);
            int b = Convert.ToInt32(split[1]);
            int c = Convert.ToInt32(split[2]);

            int n = 0;
            while (a != 1)
            {
                if (a % 2 == 0) a /= 2;
                else --a;
                ++n;
            }
            while (b != 1)
            {
                if (b % 2 == 0) b /= 2;
                else --b;
                ++n;
            }
            while (c != 1)
            {
                if (c % 2 == 0) c /= 2;
                else --c;
                ++n;
            }

            StreamWriter sw = new StreamWriter("output.txt");
            sw.Write(n);
            sw.Close();

        }
    }
}
