using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace OGKGlab
{
    public partial class Form1 : Form
    {
        int maxPid = -1;
        List<MyPoint> points = new List<MyPoint>();
        List<NearestNeighbor> nearnei = new List<NearestNeighbor>();
        List<VorNode> vor = new List<VorNode>();
        List<int> Ux = new List<int>();
        List<int> Uy = new List<int>();
        List<int[]> Uij = new List<int[]>();
        int DELTA = 1;
        int RADIUS = 8;
        int WIDTH = 0;//ширина 600
        int HEIGHT = 0;//висота 400
        Graphics g;
        Pen arrow = new Pen(Color.Brown, 5);
        Pen line = new Pen(Color.Blue, 3);
        SolidBrush brush = new SolidBrush(Color.Red);


        public Form1()
        {
            InitializeComponent();
            WIDTH = pictureBox1.Width;
            HEIGHT = pictureBox1.Height;
            g = pictureBox1.CreateGraphics();
            arrow.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
        }
       
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            AddPoint(e.X, e.Y);
            VisualPoints();
        }
       
        private void Generate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int count = (int)nupdCount.Value;
            int generated = 0;
            while (generated < count)
            {
                if (AddPoint(rand.Next() % WIDTH, rand.Next() % HEIGHT))
                    ++generated;
            }

            VisualPoints();
        }
       
        private void Clear_Click(object sender, EventArgs e)
        {
            vor.Clear();
            nearnei.Clear();
            points.Clear();
            maxPid = -1;
            g.Clear(Color.White);
            VisualPoints();
        }
       
        private void VisuаlNN(List<NearestNeighbor> nn)
        {
            for (int i = 0; i < nn.Count; ++i)
            {
                for (int k = 0; k < points.Count; ++k)
                {
                    double s = 999999;
                    int c = k;
                    for (int j = 0; j < points.Count; ++j)
                    {
                        if (k != j && Math.Sqrt((points[k].x - points[j].x) * (points[k].x - points[j].x) + (points[k].y - points[j].y) * (points[k].y - points[j].y)) < s)
                        {
                            c = j;
                            s = Math.Sqrt((points[k].x - points[j].x) * (points[k].x - points[j].x) + (points[k].y - points[j].y) * (points[k].y - points[j].y));
                        }
                    }
                    g.DrawLine(arrow, points[k].x, points[k].y, points[c].x, points[c].y);
                }
            }
        }
       
        bool AddPoint(int x, int y)
        {
            if (x < RADIUS || x > WIDTH - 2 * RADIUS) return false;
            if (y < RADIUS || y > HEIGHT - 2 * RADIUS) return false;

            for (int i = 0; i < points.Count; ++i)
            {
                if ((x > points[i].x - RADIUS && x < points[i].x + RADIUS)
                && (y > points[i].y - RADIUS && y < points[i].y + RADIUS)) return false;
            }

            ++maxPid;
            points.Add(new MyPoint(maxPid, x, y));
            return true;
        }
       
        void SortByX()
        {
            Ux.Clear();
            List<MyPoint> buf = new List<MyPoint>();
            VisualNN(new List<NearestNeighbor>());
            buf.AddRange(points);
            while (buf.Count > 0)
            {
                int min_id = 0;
                for (int i = 1; i < buf.Count; ++i)
                {
                    if (buf[i].x <= buf[min_id].x) min_id = i;
                }
                Ux.Add(buf[min_id].id);
                buf.RemoveAt(min_id);
            }
        }
      
        void SortByY()
        {
            Uy.Clear();
            List<MyPoint> buf = new List<MyPoint>();
            buf.AddRange(points);
            while (buf.Count > 0)
            {
                int min_id = 0;
                for (int i = 1; i < buf.Count; ++i)
                {
                    if (buf[i].y <= buf[min_id].y) min_id = i;
                }
                Uy.Add(buf[min_id].id);
                buf.RemoveAt(min_id);
            }
        }
       
        void SortByXandY()
        {
            for (int i = 0; i < points.Count; ++i)
            {
                int[] buf = new int[2];
                buf[0] = Ux.IndexOf(i);
                buf[1] = Uy.IndexOf(i);
                Uij.Add(buf);
            }
        }
      
        double FindAngle(int xc, int yc, int xt, int yt, int x, int y)
        {
            int ax = xt - xc;
            int ay = yt - yc;
            int bx = x - xc;
            int by = y - yc;

            double asize = Math.Sqrt(ax * ax + ay * ay);
            double bsize = Math.Sqrt(bx * bx + by * by);

            int scalar = ax * by - ay * bx;
            double angle = Math.Acos((ax * bx + ay * by) / (asize * bsize));

            if (scalar >= 0) return angle;
            return 2.0 * Math.PI - angle;
        }
      
        int[] FindCrossBorder(double A, double B, double C)
        //return x1, y1, x2, y2
        {
            //Ax+By+C=0
            int[] res = new int[4];
            int count = -1;

            //y=0
            double Ab = 0;
            double Bb = 1;
            double Cb = 0;
            int x = FindCrossX(A, B, C, Ab, Bb, Cb);
            int y = FindCrossY(A, B, C, Ab, Bb, Cb);
            if ((x >= 0 && x <= WIDTH) && (y == 0))
            {
                ++count;
                res[count] = x;
                ++count;
                res[count] = y;
            }

            //y=HEIGHT
            Ab = 0;
            Bb = 1;
            Cb = 0 - HEIGHT;
            x = FindCrossX(A, B, C, Ab, Bb, Cb);
            y = FindCrossY(A, B, C, Ab, Bb, Cb);
            if ((x >= 0 && x <= WIDTH) && (y == HEIGHT))
            {
                ++count;
                res[count] = x;
                ++count;
                res[count] = y;
            }

            //x=0
            Ab = 1;
            Bb = 0;
            Cb = 0;
            x = FindCrossX(A, B, C, Ab, Bb, Cb);
            y = FindCrossY(A, B, C, Ab, Bb, Cb);
            if ((x == 0) && (y >= 0 && y <= HEIGHT) && count < 3)
            {
                ++count;
                res[count] = x;
                ++count;
                res[count] = y;
            }

            //x=WIDTH
            Ab = 1;
            Bb = 0;
            Cb = 0 - WIDTH;
            x = FindCrossX(A, B, C, Ab, Bb, Cb);
            y = FindCrossY(A, B, C, Ab, Bb, Cb);
            if ((x == WIDTH) && (y >= 0 && y <= HEIGHT) && count < 3)
            {
                ++count;
                res[count] = x;
                ++count;
                res[count] = y;
            }

            return res;
        }
      
        int FindCrossX(double A1, double B1, double C1, double A2, double B2, double C2)
        {
            double zn = A1 * B2 - A2 * B1;
            if (zn == 0) return -1;
            double x = (-1.0) * (C1 * B2 - C2 * B1) / zn;
            if (0 - DELTA <= x && 0 + DELTA >= x) x = 0;
            if (WIDTH - DELTA <= x && WIDTH + DELTA >= x) x = WIDTH;
            return (int)x;
        }
      
        int FindCrossY(double A1, double B1, double C1, double A2, double B2, double C2)
        {
            double zn = A1 * B2 - A2 * B1;
            if (zn == 0) return -1;
            double y = (-1.0) * (A1 * C2 - A2 * C1) / zn;
            if (0 - DELTA <= y && 0 + DELTA >= y) y = 0;
            if (HEIGHT - DELTA <= y && HEIGHT + DELTA >= y) y = HEIGHT;
            return (int)y;
        }

        bool visvor = false;

        private void FindNN_Click(object sender, EventArgs e)
        {
            if (points.Count > 1)
            {
                SortByX();
                SortByY();
                SortByXandY();
                List<MyPoint> sortedPoints = new List<MyPoint>();
                foreach (int i in Ux)
                {
                    sortedPoints.Add(points[i]);
                }
                g.Clear(Color.White);
                VisualPoints();
                Result res = FindAllNN(sortedPoints);
                VisualVor(res.res_vor);
                VisuаlNN(res.res_nn);
            }
        }

        Result FindAllNN(List<MyPoint> p)//на вхід подавати відсортовані по х точки
        {
            if (p.Count == 2)
            {
                double xsp = (double)(p[0].x + p[1].x) / 2;
                double ysp = (double)(p[0].y + p[1].y) / 2;
                double kab = (double)(p[0].y - p[1].y) / (p[0].x - p[1].x);
                double ksp = (-1.0) / kab;
                double b = (double)ysp - (double)ksp * xsp;
                int[] res = FindCrossBorder(ksp, -1, b);
                VisualVor(new List<VorNode> { new VorNode(p[0].id, p[1].id, res[0], res[1], res[2], res[3]) });
                List<NearestNeighbor> nnbuf = new List<NearestNeighbor>();
                nnbuf.Add(new NearestNeighbor(p[0].id, p[1].id, Math.Sqrt((p[0].x - p[1].x) * (p[0].x - p[1].x) + (p[0].y - p[1].y) * (p[0].y - p[1].y))));
                nnbuf.Add(new NearestNeighbor(p[1].id, p[0].id, Math.Sqrt((p[0].x - p[1].x) * (p[0].x - p[1].x) + (p[0].y - p[1].y) * (p[0].y - p[1].y))));
                List<VorNode> vorbuf = new List<VorNode>();
                vorbuf.Add(new VorNode(p[0].id, p[1].id, res[0], res[1], res[2], res[3]));
                return new Result(p, nnbuf, vorbuf);
            }

            if (p.Count == 3)
            {
                List<NearestNeighbor> nnbuf = new List<NearestNeighbor>();
                List<VorNode> vorbuf = new List<VorNode>();
                double[] xsp = new double[3];
                double[] ysp = new double[3];
                double[] A = new double[3];
                double[] B = new double[3];
                double[] C = new double[3];

                for (int i = 0; i < 3; ++i)
                {
                    xsp[i] = (double)(p[i].x + p[(i + 1) % 3].x) / 2;
                    ysp[i] = (double)(p[i].y + p[(i + 1) % 3].y) / 2;
                    double dx = (p[i].x - p[(i + 1) % 3].x);
                    double dy = (p[i].y - p[(i + 1) % 3].y);
                    if (dx == 0)
                    {
                        A[i] = 0;
                        B[i] = (-1.0);
                        C[i] = ysp[i];
                    }
                    else
                    {
                        if (dy == 0)
                        {
                            A[i] = (-1.0);
                            B[i] = 0;
                            C[i] = xsp[i];
                        }
                        else
                        {
                            double kab1 = dy / dx;
                            A[i] = (-1.0) / kab1;
                            B[i] = (-1.0);
                            C[i] = (double)ysp[i] - (double)A[i] * xsp[i];
                        }
                    }

                    int nnid;
                    double size = Math.Sqrt((p[i].x - p[(i + 1) % 3].x) * (p[i].x - p[(i + 1) % 3].x) + (p[i].y - p[(i + 1) % 3].y) * (p[i].y - p[(i + 1) % 3].y));
                    double bsize = Math.Sqrt((p[i].x - p[(i + 2) % 3].x) * (p[i].x - p[(i + 2) % 3].x) + (p[i].y - p[(i + 2) % 3].y) * (p[i].y - p[(i + 2) % 3].y));
                    if ( size < bsize)
                    {
                        nnid = (i + 1) % 3;
                    }
                    else
                    {
                        nnid = (i + 2) % 3;
                        size = bsize;
                    }

                    nnbuf.Add(new NearestNeighbor(p[i].id, p[nnid].id, size));
                }

                double zn = A[1] * B[2] - A[2] * B[1];
                if (zn == 0)
                {
                    //вироджений випадок. точки на одній прямій. діаграма з паралелельних ліній
                    for (int i = 0; i < 3; ++i)
                    {
                        if ((p[i].x - p[(i + 2) % 3].x >= 0 == p[(i + 1) % 3].x - p[(i + 2) % 3].x >= 0) && (p[i].y - p[(i + 2) % 3].y >= 0 == p[(i + 1) % 3].y - p[(i + 2) % 3].y >= 0)) 
                        {
                            int[] res = FindCrossBorder(A[i], B[i], C[i]);
                            VisualVor(new List<VorNode> { new VorNode(p[0].id, p[1].id, res[0], res[1], res[2], res[3]) });
                            vorbuf.Add(new VorNode(p[i].id, p[(i+1)%3].id, res[0], res[1], res[2], res[3]));
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    double buf = (-1.0) * (C[1]*B[2] - C[2]*B[1]) / zn;
                    int xc = (int)buf;
                    buf = (-1.0) * (A[1] * C[2] - A[2] * C[1]) / zn;
                    int yc = (int)buf;

                    bool up = true;
                    if (FindAngle(p[0].x, p[0].y, p[2].x, p[2].y, p[1].x, p[1].y) < Math.PI) 
                        up = false;

                    for (int i = 0; i < 3; ++i)
                    {
                        int[] res = FindCrossBorder(A[i], B[i], C[i]);

                        if ((FindAngle(xc, yc, p[i].x, p[i].y, res[0], res[1]) < FindAngle(xc, yc, p[i].x, p[i].y, p[(i + 1) % 3].x, p[(i + 1) % 3].y)) == up)
                        {
                            if ((FindAngle(xc, yc, p[i].x, p[i].y, res[2], res[3]) < FindAngle(xc, yc, p[i].x, p[i].y, p[(i + 1) % 3].x, p[(i + 1) % 3].y)) == up)
                            {
                                VisualVor(new List<VorNode> { new VorNode(p[0].id, p[1].id, res[0], res[1], res[2], res[3]) });
                                vorbuf.Add(new VorNode(p[i].id, p[(i + 1) % 3].id, res[0], res[1], res[2], res[3]));
                            }
                            else
                            {
                                VisualVor(new List<VorNode> { new VorNode(p[0].id, p[1].id, res[0], res[1], xc, yc) });
                                vorbuf.Add(new VorNode(p[i].id, p[(i + 1) % 3].id, res[0], res[1], xc, yc));
                            }
                        }
                        else
                        {
                            if ((FindAngle(xc, yc, p[i].x, p[i].y, res[2], res[3]) < FindAngle(xc, yc, p[i].x, p[i].y, p[(i + 1) % 3].x, p[(i + 1) % 3].y)) == up)
                            {
                                VisualVor(new List<VorNode> { new VorNode(p[0].id, p[1].id, xc, yc, res[2], res[3]) });
                                vorbuf.Add(new VorNode(p[i].id, p[(i + 1) % 3].id, xc, yc, res[2], res[3]));
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }

                return new Result(p, nnbuf, vorbuf);
            }

            if (p.Count == 1)//такого ніколи не має бути
            {
                return new Result(new List<MyPoint>(), new List<NearestNeighbor>(), new List<VorNode>());
            }

            List<MyPoint> bufLeft = new List<MyPoint>();
            for (int i = 0; i < p.Count / 2; ++i)
            {
                bufLeft.Add(p[i]);
            }
            List<MyPoint> bufRight = new List<MyPoint>();
            for (int i = p.Count / 2; i < p.Count; ++i)
            {
                bufRight.Add(p[i]);
            }

            return Merger(FindAllNN(bufLeft), FindAllNN(bufRight));
        }
       
        Result Merger(Result res1, Result res2)//процедура злиття результатів рекурсії
        {
            List<VorNode> vor_buf = new List<VorNode>();
            List<int> used_id = new List<int>();
            //знайти верхню ліву опорну
            int vlop_id = res1.res_p[0].id;
            for (int i = 1; i < res1.res_p.Count; ++i)
            {
                if (res1.res_p[i].y > points[vlop_id].y)
                {
                    vlop_id = res1.res_p[i].id;
                }
                else
                {
                    if (res1.res_p[i].y == points[vlop_id].y && res1.res_p[i].x > points[vlop_id].x)
                    {
                        vlop_id = res1.res_p[i].id;
                    }
                }
            }

            //знайти нижню ліву опорну
            int nlop_id = res1.res_p[0].id;
            for (int i = 1; i < res1.res_p.Count; ++i)
            {
                if (res1.res_p[i].y < points[nlop_id].y)
                {
                    nlop_id = res1.res_p[i].id;
                }
                else
                {
                    if (res1.res_p[i].y == points[nlop_id].y && res1.res_p[i].x > points[nlop_id].x)
                    {
                        nlop_id = res1.res_p[i].id;
                    }
                }
            }

            //знайти нижню праву опорну
            int nrop_id = res2.res_p[0].id;
            for (int i = 1; i < res2.res_p.Count; ++i)
            {
                if (res2.res_p[i].y < points[nrop_id].y)
                {
                    nrop_id = res2.res_p[i].id;
                }
                else
                {
                    if (res2.res_p[i].y == points[nrop_id].y && res2.res_p[i].x < points[nrop_id].x)
                    {
                        nrop_id = res2.res_p[i].id;
                    }
                }
            }

            //знайти верхню праву опорну
            int vrop_id = res2.res_p[0].id;
            for (int i = 1; i < res2.res_p.Count; ++i)
            {
                if (res2.res_p[i].y > points[vrop_id].y)
                {
                    vrop_id = res2.res_p[i].id;
                }
                else
                {
                    if (res2.res_p[i].y == points[vrop_id].y && res2.res_p[i].x < points[vrop_id].x)
                    {
                        vrop_id = res2.res_p[i].id;
                    }
                }
            }

            //знаходжу початкові координати розділяючого ланцюга
            int xstart = (points[vlop_id].x + points[vrop_id].x) / 2;
            int ystart = HEIGHT;
            int xp = (points[vlop_id].x + points[vrop_id].x) / 2;
            int yp = (points[vlop_id].y + points[vrop_id].y) / 2;
            double A;
            double B;
            double C;
            double dx = (points[vlop_id].x - points[vrop_id].x);
            double dy = (points[vlop_id].y + points[vrop_id].y);
            if (dx == 0)
            {
                A = 0;
                B = (-1.0);
                C = yp;
            }
            else
            {
                if (dy == 0)
                {
                    A = (-1.0);
                    B = 0;
                    C = xp;
                }
                else
                {
                    double kab1 = dy / dx;
                    A = (-1.0) / kab1;
                    B = (-1.0);
                    C = (double)yp - (double)A * xp;
                }
            }
            int[] res = FindCrossBorder(A, B, C);
            if (res[1] > res[3])
            {
                xstart = res[0];
                ystart = res[1];
            }
            else
            {
                xstart = res[2];
                ystart = res[3];
            }

            //будую розділяючий ланцюг
            while (vlop_id != nlop_id && vrop_id != nrop_id)
            {
                //шукаю індекс найближчого сусіда до лівої опорної
                int lnn_index = 0;
                for (int i = 0; i < res1.res_nn.Count; ++i)
                {
                    if (res1.res_nn[i].p1_id == vlop_id)
                    {
                        lnn_index = i;
                        break;
                    }
                }

                //шукаю індекс найближчого сусіда до правої опорної
                int rnn_index = 0;
                for (int i = 0; i < res2.res_nn.Count; ++i)
                {
                    if (res2.res_nn[i].p1_id == vrop_id)
                    {
                        rnn_index = i;
                        break;
                    }
                }

                //порівнюю довжину до нової точки та заміняю сусіда, якщо треба
                double op_size = Math.Sqrt((points[vlop_id].x - points[vrop_id].x) * (points[vlop_id].x - points[vrop_id].x) + (points[vlop_id].y - points[vrop_id].y) * (points[vlop_id].y - points[vrop_id].y));
                if (op_size < res1.res_nn[lnn_index].size)
                {
                    res1.res_nn[lnn_index].size = op_size;
                    res1.res_nn[lnn_index].p2_id = vrop_id;
                }
                if (op_size < res2.res_nn[rnn_index].size)
                {
                    res2.res_nn[rnn_index].size = op_size;
                    res2.res_nn[rnn_index].p2_id = vlop_id;
                }

                //провести перпендикуляр до відрізку [vlop ; vrop]
                xp = (points[vlop_id].x + points[vrop_id].x) / 2;
                yp = (points[vlop_id].y + points[vrop_id].y) / 2;
                dx = (points[vlop_id].x - points[vrop_id].x);
                dy = (points[vlop_id].y + points[vrop_id].y);
                if (dx == 0)
                {
                    A = 0;
                    B = (-1.0);
                    C = yp;
                }
                else
                {
                    if (dy == 0)
                    {
                        A = (-1.0);
                        B = 0;
                        C = xp;
                    }
                    else
                    {
                        double kab1 = dy / dx;
                        A = (-1.0) / kab1;
                        B = (-1.0);
                        C = (double)yp - (double)A * xp;
                    }
                }

                //знайти найвищу точку перетину його з ребром однієї з діаграм воронного
                int xc = 99999;
                int yc = 99999;
                int vlop_buf = vlop_id;
                int vrop_buf = vrop_id;
                bool left = true;
                if (vlop_id != nlop_id)
                for (int i = 0; i < res1.res_vor.Count; ++i)
                {
                    if ((res1.res_vor[i].p1_id == vlop_id && !used_id.Contains(res1.res_vor[i].p2_id)) || (res1.res_vor[i].p2_id == vlop_id && !used_id.Contains(res1.res_vor[i].p1_id)))
                    {
                        dx = (res1.res_vor[i].x1 - res1.res_vor[i].x2) / 2;
                        dy = (res1.res_vor[i].y1 - res1.res_vor[i].y2) / 2;
                        double Ab;
                        double Bb;
                        double Cb;
                        if (dx == 0)
                        {
                            Ab = (-1.0);
                            Bb = 0;
                            Cb = res1.res_vor[i].x1;
                        }
                        else
                        {
                            if (dy == 0)
                            {
                                Ab = 0;
                                Bb = (-1.0);
                                Cb = res1.res_vor[i].y1;
                            }
                            else
                            {
                                Ab = 1.0 / (res1.res_vor[i].x2 - res1.res_vor[i].x1);
                                Bb = (-1.0) / (res1.res_vor[i].y2 - res1.res_vor[i].y1);
                                Cb = res1.res_vor[i].y1 / (res1.res_vor[i].y2 - res1.res_vor[i].y1) - res1.res_vor[i].x1 / (res1.res_vor[i].x2 - res1.res_vor[i].x1);
                            }
                        }
                        int bufxc = FindCrossX(A, B, C, Ab, Bb, Cb);
                        int bufyc = FindCrossY(A, B, C, Ab, Bb, Cb);
                        if (Math.Sqrt((xstart - bufxc)* (xstart - bufxc)+(ystart-bufyc)* (ystart - bufyc)) < Math.Sqrt(Math.Abs((xstart - xc) * (xstart - xc) + (ystart - yc) * (ystart - yc))))
                        {
                            xc = bufxc;
                            yc = bufyc;
                            if (res1.res_vor[i].p1_id != vlop_id)
                            {
                                used_id.Add(vlop_buf);
                                vlop_buf = res1.res_vor[i].p1_id;
                            }
                            else
                            {
                                    used_id.Add(vlop_buf);
                                    vlop_buf = res1.res_vor[i].p2_id;
                            }
                        }
                    }
                }
                if(vrop_id != nrop_id)
                for (int i = 0; i < res2.res_vor.Count; ++i)
                {
                    if ((res2.res_vor[i].p1_id == vrop_id && !used_id.Contains(res2.res_vor[i].p2_id)) || (res2.res_vor[i].p2_id == vrop_id && !used_id.Contains(res2.res_vor[i].p1_id)))
                    {
                        dx = (res2.res_vor[i].x1 - res2.res_vor[i].x2) / 2;
                        dy = (res2.res_vor[i].y1 - res2.res_vor[i].y2) / 2;
                        double Ab;
                        double Bb;
                        double Cb;
                        if (dx == 0)
                        {
                            Ab = (-1.0);
                            Bb = 0;
                            Cb = res2.res_vor[i].x1;
                        }
                        else
                        {
                            if (dy == 0)
                            {
                                Ab = 0;
                                Bb = (-1.0);
                                Cb = res2.res_vor[i].y1;
                            }
                            else
                            {
                                Ab = 1.0 / (res2.res_vor[i].x2 - res2.res_vor[i].x1);
                                Bb = (-1.0) / (res2.res_vor[i].y2 - res2.res_vor[i].y1);
                                Cb = res2.res_vor[i].y1 / (res2.res_vor[i].y2 - res2.res_vor[i].y1) - res2.res_vor[i].x1 / (res2.res_vor[i].x2 - res2.res_vor[i].x1);
                            }
                        }
                        int bufxc = FindCrossX(A, B, C, Ab, Bb, Cb);
                        int bufyc = FindCrossY(A, B, C, Ab, Bb, Cb);
                        if (Math.Sqrt((xstart - bufxc) * (xstart - bufxc) + (ystart - bufyc) * (ystart - bufyc)) < Math.Sqrt(Math.Abs((xstart - xc) * (xstart - xc) + (ystart - yc) * (ystart - yc))))
                        {
                            xc = bufxc;
                            yc = bufyc;
                            if (res2.res_vor[i].p1_id != vrop_id)
                            {
                                used_id.Add(vrop_buf);
                                vrop_buf = res2.res_vor[i].p1_id;
                                left = false;
                            }
                            else
                            {
                                used_id.Add(vrop_buf);
                                vrop_buf = res2.res_vor[i].p2_id;
                                left = false;
                            }
                        }
                    }
                }
                if (xc == 99999 || yc == 99999)
                {
                    break;
                }
                //додати нове ребро між опорними точками
                vor_buf.Add(new VorNode(vlop_id, vrop_id, xstart, ystart, xc, yc));

                //обрізати старе ребро й поміняти опорну точку
                if (left)
                {
                    for (int i = 0; i < res1.res_vor.Count; ++i)
                    {
                        if ((res1.res_vor[i].p1_id == vlop_id && res1.res_vor[i].p2_id == vlop_buf) || (res1.res_vor[i].p1_id == vlop_buf && res1.res_vor[i].p2_id == vlop_id))
                        {
                            if (res1.res_vor[i].y1 > res1.res_vor[i].y2)
                            {
                                res1.res_vor[i].y1 = yc;
                                res1.res_vor[i].x1 = xc;
                            }
                            else
                            {
                                res1.res_vor[i].y2 = yc;
                                res1.res_vor[i].x2 = xc;
                            }
                            used_id.Add(vlop_id);
                            vlop_id = vlop_buf;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < res2.res_vor.Count; ++i)
                    {
                        if ((res2.res_vor[i].p1_id == vrop_id && res2.res_vor[i].p2_id == vrop_buf) || (res2.res_vor[i].p1_id == vrop_buf && res2.res_vor[i].p2_id == vrop_id))
                        {
                            if (res2.res_vor[i].y1 > res2.res_vor[i].y2)
                            {
                                res2.res_vor[i].y1 = yc;
                                res2.res_vor[i].x1 = xc;
                            }
                            else
                            {
                                res2.res_vor[i].y2 = yc;
                                res2.res_vor[i].x2 = xc;
                            }
                            used_id.Add(vrop_id);
                            vrop_id = vrop_buf;
                            break;
                        }
                    }
                }

                //поміняти початкову точку перпендикуляра розділяючого ланцюга
                xstart = xc;
                ystart = yc;
            }//теперішні опорні точки співпали з нижніми

            //для нижніх опорних точок знаходжу перетин перпендикуляра з межами
            if (xstart > 0 && ystart > 0)
            {
                xp = (points[nlop_id].x + points[nrop_id].x) / 2;
                yp = (points[nlop_id].y + points[nrop_id].y) / 2;
                dx = (points[nlop_id].x - points[nrop_id].x);
                dy = (points[nlop_id].y + points[nrop_id].y);
                if (dx == 0)
                {
                    A = 0;
                    B = (-1.0);
                    C = yp;
                }
                else
                {
                    if (dy == 0)
                    {
                        A = (-1.0);
                        B = 0;
                        C = xp;
                    }
                    else
                    {
                        double kab1 = dy / dx;
                        A = (-1.0) / kab1;
                        B = (-1.0);
                        C = (double)yp - (double)A * xp;
                    }
                }
                res = FindCrossBorder(A, B, C);
                if (res[1] < res[3])
                {
                    vor_buf.Add(new VorNode(nlop_id, nrop_id, xstart, ystart, res[0], res[1]));
                }
                else
                {
                    vor_buf.Add(new VorNode(nlop_id, nrop_id, xstart, ystart, res[2], res[3]));
                }
            }

            //об'єдную й повертаю результат
            res1.res_p.AddRange(res2.res_p);
            res1.res_nn.AddRange(res2.res_nn);
            res1.res_vor.AddRange(res2.res_vor);
            res1.res_vor.AddRange(vor_buf);
            return new Result(res1.res_p, res1.res_nn, res1.res_vor);
        }
        
        void VisualPoints()
        {
            int half = RADIUS / 2;

            for (int i = 0; i < points.Count; ++i)
            {
                g.FillEllipse(brush, points[i].x - half, points[i].y - half, RADIUS, RADIUS);
            }
        }

        void VisualNN(List<NearestNeighbor> nearnei)
        {
            for (int i = 0; i < nearnei.Count; ++i)
            {
                g.DrawLine(arrow, points[nearnei[i].p1_id].x, points[nearnei[i].p1_id].y, points[nearnei[i].p2_id].x, points[nearnei[i].p2_id].y);
            }
        }

        void VisualVor(List<VorNode> v)
        {
            if (visvor)
            for (int i = 0; i < v.Count; ++i) 
            {
                g.DrawLine(line, v[i].x1, v[i].y1, v[i].x2, v[i].y2);
            }
        }
    }
}
