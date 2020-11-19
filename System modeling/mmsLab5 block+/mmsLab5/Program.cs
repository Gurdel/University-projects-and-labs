using System;
using System.Collections.Generic;
using System.Threading;

namespace mmsLab5
{
    class Program
    {
        static List<int> vimposition = new List<int>();
        static List<double> timestart = new List<double>();

        static double Tmod = 100.0;
        static double curtime = 0.0;
        static double o = 0.0;
        static double ta = o;
        static double t11 = o;
        static double t12 = o;
        static double t2 = o;
        static double t11start = o;
        static double t12start = o;
        static double t2start = o;
        static double qprev = o;
        static double dt = o;


        static double t11sum = o;
        static double t12sum = o;
        static double t2sum = o;
        static double qav = o;

        static int generator = 1;
        static int start = 0;
        static int queue = 0;
        static int enabled = 6;
        static int k1 = 2;
        static int buf1 = 0;
        static int buf2 = 0;
        static int buf = 0;
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
            Console.WriteLine("Lab5 block\n");

            while (CanChanged())
            {
                double mint = Tmod;
                if (ta != o && ta < mint) mint = ta;
                if (t11 != o && t11 < mint) mint = t11;
                if (t12 != o && t12 < mint) mint = t12;
                if (t2 != o && t2 < mint) mint = t2;
                if(mint != Tmod)
                {
                    dt = mint - curtime;
                    curtime = mint;
                }

                if (mint == t2)
                {
                    ++serv;
                    ++k2;
                    t2 = o;
                    t2sum += (curtime - t2start);

                    int i = vimposition.IndexOf(4);
                    stat.Serv(curtime - timestart[i]);
                    vimposition.RemoveAt(i);
                    timestart.RemoveAt(i);
                }
                if (mint == t11)
                {
                    ++buf;
                    t11 = o;
                    t11sum += (curtime - t11start);

                    int i = vimposition.IndexOf(2);
                    vimposition[i] = 3;
                }
                if (mint == t12)
                {
                    ++buf;
                    t12 = o;
                    t12sum += (curtime - t12start);

                    int i = vimposition.IndexOf(2);
                    vimposition[i] = 3;
                }
                if (mint == ta)
                {
                    ++start;
                    ++generator;
                    ta = o;

                    vimposition.Add(0);
                    timestart.Add(curtime);
                }

                bool changed;
                do
                {
                    changed = false;
                    if (buf2 > 0)
                    {
                        --buf2;
                        t2start = curtime;
                        t2 = curtime + m2 + (0.5 - rand.NextDouble()) * m2;
                        changed = true;
                    }
                    if (buf > 0 && k2 > 0)
                    {
                        --buf;
                        --k2;
                        ++k1;
                        ++buf2;
                        changed = true;

                        int i = vimposition.IndexOf(3);
                        vimposition[i] = 4;
                    }
                    if (buf1 > 0)
                    {
                        --buf1;
                        if (t11 == o) 
                        {
                            t11start = curtime;
                            t11 = curtime + m1 + (0.5 - rand.NextDouble()) * m1; 
                        }
                        else
                        {
                            if (t12 == o)
                            {
                                t12start = curtime;
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
                        qav += queue * (curtime - qprev);
                        qprev = curtime;
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
                        qav += queue * (curtime - qprev);
                        qprev = curtime;
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

               // Console.WriteLine(curtime + " " + k2);
                stat.Next(curtime, queue, k1, k2);
            }

            k2 = 1;
            k1 = 2;
            qav += queue * (curtime - qprev);
            stat.Next(curtime, queue, k1, k2);
            Res();
            stat.Results(curtime, serv, unserv);
        }

        static void Res()
        {
            Console.WriteLine("Час моделювання: \t" + curtime);
            Console.WriteLine("Вимог оброблено: \t" + serv);
            Console.WriteLine("Вимог не оброблено: \t" + unserv);
            Console.WriteLine("Iмовiрнiсть вiдмови: \t" + (double)unserv/(unserv+serv));
            Console.WriteLine("Середня довжина черги: \t" + qav/curtime);
            Console.WriteLine("Середнє очiкування вимог у черзi: \t" + qav/serv);
            //Console.WriteLine("Середнiй час обслуговування: \t" + Tnet);
            Console.WriteLine("Середнє завантаження пристроїв");
            Console.WriteLine("\t\t К11:\t" + t11sum/curtime);
            Console.WriteLine("\t\t К12:\t" + t12sum/curtime);
            Console.WriteLine("\t\t К2:\t" + t2sum/curtime);
           // Console.WriteLine("Середня кiлькiсть зайнятих пристроїв");
            //Console.WriteLine("\t\t СМО1:\t" + (Daver1));
            //Console.WriteLine("\t\t СМО2:\t" + (Daver2));
            //Console.WriteLine("\t\t ММО:\t" + (Daver));
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
    }
}
