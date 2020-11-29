using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsLab2
{
    public partial class InfoAboutFilm : Form
    {
        public InfoAboutFilm()
        {
            InitializeComponent();
        }

        public InfoAboutFilm(int fid)
        {
            InitializeComponent();
            FilmsLab2.FilmsBDEntities2 ctx = new FilmsLab2.FilmsBDEntities2();
            rtbName.AppendText((from f in ctx.Films where f.f_id == fid select f.d_name).First());
            rtbYear.AppendText(Convert.ToString((from _f in ctx.Films where _f.f_id == fid select _f.f_year).First()));
            int pid = (int)(from ff in ctx.Films where ff.f_id == fid select ff.f_producer).First();
            rtbProducer.AppendText((from p in ctx.Producers where p.p_id == pid select p.p_name).First());
            List<int> gids = new List<int>();
            gids = (from fg in ctx.FilmsGenres where fg.fg_f_id == fid select fg.fg_g_id).ToList();
            foreach (int gid in gids)
            {
                rtbGenres.AppendText((from g in ctx.Genres where g.g_id == gid select g.g_name).First() + "\n");
            }
            List<int> aids = new List<int>();
            aids = (from fa in ctx.FilmsActors where fa.fa_f_id == fid select fa.fa_a_id).ToList();
            foreach (int aid in aids)
            {
                rtbActors.AppendText((from a in ctx.Actors where a.a_id == aid select a.a_name).First() + "\n");
            }
        }

        private void InfoAboutFilm_Load(object sender, EventArgs e)
        {

        }
    }
}
