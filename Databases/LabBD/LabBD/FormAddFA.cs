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
    public partial class FormAddFA : Form
    {
        public FormAddFA()
        {
            InitializeComponent();
        }

        private void FormAddFA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFilms.Actors' table. You can move, or remove it, as needed.
            this.actorsTableAdapter.Fill(this.dSFilms.Actors);
            // TODO: This line of code loads data into the 'dSFilms.Films' table. You can move, or remove it, as needed.
            this.filmsTableAdapter.Fill(this.dSFilms.Films);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int fid = Convert.ToInt32(comboBox1.Text);
                int aid = Convert.ToInt32(comboBox3.Text);
                if ((int)queriesTableAdapter1.SQCount_fa_id_by_f_id_a_id_InFilmsActors(fid, aid) == 0)
                {
                    queriesTableAdapter1.InsertFilmActor(fid, aid);
                    MessageBox.Show("Додано");
                }
                else
                {
                    MessageBox.Show("Такий зв'язок уже є");
                }
            }
            catch
            {
                MessageBox.Show("Щось пішло не так", "Помилка");
            }
        }
    }
}
