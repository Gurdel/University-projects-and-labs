using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaLab1
{
    class Program
    {
        private const int MAX_LENGTH = 15;//макс довжина слів
        private const int n = 1000000;
        private const int p = 31;
        private static uint[] pmas = new uint[MAX_LENGTH];//масив степенів р для ф-ції хешування
        private const int m = 100000321;
        private static string letters = "abcdefghijklmnopqrstuvwxyz   ";

        static void Main(string[] args)
        {
            List<string>[] table = new List<string>[m];

            GenerateInputFile("input.txt");
            FillPowersP();
            FillHashTable(ref table, "input.txt", "log.txt");
            MakeHistogram(ref table, "hist.txt");
            ResultsOutput(ref table, "output.txt");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static int h(string x)
        {
            ulong res = 0;
            List<char> c = x.ToList();
            for (int i = 0; i < c.Count; ++i)
            {
                res = (res + (pmas[i] * (ulong)letters.IndexOf(c[i]) % m)) % m;
            }
            return (int)res;
        }

        private static void GenerateInputFile(string fname)
        {
            Console.WriteLine("generation step 0");
            List<char> c = letters.ToList();
            int k = n / 10;
            string[] sm = new string[k];
            Random rand = new Random();

            Console.WriteLine("generation step 1");
            for (int j = 0; j < MAX_LENGTH; ++j)
            {
                for (int i = 0; i < k; ++i)
                {
                    sm[i] += c[rand.Next(0, 29)];
                    sm[i] = sm[i].TrimEnd(' ');
                }
            }

            Console.WriteLine("generation step 2");
            StreamWriter sw = new StreamWriter(fname);
            char[] oper = new char[] { '+', '+', '?', '-' };
            for (int j = 0; j < 10; ++j)
            {
                for (int i = 0; i < k; ++i)
                {
                    sw.Write(oper[rand.Next(4)]);
                    sw.Write(' ');
                    sw.WriteLine(sm[i]);
                }
            }
            sw.WriteLine("##");
            sw.Close();

            Console.WriteLine("generation complete");
        }

        private static void FillHashTable(ref List<string>[] table, string fname, string logname)
        {
            string line = "";
            StreamReader sr = new StreamReader(fname);
            StreamWriter sw = new StreamWriter(logname);

            Console.WriteLine("Working with hashtable");
            int count = 0;//лічильник для візуалізації процесу виконання програми
            while (true)
            {
                if (++count % 10000 == 0) Console.WriteLine(count / 10000);

                line = sr.ReadLine();
                if (line.Equals("##")) break;

                string[] spl = line.Split(' ');
                string x = " ";
                if (spl.Count() == 2)
                {
                    x = spl[1];
                }

                if (spl[0].Equals("+"))
                {
                    if(AddToHashTable(ref table, x))
                    {
                        sw.WriteLine("+ " + x);
                    }
                    else
                    {
                        sw.WriteLine("! + " + x);
                    }
                }
                else
                {
                    if (spl[0].Equals("-"))
                    {
                        if (RemoveFromHashTable(ref table, x))
                        {
                            sw.WriteLine("- " + x);
                        }
                        else
                        {
                            sw.WriteLine("- ?-" + x);
                        }
                    }
                    else
                    {
                        if (spl[0].Equals("?"))
                        {
                            if (SearchInHashTable(ref table, x))
                            {
                                sw.WriteLine("?+ " + x);
                            }
                            else
                            {
                                sw.WriteLine("?- " + x);
                            }
                        }
                    }
                }
            }
            sw.Close();
            sr.Close();
        }

        private static void MakeHistogram(ref List<string>[] table, string fname)
        {
            Console.WriteLine("Making a histogram");
            StreamWriter sw = new StreamWriter(fname);
            int q = 0;
            for (int i = 0; i < m; ++i)
            {
                if (table[i] != null)
                {
                    sw.WriteLine(q);
                    q = 0;
                    foreach (string s in table[i])
                    {
                        sw.Write(s + ' ');
                    }
                    sw.WriteLine("____________________________________");
                }
                else
                {
                    ++q;
                }
            }
            sw.WriteLine(q);
            sw.Close();
        }

        private static void ResultsOutput(ref List<string>[] table, string fname)
        {
            Console.WriteLine("Results");
            StreamWriter sw = new StreamWriter(fname);
            for (int i = 0; i < m; ++i)
            {
                if (i % 1000000 == 0) Console.WriteLine(i / 1000000);
                if (table[i] != null)
                {
                    while (table[i].Count > 0)
                    {
                        string word = table[i][0];
                        while (table[i].Remove(word))
                        {
                            sw.Write(word + ' ');
                        }
                        sw.WriteLine();
                    }
                }
            }
            sw.Close();
        }

        private static void FillPowersP()
        {
            pmas[0] = 1;
            for (int i = 1; i < MAX_LENGTH; ++i)
            {
                pmas[i] = (pmas[i - 1] * p) % m;
            }
        }

        private static bool AddToHashTable(ref List<string>[] table, string x)
        {
            try
            {
                int t = h(x);
                if (table[t] == null) table[t] = new List<string>();
                table[t].Add(x);
                if (table[t].Count == 0)
                    table[t] = null;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool RemoveFromHashTable(ref List<string>[] table, string x)
        {
            try
            {
                bool res = false;
                int t = h(x);
                if (table[t] == null) table[t] = new List<string>();
                if (table[t].Remove(x)) res = true;
                if (table[t].Count == 0)
                    table[t] = null;
                return res;
            }
            catch
            {
                return false;
            }
        }

        private static bool SearchInHashTable(ref List<string>[] table, string x)
        {
            try
            {
                int t = h(x);
                if (table[t] == null) table[t] = new List<string>();
                if (table[t].Contains(x))
                {
                    if (table[t].Count == 0)
                        table[t] = null;
                    return true;
                }
                else
                {
                    if (table[t].Count == 0)
                        table[t] = null;
                    return false;
                }
            }
            catch
            {
                int t = h(x);
                if (table[t] == null) table[t] = new List<string>();
                if (table[t].Count == 0)
                    table[t] = null;
                return false;
            }
            
        }
    }
}
