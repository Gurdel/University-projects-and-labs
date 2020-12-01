using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_yakobi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            double[,] a = new double[4, 4] {
                { 4, 2, 2, 2},
                {2, -3, -1, -1 },
                {2, -1, -4, -2},
                {2, -1, -2, 3}
            };

            double[] b = new double[4] { 8, -6, -9, 3 };
            double[] x = new double[4] { 0, 0, 0, 0 };
            double[] x_next = new double[4] { 0, 0, 0, 0 };
            double e = 0.0001;
            bool exit = false;
            double buf = 0;
            int k = 1;

            while (!exit)
            {
                exit = true;
                for (int i = 0; i < n; ++i)
                {
                    buf = 0;
                    for (int j = 0; j < n; ++j)
                    {
                        buf = buf + a[i, j] * x[j];
                    }
                    if (Math.Abs(b[i] - buf) > e)
                    {
                        exit = false;
                        break;
                    }
                }
                if (exit) break;


                for (int i = 0; i < n; ++i)
                {
                    buf = 0;
                    for (int j = 0; j < i; ++j)
                    {
                        buf = buf + a[i, j] * x[j];
                    }
                    for (int j = i+1; j < n; ++j)
                    {
                        buf = buf + a[i, j] * x[j];
                    }
                    x_next[i] = (b[i] - buf) / a[i, i];
                }

                x = x_next;

                Console.Write($"\n{k})\t");
                for (int i = 0; i < n; ++i)
                {
                    Console.Write($"{x[i].ToString("F" + 10)}\t");
                }
                ++k;
            }

            Console.WriteLine("EXIT");
            Console.ReadKey();
        }
    }
}
