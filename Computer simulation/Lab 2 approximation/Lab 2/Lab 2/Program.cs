using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;


namespace Lab_2
{
    class Program
    {
        //будує ЕНСКН заданої ф-ції за допомогою поліномів Лежанра
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //(1-x*sin(x))^2
            string f = "(1-x*sin(x))^2"; //задана ф-ція
            int COUNT = 9; //(COUNT - 1) - степінь результуючого поліному
             
            //генерація поліномів Лежанра
            //allL[i] відповідає поліному і-го степеня
            //allL[i][j] відповідає коефіцієнту при x^j поліному і-го степеня
                List<List<double>> allL = new List<List<double>>();
                List<double> l1 = new List<double>();
                List<double> l2 = new List<double>();
                l1.Add(1);
                allL.Add(l1);
                l2.Add(0);
                l2.Add(1);
                allL.Add(l2);
                for (int i = 2; i < COUNT; ++i)
                {
                    double n = allL.Count() - 1;
                    List<double> lNext = new List<double>();
                    lNext.Add(0);
                    double k = (2 * n + 1) / (n + 1);
                    foreach (double x in l2)
                    {
                        lNext.Add(x * k);
                    }
                    k = n / (n + 1);
                    int ln = l1.Count();
                    for (int j = 0; j < ln; ++j)
                    {
                        lNext[j] -= k * l1[j];
                    }
                    l1 = l2;
                    l2 = lNext;
                    allL.Add(lNext);
                }
            
            //множення кожного поліному на відповідне йому Сі (тут - k) 
            for (int i = 0; i < COUNT; ++i)
            {
                Expression ex = new Expression("int((" + f + ")*(" + getString(allL[i]) + "), x, -1, 1)");
                double d = ex.calculate();
                double k = ((2.0 * i + 1.0) / 2.0) * d;
                //Console.WriteLine(i + ") " + k);
                for (int j = 0; j < allL[i].Count(); ++j)
                {
                    allL[i][j] *= k;
                }
            }

            //підсумовування х однакового степеня в
            //результат зберігається в allL[COUNT-1]
            for (int i = 0; i < COUNT - 1; ++i)
            {
                for (int j = 0; j < allL[i].Count(); ++j)
                {
                    allL[i + 1][j] += allL[i][j];
                }
            }

            //виведення результату
            Console.Write(allL[COUNT-1][0].ToString("F" + 15));
            for (int i = 1; i < COUNT; ++i)
            {
                double x = allL[COUNT - 1][i];
                if (x != 0.0)
                {
                    if (x > 0) Console.Write("+");
                    Console.Write(x.ToString("F" + 15) + "*x^" + i.ToString());
                }
            }
            Console.WriteLine();

            //відхилення
            Expression exp = new Expression("sqrt(int(((" + f + ")-(" + getString(allL[COUNT - 1]) + "))^2, x, -1, 1))");
            Console.WriteLine(exp.calculate().ToString("F" + 15));
            Console.ReadKey();
        }

        static string getString(List<double> l)
        {
            int n = l.Count();
            string res = l[0].ToString();
            for (int i = 1; i < n; ++i)
            {
                if (l[i] != 0)
                {
                    if (l[i] > 0) res += "+";
                    res += l[i].ToString() + "*x^" + i.ToString();
                }
            }
            return res;
        }
    }
}
