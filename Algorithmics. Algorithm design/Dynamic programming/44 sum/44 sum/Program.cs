using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] res = new int[9999];
            res[1] = 1;
            for (int i = 2; i <= n; ++i)
            {
                res[i] = i;
                for (int j = 1; 2 * j < i; j++)
                    if (res[j] + res[i - j] < res[i]) res[i] = res[j] + res[i - j];
                for (int j = 2; j * j <= i; j++)
                    if (i % j == 0 && res[j] + res[i / j] < res[i]) res[i] = res[j] + res[i / j];
            }
            Console.WriteLine(res[n]);
        }
    }
}
