using System;
using System.IO;

namespace kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input1.txt");
            string s1 = sr.ReadToEnd();
            sr.Close();
            sr = new StreamReader("input2.txt");
            string s2 = sr.ReadToEnd();
            sr.Close();
            sr = new StreamReader("main.cpp");
            string s3 = sr.ReadToEnd();
            sr.Close();

            Normalizator norm = new Normalizator("Grammar.txt");
            s1 = norm.GetNormalizedCode(s1);
            s2 = norm.GetNormalizedCode(s2);
            s3 = norm.GetNormalizedCode(s3);

            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(s2);
            sw.Close();

            Plagiator plag = new Plagiator();

            Console.WriteLine("LongestCommonSubstringTest: " + plag.LongestCommonSubstringTest(s1, s1));
            Console.WriteLine("WShinglingTest: " + plag.WShinglingTest(s1, s1));
            Console.WriteLine("AveragePlagTest: " + plag.AveragePlagTest(s1, s1));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("LongestCommonSubstringTest: " + plag.LongestCommonSubstringTest(s1, s2));
            Console.WriteLine("WShinglingTest: " + plag.WShinglingTest(s1, s2));
            Console.WriteLine("AveragePlagTest: " + plag.AveragePlagTest(s1, s2));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("LongestCommonSubstringTest: " + plag.LongestCommonSubstringTest(s1, s3));
            Console.WriteLine("WShinglingTest: " + plag.WShinglingTest(s1, s3));
            Console.WriteLine("AveragePlagTest: " + plag.AveragePlagTest(s1, s3));

        }
    }
}
