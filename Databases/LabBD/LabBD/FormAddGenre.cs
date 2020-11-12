using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBD
{
    public partial class FormAddGenre : Form
    {
        public FormAddGenre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                if ((int)queriesTableAdapter.SQCount_g_id_by_g_name_InGenres(name) == 0)
                {
                    queriesTableAdapter.InsertGenre(name);
                    MessageBox.Show("Додано");
                }
                else
                {
                    MessageBox.Show("Такий жанр уже є");
                }
            }
            catch
            {
                MessageBox.Show("Щось пішло не так", "Помилка");
            }
        }
    }
}
