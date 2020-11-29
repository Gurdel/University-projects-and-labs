using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormFilmsBD
{
    public partial class FormAllAboutFilms2 : Form
    {
        public FormAllAboutFilms2()
        {
            InitializeComponent();
        }

        public FormAllAboutFilms2(string name, int year)
        {
            InitializeComponent();
            rtbName.AppendText(name.TrimEnd(' '));
            rtbYear.AppendText(Convert.ToString(year));
            try
            {
                int p_id = (int)kQueriesTableAdapter1.SQGet_f_producer_by_f_name_year_InFilms(name, year);
                rtbProducer.AppendText((string)kQueriesTableAdapter1.SQGet_p_name_by_id_InProducers1(p_id));
            }
            catch { }

            try
            {
                string genres = (string)kQueriesTableAdapter1.SQGet_f_genreslist_by_name_year_InFilms(name, year);
                string[] split = genres.Split('*');
                foreach (string genre in split)
                {
                    if (genre != "")
                        rtbGenres.AppendText(genre + "\n");
                }
            }
            catch { }

            try
            {
                string actors = (string)kQueriesTableAdapter1.SQGet_f_actorslist_by_name_year_InFilms(name, year);
                string[] split = actors.Split('*');
                foreach (string actor in split)
                {
                    if (actor != "")
                    {
                        rtbActors.AppendText((string)kQueriesTableAdapter1.SQGet_a_name_by_id_InActors(Convert.ToInt32(actor)) + "\n");
                    }
                }
            }
            catch { }
        }

        private void FormAllAboutFilms2_Load(object sender, EventArgs e)
        {

        }
    }
}
