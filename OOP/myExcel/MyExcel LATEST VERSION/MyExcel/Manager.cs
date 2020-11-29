using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MyExcel
{
    public class Manager
    {
        public string mode = "expression";
        const int MAXHEIGHT = 666;
        const int MAXWIDTH = 999;
        private File file = new File();

        private int height = 11; //рядки
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        private int width = 11; //стовпчики
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public Cell[,] cells = new Cell[MAXWIDTH, MAXHEIGHT];

        public Parser parser = new Parser();
        public Calculator calc = new Calculator();
        private List<string> visited = new List<string>();
        private int presColumn;
        private int presRow;

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
    //ЗМІНА КЛІТИН
    //
        public bool ChangeCell(int i, int j, string str) //повертає true, якщо все норм. Інакше повертає false
        {
            //string buf = "";
            cells[i, j].Expression = str;

            //заміна клітин на їх значення
            string[] words = str.Split(new char[] { ' ' });
            str = "";
            foreach (string s in words)
            {
                if (char.IsLetter(s[0]) && !char.IsLower(s[0]))
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
                    int column = fromSys(letter);
                    int row = Convert.ToInt32(number);
                    if (presColumn == column && presRow == row)
                    {
                        cells[presColumn, presRow].Error = "LOOPING";
                        return false;
                    }
                    if (column >= width || row >= height)
                    {
                        cells[i, j].Error = "WRONG CELL";
                        return false;
                    }
                    if (cells[column, row].Expression == "")
                    {
                        cells[i, j].Error = "NON EXPRESSION";
                        return false;
                    }
                    if (cells[column, row].Error != "")
                    {
                        cells[i, j].Error = cells[column, row].Error;
                        return false;
                    }
                    if (ChangeCell(column, row, cells[column, row].Expression))
                        str += Convert.ToString(cells[column, row].Value);
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    str += s;
                }
            }

            str = calc.Calc(str);
            if (str == "DIV BY ZERO")
            {
                cells[i, j].Error = str;
                return false;
            }
            else
            {
                cells[i, j].Value = Convert.ToDouble(str);
            }

            if (cells[i, j].Error != "")
            {
                cells[i, j].Error = "";
                ReCalcTable();
            }

            return true;
        }

        public void ReCalcTable()
        {
            for (int i = 0; i < width; i ++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (cells[i, j].Expression != "")
                    {
                        presColumn = i;
                        presRow = j;
                        ChangeCell(i, j, cells[i, j].Expression);
                    }
                }
            }
        }

        public void SetCell(int i, int j, string str)
        {
            cells[i, j].Expression = str;
            if (str == "")
            {
                cells[i, j].Value = 0.0;
                cells[i, j].Error = "";
            }
            ReCalcTable();
        }

        public void AddRow()
        {
            if (height < MAXHEIGHT)
            {
                height++;
                ReCalcTable();
            }
        }

        public void AddColumn()
        {
            if (width < MAXWIDTH)
            {
                width++;
                ReCalcTable();
            }
        }

        public void DeleteColumn()
        {
            if (width > 0)
            {
                for (int i = 0; i < height; i++)
                {
                    if (cells[width - 1, i].Expression != "")
                    {
                        DialogResult result = MessageBox.Show(
                        "The column has an expression. Are you sure you want to delete the column?",
                        "Deleting column...",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            for (int j = i; j < height; j++)
                            {
                                cells[width - 1, j].Value = 0.0;
                                cells[width - 1, j].Expression = "";
                                cells[width - 1, j].Error = "";
                            }
                            break;
                        }
                    }
                }
                width--;
                ReCalcTable();
            }
        }

        public void DeleteRow()
        {
            if (height > 0)
            {
                for (int i = 0; i < width; i++)
                {
                    if (cells[i, height - 1].Expression != "")
                    {
                        DialogResult result = MessageBox.Show(
                        "The row has an expression. Are you sure you want to delete the row?",
                        "Deleting row...",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            for (int j = i; j < width; j++)
                            {
                                cells[j, height - 1].Value = 0.0;
                                cells[j, height - 1].Expression = "";
                                cells[j, height - 1].Error = "";
                            }
                            break;
                        }
                    }
                }
                height--;
                ReCalcTable();
            }
        }

        public bool OpenFile(string name)
        {
            if (file.Open(name))
            {
                for (int i = 0; i < MAXWIDTH; i++)
                {
                    for (int j = 0; j < MAXHEIGHT; j++)
                    {
                        cells[i, j].Value = 0.0;
                        cells[i, j].Expression = "";
                    }
                }

                string[] index = file.Lines[0].Split(new char[] { '_' });
                width = Convert.ToInt32(index[0]);
                height = Convert.ToInt32(index[1]);
                for (int i = 1; i < file.Lines.Length; i++)
                {
                    string[] cell = file.Lines[i].Split(new char[] { '_' });
                    cells[Convert.ToInt32(cell[0]), Convert.ToInt32(cell[1])].Expression = cell[2];
                }

                ReCalcTable();

                return true;
            }
            else
                return false;
        }

        public bool SaveFile(string name)
        {
            //получить доступ к  существующему либо создать новый
            StreamWriter file = new StreamWriter(name);
            file.WriteLine($"{width}_{height}");
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (cells[i, j].Expression != "")
                    {
                        file.WriteLine($"{i}_{j}_{cells[i, j].Expression}");
                    }
                }
            }
            //закрыть для сохранения данных
            file.Close();

            return true;
        }
    }
}
