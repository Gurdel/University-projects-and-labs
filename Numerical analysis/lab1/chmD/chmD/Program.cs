using System;

namespace chmD
{
    class Program
    {
        public static double F (double x)
        {
            return (3.0 * x + Math.Cos(x) + 1.0);
        }

        static void Main(string[] args)
        {
            double a = -1;
            double b = 1;
            double x = 0;
            double e = 0.0001;
            double f = F(x);
            int i = 0;
            Console.WriteLine($"{i}) \t a = {a.ToString("F" + 10)} ;\t b = {b.ToString("F" + 10)} ;\t x = {x.ToString("F" + 10)} ; \t f = {f.ToString("F" + 10)} ;");
            while (Math.Abs(f) > e)
            {
                if (Math.Sign(F(a)) == Math.Sign(F(x)))
                    a = x;
                if (Math.Sign(F(b)) == Math.Sign(F(x)))
                    b = x;

                x = (a + b) / 2;
                f = F(x);
                ++i;
                Console.WriteLine($"{i}) \t a = {a.ToString("F" + 10)} ;\t b = {b.ToString("F" + 10)} ;\t x = {x.ToString("F" + 10)} ; \t f = {f.ToString("F" + 10)} ;");
            }
            Console.ReadKey();
        }
    }
}
