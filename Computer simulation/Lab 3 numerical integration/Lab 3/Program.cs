using System;
using System.Collections.Generic;
using System.Linq;
using org.mariuszgromada.math.mxparser;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string f = "x^4+8*x^2";
            int N = 6;
            double[] xi = {  0.436077411928,
                            -0.436077411928,
                             1.33584907401,
                            -1.33584907401,
                             2.35060497367,
                            -2.35060497367};
            List<List<double>> allL = new List<List<double>>();
            List<double> l1 = new List<double>();
            List<double> l2 = new List<double>();
            l1.Add(1);
            allL.Add(l1);
            l2.Add(0);
            l2.Add(2);
            allL.Add(l2);
            for (int i = 2; i <= N; ++i)
            {
                double n = allL.Count() - 1;
                List<double> lNext = new List<double>();
                lNext.Add(0);
                double k = 2;
                foreach (double x in l2)
                {
                    lNext.Add(x * k);
                }
                k = 2 * (i - 1);
                int ln = l1.Count();
                for (int j = 0; j < ln; ++j)
                {
                    lNext[j] -= k * l1[j];
                }
                l1 = l2;
                l2 = lNext;
                allL.Add(lNext);
            }
            List<double> H1 = new List<double>(allL.Last());
            for (int i = 0; i < H1.Count; ++i)
            {
                H1[i] *= i;
            }
            H1.RemoveAt(0);
            Expression ex = new Expression("sqrt(pi)*(2^" + (N + 1).ToString() + ")*" + (N).ToString() + "!");
            double top = ex.calculate();
            double res = 0.0;
            Console.WriteLine("I6(x) = ");
            foreach (double x in xi)
            {
                string buf = f.Replace("x", "(" + x.ToString() + ")");
                string s = top.ToString() + "*(" + buf + ")" + "/" + getExp(H1, x) + "^2";
                Console.WriteLine("+(" + s + ")");
                Expression e = new Expression(s);
                res += e.calculate();
            }

            Expression integral = new Expression("int((" + f +")*e^(-x^2), x, -9, 9)");
            Console.WriteLine("\n\nI(x) = " + (integral.calculate()).ToString("F" + 20));
            Console.WriteLine("I6(x) = " + res.ToString("F" + 20));
            Console.WriteLine("R = " + (integral.calculate() - res).ToString("F" + 20));
            Console.ReadKey();
        }

        public static string getExp(List<double> h, double x)
        {
            string s = "(";
            for (int i = 0; i < h.Count; ++i)
            {
                if (h[i] != 0)
                {
                    s += "(" + h[i].ToString() + "*(" + x + ")^" + i + ")+";
                }
            }
            s += "0)";
            return s;
        }
    }
}
