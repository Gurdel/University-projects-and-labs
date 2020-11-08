using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _609_water
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] split = line.Split(' ');
            int m = Convert.ToInt32(split[1]);

            line = Console.ReadLine();
            List<string> sNombers = line.Split(' ').ToList();
            List<int> dNombers = new List<int>();
            foreach (string s in sNombers)
            {
                dNombers.Add(Convert.ToInt32(s));
            }
            int c = 0;
            int n = 0;
            int free;
            int seccond;
            if (dNombers.Max() > m)
            {
                Console.WriteLine("Impossible");
            }
            else
            {
                dNombers.Sort();
                while(dNombers.Count > 0)
                {
                    c = dNombers.Max();
                    dNombers.Remove(c);
                    free = m - c;
                    seccond = 0;
                    foreach (int i in dNombers)
                    {
                        if (i > free) break;
                        seccond = i;
                    }
                    dNombers.Remove(seccond);
                    ++n;
                }
                Console.WriteLine(n);
                Console.ReadKey();
            }
        }
    }
}
