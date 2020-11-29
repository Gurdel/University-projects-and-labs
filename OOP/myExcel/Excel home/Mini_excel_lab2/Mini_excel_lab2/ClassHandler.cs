using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Mini_excel_lab2
{
    public class Handler
    {
        Indexator indexator = new Indexator();

        public List<string> ListNameCells(Cell cell, DataGridView dgv)
        {
            string  s = cell.Exp;
            List<string> res = new List<string>();
            int pos = 0;
            int lenS = s.Length;

            while (pos < lenS)
            {
                string oneOfnames = "";
                if (s[pos] <= 'Z' && s[pos] >= 'A')
                {
                    while (pos < lenS && ((s[pos] >= '0' && s[pos] <= '9') || (s[pos] <= 'Z' && s[pos] >= 'A')))
                    {
                        oneOfnames += s[pos];
                        pos++;
                    }
                    if (IsName(oneOfnames, dgv)) res.Add(oneOfnames);
                    else
                    {
                        return new List<string>();
                    }
                   // pos++;
                }
                pos++;
            }
            return res;
        }
        public bool IsName(string s, DataGridView dgv)
        {

            int lenS = s.Length;
            string colCoord = "";
            int rowCoord = 0;
            if ((s[lenS - 1] >= 'A' && s[lenS - 1] <= 'Z') )
            {
                MessageBox.Show("Клітинка не знайдена");
                return false;
            }
            for (int i = 1; i < lenS; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    colCoord += s[i];
                }
                if (s[i] >= '0' && s[i] <= '9')
                {
                    rowCoord += s[i] - '0';
                    rowCoord *= 10;
                }
                if (s[i] >= 'A' && s[i] <= 'Z' && s[i - 1] >= '0' && s[i - 1] <= '9')
                {
                    MessageBox.Show("Клітинка не знайдена");
                    return false;
                }
            }
            if ((indexator.fromWordToNumber(colCoord) > dgv.ColumnCount) || rowCoord/10 > dgv.RowCount - 1)
            {

                MessageBox.Show("Клітинка не знайдена");
                return false;
            }
            return true;
        }




    }
}
