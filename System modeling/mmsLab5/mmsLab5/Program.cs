using System;
using System.Collections.Generic;
using System.Threading;

namespace mmsLab5
{
    class Program
    {
        static List<int> vimposition = new List<int>();
        static List<double> timestart = new List<double>();

        static double Tmod = 10000.0;
        static double curtime = 0.0;
        static double o = 0.0;
        static double ta = o;
        static double t11 = o;
        static double t12 = o;
        static double t2 = o;

        static int generator = 1;
        static int start = 0;
        static int queue = 0;
        static int enabled = 6;
        static int k1 = 2;
        static int buf1 = 0;
        static int buf2 = 0;
        static int k2 = 1;
        static int serv = 0;
        static int unserv = 0;

        static double a = 0.2;
        static double m1 = 0.1;
        static double m2 = 0.2;

        static Statistic stat = new Statistic();
        static Random rand = new Random();
        static void Main(string[] args)
        {
            while (CanChanged())
            {
                double mint = Tmod;
                if (ta != o && ta < mint) mint = ta;
                if (t11 != o && t11 < mint) mint = t11;
                if (t12 != o && t12 < mint) mint = t12;
                if (t2 != o && t2 < mint) mint = t2;

                if (mint == t2)
                {
                    ++serv;
                    ++k2;
                    curtime = t2;
                    t2 = o;
                    int i = vimposition.IndexOf(4);
                    stat.Serv(curtime - timestart[i]);
                    vimposition.RemoveAt(i);
                    timestart.RemoveAt(i);
                }
                if (mint == t11)
                {
                    ++buf2;
                    ++k1;
                    curtime = t11;
                    t11 = o;
                    int i = vimposition.IndexOf(2);
                    vimposition[i] = 3;
                }
                if (mint == t12)
                {
                    ++buf2;
                    ++k1;
                    curtime = t12;
                    t12 = o;
                    int i = vimposition.IndexOf(2);
                    vimposition[i] = 3;
                }
                if (mint == ta)
                {
                    ++start;
                    ++generator;
                    curtime = ta;
                    ta = o;

                    vimposition.Add(0);
                    timestart.Add(curtime);
                }

                bool changed;
                do
                {
                    changed = false;
                    if (buf2 > 0 && k2 > 0)
                    {
                        --buf2;
                        --k2;
                        t2 = curtime + m2 + (0.5 - rand.NextDouble()) * m2;
                        changed = true;
                        int i = vimposition.IndexOf(3);
                        vimposition[i] = 4;
                    }
                    if (buf1 > 0)
                    {
                        --buf1;
                        if (t11 == o) 
                        { 
                            t11 = curtime + m1 + (0.5 - rand.NextDouble()) * m1; 
                        }
                        else
                        {
                            if (t12 == o)
                            {
                                t12 = curtime + m1 + (0.5 - rand.NextDouble()) * m1;
                            }
                            else
                            {
                                Console.WriteLine("THERE");
                            }
                        }
                        changed = true;
                    }
                    if (queue > 0 && k1 > 0)
                    {
                        --queue;
                        --k1;
                        ++buf1;
                        ++enabled;
                        changed = true;


                        int i = vimposition.IndexOf(1);
                        vimposition[i] = 2;
                    }
                    if (start > 0 && enabled > 0)
                    {
                        --start;
                        --enabled;
                        ++queue;
                        changed = true;

                        int i = vimposition.IndexOf(0);
                        vimposition[i] = 1;
                    }
                    if (generator > 0)
                    {
                        --generator;
                        ta = curtime + a + (0.5 - rand.NextDouble()) * a;
                        changed = true;
                    }
                } while (changed);

                if (start > 0)
                {
                    unserv += start;
                    start = 0;

                    int i = vimposition.IndexOf(0);
                    vimposition.RemoveAt(i);
                    timestart.RemoveAt(i);
                }
                if (buf2 > 0) 
                {
                    unserv += buf2;
                    buf2 = 0;

                    int i = vimposition.IndexOf(3);
                    while(i != -1)
                    {
                        vimposition.RemoveAt(i);
                        timestart.RemoveAt(i);
                        i = vimposition.IndexOf(3);
                    }
                }

                stat.Next(curtime, queue, 2 - k1, 1 - k2);
            }

            stat.Results(Tmod, serv, unserv);
        }
    
        static bool CanChanged()
        {
            if (ta != o && ta < Tmod) return true;
            if (t11 != o && t11 < Tmod) return true;
            if (t12 != o && t12 < Tmod) return true;
            if (t2 != o && t2 < Tmod) return true;
            if (curtime == 0) return true;
            return false;
        }
    
        static void ChangeStatus(int s)
        {
            int i = vimposition.IndexOf(s);
            if (i != -1)
            {

            }
        }
    }
}
