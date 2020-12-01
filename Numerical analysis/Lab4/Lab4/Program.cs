using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static int N = 3; //k-st tochok
        static int C = 3; //k-st pohidnyh
        static double[] xmas = { -1, 0, 1 };
        static double[,] fmas = { {0, 1, 2 },
                            { 9, -2, 9 },
                            { -32, 0, 32 } };
        static void Main(string[] args)
        {
            double[,] delta = new double[C * N + 1, C * N];
            for (int i = 0; i < N; ++i)
                for(int j = 0; j < C; ++j)
                {
                    delta[0, i*N + j] = xmas[i];
                    delta[1, i*N + j] = fmas[0,i];
                }

            for (int i = 1; i < N * C; ++i) 
            {
                for(int j = 0; j < N * C - i; ++j)
                {
                    if(delta[0, j + i] != delta[0, j])
                    {
                        delta[i + 1, j] = (delta[i, j + 1] - delta[i, j]) / (delta[0, j + i] - delta[0, j]);
                    }
                    else
                    {
                        delta[i + 1, j] = fmas[i, j / N]/i;
                    }
                }
            }

            for (int i = 0; i < N * C; ++i)
                Console.Write($"{delta[0, i]}\t");
            Console.WriteLine();
            for (int i = 1; i <= N * C; ++i)
            {
                for (int j = 0; j < N * C - i+1; ++j)
                {
                    Console.Write($"{delta[i, j]}\t");
                }
                Console.WriteLine();
            }

            string s = "";
            Console.Write("f(x) = ");
            if (delta[1, 0] != 0) Console.Write(delta[1, 0]);
            for (int i = 1; i < N * C; ++i) 
            {
                if (delta[i + 1, 0] != 0)
                {
                    if (delta[i + 1, 0] > 0) Console.Write('+');
                    Console.Write(delta[i + 1, 0]);
                    if(delta[0, i - 1] != 0)
                    {
                        s += "*(x";
                        if (delta[0, i - 1] < 0) s += "+";
                        s += Convert.ToString(delta[0, i - 1] * (-1));
                        s += ")";
                    }
                    else s += "*x";
                    Console.Write(s);
                }
            }
            Console.ReadKey();
        }
    }
}
