using System;
namespace Simpson
{
    class Program
    {
        static double a = 0;
        static double b = 2;
        static int n = 200; //n=2k

        static double f1(double x)
        {
            return 2 * x + 4 * Math.Cos(x);
        }

        static void Main(string[] args)
        {
            double h = Math.Abs(a - b) / n;

            double res = 0;
            res += f1(a) + f1(b);

            for (double x = a+h; x < b; x += 2*h)
            {
                res += (4 * f1(x));
            }

            for (double x = a + 2*h; x < b; x += 2 * h)
            {
                res += (2 * f1(x));
            }

            res = res * h / 3;
            Console.Write("integral = ");
            Console.WriteLine(res);

            double M = 4; //max abs f````(x) [a; b]
            double d = h * h * h * h * (b - a) * M / 180;
            Console.Write("delta = ");
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
