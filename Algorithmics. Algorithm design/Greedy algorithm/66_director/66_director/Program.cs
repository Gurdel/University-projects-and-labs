using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _66_director
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt", System.Text.Encoding.Default);
            string line = sr.ReadLine();
            int n = Convert.ToInt32(line);
            List<int> Start = new List<int>();
            List<int> End = new List<int>();
            
            for(int i = 0; i < n; ++i)
            {
                line = sr.ReadLine();
                string[] split = line.Split(' ', ':');
                Start.Add(Convert.ToInt32(split[0])*100 + Convert.ToInt32(split[1]));
                End.Add(Convert.ToInt32(split[2])*100 + Convert.ToInt32(split[3]));
            }
            sr.Close();
            int minEnd;
            int res = 0;

            while (End.Count() > 0)
            {
                minEnd = End.Min();
                ++res;
                int i = 0;
                while (i < Start.Count())
                {
                    if (Start[i] < minEnd)
                    {
                        Start.RemoveAt(i);
                        End.RemoveAt(i);
                    }
                    else ++i;
                }
                i = 0;
                while (i < End.Count())
                {
                    if (End[i] == minEnd)
                    {
                        Start.RemoveAt(i);
                        End.RemoveAt(i);
                    }
                    else ++i;
                }
            }

            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(res);
            sw.Close();
        }
    }
}
