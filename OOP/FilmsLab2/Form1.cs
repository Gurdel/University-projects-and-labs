using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace FilmsLab2
{
    public partial class FormFilms : Form
    {
        private FilmsLab2.FilmsBDEntities2 ctx;
        private int id = -1;
        private bool admin = false;
        private int minBirthYear = 1;
        private int maxDeathYear = 2019;
        private int standartYear = 1991;
        private int minFilmYear = 1983;
        private int maxFilmYear = 2019;
        private string oldPName = "";
        private int oldPBirth = -1;
        private int oldPDeath = -1;
        private string oldAName = "";
        private int oldABirth = -1;
        private int oldADeath = -1;
        private string oldGName = "";
        private bool startEditFilms = false;
        private string oldFName = "";
        private int oldFYear = -1;


        private void Info(int fid)
        {
            InfoAboutFilm inf = new InfoAboutFilm(fid);
            inf.Show();
        }

        public FormFilms()
        {
            InitializeComponent();
        }

        private void FillAllBindingSources()
        {
            this.actorBindingSource.DataSource = ctx.Actors.Local.ToBindingList();
            this.findedActorsBS.DataSource = ctx.Actors.Local.ToBindingList();
            this.producerBindingSource.DataSource = ctx.Producers.Local.ToBindingList();
            this.findedProducerBS.DataSource = ctx.Producers.Local.ToBindingList();
            this.filmBindingSource.DataSource = ctx.Films.Local.ToBindingList();
            this.findedFilmsBS.DataSource = ctx.Films.Local.ToBindingList();
            this.genreBindingSource.DataSource = ctx.Genres.Local.ToBindingList();
            this.findedGenresBS.DataSource = ctx.Genres.Local.ToBindingList();
            this.viewersFilmBindingSource.DataSource = ctx.ViewersFilms.Local.ToBindingList();
            this.viewerBindingSource.DataSource = ctx.Viewers.Local.ToBindingList();
            this.filmsActorBindingSource.DataSource = ctx.FilmsActors.Local.ToBindingList();
            this.filmsGenreBindingSource.DataSource = ctx.FilmsGenres.Local.ToBindingList();
            var query = (from f in ctx.Films select f.f_year).Distinct();
            query.Load();
            this.unicFilmYear.DataSource = query.ToList();
            query = (from p in ctx.Producers select p.p_birth).Distinct();
            query.Load();
            this.unicProducerBirth.DataSource = query.ToList();
            var quer = (from p in ctx.Producers where p.p_death != null select p.p_death).Distinct();
            quer.Load();
            this.unicProducerDeath.DataSource = quer.ToList();
            query = (from a in ctx.Actors select a.a_birth).Distinct();
            query.Load();
            this.unicActorBirth.DataSource = query.ToList();
            quer = (from a in ctx.Actors where a.a_death != null select a.a_death).Distinct();
            quer.Load();
            this.unicActorDeath.DataSource = quer.ToList();
            if (id != -1)
            {
                var que = (from vf in ctx.ViewersFilms where vf.vf_v_id == id select vf.Film);
                que.Load();
                listFilmsBS.DataSource = que.ToList();
            }
        }

        private void ClearAllCmbText()
        {
            cmbSearchActorBirth.Text = "";
            cmbSearchActorDeath.Text = "";
            cmbSearchActorName.Text = "";
            cmbSearchProducerBirth.Text = "";
            cmbSearchProducerDeath.Text = "";
            cmbSearchProducerName.Text = "";
            cmbSearchGenre.Text = "";
            cmbSearchFilmsActor.Text = "";
            cmbSearchFilmsGenre.Text = "";
            cmbSearchFilmsName.Text = "";
            cmbSearchFilmsProducer.Text = "";
            cmbSearchFilmsYear.Text = "";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ctx = new FilmsLab2.FilmsBDEntities2();
            ctx.Films.Load();
            ctx.Actors.Load();
            ctx.Producers.Load();
            ctx.Genres.Load();
            ctx.Viewers.Load();
            ctx.FilmsActors.Load();
            ctx.FilmsGenres.Load();
            ctx.ViewersFilms.Load();
            FillAllBindingSources();

            ClearAllCmbText();

            AllUnvisible();
            lblLogin.Visible = lblPassword.Visible = true;
            txtbLogin.Visible = txtbPassword.Visible = true;
            tabControlSearch.Visible = true;
            btnEnter.Visible = btnRegistration.Visible = true;

            nudAddFilmYear.Minimum = nudAddProducerBirth.Minimum = nudAddProducerDeath.Minimum = nudAddActorBirth.Minimum = nudAddActorDeath.Minimum = minBirthYear;
            nudAddFilmYear.Maximum = nudAddProducerBirth.Maximum = nudAddProducerDeath.Maximum = nudAddActorBirth.Maximum = nudAddActorDeath.Maximum = maxDeathYear;
            nudAddFilmYear.Value = nudAddProducerDeath.Value = nudAddProducerBirth.Value = nudAddActorDeath.Value = nudAddActorBirth.Value = standartYear;
        }

        private int getViewerIdByUsername(string username)
        {
            int b = (from v in ctx.Viewers where v.v_username == username select v.v_id).First();
            return b;
        }

        private string getFilmNameById(int id)
        {
            return (from f in ctx.Films where f.f_id == id select f.d_name).First();
        }

        private int getFilmYearById(int id)
        {
            return (from f in ctx.Films where f.f_id == id select f.f_year).First();
        }

        private List<int> getFilmsIdListByGenreId(int gid)
        {
            return (from fg in ctx.FilmsGenres where fg.fg_g_id == gid select fg.fg_f_id).ToList();
        }

        private List<int> getFilmsIdListByActorId(int aid)
        {
            return (from fa in ctx.FilmsActors where fa.fa_a_id == aid select fa.fa_f_id).ToList();
        }

        private int getProducerIdByName(string pname)
        {
            try
            {
                return (from p in ctx.Producers where p.p_name == pname select p.p_id).First();
            }
            catch { }
            return -1;
        }

        private int getGenreIdByName(string gname)
        {
            try
            {
                return (from g in ctx.Genres where g.g_name == gname select g.g_id).First();
            }
            catch { }
            return -1;
        }

        private int getActorIdByName(string aname)
        {
            try
            {
                return (from a in ctx.Actors where a.a_name == aname select a.a_id).First();
            }
            catch { }
            return -1;
        }

        private List<string> getViewerFilmListByVId(int id)
        {
            List<string> result = new List<string>();
            List<int> films_id = (from vf in ctx.ViewersFilms where vf.vf_v_id == id select vf.vf_f_id).ToList();
            foreach (int fid in films_id)
            {
                string name = getFilmNameById(fid);
                string year = Convert.ToString(getFilmYearById(fid));
                result.Add(name + " " + year);
            }
            return result;
        }

        protected void AllUnvisible()
        {
            tabControlSearch.Visible = tabControlChenging.Visible = false;
            dgvList.Visible = false;
            btnListDelete.Visible = false;
            btnEnter.Visible = btnExit.Visible = btnList.Visible = btnListEnd.Visible =
                btnRegistr.Visible = btnRegistration.Visible = btnEditing.Visible = btnEndEdit.Visible =
                btnSaveAllChanges.Visible = btnRegCancel.Visible = false;
            lblRegLogin.Visible = lblRegMail.Visible = lblRegName.Visible = lblRegPassword.Visible = false;
            txtbRegistrationMail.Visible = txtbRegistrationName.Visible =
                txtbRegistrationPassword.Visible = txtbRegistrationUsername.Visible = false;
            btnAddToList.Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }

        private void btnSaveAllChanges_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
            MessageBox.Show("Збережено");
        }

        private void btnSaveFilms_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
            MessageBox.Show("Збережено");
        }

        private void btnSaveGenres_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
            MessageBox.Show("Збережено");
        }

        private void btnSaveProducers_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
            MessageBox.Show("Збережено");
        }

        private void btnSaveActors_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
            MessageBox.Show("Збережено");
        }

        private void btnSaveViewers_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
            MessageBox.Show("Збережено");
        }

        private void btnDeleteGenres_Click(object sender, EventArgs e)
        {
            try
            {
                Genre genre = (Genre) dgvGenres.CurrentRow.DataBoundItem;
                var b = (from fg in ctx.Films where fg.FilmsGenres.Any(f => f.fg_g_id == genre.g_id) select fg).Any();
                if (b)
                {
                    MessageBox.Show("Існує фільм із цим жанром", "Помилка видалення");
                }
                else
                {
                    genreBindingSource.RemoveCurrent();
                }
            }
            catch (Exception){ MessageBox.Show("Невідома помилка", "Помилка видалення"); }
        }

        private void btnDeleteProducer_Click(object sender, EventArgs e)
        {
            Producer prod = (Producer) dgvProducers.CurrentRow.DataBoundItem;
            var b = (from f in ctx.Films where f.f_producer == prod.p_id select f).Any();
            if (b)
            {
                MessageBox.Show("Існує фільм із цим режисером", "Помилка видалення");
            }
            else
            {
                producerBindingSource.RemoveCurrent();
            }
        }

        private void btnDeleteActors_Click(object sender, EventArgs e)
        {
            Actor act = (Actor)dgvActors.CurrentRow.DataBoundItem;
            var b = (from f in ctx.Films where f.FilmsActors.Any(fa => fa.fa_a_id == act.a_id) select f).Any();
            if (b)
            {
                MessageBox.Show("Існує фільм із цим актором", "Помилка видалення");
            }
            else
            {
                actorBindingSource.RemoveCurrent();
            }
        }

        private void btnDeleteViewers_Click(object sender, EventArgs e)
        {
            int vid = (int)dgvViewers.CurrentRow.Cells["vid"].Value;
            var vfs = (from vf in ctx.ViewersFilms where vf.vf_v_id == vid select vf);
            ctx.ViewersFilms.RemoveRange(vfs);
            var viewer = (from v in ctx.Viewers where v.v_id == vid select v).First();
            ctx.Viewers.Remove(viewer);
            FillAllBindingSources();
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            string login = txtbRegistrationUsername.Text;
            string password = txtbRegistrationPassword.Text;
            string name = txtbRegistrationName.Text;
            string mail = txtbRegistrationMail.Text;
            string[] split = mail.Split('@');
            if (login == "" || password == "")
            {
                MessageBox.Show("Уведіть необхідні дані", "Помилка реєстрації");
            }
            else
            {
                if (mail != "" && split.Count() != 2)
                {
                    MessageBox.Show("Некоректна пошта", "Помилка реєстрації");
                }
                else
                {
                    var b = (from v in ctx.Viewers where (v.v_username == login) select v).Any();
                    if (b)
                    {
                        MessageBox.Show("Такий користувач уже існує", "Помилка реєстрації");
                    }
                    else
                    {
                        try
                        {
                            Viewer v = new Viewer();
                            v.v_name = name;
                            v.v_password = password;
                            v.v_username = login;
                            v.v_mail = mail;
                            v.v_admin = false;
                            ctx.Viewers.Add(v);
                            ctx.SaveChanges();
                            MessageBox.Show("Зареєстровано!");

                            id = getViewerIdByUsername(login);
                            AllUnvisible();
                            tabControlSearch.Visible = true;
                            btnExit.Visible = btnList.Visible = true;
                            btnAddToList.Visible = true;
                            txtbLogin.Text = login;
                            txtbPassword.Text = password;
                        }
                        catch
                        {
                            MessageBox.Show("Невідома помилка", "Помилка реєстрації");
                        }
                    }
                }
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            AllUnvisible();
            txtbRegistrationMail.Clear();
            txtbRegistrationName.Clear();
            txtbRegistrationPassword.Clear();
            txtbRegistrationUsername.Clear();
            lblRegLogin.Visible = lblRegMail.Visible = lblRegName.Visible = lblRegPassword.Visible = true;
            txtbRegistrationMail.Visible = txtbRegistrationName.Visible = txtbRegistrationPassword.Visible = txtbRegistrationUsername.Visible = true;
            btnRegistr.Visible = btnRegCancel.Visible = true;
            btnEnter.Visible = true;
        }

        private void btnSearchFilms_Click(object sender, EventArgs e)
        {
            string fname = cmbSearchFilmsName.Text;
            string _fyear = cmbSearchFilmsYear.Text;
            string fproducer = cmbSearchFilmsProducer.Text;
            string fgenre = cmbSearchFilmsGenre.Text;
            string factor = cmbSearchFilmsActor.Text;

            int fyear = -1;
            try
            {
                fyear = Convert.ToInt32(_fyear);
                if (fyear > maxFilmYear || fyear < minFilmYear)
                {
                    fyear = -1;
                    cmbSearchFilmsYear.Text = "";
                }
            }
            catch
            {
                cmbSearchFilmsYear.Text = "";
            }

            FilmsLab2.FilmsBDEntities2 ctxFindFilms = new FilmsBDEntities2();
            var query = from f in ctxFindFilms.Films select f;
            if (!string.IsNullOrWhiteSpace(fname) && !string.IsNullOrEmpty(fname)) query = query.Where(f => f.d_name == fname);
            if (fyear != -1) query = query.Where(f => f.f_year == fyear);
            if (!string.IsNullOrWhiteSpace(fproducer) && !string.IsNullOrEmpty(fproducer))
            {
                int pid = -1;
                pid = getProducerIdByName(fproducer);
                if (pid != -1) query = query.Where(f => f.f_producer == pid);
            }
            if(!string.IsNullOrWhiteSpace(fgenre) && !string.IsNullOrEmpty(fgenre))
            {
                int gid = -1;
                gid = getGenreIdByName(fgenre);
                List<int> fidlist = new List<int>();
                fidlist = getFilmsIdListByGenreId(gid);
                query = query.Where(f => fidlist.Contains(f.f_id));
            }
            if (!string.IsNullOrWhiteSpace(factor) && !string.IsNullOrEmpty(factor))
            {
                int aid = -1;
                aid = getActorIdByName(factor);
                List<int> aidlist = new List<int>();
                aidlist = getFilmsIdListByActorId(aid);
                query = query.Where(f => aidlist.Contains(f.f_id));
            }

            query.Load();
            findedFilmsBS.DataSource = query.ToList();
        }

        private void btnRegCancel_Click(object sender, EventArgs e)
        {
            AllUnvisible();
            tabControlSearch.Visible = true;
            btnEnter.Visible = btnRegistration.Visible = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = txtbLogin.Text;
            string password = txtbPassword.Text;
            var b = (from v in ctx.Viewers where (v.v_username == login && v.v_password == password) select v).Any();
            if (b)
            {
                id = getViewerIdByUsername(login);
                admin = (from v in ctx.Viewers where (v.v_id == id) && v.v_admin select v).Any();
                AllUnvisible();
                tabControlSearch.Visible = true;
                btnExit.Visible = btnList.Visible = true;
                btnAddToList.Visible = true;
                if (admin) btnEditing.Visible = true;
            }
            else
            {
                MessageBox.Show("Неправильний логін чи пароль", "Помилка входу");
            }
        }

        private void btnEditing_Click(object sender, EventArgs e)
        {
            AllUnvisible();
            tabControlChenging.Visible = true;
            btnExit.Visible = btnList.Visible = btnEndEdit.Visible = btnSaveAllChanges.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AllUnvisible();
            txtbLogin.Clear();
            txtbPassword.Clear();
            tabControlSearch.Visible = true;
            btnEnter.Visible = btnRegistration.Visible = true;
        }

        private void btnEndEdit_Click(object sender, EventArgs e)
        {
            AllUnvisible();
            tabControlSearch.Visible = true;
            btnExit.Visible = btnList.Visible = true;
            btnAddToList.Visible = true;
            if (admin) btnEditing.Visible = true;
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            try
            {
                int f_id = (int)dgvSearchFilms.CurrentRow.Cells["f_id"].Value;
                if ((from v in ctx.ViewersFilms where v.vf_f_id == f_id && v.vf_v_id==id select v).Any())
                {
                    MessageBox.Show("Цей фільм уже в списку", "Помилка додавання");
                }
                else
                {
                    ViewersFilm vf = new ViewersFilm();
                    vf.vf_v_id = id;
                    vf.vf_f_id = f_id;
                    ctx.ViewersFilms.Add(vf);
                    ctx.SaveChanges();
                    MessageBox.Show("Додано до списку");
                }
            }
            catch
            {
                MessageBox.Show("Невідома помилка", "Помилка додавання");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var query = (from vf in ctx.ViewersFilms where vf.vf_v_id == id select vf.Film);
            query.Load();
            listFilmsBS.DataSource = query.ToList();
            AllUnvisible();
            btnExit.Visible = btnListEnd.Visible = true;
            if (admin) btnEditing.Visible = true;
            dgvList.Visible = true;
            btnListDelete.Visible = true;
        }

        private void btnListEnd_Click(object sender, EventArgs e)
        {
            AllUnvisible();
            tabControlSearch.Visible = true;
            btnExit.Visible = btnList.Visible = true;
            btnAddToList.Visible = true;
            if (admin) btnEditing.Visible = true;
        }

        private void btnSearchGenre_Click(object sender, EventArgs e)
        {
            FilmsLab2.FilmsBDEntities2 ctxFindGenres = new FilmsBDEntities2();
            string genre = cmbSearchGenre.Text;
            var query = (from g in ctxFindGenres.Genres where g.g_name == genre select g);
            query.Load();
            findedGenresBS.DataSource = query.ToList();
        }

        private void btnSearchProducer_Click(object sender, EventArgs e)
        {
            string pname = cmbSearchProducerName.Text;
            string _pbirth = cmbSearchProducerBirth.Text;
            string _pdeath = cmbSearchProducerDeath.Text;
            int pbirth = -1;
            try
            {
                pbirth = Convert.ToInt32(_pbirth);
                if (pbirth < minBirthYear || pbirth > maxDeathYear)
                {
                    pbirth = -1;
                    cmbSearchProducerBirth.Text = "";
                }
            }
            catch
            {
                cmbSearchProducerBirth.Text = "";
            }
            int pdeath = -1;
            try
            {
                pdeath = Convert.ToInt32(_pdeath);
                if (pdeath < minBirthYear || pdeath > maxDeathYear)
                {
                    pdeath = -1;
                    cmbSearchProducerDeath.Text = "";
                }
            }
            catch
            {
                cmbSearchProducerDeath.Text = "";
            }

            FilmsLab2.FilmsBDEntities2 ctxFindProducer = new FilmsBDEntities2();
            var query = (from p in ctxFindProducer.Producers select p);
            if (!string.IsNullOrWhiteSpace(pname) && !string.IsNullOrEmpty(pname)) query = query.Where(p => p.p_name == pname);
            if (pbirth != -1) query = query.Where(p => p.p_birth == pbirth);
            if (pdeath != -1) query = query.Where(p => p.p_death == pdeath);
            query.Load();
            findedProducerBS.DataSource = query.ToList();
        }

        private void btnSearchActor_Click(object sender, EventArgs e)
        {
            string aname = cmbSearchActorName.Text;
            string _abirth = cmbSearchActorBirth.Text;
            string _adeath = cmbSearchActorDeath.Text;

            int abirth = -1;
            try
            {
                abirth = Convert.ToInt32(_abirth);
                if (abirth < minBirthYear || abirth > maxDeathYear)
                {
                    abirth = -1;
                    cmbSearchActorBirth.Text = "";
                }
            }
            catch
            {
                cmbSearchActorBirth.Text = "";
            }
            int adeath = -1;
            try
            {
                adeath = Convert.ToInt32(_adeath);
                if (adeath < minBirthYear || adeath > maxDeathYear)
                {
                    adeath = -1;
                    cmbSearchActorDeath.Text = "";
                }
            }
            catch
            {
                cmbSearchActorDeath.Text = "";
            }

            FilmsLab2.FilmsBDEntities2 ctxFindActor = new FilmsBDEntities2();
            var query = from a in ctxFindActor.Actors select a;
            if (!string.IsNullOrWhiteSpace(aname) && !string.IsNullOrEmpty(aname)) query = query.Where(a => a.a_name == aname);
            if (abirth != -1) query = query.Where(a => a.a_birth == abirth);
            if (adeath != -1) query = query.Where(a => a.a_death == adeath);
            query.Load();
            findedActorsBS.DataSource = query.ToList();
        }

        private void btnClearSearchFilm_Click(object sender, EventArgs e)
        {
            cmbSearchFilmsActor.Text = "";
            cmbSearchFilmsGenre.Text = "";
            cmbSearchFilmsName.Text = "";
            cmbSearchFilmsProducer.Text = "";
            cmbSearchFilmsYear.Text = "";
        }

        private void btnClearSearchGenre_Click(object sender, EventArgs e)
        {
            cmbSearchGenre.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbSearchProducerBirth.Text = "";
            cmbSearchProducerDeath.Text = "";
            cmbSearchProducerName.Text = "";
        }

        private void btnClearSearchActor_Click(object sender, EventArgs e)
        {
            cmbSearchActorBirth.Text = "";
            cmbSearchActorDeath.Text = "";
            cmbSearchActorName.Text = "";
        }

        private void btnListDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int fid = (int)dgvList.CurrentRow.Cells["fid"].Value;
                var obj = (from vf in ctx.ViewersFilms where vf.vf_f_id == fid && vf.vf_v_id == id select vf).First();
                ctx.ViewersFilms.Remove(obj);
                ctx.SaveChanges();
                FillAllBindingSources();
            }
            catch { }
        }

        private void btnGenreAddNew_Click(object sender, EventArgs e)
        {
            btnGenresEndAdd.Visible = true;
            btnAddGenre.Visible = lblAddGenre.Visible = txtbAddGenre.Visible = true;
            dgvGenres.Visible = false;
            btnGenreAddNew.Visible = false;
            txtbAddGenre.Text = "";
        }

        private void btnGenresEndAdd_Click(object sender, EventArgs e)
        {
            btnGenresEndAdd.Visible = false;
            btnAddGenre.Visible = lblAddGenre.Visible = txtbAddGenre.Visible = false;
            dgvGenres.Visible = true;
            btnGenreAddNew.Visible = true;
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string gname = txtbAddGenre.Text;
            if (String.IsNullOrEmpty(gname) || String.IsNullOrWhiteSpace(gname))
            {
                MessageBox.Show("Уведіть назву", "Помилка додавання");
            }
            else
            {
                if ((from gr in ctx.Genres where gr.g_name == gname select gr).Any())
                {
                    MessageBox.Show("Такий жанр уже є", "Помилка додавання");
                }
                else
                {
                    Genre g = new Genre();
                    g.g_name = gname;
                    ctx.Genres.Add(g);
                    ctx.SaveChanges();
                    FillAllBindingSources();
                    MessageBox.Show("Додано");
                }
            }
        }

        private void btnProducerAddNew_Click(object sender, EventArgs e)
        {
            lblAddProducerName.Visible = txtbAddProducerName.Visible = btnAddProducer.Visible = btnProducerEndAdd.Visible = true;
            dgvProducers.Visible = btnProducerAddNew.Visible = false;
            txtbAddProducerName.Text = "";
            lblAddProducerBirth.Visible = lblAddProducerDeath.Visible = nudAddProducerBirth.Visible = nudAddProducerDeath.Visible = true;
            nudAddProducerDeath.Value = nudAddProducerBirth.Value = standartYear;
            chbAddProducer.Visible = true;
            chbAddProducer.Checked = false ;
        }

        private void btnProducerEndAdd_Click(object sender, EventArgs e)
        {
            lblAddProducerName.Visible = txtbAddProducerName.Visible = btnAddProducer.Visible = btnProducerEndAdd.Visible = false;
            lblAddProducerBirth.Visible = lblAddProducerDeath.Visible = nudAddProducerBirth.Visible = nudAddProducerDeath.Visible = false;
            dgvProducers.Visible = btnProducerAddNew.Visible = true;
            chbAddProducer.Visible = false;
        }

        private void lblAddGenre_Click(object sender, EventArgs e)
        {

        }

        private void txtbAddGenre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            string pname = txtbAddProducerName.Text;
            int pbirth = (int)nudAddProducerBirth.Value;
            int pdeath = (int)nudAddProducerDeath.Value;
            bool ch = chbAddProducer.Checked;
            if (String.IsNullOrEmpty(pname) || String.IsNullOrWhiteSpace(pname))
            {
                MessageBox.Show("Уведіть ім'я", "Помилка додавання");
            }
            else
            {
                if ((from p in ctx.Producers where p.p_name == pname select p).Any())
                {
                    MessageBox.Show("Такий режисер уже є", "Помилка додавання");
                }
                else
                {
                    if (!ch)
                    {
                        if (pdeath < pbirth)
                        {
                            MessageBox.Show("Некоректні роки", "Помилка додавання");
                        }
                        else
                        {
                            Producer p = new Producer();
                            p.p_name = pname;
                            p.p_birth = pbirth;
                            p.p_death = pdeath;
                            ctx.Producers.Add(p);
                            ctx.SaveChanges();
                            FillAllBindingSources();
                            MessageBox.Show("Додано");
                        }
                    }
                    else
                    {
                        Producer p = new Producer();
                        p.p_name = pname;
                        p.p_birth = pbirth;
                        p.p_death = pdeath;
                        ctx.Producers.Add(p);
                        ctx.SaveChanges();
                        FillAllBindingSources();
                        MessageBox.Show("Додано");
                    }
                }
            }
        }

        private void btnActorAddNew_Click(object sender, EventArgs e)
        {
            dgvActors.Visible = btnActorAddNew.Visible = false;
            nudAddActorBirth.Value = nudAddActorDeath.Value = standartYear;
            txtbAddActorName.Text = "";
            lblAddActorBirth.Visible = lblAddActorDeath.Visible = lblAddActorName.Visible = true;
            btnAddActor.Visible = btnActorEndAdd.Visible = true;
            txtbAddActorName.Visible = true;
            chbAddActor.Visible = true;
            chbAddActor.Checked = false;
            nudAddActorBirth.Visible = nudAddActorDeath.Visible = true;
        }

        private void btnActorEndAdd_Click(object sender, EventArgs e)
        {
            dgvActors.Visible = btnActorAddNew.Visible = true;
            lblAddActorBirth.Visible = lblAddActorDeath.Visible = lblAddActorName.Visible = false;
            btnAddActor.Visible = btnActorEndAdd.Visible = false;
            txtbAddActorName.Visible = false;
            nudAddActorBirth.Visible = nudAddActorDeath.Visible = false;
            chbAddActor.Visible = false;
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            string aname = txtbAddActorName.Text;
            int abirth = (int)nudAddActorBirth.Value;
            int adeath = (int)nudAddActorDeath.Value;
            bool ch = chbAddActor.Checked;
            if (String.IsNullOrEmpty(aname) || String.IsNullOrWhiteSpace(aname))
            {
                MessageBox.Show("Уведіть ім'я", "Помилка додавання");
            }
            else
            {
                if ((from a in ctx.Actors where a.a_name == aname select a).Any())
                {
                    MessageBox.Show("Такий актор уже є", "Помилка додавання");
                }
                else
                {
                    if (!ch)
                    {
                        if (adeath < abirth)
                        {
                            MessageBox.Show("Некоректні роки", "Помилка додавання");
                        }
                        else
                        {
                            Actor a = new Actor();
                            a.a_name = aname;
                            a.a_birth = abirth;
                            a.a_death = adeath;
                            ctx.Actors.Add(a);
                            ctx.SaveChanges();
                            FillAllBindingSources();
                            MessageBox.Show("Додано");
                        }
                    }
                    else
                    {
                        Actor a = new Actor();
                        a.a_name = aname;
                        a.a_birth = abirth;
                        a.a_death = adeath;
                        ctx.Actors.Add(a);
                        ctx.SaveChanges();
                        FillAllBindingSources();
                        MessageBox.Show("Додано");
                    }
                }
            }
        }

        private void btnFilmsAddNew_Click(object sender, EventArgs e)
        {
            startEditFilms = false;
            dgvFilms.Visible = btnFilmsAddNew.Visible = false;
            lblAddFilmName.Visible = lblAddFilmProducer.Visible = lblAddFilmYear.Visible =
                txtbAddFilmName.Visible = nudAddFilmYear.Visible =
                cmbAddFilmActors.Visible = cmbAddFilmGenres.Visible = cmbAddFilmProducer.Visible = cmbAddFilmSelectedActors.Visible = cmbAddFilmSelectedGenres.Visible =
                btnAddFilmClear.Visible = btnAddFilm.Visible = true;
            txtbAddFilmName.Text = "";
            cmbAddFilmSelectedActors.Items.Clear();
            cmbAddFilmSelectedGenres.Items.Clear();
            nudAddFilmYear.Value = standartYear;
            btnDeleteFilms.Visible = false;
            btnFilmEndAdd.Visible = true;
            btnAddFilmDeleteActor.Visible = btnAddFilmDeleteGenre.Visible = btnAddFilmSelectActor.Visible = btnAddFilmSelectGenre.Visible = true;

            lblEditFilmProducer.Visible = lblEditFilmId.Visible = lblEditFilmsName.Visible = lblEditFilmsYear.Visible = false;
            cmbEditFilmId.Visible = cmbEditFilmName.Visible = cmbEditFilmYear.Visible =
                cmbEditFilmsGenre.Visible = cmbEditFilmActor.Visible = cmbEditFilmChooseActors.Visible =
                cmbEditFilmChooseGenres.Visible = cmbEditFilmProducer.Visible = false;
            chbEditFilmProducer.Visible = false;
            rtbEditFilmProducer.Visible = false;
            btnEditFilmClear.Visible = btnEditFilmDeleteActor.Visible = btnEditFilmDeleteGenre.Visible =
                btnEditFilmEdit.Visible = btnEditFilmsAddActor.Visible = btnEditFilmsAddGenre.Visible = false;
            btnEditFilmStart.Visible = true;
        }

        private void btnFilmEndAdd_Click(object sender, EventArgs e)
        {
            startEditFilms = false;
            dgvFilms.Visible = btnFilmsAddNew.Visible = true;
            lblAddFilmName.Visible = lblAddFilmProducer.Visible = lblAddFilmYear.Visible =
                txtbAddFilmName.Visible = nudAddFilmYear.Visible =
                cmbAddFilmActors.Visible = cmbAddFilmGenres.Visible = cmbAddFilmProducer.Visible = cmbAddFilmSelectedActors.Visible = cmbAddFilmSelectedGenres.Visible =
                btnAddFilmClear.Visible = btnAddFilm.Visible = false;
            btnDeleteFilms.Visible = true;
            btnFilmEndAdd.Visible = false;
            btnAddFilmDeleteActor.Visible = btnAddFilmDeleteGenre.Visible = btnAddFilmSelectActor.Visible = btnAddFilmSelectGenre.Visible = false;

            lblEditFilmProducer.Visible = lblEditFilmId.Visible = lblEditFilmsName.Visible = lblEditFilmsYear.Visible = false;
            cmbEditFilmId.Visible = cmbEditFilmName.Visible = cmbEditFilmYear.Visible =
                cmbEditFilmsGenre.Visible = cmbEditFilmActor.Visible = cmbEditFilmChooseActors.Visible =
                cmbEditFilmChooseGenres.Visible = cmbEditFilmProducer.Visible = false;
            chbEditFilmProducer.Visible = false;
            rtbEditFilmProducer.Visible = false;
            btnEditFilmClear.Visible = btnEditFilmDeleteActor.Visible = btnEditFilmDeleteGenre.Visible =
                btnEditFilmEdit.Visible = btnEditFilmsAddActor.Visible = btnEditFilmsAddGenre.Visible = false;
            btnEditFilmStart.Visible = true;
        }

        private void btnAddFilmSelectGenre_Click(object sender, EventArgs e)
        {
            string g = cmbAddFilmGenres.Text;
            if (!cmbAddFilmSelectedGenres.Items.Contains(g))
            {
                cmbAddFilmSelectedGenres.Items.Add(g);
            }
        }

        private void btnAddFilmDeleteGenre_Click(object sender, EventArgs e)
        {
            object g = cmbAddFilmSelectedGenres.SelectedItem;
            cmbAddFilmSelectedGenres.Items.Remove(g);
        }

        private void btnAddFilmSelectActor_Click(object sender, EventArgs e)
        {
            string a = cmbAddFilmActors.Text;
            if (!cmbAddFilmSelectedActors.Items.Contains(a))
            {
                cmbAddFilmSelectedActors.Items.Add(a);
            }
        }

        private void btnAddFilmDeleteActor_Click(object sender, EventArgs e)
        {
            object a = cmbAddFilmSelectedActors.SelectedItem;
            cmbAddFilmSelectedActors.Items.Remove(a);
        }

        private void btnAddFilmClear_Click(object sender, EventArgs e)
        {
            txtbAddFilmName.Text = "";
            cmbAddFilmSelectedActors.Items.Clear();
            cmbAddFilmSelectedGenres.Items.Clear();
            nudAddFilmYear.Value = standartYear;
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            string fname = txtbAddFilmName.Text;
            int fyear = (int)nudAddFilmYear.Value;
            int pid = getProducerIdByName(cmbAddFilmProducer.Text);
            if ((from f in ctx.Films where f.d_name == fname && f.f_year == fyear select f).Any())
            {
                MessageBox.Show("Такий фільм уже є", "Помилка додавання");
            }
            else
            {
                Film f = new Film();
                f.d_name = fname;
                f.f_year = fyear;
                f.f_producer = pid;
                ctx.Films.Add(f);
                ctx.SaveChanges();
                FillAllBindingSources();
                int fid = (from _f in ctx.Films where _f.d_name == fname && _f.f_year == fyear select _f.f_id).First();

                foreach (var item in cmbAddFilmSelectedGenres.Items)
                {
                    FilmsGenre fg = new FilmsGenre();
                    fg.fg_f_id = fid;
                    fg.fg_g_id = getGenreIdByName(item.ToString());
                    ctx.FilmsGenres.Add(fg);
                    ctx.SaveChanges();
                }
                FillAllBindingSources();

                foreach (var item in cmbAddFilmSelectedActors.Items)
                {
                    FilmsActor fa = new FilmsActor();
                    fa.fa_f_id = fid;
                    fa.fa_a_id = getActorIdByName(item.ToString());
                    ctx.FilmsActors.Add(fa);
                    ctx.SaveChanges();
                }
                FillAllBindingSources();
                
                MessageBox.Show("Додано!");
            }
        }

        private void dgvSearchFilms_DoubleClick(object sender, EventArgs e)
        {
            Info((int)dgvSearchFilms.CurrentRow.Cells["f_id"].Value);
        }

        private void btnDeleteFilms_Click(object sender, EventArgs e)
        {
            int fid = Convert.ToInt32(dgvFilms.CurrentRow.Cells["ffid"].Value);
            var fgs = (from fg in ctx.FilmsGenres where fg.fg_f_id == fid select fg);
            ctx.FilmsGenres.RemoveRange(fgs);
            var fas = (from fa in ctx.FilmsActors where fa.fa_f_id == fid select fa);
            ctx.FilmsActors.RemoveRange(fas);
            var vfs = (from vf in ctx.ViewersFilms where vf.vf_f_id == fid select vf);
            ctx.ViewersFilms.RemoveRange(vfs);
            var film = (from f in ctx.Films where f.f_id == fid select f).First();
            ctx.Films.Remove(film);
            FillAllBindingSources();
        }

        private void dgvProducers_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldPName = (string)dgvProducers.CurrentRow.Cells["pname"].Value;
            oldPBirth = (int)dgvProducers.CurrentRow.Cells["pbirth"].Value;
            oldPDeath = -1;
            if (dgvProducers.CurrentRow.Cells["pdeath"].Value != null)
            oldPDeath = (int)dgvProducers.CurrentRow.Cells["pdeath"].Value;
        }

        private void dgvProducers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string curPName = (string)dgvProducers.CurrentRow.Cells["pname"].Value;
            int curPBirth = -1;
            if (dgvProducers.CurrentRow.Cells["pbirth"].Value != null)
                curPBirth = (int)dgvProducers.CurrentRow.Cells["pbirth"].Value;
            int curPDeath = -1;
            if (dgvProducers.CurrentRow.Cells["pdeath"].Value != null)
                curPDeath = (int)dgvProducers.CurrentRow.Cells["pdeath"].Value;

            if (oldPName != curPName)
            {
                int c = dgvProducers.Rows.Count;
                int count = 0;
                for (int i = 0; i < c; ++i)
                {
                    if ((string)dgvProducers.Rows[i].Cells["pname"].Value == curPName)
                    {
                        ++count;
                    }
                }
                if (count > 1)
                {
                    dgvProducers.CurrentRow.Cells["pname"].Value = oldPName;
                    MessageBox.Show("Такий режисер уже є", "Помилка редагування");
                }
                if (string.IsNullOrEmpty(curPName) || string.IsNullOrWhiteSpace(curPName))
                {
                    dgvProducers.CurrentRow.Cells["pname"].Value = oldPName;
                    MessageBox.Show("Уведіть ім'я", "Помилка редагування");
                }
            }

            if (curPBirth != oldPBirth)
            {
                if (curPBirth == -1 || curPBirth < minBirthYear || curPBirth > maxDeathYear || (curPDeath != -1 && curPDeath < curPBirth))
                {
                    dgvProducers.CurrentRow.Cells["pbirth"].Value = oldPBirth;
                    MessageBox.Show("Некоректний рік", "Помилка редагування");
                }
            }

            if (curPDeath != -1 && curPDeath != oldPDeath)
            {
                if (curPDeath < minBirthYear || curPDeath > maxDeathYear || (curPDeath != -1 && curPDeath < curPBirth))
                {
                    if (oldPDeath != -1)
                        dgvProducers.CurrentRow.Cells["pdeath"].Value = oldPDeath;
                    else
                        dgvProducers.CurrentRow.Cells["pdeath"].Value = null;
                    MessageBox.Show("Некоректний рік", "Помилка редагування");
                }
            }
        }

        private void dgvActors_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldAName = (string)dgvActors.CurrentRow.Cells["aname"].Value;
            oldABirth = (int)dgvActors.CurrentRow.Cells["abirth"].Value;
            oldADeath = -1;
            if (dgvActors.CurrentRow.Cells["adeath"].Value != null)
                oldADeath = (int)dgvActors.CurrentRow.Cells["adeath"].Value;
        }

        private void dgvActors_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string curAName = (string)dgvActors.CurrentRow.Cells["aname"].Value;
            int curABirth = -1;
            if (dgvActors.CurrentRow.Cells["abirth"].Value != null)
                curABirth = (int)dgvActors.CurrentRow.Cells["abirth"].Value;
            int curADeath = -1;
            if (dgvActors.CurrentRow.Cells["adeath"].Value != null)
                curADeath = (int)dgvActors.CurrentRow.Cells["adeath"].Value;

            if (oldAName != curAName)
            {
                int c = dgvActors.Rows.Count;
                int count = 0;
                for (int i = 0; i < c; ++i)
                {
                    if ((string)dgvActors.Rows[i].Cells["aname"].Value == curAName)
                    {
                        ++count;
                    }
                }
                if (count > 1)
                {
                    dgvActors.CurrentRow.Cells["aname"].Value = oldAName;
                    MessageBox.Show("Такий актор уже є", "Помилка редагування");
                }
                if (string.IsNullOrEmpty(curAName) || string.IsNullOrWhiteSpace(curAName))
                {
                    dgvActors.CurrentRow.Cells["aname"].Value = oldAName;
                    MessageBox.Show("Уведіть ім'я", "Помилка редагування");
                }
            }

            if (curABirth != oldABirth)
            {
                if (curABirth == -1 || curABirth < minBirthYear || curABirth > maxDeathYear || (curADeath != -1 && curADeath < curABirth))
                {
                    dgvActors.CurrentRow.Cells["abirth"].Value = oldABirth;
                    MessageBox.Show("Некоректний рік", "Помилка редагування");
                }
            }

            if (curADeath != -1 && curADeath != oldADeath)
            {
                if (curADeath < minBirthYear || curADeath > maxDeathYear || (curADeath != -1 && curADeath < curABirth))
                {
                    if (oldADeath != -1)
                        dgvActors.CurrentRow.Cells["adeath"].Value = oldADeath;
                    else
                        dgvActors.CurrentRow.Cells["adeath"].Value = null;
                    MessageBox.Show("Некоректний рік", "Помилка редагування");
                }
            }
        }

        private void dgvGenres_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldGName = (string)dgvGenres.CurrentRow.Cells["gname"].Value;
        }

        private void dgvGenres_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string curGName = (string)dgvGenres.CurrentRow.Cells["gname"].Value;
            if (oldGName != curGName)
            {
                int c = dgvGenres.Rows.Count;
                int count = 0;
                for (int i = 0; i < c; ++i)
                {
                    if ((string)dgvGenres.Rows[i].Cells["gname"].Value == curGName)
                    {
                        ++count;
                    }
                }
                if (count > 1)
                {
                    dgvGenres.CurrentRow.Cells["gname"].Value = oldGName;
                    MessageBox.Show("Такий жанр уже є", "Помилка редагування");
                }
                if (string.IsNullOrEmpty(curGName) || string.IsNullOrWhiteSpace(curGName))
                {
                    dgvGenres.CurrentRow.Cells["gname"].Value = oldGName;
                    MessageBox.Show("Уведіть назву", "Помилка редагування");
                }
            }
        }

        private void btnEditFilmStart_Click(object sender, EventArgs e)
        {
            lblEditFilmProducer.Visible = lblEditFilmId.Visible = lblEditFilmsName.Visible = lblEditFilmsYear.Visible = true;
            cmbEditFilmId.Visible = cmbEditFilmName.Visible = cmbEditFilmYear.Visible =
                cmbEditFilmsGenre.Visible = cmbEditFilmActor.Visible = cmbEditFilmChooseActors.Visible = 
                cmbEditFilmChooseGenres.Visible = cmbEditFilmProducer.Visible = true;
            chbEditFilmProducer.Visible = true;
            rtbEditFilmProducer.Visible = true;
            btnEditFilmClear.Visible = btnEditFilmDeleteActor.Visible = btnEditFilmDeleteGenre.Visible = 
                btnEditFilmEdit.Visible = btnEditFilmsAddActor.Visible = btnEditFilmsAddGenre.Visible = true;
            btnFilmEndAdd.Visible = true;
            btnEditFilmStart.Visible = false;

            dgvFilms.Visible = false;
            btnDeleteFilms.Visible = false;
            lblAddFilmName.Visible = lblAddFilmProducer.Visible = lblAddFilmYear.Visible =
                txtbAddFilmName.Visible = nudAddFilmYear.Visible =
                cmbAddFilmActors.Visible = cmbAddFilmGenres.Visible = cmbAddFilmProducer.Visible = cmbAddFilmSelectedActors.Visible = cmbAddFilmSelectedGenres.Visible =
                btnAddFilmClear.Visible = btnAddFilm.Visible = false;
            btnAddFilmDeleteActor.Visible = btnAddFilmDeleteGenre.Visible = btnAddFilmSelectActor.Visible = btnAddFilmSelectGenre.Visible = false;
            btnFilmsAddNew.Visible = true;

            startEditFilms = true;
            FillEditFilm();
        }

        private void FillEditFilm()
        {
            chbEditFilmProducer.Checked = false;
            cmbEditFilmChooseActors.Items.Clear();
            cmbEditFilmChooseGenres.Items.Clear();
            int fid = Convert.ToInt32(cmbEditFilmId.Text);
            rtbEditFilmProducer.Text = (from p in ctx.Producers where p.p_id == ((from f in ctx.Films where f.f_id == fid select f.f_producer).FirstOrDefault()) select p.p_name).First();
            List<int> gids = (from fg in ctx.FilmsGenres where fg.fg_f_id == fid select fg.fg_g_id).ToList();
            foreach(int gid in gids)
            {
                cmbEditFilmChooseGenres.Items.Add((from g in ctx.Genres where g.g_id == gid select g.g_name).First());
            }
            List<int> aids = (from fa in ctx.FilmsActors where fa.fa_f_id == fid select fa.fa_a_id).ToList();
            foreach (int aid in aids)
            {
                cmbEditFilmChooseActors.Items.Add((from a in ctx.Actors where a.a_id == aid select a.a_name).First());
            }
        }

        private void cmbEditFilmId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (startEditFilms) FillEditFilm();
        }

        private void cmbEditFilmName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (startEditFilms) FillEditFilm();
        }

        private void cmbEditFilmYear_SelectedValueChanged(object sender, EventArgs e)
        {
            if (startEditFilms) FillEditFilm();
        }

        private void FormFilms_FormClosing(object sender, FormClosingEventArgs e)
        {
            startEditFilms = false;
        }

        private void btnEditFilmClear_Click(object sender, EventArgs e)
        {
            chbEditFilmProducer.Checked = false;
            cmbEditFilmChooseGenres.Items.Clear();
            cmbEditFilmChooseActors.Items.Clear();
        }

        private void btnEditFilmsAddGenre_Click(object sender, EventArgs e)
        {
            string g = cmbEditFilmsGenre.Text;
            if (!cmbEditFilmChooseGenres.Items.Contains(g))
                cmbEditFilmChooseGenres.Items.Add(g);
        }

        private void btnEditFilmsAddActor_Click(object sender, EventArgs e)
        {
            string a = cmbEditFilmActor.Text;
            if (!cmbEditFilmChooseActors.Items.Contains(a))
                cmbEditFilmChooseActors.Items.Add(a);
        }

        private void btnEditFilmDeleteGenre_Click(object sender, EventArgs e)
        {
            object g = cmbEditFilmChooseGenres.SelectedItem;
            cmbEditFilmChooseGenres.Items.Remove(g);
        }

        private void btnEditFilmDeleteActor_Click(object sender, EventArgs e)
        {
            object a = cmbEditFilmChooseActors.SelectedItem;
            cmbEditFilmChooseActors.Items.Remove(a);
        }

        private void dgvFilms_DoubleClick(object sender, EventArgs e)
        {
            Info((int)dgvFilms.CurrentRow.Cells["ffid"].Value);
        }

        private void btnEditFilmEdit_Click(object sender, EventArgs e)
        {
            startEditFilms = false;

            int fid = Convert.ToInt32(cmbEditFilmId.Text);
            var fgs = (from fg in ctx.FilmsGenres where fg.fg_f_id == fid select fg);
            ctx.FilmsGenres.RemoveRange(fgs);
            var fas = (from fa in ctx.FilmsActors where fa.fa_f_id == fid select fa);
            ctx.FilmsActors.RemoveRange(fas);

            foreach (var item in cmbEditFilmChooseGenres.Items)
            {
                FilmsGenre fg = new FilmsGenre();
                fg.fg_f_id = fid;
                fg.fg_f_id = getGenreIdByName(item.ToString());
                ctx.FilmsGenres.Add(fg);
            }
            
            foreach (var item in cmbEditFilmChooseActors.Items)
            {
                FilmsActor fa = new FilmsActor();
                fa.fa_f_id = fid;
                fa.fa_a_id = getActorIdByName(item.ToString());
                ctx.FilmsActors.Add(fa);
            }

            if (chbEditFilmProducer.Checked)
            {
                int pid = getProducerIdByName(cmbEditFilmProducer.Text);
                ctx.Films.Where(f => f.f_id == fid).ToList().ForEach(y => y.f_producer = pid);
            }
            ctx.SaveChanges();
            FillAllBindingSources();

            startEditFilms = true;

            MessageBox.Show("Відредаговано");
        }

        private void dgvFilms_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string curFName = (string)dgvFilms.CurrentRow.Cells["fdname"].Value;
            int curFYear = -1;
            if (dgvFilms.CurrentRow.Cells["ffyear"].Value != null)
                curFYear = (int)dgvFilms.CurrentRow.Cells["ffyear"].Value;

            if (oldFName != curFName)
            {
                int c = dgvFilms.Rows.Count;
                int count = 0;
                for (int i = 0; i < c; ++i)
                {
                    if ((string)dgvFilms.Rows[i].Cells["fdname"].Value == curFName)
                    {
                        ++count;
                    }
                }
                if (count > 1)
                {
                    dgvFilms.CurrentRow.Cells["fdname"].Value = oldFName;
                    MessageBox.Show("Такий фільм уже є", "Помилка редагування");
                }
                if (string.IsNullOrEmpty(curFName) || string.IsNullOrWhiteSpace(curFName))
                {
                    dgvFilms.CurrentRow.Cells["fdname"].Value = oldFName;
                    MessageBox.Show("Уведіть назву", "Помилка редагування");
                }
            }

            if (curFYear != oldFYear)
            {
                if (curFYear == -1 || curFYear < minFilmYear || curFYear > maxFilmYear)
                {
                    dgvFilms.CurrentRow.Cells["ffyear"].Value = oldFYear;
                    MessageBox.Show("Некоректний рік", "Помилка редагування");
                }
            }
        }

        private void dgvFilms_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldFName = (string)dgvFilms.CurrentRow.Cells["fdname"].Value;
            oldFYear = (int)dgvFilms.CurrentRow.Cells["ffyear"].Value;
        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            Info((int)dgvList.CurrentRow.Cells["fid"].Value);
        }
    }
}
