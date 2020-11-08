using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5855_max_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            string line = sr.ReadLine();
            string[] split = line.Split(' ');
            int m = Convert.ToInt32(split[0]);
            int n = Convert.ToInt32(split[1]);
            int[,] mass = new int[200, 200]; 

            for (int i = 0; i < m; ++i)
            {
                line = sr.ReadLine();
                split = line.Split(' ');
                for (int j = 0; j <n; ++j)
                {
                    mass[i, j] = Convert.ToInt32(split[j]);
                }
            }

            sr.Close();

            for(int i = 1; i < m; ++i)
            {
                int _i = i - 1;
                mass[i, 0] += Math.Max(mass[_i, 0], mass[_i, 1]);
                mass[i,n-1] += Math.Max(mass[_i, n-2], mass[_i, n-1]);
                for (int j = 1; j<n-1; ++j)
                {
                    mass[i, j] += Math.Max(Math.Max(mass[_i, j - 1], mass[_i, j]), mass[_i, j + 1]);
                }
            }

            int _m = m - 1;
            int max = mass[_m, 0];
            int count = 1;
            for (int i = 1; i < n; ++i)
            {
                if (mass[_m, i] == max) ++count;
                if (mass[_m, i] > max) { max = mass[_m, i]; count = 1; }
            }

            StreamWriter sw = new StreamWriter("output.txt");
            sw.Write($"{max} {count}");
            sw.Close();

        }
    }
}
