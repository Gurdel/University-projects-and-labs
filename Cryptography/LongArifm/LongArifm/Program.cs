using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongArifm
{
    class Program
    {
        static void Main(string[] args)
        {
            LongCalculator calc = new LongCalculator();

            while (true)
            {
                Console.Write('>');
                string s = Console.ReadLine();
                string[] spl = s.Split(' ');
                if (spl.Length == 1) break;
                if (spl.Length == 3)
                {
                    if (spl[1] == ">") Console.WriteLine(calc.More(spl[0], spl[2]));
                    if (spl[1] == "<") Console.WriteLine(calc.Less(spl[0], spl[2]));
                    if (spl[1] == "=") Console.WriteLine(calc.Equal(spl[0], spl[2]));
                    if (spl[1] == "+") Console.WriteLine(calc.Add(spl[0], spl[2]));
                    if (spl[1] == "-") Console.WriteLine(calc.Sub(spl[0], spl[2]));
                    if (spl[1] == "*") Console.WriteLine(calc.Mult(spl[0], spl[2]));
                    if (spl[1] == "/") Console.WriteLine(calc.Div(spl[0], spl[2]));
                    if (spl[1] == "%") Console.WriteLine(calc.Mod(spl[0], spl[2]));
                    if (spl[1] == "^") Console.WriteLine(calc.Pow(spl[0], spl[2]));
                    if (spl[1] != "china" || spl[1] != "china2") continue;
                }
                if (spl.Length == 4)
                {
                    if (spl[1] == "+") Console.WriteLine(calc.Add(spl[0], spl[2], spl[3]));
                    if (spl[1] == "-") Console.WriteLine(calc.Sub(spl[0], spl[2], spl[3]));
                    if (spl[1] == "*") Console.WriteLine(calc.Mult(spl[0], spl[2], spl[3]));
                    if (spl[1] == "/") Console.WriteLine(calc.Div(spl[0], spl[2], spl[3]));
                    if (spl[1] == "%") Console.WriteLine(calc.Mod(spl[0], spl[2], spl[3]));
                    if (spl[1] == "^") Console.WriteLine(calc.Pow(spl[0], spl[2], spl[3]));
                    continue;
                }
                if (spl.Length == 2)
                {
                    if (spl[0] == "sqrt")
                    {
                        Console.WriteLine(calc.Sqrt(spl[1]));
                    }
                    continue;
                }
                if (spl.Contains("china") || spl.Contains("china2"))
                {
                    List<string> bi = new List<string>();
                    List<string> ai = new List<string>();
                    int l = spl.Length/2;
                    int i = 0;
                    for (; i < l; ++i)
                    {
                        bi.Add(spl[i]);
                    }
                    l = spl.Length;
                    for (++i; i < l; ++i)
                    {
                        ai.Add(spl[i]);
                    }
                    if (spl.Contains("china")) Console.WriteLine(calc.China(bi, ai));
                    if (spl.Contains("china2")) Console.WriteLine(calc.China2(bi, ai));
                }
            }
        }
    }
}
