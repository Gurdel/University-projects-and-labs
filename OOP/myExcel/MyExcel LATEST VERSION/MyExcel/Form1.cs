using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExcel
{
    public partial class Form1 : Form
    {
        public Manager manager = new Manager();
        public File file = new File();
        public Form1()
        {

            InitializeComponent();
            openFileDialog1.Filter = "(*.tbl)|*.tbl";
            saveFileDialog1.Filter = "(*.tbl)|*.tbl";
            dataGridView1.RowHeadersWidth = 65;

            getTable();
        }

        public void getTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            for (int i = 0; i < manager.Width; i++)
            {
                dataGridView1.Columns.Add(Convert.ToString(i), manager.toSys(i));
            }

            for (int i = 0; i < manager.Height; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = i.ToString();
            }

            if (manager.mode == "expression")
            {
                for (int i = 0; i < manager.Width; i++)
                {
                    for (int j = 0; j < manager.Height; j++)
                    {
                        if (manager.cells[i, j].Error != "")
                        {
                            dataGridView1.Rows[j].Cells[i].Value = manager.cells[i, j].Error;
                        }
                        else
                        dataGridView1.Rows[j].Cells[i].Value = manager.cells[i, j].Expression;
                    }
                }
            }
            if (manager.mode == "value")
            {
                for (int i = 0; i < manager.Width; i++)
                {
                    for (int j = 0; j < manager.Height; j++)
                    {
                        if (manager.cells[i, j].Error != "")
                        {
                            dataGridView1.Rows[j].Cells[i].Value = manager.cells[i, j].Error;
                        }
                        else
                            dataGridView1.Rows[j].Cells[i].Value = manager.cells[i, j].Value;
                    }
                }
            }
        }

        private void expressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.mode = "expression";
            getTable();
        }

        private void valueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.mode = "value";
            getTable();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            string str = "";
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            str = (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).ToString();
            manager.SetCell(e.ColumnIndex, e.RowIndex, str);
            getTable();
            
        }

        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.AddColumn();
            getTable();
        }

        private void addRowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            manager.AddRow();
            getTable();
        }

        private void deleteColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.DeleteColumn();
            getTable();
        }

        private void deleteRowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            manager.DeleteRow();
            getTable();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Close the program?",
            "Closing...",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            if (manager.OpenFile(filename))
            {
                getTable();
                MessageBox.Show("File open");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;
            if (manager.SaveFile(filename))
            {
                getTable();
                MessageBox.Show("File saved");
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = manager.cells[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex].Expression;
        }
    }
}
