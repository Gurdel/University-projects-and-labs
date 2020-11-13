using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_komp_mod
{
    class Program
    {
        public static double F(double x, double y)
        {
            return x * x - 2.0 * y;
        }

        public static double U(double x)
        {
            return 0.25 - 0.5 * x + 0.5 * x * x + 0.75 * Math.Exp(-2.0 * x);
        }

        static void Main(string[] args)
        {
            double yn = 1.0;
            double xn = 0.0;
            double yb = 0.0;
            double h = 0.1;
            double xb = xn - h / 2;
            int n = 10;
            double r = 0.0;
            double z = 0.0;
            Console.WriteLine("i \tXi \tYi \t\tUi \t\tZi \t\tRt");
            Console.WriteLine();
            for (int i = 0; i <= n; ++i)
            {
                Console.WriteLine(i+"\t"+xn.ToString("F" + 2) + "\t" + yn.ToString("F" + 6) + "\t" + U(xn).ToString("F" + 6) 
                    + "\t" + z.ToString("F" + 6) + "\t" + r.ToString("F" + 6));
                
                xn += h;
                xb += h;
                yb = yn + h * F(xn, yn) / 2;
                yn = yn + h * F(xb, yb);
                z = yn - U(xn);
                r += Math.Abs(z);
            }
            Console.ReadKey();
        }
    }
}
