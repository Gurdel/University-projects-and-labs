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
    public partial class FormAboutFilm : Form
    {
        public FormAboutFilm()
        {
            InitializeComponent();
        }

        public FormAboutFilm(int fid)
        {
            InitializeComponent();
            rtbName.Text = (string)queriesTableAdapter.SQGet_f_name_by_id_InFilms(fid);
            rtbYear.Text = Convert.ToString((int)queriesTableAdapter.SQGet_f_year_by_id_InFilms(fid));
            rtbProducer.Text = (string)queriesTableAdapter.SQGet_p_name_by_f_id_inProducers(fid);

            aboutActorsTableAdapter.Fill(dSFilms1.AboutActors, fid);
            aboutGenresTableAdapter.Fill(dSFilms.AboutGenres, fid);
        }

        private void FormAboutFilm_Load(object sender, EventArgs e)
        {

        }
    }
}
