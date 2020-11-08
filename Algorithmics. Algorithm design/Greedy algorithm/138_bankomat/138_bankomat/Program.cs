using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _138_bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int k;
            k = n / 500;
            s += k;
            n = n - k * 500;

            k = n / 200;
            s += k;
            n = n - k * 200;


            k = n / 100;
            s += k;
            n = n - k * 100;


            k = n / 50;
            s += k;
            n = n - k * 50;


            k = n / 20;
            s += k;
            n = n - k * 20;


            k = n / 10;
            s += k;
            n = n - k * 10;

            if (n != 0) Console.WriteLine("-1");
            else Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
