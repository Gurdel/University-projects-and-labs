using System;
//using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _480
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var mas = str.Split(' ');
            long a = long.Parse(mas[0]);
            long b = long.Parse(mas[1]);
            long c = long.Parse(mas[2]);
            //Console.WriteLine(BigInteger.ModPow(a, b, c));
        }
    }
}
