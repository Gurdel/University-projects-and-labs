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
    public partial class Form1 : Form
    {
        Indexator indexator = new Indexator();
        Parser parser = new Parser();
        Handler handler = new Handler();
        int currRow, currCol;
        public Dictionary<string, Cell> dictionary = new Dictionary<string, Cell>();
        public Dictionary<string, Cell> dictionaryCellsWithFormuls = new Dictionary<string, Cell>();
        public Form1()
        {
            InitializeComponent();
            DataGridViewColumn A = new DataGridViewColumn();
            DataGridViewColumn B = new DataGridViewColumn();
            DataGridViewColumn C = new DataGridViewColumn();
            DataGridViewColumn D = new DataGridViewColumn();
            DataGridViewColumn E = new DataGridViewColumn();
            DataGridViewColumn F = new DataGridViewColumn();
            DataGridViewColumn G = new DataGridViewColumn();
            DataGridViewColumn H = new DataGridViewColumn();

            Cell cellA = new Cell(); A.CellTemplate = cellA;
            Cell cellB = new Cell(); B.CellTemplate = cellB;
            Cell cellC = new Cell(); C.CellTemplate = cellC;
            Cell cellD = new Cell(); D.CellTemplate = cellD;
            Cell cellE = new Cell(); E.CellTemplate = cellE;
            Cell cellF = new Cell(); F.CellTemplate = cellF;
            Cell cellG = new Cell(); G.CellTemplate = cellG;
            Cell cellH = new Cell(); H.CellTemplate = cellH;


            A.HeaderText = "A"; A.Name = "A";
            B.HeaderText = "B"; B.Name = "B";
            C.HeaderText = "C"; C.Name = "C";
            D.HeaderText = "D"; D.Name = "D";
            E.HeaderText = "E"; E.Name = "E";
            F.HeaderText = "F"; F.Name = "F";
            G.HeaderText = "G"; G.Name = "G";
            H.HeaderText = "H"; H.Name = "H";

            dgv.Columns.Add(A);
            dgv.Columns.Add(B);
            dgv.Columns.Add(C);
            dgv.Columns.Add(D);
            dgv.Columns.Add(E);
            dgv.Columns.Add(F);
            dgv.Columns.Add(G);
            dgv.Columns.Add(H);

            DataGridViewRow row = new DataGridViewRow();
            dgv.Rows.Add(row);
            dgv.Rows.Add();
            dgv.Rows.Add();
            dgv.Rows.Add();
            dgv.Rows.Add();
            dgv.Rows.Add();
            dgv.Rows.Add();

            for (int i = 0; i < 9; i++)
            {
                for(int j=0; j<9; j++)
                {
                    string cell_name = indexator.fromNumberToWord(j + 1) + (i + 1).ToString();
                    Cell cell = new Cell();
                    cell.Value = "0";
                    cell.Exp = "0";
                    dictionary.Add(cell_name, cell);
                }
            }

            List<string> test = new List<string>();


            // label1.Text = i.nextWord(dataGridView1.Columns[0].HeaderText, dataGridView1.Columns[0].HeaderText.Length - 1);
            //label1.Text = p.ExpressionStart("5*2^(2+1)").ToString();
            //label1.Text = i.fromWordToNumber("BA").ToString();
        }

        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            currRow = dgv.CurrentCell.RowIndex;
            currCol = dgv.CurrentCell.ColumnIndex;
            string currCellName = indexator.fromNumberToWord(currCol + 1) + (currRow + 1).ToString();
            label3.Text = currCellName;
            textBoxFormula.Text = dictionary[currCellName].Exp;
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            string currCellName = indexator.fromNumberToWord(currCol + 1) + (currRow + 1).ToString();
            if(dgv.Rows[currRow].Cells[currCol].Value!=null)
            {
                string currCellValue = dgv.Rows[currRow].Cells[currCol].Value.ToString();
                dictionary[currCellName].Value = parser.ExpressionStart(currCellValue).ToString();
                dgv.Rows[currRow].Cells[currCol].Value = dictionary[currCellName].Value;
            }
        }
        private void buttonAddColumn_Click(object sender, EventArgs e)//додати колонку
        {
            int n = dgv.ColumnCount++;
            dgv.Columns[n].HeaderText = indexator.nextWord(dgv.Columns[n - 1].HeaderText);
        }

        private void buttonAddRow_Click(object sender, EventArgs e)//додати рядочок
        {
            dgv.RowHeadersVisible = true;
            int n = dgv.RowCount++;
            dgv.Rows[n].HeaderCell.Value = n.ToString();
        }

        private void textBoxFormula_TextChanged(object sender, EventArgs e) // записать формулу
        {
            string currCellName = indexator.fromNumberToWord(currCol + 1) + (currRow + 1).ToString();
            dictionary[currCellName].Exp = textBoxFormula.Text;

        }

        private void calculateExp_Click(object sender, EventArgs e)
        {
            Cell testCell = new Cell();
            testCell.Exp = "A1 + A2";
           // label1.Text = CalcCell(testCell, dgv).ToString();

            for(int j=0; j<dgv.ColumnCount ; j++)
            {
               for(int i =0; i <dgv.RowCount; i++)
                {
                    string currCellName = indexator.fromNumberToWord(j + 1) + (i + 1).ToString();
                    if(dictionary[currCellName].Exp != "0")
                    {
                        dgv.Rows[i].Cells[j].Value = CalcCell(dictionary[currCellName], dgv).ToString();
                        dictionary[currCellName].Value = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }

            }
        }

        public double CalcCell(Cell c, DataGridView dgv)
        {
            string saveFormula = c.Exp;
            List<string> anotherCells = handler.ListNameCells(c, dgv);
            if (anotherCells.Count == 0)
            {
                if (c.Value == "0" || c.Value == null)
                {
                    return parser.ExpressionStart(c.Exp);
                }
                return parser.ExpressionStart(c.Value);
            }
            else
            {
                for(int i=0; i< anotherCells.Count; i++)
                {
                   c.Exp =  c.Exp.Replace(anotherCells[i]," " + CalcCell(dictionary[anotherCells[i]], dgv).ToString() + " ");
                }
                string finishFormula = c.Exp;
                c.Exp = saveFormula;
                MessageBox.Show(finishFormula);
                return parser.ExpressionStart(finishFormula);
            }
        }

    } 

}
