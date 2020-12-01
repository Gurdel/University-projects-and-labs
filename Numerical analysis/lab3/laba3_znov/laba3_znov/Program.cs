using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_znov
{
    class Program
        {
            static void Main(string[] args)
            {
                double[,] zero = new double[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                double[,] a = new double[3, 3] { { 3, 2, 1 }, { 2, 2, 5 }, { 1, 5, 1 } };
                double[,] u = new double[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                double[,] aaa_trans_u = new double[3, 3] { { 1, 1, 1 }, { 0, 0, 0 }, { 0, 0, 0 } };
                double[,] b = new double[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                double e = 0.1;

                int count = 0;
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
                            if (Math.Abs(a[i, j]) > Math.Abs(a[im, jm]) && i != j)
                            {
                                im = i;
                                jm = j;
                            }
                        }
                    }
                    //find angle
                    double f = 0.5 * Math.Atan((2 * a[im, jm]) / (a[im, im] - a[jm, jm]));
                //find u and aaa_trans_u
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        u[i, j] = 0;
                        aaa_trans_u[i, j] = 0;
                    }
                }
                
                    for (int i = 0; i < 3; ++i)
                    {
                        u[i, i] = 1;
                        aaa_trans_u[i, i] = 1;
                    }
                    buf = Math.Cos(f);
                    u[im, im] = buf;
                    u[jm, jm] = buf;
                    aaa_trans_u[im, im] = buf;
                    aaa_trans_u[jm, jm] = buf;
                    buf = (-1.0) * Math.Sin(f);
                    u[im, jm] = buf;
                    aaa_trans_u[jm, im] = buf;
                    buf = Math.Sin(f);
                    u[jm, im] = buf;
                    aaa_trans_u[im, jm] = buf;
                //iteration
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        b[i, j] = 0;
                    }
                }
                //b = aaa_trans_u * a
                for (int i = 0; i < 3; ++i)
                    {
                        for (int j = 0; j < 3; ++j)
                        {
                            buf = 0;
                            for (int k = 0; k < 3; ++k)
                            {
                                buf += u[k, i] * a[k, j];
                            }
                            b[i, j] = buf;
                        }
                    }
                    //a = b * u = aaa_trans_u * a * u
                    for (int i = 0; i < 3; ++i)
                    {
                        for (int j = 0; j < 3; ++j)
                        {
                            buf = 0;
                            for (int k = 0; k < 3; ++k)
                            {
                                buf += b[i, k] * u[k, j];
                            }
                            a[i, j] = buf;
                        }
                    }

                    //visual
                    ++count;
                    Console.WriteLine($"{count})\nf = {f.ToString("F" + 10)}");
                    for (int i = 0; i < 3; ++i)
                    {
                        for (int j = 0; j < 3; ++j)
                        {
                            Console.Write($"{a[i, j].ToString("F" + 10)}\t");
                        }
                        Console.Write("\t|\t)");
                        for (int j = 0; j < 3; ++j)
                        {
                            Console.Write($"{u[i, j].ToString("F" + 10)}\t");
                        }
                        Console.Write("\t|\t)");
                        for (int j = 0; j < 3; ++j)
                        {
                            Console.Write($"{aaa_trans_u[i, j].ToString("F" + 10)}\t");
                        }
                        Console.WriteLine();
                    }
                }
                Console.ReadKey();
            }
        }
    }
