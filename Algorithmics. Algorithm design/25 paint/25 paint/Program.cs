using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_paint
{
    class Program
    {
        public const ulong N = 101;
        public const ulong MAX = 2000000000;

        public static ulong[,] dp = new ulong[N, N];

        public static ulong calculate(ulong a, ulong start_value)
        {
            for (ulong i = 0; i <= a; ++i)
                for (ulong j = 0; j <= a; ++j) dp[i,j] = MAX;

            dp[1,1] = start_value;
            for (ulong i = 1; i <= a; ++i)
            {
                for (ulong buf = 1; buf <= i; ++buf)
                {
                    ulong tmp = dp[i - buf,buf] + 2;
                    if (tmp < dp[i,buf]) dp[i,buf] = tmp;
                    for (ulong j = 1; j < buf; ++j)
                    {
                        if (dp[i,j] + 2 < dp[i,buf]) dp[i,buf] = dp[i,j] + 2;
                        else if (dp[i,buf] + 2 < dp[i,j]) dp[i,j] = dp[i,buf] + 2;
                    }
                }
            }
            ulong Min = MAX;
            for (ulong i = 1; i <= a; ++i) if (dp[a,i] < Min) Min = dp[a,i];
            return Min;
        }

        public static ulong calc(ulong a, ulong b)
        {
            ulong Min = calculate(a, 4);
            if (b == 1) return Min;
            return calculate(b, dp[a,a]);
        }

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] buf = line.Split(' ');
            ulong[] data = new ulong[3];
            data[0] = Convert.ToUInt32(buf[0]);
            data[1] = Convert.ToUInt32(buf[1]);
            data[2] = Convert.ToUInt32(buf[2]);
            //  sort(input, input + 3);
            ulong min = calc(data[2], data[1]);
            if (data[0] == 1) Console.WriteLine(min);
            else Console.WriteLine(calculate(data[0], dp[data[1],data[1]]));
        }
    }
}
