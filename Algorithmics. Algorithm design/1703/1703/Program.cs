using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                var mas = str.Split('>');
                if (mas[0][0] == mas[1][0]) res++;
            }
            Console.WriteLine(res);
        }
    }
}
