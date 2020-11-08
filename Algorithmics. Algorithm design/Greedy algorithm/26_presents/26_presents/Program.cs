using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _26_presents
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            string line = sr.ReadLine();
            int n = Convert.ToInt32(line);
            line = sr.ReadLine();
            List<string> spl = line.Split(' ').ToList();
            List<int> gurka = new List<int>();
            List<int> dead = new List<int>();
            foreach (string str in spl)
                gurka.Add(Convert.ToInt32(str));
            line = sr.ReadLine();
            spl.Clear();
            spl = line.Split(' ').ToList();
            foreach (string str in spl)
                dead.Add(Convert.ToInt32(str));
            sr.Close();




            Console.ReadKey();
        }
    }
}
