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
    public partial class FormAddFilm : Form
    {
        public FormAddFilm()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 1888;
        }

        private void FormAddFilm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FormFilms f = new FormFilms();
            //f.FillAll();
        }

        private void FormAddFilm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFilms.Producers' table. You can move, or remove it, as needed.
            this.producersTableAdapter.Fill(this.dSFilms.Producers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                int year = (int)numericUpDown1.Value;
                int pid = Convert.ToInt32(comboBox2.Text);
                if((int)queriesTableAdapter.SQCount_f_id_by_f_name_year_InFilms(name, year) == 0)
                {
                    queriesTableAdapter.InsertFilm(name, year, pid);
                    MessageBox.Show("Додано");
                }
                else
                {
                    MessageBox.Show("Такий фільм уже є");
                }
            }
            catch
            {
                MessageBox.Show("Щось пішло не так", "Помилка");
            }
        }
    }
}
