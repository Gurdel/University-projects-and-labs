using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_obert_yakobi
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[3, 3] { { 3, 2, 1 }, { 2, 2, 5 }, { 1, 5, 1 } };
            double[,] u = new double[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            double[,] ut = new double[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            double[,] b = new double[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            double e = 0.001;
            int t = 4;
            int count = 0;
            Console.WriteLine($"{count})\nf = 0,00");
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    Console.Write($"{a[i, j].ToString("F" + t)}\t");
                }
                Console.Write("\t|\t");
                for (int j = 0; j < 3; ++j)
                {
                    Console.Write($"{u[i, j].ToString("F" + t)}\t");
                }
                Console.Write("\t|\t");
                for (int j = 0; j < 3; ++j)
                {
                    Console.Write($"{ut[i, j].ToString("F" + t)}\t");
                }
                Console.WriteLine();
            }
            while (true)
            {
                //exit?
                double buf = 0;
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        if (i != j)
                        {
                            buf += a[i, j] * a[i, j];
                        }
                    }
                }
                if (buf < e) break;
                //find max elem
                int im = 0;
                int jm = 1;
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        if(Math.Abs(a[i,j]) > Math.Abs(a[im,jm]) && i!=j)
                        {
                            im = i;
                            jm = j;
                        }
                    }
                }
                //find angle
                double f = 0.5 * Math.Atan((2 * a[im, jm]) / (a[im, im] - a[jm, jm]));
                //find u and ut
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        u[i, j] = 0;
                        ut[i, j] = 0;
                    }
                }
                for (int i = 0; i < 3; ++i)
                {
                    u[i, i] = 1;
                    ut[i, i] = 1;
                }
                buf = Math.Cos(f);
                u[im, im] = buf;
                u[jm, jm] = buf;
                ut[im, im] = buf;
                ut[jm, jm] = buf;
                buf = (-1.0) * Math.Sin(f);
                u[im, jm] = buf;
                ut[jm, im] = buf;
                buf = Math.Sin(f);
                u[jm, im] = buf;
                ut[im, jm] = buf;
                //iteration
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        b[i, j] = 0;
                    }
                }
                //b = ut * a
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        buf = 0;
                        for (int k = 0; k < 3;  ++k)
                        {
                            buf += ut[i, k] * a[k, j];
                        }
                        b[i, j] = buf;
                    }
                }
                //a = b * u = ut * a * u
                double q;
                double w;
                double res;
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        buf = 0;
                        for (int k = 0; k < 3; ++k)
                        {
                            q = b[i, k];
                            w = u[k, j];
                            res = q * w;
                            buf += res;
                        }
                        a[i, j] = buf;
                    }
                }

                //visual
                ++count;
                Console.WriteLine($"\n{count})\nf = {f.ToString("F" + t)}");
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        Console.Write($"{a[i, j].ToString("F" + t)}\t");
                    }
                    Console.Write("\t|\t");
                    for (int j = 0; j < 3; ++j)
                    {
                        Console.Write($"{u[i, j].ToString("F" + t)}\t");
                    }
                    Console.Write("\t|\t");
                    for (int j = 0; j < 3; ++j)
                    {
                        Console.Write($"{ut[i, j].ToString("F" + t)}\t");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
