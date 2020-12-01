using System;

namespace trap
{
    class Program
    {
        static double a = 0;
        static double b = 2;
        static int n = 200;

        static double f1(double x)
        {
            return 2 * x + 4 * Math.Cos(x);
        }

        static void Main(string[] args)
        {
            double h = Math.Abs(a - b) / n;

            double res = 0;
            res += (f1(a) + f1(b))/2;

            for (double x = a + h; x < b; x += h)
            {
                res += f1(x);
            }

            res = res * h;
            Console.Write("integral = ");
            Console.WriteLine(res);

            double M = 2; //max abs f``(x) [a; b]
            double d = h * h * (b - a) * M / 12;
            Console.Write("delta = ");
            Console.WriteLine(d);
            
            Console.ReadKey();
        }
    }
}
