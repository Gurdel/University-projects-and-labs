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
    public partial class FormAddFG : Form
    {
        public FormAddFG()
        {
            InitializeComponent();
        }

        private void FormAddFG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFilms.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.dSFilms.Genres);
            // TODO: This line of code loads data into the 'dSFilms.FilmsGenres' table. You can move, or remove it, as needed.
            this.filmsGenresTableAdapter.Fill(this.dSFilms.FilmsGenres);
            // TODO: This line of code loads data into the 'dSFilms.Films' table. You can move, or remove it, as needed.
            this.filmsTableAdapter.Fill(this.dSFilms.Films);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int fid = Convert.ToInt32(comboBox1.Text);
                int gid = Convert.ToInt32(comboBox3.Text);
                if ((int)queriesTableAdapter1.SQCount_fg_id_by_f_id_g_id_InFilmsGenres(fid, gid) == 0)
                {
                    queriesTableAdapter1.InsertFilmGenre(fid, gid);
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
