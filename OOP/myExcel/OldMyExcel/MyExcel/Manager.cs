using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExcel
{
    public class Manager
    {
        public string mode = "expression";
        const int MAXHEIGHT = 666;
        const int MAXWIDTH = 999;

        private int height = 51; //рядки
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        private int width = 41; //стовпчики
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public Cell[,] cells = new Cell[MAXWIDTH, MAXHEIGHT];

        public Parser parser = new Parser();
        public Calculator calc = new Calculator();

        public Manager()
        {
            for (int i = 0; i < MAXWIDTH; i++)
            {
                for (int j = 0; j < MAXHEIGHT; j++)
                {
                   cells[i, j] = new Cell();
                }
            }
        }

        public string toSys(int i)
        {
            int k = 0;
            int[] arr = new int[100];
            while (i > 25)
            {
                arr[k] = i / 26 - 1;
                k++;
                i %= 26;
            }
            arr[k] = i;

            string res = "";
            for (int j = 0; j <= k; j++)
            {
                res += ((char)('A' + arr[j])).ToString();
            }

            return res;
        }

        public int fromSys(string name)
        {
            char[] arr = name.ToCharArray();
            int l = arr.Length;
            int res = 0;
            for (int i = l - 2; i >= 0; i--)
            {
                res += (((int)arr[i] - (int)'A') + 1) * Convert.ToInt32(Math.Pow(26, l - i - 1));
            }
            res += ((int)arr[l - 1] - (int)'A');

            return res;
        }
    
        
    //
    //ЗМІНА КЛІТИН Й ІНША ФІГНЯ
    //
        public bool ChangeCell(int i, int j, string str) //повертає true, якщо все норм. Інакше повертає false
        {
            string buf = "";
            cells[i, j].Expression = str;

            //заміна клітин на їх значення
            string[] words = str.Split(new char[] { ' ' });
            str = "";

            foreach (string s in words)
            {
                if (char.IsLetter(s[0]))
                {
                    string letter = "";
                    string number = "";
                    for (int _i = 0; _i < s.Length; _i++)
                    {
                        if (char.IsLetter(s[_i]))
                            letter += s[_i];
                        else
                            number += s[_i];
                    }
                    str += Convert.ToString(cells[fromSys(letter), Convert.ToInt32(number)].Value);

                    //додаю зв'язок клітин
                    buf = toSys(i) + Convert.ToString(j);
                    if (cells[fromSys(letter), Convert.ToInt32(number)].attach.IndexOf(buf) == -1)
                        cells[fromSys(letter), Convert.ToInt32(number)].attach.Add(buf);
                }
                else
                {
                    str += s;
                }
            }

            cells[i, j].Value = parser.Evaluate(str);

            foreach (string s in cells[i, j].attach)
            {
                string letter = "";
                string number = "";
                for (int _i = 0; _i < s.Length; _i++)
                {
                    if (char.IsLetter(s[_i]))
                        letter += s[_i];
                    else
                        number += s[_i];
                }
                ChangeCell(fromSys(letter), Convert.ToInt32(number), cells[fromSys(letter), Convert.ToInt32(number)].Expression);
            }


            return true;
        }

        public void AddRow()
        {
            if (height < MAXHEIGHT)
            {
                height++;
            }
        }

        public void AddColumn()
        {
            if (width < MAXWIDTH)
            {
                width++;
            }
        }

        public void DeleteColumn()
        {
            if (width > 0)
            {
                for (int i = 0; i < height; i++)
                {
                    cells[width - 1, i].Value = 0.0;
                    cells[width - 1, i].Expression = "";
                    foreach (string s in cells[width - 1, i].attach)
                    {
                        string letter = "";
                        string number = "";
                        for (int _i = 0; _i < s.Length; _i++)
                        {
                            if (char.IsLetter(s[_i]))
                                letter += s[_i];
                            else
                                number += s[_i];
                        }
                        ChangeCell(fromSys(letter), Convert.ToInt32(number), cells[fromSys(letter), Convert.ToInt32(number)].Expression);
                    }
                }
                width--;
            }
        }

        public void DeleteRow()
        {
            if (height > 0)
            {
                for (int i = 0; i < width; i++)
                {
                    cells[i, height - 1].Value = 0.0;
                    cells[i, height - 1].Expression = "";
                    foreach (string s in cells[i, height - 1].attach)
                    {
                        string letter = "";
                        string number = "";
                        for (int _i = 0; _i < s.Length; _i++)
                        {
                            if (char.IsLetter(s[_i]))
                                letter += s[_i];
                            else
                                number += s[_i];
                        }
                        ChangeCell(fromSys(letter), Convert.ToInt32(number), cells[fromSys(letter), Convert.ToInt32(number)].Expression);
                    }
                }
                height--;
            }
        }
    }
}
