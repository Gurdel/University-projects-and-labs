using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _21_koruption
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            string line = sr.ReadLine();
            string[] split = line.Split(' ');
            int n = Convert.ToInt32(split[0]);
            double p = (100 - Convert.ToDouble(split[1])) / 100;

            line = sr.ReadLine();
            List<string> sNombers = line.Split(' ').ToList();
            List<double> dNombers = new List<double>();
            foreach (string s in sNombers)
            {
                dNombers.Add(Convert.ToDouble(s));
            }

            double min1;
            double min2;
            while(dNombers.Count > 1)
            {
                min1 = dNombers.Min();
                dNombers.Remove(min1);
                min2 = dNombers.Min();
                dNombers.Remove(min2);
                dNombers.Insert(0, (min1 + min2) * p);
            }

            StreamWriter sw = new StreamWriter("output.txt");
            sw.Write(dNombers[0]);
            sw.Close();
            sr.Close();
        }
    }
}
