using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_chess
{
    class Program
    {
        public static double Turn(int k1, int k2, int p1, int p2)
        {
            if (k1 > 8 || k1 < 1 || k2 > 8 || k2 < 1) return 1;
            if (k1 == p1 && k2 == p2) return -1;
            if (p2 == 8) return 1;
            ++p2;
            if (k1 == p1 && k2 == p2) return 0.5;
            double a = 1;
            bool np = false;

            a = Turn(k1 + 2, ++k2, p1, p2);
            if (a == -1) return -1;
            else if (a == 0.5) np = true;

            a = Turn(k1 + 2, --k2, p1, p2);
            if (a == -1) return -1;
            else if (a == 0.5) np = true;

            a = Turn(k1 - 2, ++k2, p1, ++p2);
            if (a == -1) return -1;
            else if (a == 0.5) np = true;

            a = Turn(k1 - 2, --k2, p1, ++p2);
            if (a == -1) return -1;
            else if (a == 0.5) np = true;

            a = Turn(++k1, k2 + 2, p1, p2);
            if (a == -1) return -1;
            else if (a == 0.5) np = true;

            a = Turn(--k1, k2 + 2, p1, p2);
            if (a == -1) return -1;
            else if (a == 0.5) np = true;

            a = Turn(++k1, k2 - 2, p1, p2);
            if (a == -1) return -1;
            else if (a == 0.5) np = true;

            a = Turn(--k1, k2 - 2, p1, p2);
            if (a == -1) return -1;
            else if (a == 0.5) np = true;

            if (np) return 0.5;
            return 1;
        }
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] buf = line.Split(' ');
            int k1 = 0, k2, p1 = 0, p2;
            if (buf[0][0].Equals('a')) k1 = 1;
            if (buf[0][0].Equals('b')) k1 = 2;
            if (buf[0][0].Equals('c')) k1 = 3;
            if (buf[0][0].Equals('d')) k1 = 4;
            if (buf[0][0].Equals('e')) k1 = 5;
            if (buf[0][0].Equals('f')) k1 = 6;
            if (buf[0][0].Equals('g')) k1 = 7;
            if (buf[0][0].Equals('h')) k1 = 8;
            string i = buf[0];
            i = i.Remove(0, 1);
            k2 = Convert.ToInt32(i);
            if (buf[1][0].Equals('a')) p1 = 1;
            if (buf[1][0].Equals('b')) p1 = 2;
            if (buf[1][0].Equals('c')) p1 = 3;
            if (buf[1][0].Equals('d')) p1 = 4;
            if (buf[1][0].Equals('e')) p1 = 5;
            if (buf[1][0].Equals('f')) p1 = 6;
            if (buf[1][0].Equals('g')) p1 = 7;
            if (buf[1][0].Equals('h')) p1 = 8;
            i = buf[1];
            i = i.Remove(0, 1);
            p2 = Convert.ToInt32(i);
            if (p2 != 2)
                Console.WriteLine(Turn(p1, p2, k1, k2));
            else
            {
                double a1 = Turn(p1, p2, k1, k2);
                double a2 = Turn(p1, p2, k1, ++k2);
                if (a1 == -1 || a2 == -1) Console.WriteLine("-1");
                else
                    if (a1 == 0.5 || a2 == 0.5) Console.WriteLine("0.5");
                else
                    Console.WriteLine("1");
            }
            Console.ReadKey();
        }
    }
}
