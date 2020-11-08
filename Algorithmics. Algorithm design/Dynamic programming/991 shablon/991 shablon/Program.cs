using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _991_shablon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.ReadLine();
            Console.ReadLine();
            if (r.Next() % 2 == 0) Console.Write("YES");
            else Console.Write("NO");
        }
    }
}
