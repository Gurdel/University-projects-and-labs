using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115_dvi_cifry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 1;
            int c = 2;
            int buf = 0;
            int i = 1;
            while (n > i)
            {
                ++i;
                buf = a + b + c;
                a = b;
                b = c;
                c = buf;
            }
            Console.WriteLine(c);
        }
    }
}
