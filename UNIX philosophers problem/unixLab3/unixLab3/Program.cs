using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unixLab3
{
    class Program
    {
        const int n = 5;
        const int EAT_MOD = 10;
        const int WAIT_MOD = 5;
        const int THINK_MOD = 15;
        const int DIE_MOD = 1000;
        static void Main(string[] args)
        {
            int dead = 0;
            Random rand = new Random();
            Fork[] f = new Fork[n];
            Philosopher[] ph = new Philosopher[n];
            for (int i = 0; i < n; ++i)
            {
                f[i] = new Fork();
                string s = "think";
                if (rand.Next() % 2 == 0) s = "hungry";
                ph[i] = new Philosopher((rand.Next() % WAIT_MOD), false, false, s);
            }

            StreamWriter sw = new StreamWriter("log.txt");
            bool write = false; ;

            for (int i = 0; i < n; ++i)
            {
                sw.Write("{0} \t\t", f[i].enabled);
            }
            sw.WriteLine();
            for (int i = 0; i < n; ++i)
            {
                sw.Write("{0} \t\t", ph[i].status);
            }
            sw.WriteLine();
            for (int i = 0; i < n; ++i)
            {
                sw.Write("{0} \t\t", ph[i].left);
            }
            sw.WriteLine();
            for (int i = 0; i < n; ++i)
            {
                sw.Write("{0} \t\t", ph[i].right);
            }
            sw.WriteLine();
            for (int i = 0; i < n; ++i)
            {
                sw.Write("{0} \t\t", ph[i].timer);
            }
            sw.WriteLine();
            sw.WriteLine("---------------------------------------------------------------------");
            sw.WriteLine();

            while (dead < n)
            {
                write = false;

                for (int i = 0; i < n; ++i) 
                {
                    if (ph[i].status == "dead")
                    {
                        continue;
                    }

                    if (rand.Next() % DIE_MOD == 0)
                    {
                        write = true;
                        ph[i].status = "dead";
                        ++dead;
                        if (ph[i].left)
                        {
                            f[i].enabled = true;
                            ph[i].left = false;
                        }
                        if (ph[i].right)
                        {
                            f[(i - 1 + n) % n].enabled = true;
                            ph[i].right = false;
                        }
                        ph[i].timer = 0;
                        continue;
                    }

                    if (--ph[i].timer <= 0) 
                    {
                        if (ph[i].status == "think")
                        {
                            write = true;
                            ph[i].status = "hungry";
                            ph[i].timer = rand.Next() % WAIT_MOD;
                            continue;
                        }

                        if (ph[i].status == "hungry")
                        {
                            if(i != 0)
                            {
                                if (!ph[i].left && f[i].enabled)
                                {
                                    f[i].enabled = false;
                                    ph[i].left = true;
                                    write = true;
                                    ph[i].timer = rand.Next() % WAIT_MOD;
                                    continue;
                                }

                                if (ph[i].left && !ph[i].right && f[(i - 1 + n) % n].enabled)
                                {
                                    f[(i - 1 + n) % n].enabled = false;
                                    ph[i].right = true;
                                    write = true;
                                    ph[i].timer = rand.Next() % WAIT_MOD;
                                    continue;
                                }
                            }
                            else
                            {
                                if (!ph[i].right && f[(i - 1 + n) % n].enabled)
                                {
                                    f[(i - 1 + n) % n].enabled = false;
                                    ph[i].right = true;
                                    write = true;
                                    ph[i].timer = rand.Next() % WAIT_MOD;
                                    continue;
                                }

                                if (ph[i].right && !ph[i].left && f[i].enabled)
                                {
                                    f[i].enabled = false;
                                    ph[i].left = true;
                                    write = true;
                                    ph[i].timer = rand.Next() % WAIT_MOD;
                                    continue;
                                }
                            }

                            if (ph[i].left && ph[i].right)
                            {
                                write = true;
                                ph[i].timer = rand.Next() % EAT_MOD;
                                ph[i].status = "eat";
                                continue;
                            }
                        }

                        if (ph[i].status == "eat")
                        {
                            write = true;
                            f[(i - 1 + n) % n].enabled = true;
                            ph[i].right = false;
                            f[i].enabled = true;
                            ph[i].left = false;
                            ph[i].timer = rand.Next() % THINK_MOD;
                            ph[i].status = "think";
                            continue;
                        }
                    }
                }

                if (write)
                {
                    for (int i = 0; i < n; ++i)
                    {
                        sw.Write("{0} \t\t", f[i].enabled);
                    }
                    sw.WriteLine();
                    for (int i = 0; i < n; ++i)
                    {
                        sw.Write("{0} \t\t", ph[i].status);
                    }
                    sw.WriteLine();
                    for (int i = 0; i < n; ++i)
                    {
                        sw.Write("{0} \t\t", ph[i].left);
                    }
                    sw.WriteLine();
                    for (int i = 0; i < n; ++i)
                    {
                        sw.Write("{0} \t\t", ph[i].right);
                    }
                    sw.WriteLine();
                    for (int i = 0; i < n; ++i)
                    {
                        sw.Write("{0} \t\t", ph[i].timer);
                    }
                    sw.WriteLine();
                    sw.WriteLine("---------------------------------------------------------------------");
                    sw.WriteLine();
                }
            }

            sw.Close();
        }
    }
}
