using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unixFormLab3
{
    public partial class Form1 : Form
    {
        const int n = 5;
        const int EAT_MOD = 10;
        const int WAIT_MOD = 5;
        const int THINK_MOD = 15;
        const int DIE_MOD = 1000;
        int dead = 0;
        Random rand = new Random();
        StreamWriter sw = new StreamWriter("log.txt");

        Fork[] f = new Fork[n];
        Philosopher[] ph = new Philosopher[n];

        public void Visual()
        {
            p0d.Visible = p1d.Visible = p2d.Visible = p3d.Visible = p4d.Visible =
                p0t.Visible = p1t.Visible = p2t.Visible = p3t.Visible = p4t.Visible =
                p0e.Visible = p1e.Visible = p2e.Visible = p3e.Visible = p4e.Visible =
                p0h.Visible = p1h.Visible = p2h.Visible = p3h.Visible = p4h.Visible = false;


            f0.Visible = f[0].enabled;
            f1.Visible = f[1].enabled;
            f2.Visible = f[2].enabled;
            f3.Visible = f[3].enabled;
            f4.Visible = f[4].enabled;

            fl0.Visible = ph[0].left;
            fl1.Visible = ph[1].left;
            fl2.Visible = ph[2].left;
            fl3.Visible = ph[3].left;
            fl4.Visible = ph[4].left;

            fr0.Visible = ph[0].right;
            fr1.Visible = ph[1].right;
            fr2.Visible = ph[2].right;
            fr3.Visible = ph[3].right;
            fr4.Visible = ph[4].right;

            if (ph[0].status == "dead") p0d.Visible = true;
            else
            if (ph[0].status == "think") p0t.Visible = true;
            else
            if (ph[0].status == "eat") p0e.Visible = true;
            else
            if (ph[0].status == "hungry") p0h.Visible = true;

            if (ph[1].status == "dead") p1d.Visible = true;
            else
            if (ph[1].status == "think") p1t.Visible = true;
            else
            if (ph[1].status == "eat") p1e.Visible = true;
            else
            if (ph[1].status == "hungry") p1h.Visible = true;

            if (ph[2].status == "dead") p2d.Visible = true;
            else
            if (ph[2].status == "think") p2t.Visible = true;
            else
            if (ph[2].status == "eat") p2e.Visible = true;
            else
            if (ph[2].status == "hungry") p2h.Visible = true;

            if (ph[3].status == "dead") p3d.Visible = true;
            else
            if (ph[3].status == "think") p3t.Visible = true;
            else
            if (ph[3].status == "eat") p3e.Visible = true;
            else
            if (ph[3].status == "hungry") p3h.Visible = true;

            if (ph[4].status == "dead") p4d.Visible = true;
            else
            if (ph[4].status == "think") p4t.Visible = true;
            else
            if (ph[4].status == "eat") p4e.Visible = true;
            else
            if (ph[4].status == "hungry") p4h.Visible = true;
        }

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < n; ++i)
            {
                f[i] = new Fork();
                string s = "think";
                if (rand.Next() % 2 == 0) s = "hungry";
                ph[i] = new Philosopher((rand.Next() % WAIT_MOD), false, false, s);
                sw.WriteLine("Phil{0} \t {1} {2}", i, ph[i].status, ph[i].timer);
            }
            fl0.SendToBack();
            fr0.SendToBack();
            fl1.SendToBack();
            fr1.SendToBack();
            fl2.SendToBack();
            fr2.SendToBack();
            fl3.SendToBack();
            fr3.SendToBack();
            fl4.SendToBack();
            fr4.SendToBack();
            pictureBox1.SendToBack();
            Visual();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Iteration();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Iteration();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
        }

        private void Iteration()
        {
            for (int i = 0; i < n; ++i)
            {
                if (ph[i].status == "dead")
                {
                    continue;
                }

                if (rand.Next() % DIE_MOD == 0)
                {
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
                    Visual();
                    sw.WriteLine("Phil{0} \t {1} {2}", i, ph[i].status, ph[i].timer);
                    continue;
                }

                if (--ph[i].timer <= 0)
                {
                    if (ph[i].status == "think")
                    {
                        ph[i].status = "hungry";
                        ph[i].timer = rand.Next() % WAIT_MOD;
                        Visual();
                        sw.WriteLine("Phil{0} \t {1} {2}", i, ph[i].status, ph[i].timer);
                        continue;
                    }

                    if (ph[i].status == "hungry")
                    {
                        if (i != 0)
                        {
                            if (!ph[i].left && f[i].enabled)
                            {
                                f[i].enabled = false;
                                ph[i].left = true;
                                ph[i].timer = rand.Next() % WAIT_MOD;
                                Visual();
                                sw.WriteLine("Phil{0} get left fork {1}", i, ph[i].timer);
                                continue;
                            }

                            if (ph[i].left && !ph[i].right && f[(i - 1 + n) % n].enabled)
                            {
                                f[(i - 1 + n) % n].enabled = false;
                                ph[i].right = true;
                                ph[i].timer = rand.Next() % WAIT_MOD;
                                Visual();
                                sw.WriteLine("Phil{0} get right fork {1}", i, ph[i].timer);
                                continue;
                            }
                        }
                        else
                        {
                            if (!ph[i].right && f[(i - 1 + n) % n].enabled)
                            {
                                f[(i - 1 + n) % n].enabled = false;
                                ph[i].right = true;
                                ph[i].timer = rand.Next() % WAIT_MOD;
                                Visual();
                                sw.WriteLine("Phil{0} get right fork {1}", i, ph[i].timer);
                                continue;
                            }

                            if (ph[i].right && !ph[i].left && f[i].enabled)
                            {
                                f[i].enabled = false;
                                ph[i].left = true;
                                ph[i].timer = rand.Next() % WAIT_MOD;
                                Visual();
                                sw.WriteLine("Phil{0} get left fork {1}", i, ph[i].timer);
                                continue;
                            }
                        }

                        if (ph[i].left && ph[i].right)
                        {
                            ph[i].timer = rand.Next() % EAT_MOD;
                            ph[i].status = "eat";
                            Visual();
                            sw.WriteLine("Phil{0} \t {1} {2}", i, ph[i].status, ph[i].timer);
                            continue;
                        }
                    }

                    if (ph[i].status == "eat")
                    {
                        if (i == 0)
                        {
                            f[i].enabled = true;
                            ph[i].left = false;
                            sw.WriteLine("Phil{0} put left fork {1}", i, ph[i].timer);
                            f[(i - 1 + n) % n].enabled = true;
                            ph[i].right = false;
                            sw.WriteLine("Phil{0} put right fork {1}", i, ph[i].timer);
                        }
                        else
                        {
                            f[(i - 1 + n) % n].enabled = true;
                            ph[i].right = false;
                            sw.WriteLine("Phil{0} put right fork {1}", i, ph[i].timer);
                            f[i].enabled = true;
                            ph[i].left = false;
                            sw.WriteLine("Phil{0} put left fork {1}", i, ph[i].timer);
                        }
                        ph[i].timer = rand.Next() % THINK_MOD;
                        ph[i].status = "think";
                        Visual();
                        sw.WriteLine("Phil{0} \t {1} {2}", i, ph[i].status, ph[i].timer);
                        continue;
                    }
                }
            }
        }

        private void fl1_Click(object sender, EventArgs e)
        {

        }

        private void p0e_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            while (dead < 5)
            {
                Iteration();
            }
            sw.Close();
        }
    }
}
