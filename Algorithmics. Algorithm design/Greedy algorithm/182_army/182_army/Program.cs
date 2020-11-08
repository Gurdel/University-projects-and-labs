using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _182_army
{
    public class Warrior
    {
        public int g;
        public int h;
        public Warrior(int v1, int v2)
        {
            g = v1;
            h = v2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] split = line.Split(' ');
            int n = Convert.ToInt32(split[0]);
            int g = Convert.ToInt32(split[1]);
            int h = Convert.ToInt32(split[2]);
            List<Warrior> W = new List<Warrior>();
            for(int i = 0; i < n; ++i)
            {
                line = Console.ReadLine();
                split = line.Split(' ');
                W.Add(new Warrior(Convert.ToInt32(split[0]), Convert.ToInt32(split[1])));
            }

            if (n < g+h)
            {
                Console.WriteLine("-1");
            }
            else
            {
                int maxPower = 0;
                List<int> G = new List<int>();
                List<int> H = new List<int>();
                int mg;
                int mh;
                while(n!=g && n!=h)
                {
                    mg = 0;
                    mh = 0;
                    G.Clear();
                    H.Clear();
                    G.Add(mg);
                    H.Add(mh);
                    for (int i = 1; i < W.Count; ++i)
                    {
                        if (W[i].g > W[mg].g)
                        {
                            G.Clear();
                            mg = i;
                            G.Add(i);
                        } else
                        if (W[i].g == W[mg].g)
                        {
                            G.Add(i);
                        }

                        if (W[i].h > W[mh].h)
                        {
                            H.Clear();
                            mh = i;
                            H.Add(i);
                        } else
                        if (W[i].h == W[mh].h)
                        {
                            H.Add(i);
                        }
                    }
                    int minh = G[0];
                    for (int i = 1; i < G.Count(); ++i)
                    {
                        if (W[G[i]].h < W[G[minh]].h) minh = G[i];
                    }
                    int ming = H[0];
                    for (int i = 1; i < H.Count(); ++i)
                    {
                        if (W[H[i]].g < W[G[ming]].g) ming = G[i];
                    }

                    if (W[minh].g > W[ming].h) { --n; if (g > 0) --g; maxPower += W[minh].g; W.RemoveAt(minh); } else
                    if (W[ming].h > W[minh].g) { --n; if (h > 0) --h; maxPower += W[ming].h; W.RemoveAt(ming); } else
                    if (W[ming].h == W[minh].g)
                    {
                        --n;
                        if (h > 0)
                        {
                            if (h > 0) --h;
                            maxPower += W[ming].h;
                            W.RemoveAt(ming);
                        } else
                        {
                            if (g > 0) --g;
                            maxPower += W[minh].g;
                            W.RemoveAt(minh);
                        }
                    }
                }
                if (n == g)
                {
                    foreach(Warrior w in W)
                    {
                        maxPower += w.g;
                    }
                }
                if (n == h)
                {
                    foreach (Warrior w in W)
                    {
                        maxPower += w.h;
                    }
                }
                Console.WriteLine(maxPower);
            }

            Console.ReadKey();
        }
    }
}
