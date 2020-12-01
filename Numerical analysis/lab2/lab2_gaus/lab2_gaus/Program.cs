using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_gaus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            double[,] a = new double [4,4] { 
                { 4, 2, 2, 2},
                {2, -3, -1, -1 }, 
                {2, -1, -4, -2}, 
                {2, -1, -2, 3}
            };

            double[] b = new double[4] { 8, -6, -9, 3};
            double[] x = new double[4] { 0, 0, 0, 0};
            
            int _j;
            List<int> q = new List<int>();

            for (int i = 0; i < n; ++i)
            {
                _j = 0;
                for(int j = 0; j < n; ++j)
                {
                    if ((!q.Contains(j)) && (Math.Abs(a[i,j]) > Math.Abs(a[i,_j])))
                    {
                        _j = j;
                    }
                }

                q.Add(_j);
                double buf = a[i, _j];
                for (int j = 0; j < n; ++j)
                {
                    a[i, j] = a[i, j] / buf;
                }
                b[i] = b[i] / buf;

                for (int k = i+1; k < n; ++k)
                {
                    buf = a[k, _j];
                    for (int j = 0; j < n; ++j)
                    {
                        a[k, j] = a[k, j] - a[i, j] * buf;
                    }
                    b[k] = b[k] - b[i] * buf;
                }

                Console.WriteLine($"{i+1})");
                for (int k = 0; k < n; ++k)
                {
                    for (int l = 0; l < n; ++l)
                    {
                        Console.Write($"{a[k, l]} \t");
                    }
                    Console.WriteLine($"| {b[k]}");
                }
                Console.WriteLine();
            }

            for (int i = n-1; i >= 0; --i)
            {
                for (int k = 0; k < n; ++k)
                {
                    b[i] = b[i] - a[i, k] * x[k];
                }
                x[q[i]] = b[i];
            }

            for (int k = 0; k < n; ++k)
            {
                Console.WriteLine($"x{k+1} = {x[k]}");
            }
                Console.ReadKey();
        }
    }
}
