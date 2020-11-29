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
    public partial class FormFilms : Form
    {
        int id = -1;
        bool admin = false;
        public FormFilms()
        {
            InitializeComponent();
            actorsTableAdapter.Fill(newDS.Actors);
            filmsTableAdapter.Fill(newDS.Films);
            producersTableAdapter.Fill(newDS.Producers);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FormFilms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newDS.FindedProducers' table. You can move, or remove it, as needed.
            this.findedProducersTableAdapter.Fill(this.newDS.FindedProducers);
            // TODO: This line of code loads data into the 'newDS.FindedGenres' table. You can move, or remove it, as needed.
            this.findedGenresTableAdapter.Fill(this.newDS.FindedGenres);
            // TODO: This line of code loads data into the 'newDS.ViewersFilms' table. You can move, or remove it, as needed.
            this.viewersFilmsTableAdapter.Fill(this.newDS.ViewersFilms);
            // TODO: This line of code loads data into the 'newDS.FilmsActors' table. You can move, or remove it, as needed.
            this.filmsActorsTableAdapter.Fill(this.newDS.FilmsActors);
            // TODO: This line of code loads data into the 'newDS.FilmsGenres' table. You can move, or remove it, as needed.
            this.filmsGenresTableAdapter.Fill(this.newDS.FilmsGenres);
            // TODO: This line of code loads data into the 'newDS.Viewers' table. You can move, or remove it, as needed.
            this.viewersTableAdapter.Fill(this.newDS.Viewers);
            // TODO: This line of code loads data into the 'newDS.Producers' table. You can move, or remove it, as needed.
            this.producersTableAdapter.Fill(this.newDS.Producers);
            // TODO: This line of code loads data into the 'newDS.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.newDS.Genres);
            // TODO: This line of code loads data into the 'newDS.Actors' table. You can move, or remove it, as needed.
            this.actorsTableAdapter.Fill(this.newDS.Actors);
            // TODO: This line of code loads data into the 'newDS.Films' table. You can move, or remove it, as needed.
            this.filmsTableAdapter.Fill(this.newDS.Films);
        }

        private void btnSaveActors_Click(object sender, EventArgs e)
        {
            actorsTableAdapter.Update(newDS.Actors);
        }

        private void btnSaveFilms_Click(object sender, EventArgs e)
        {
            filmsTableAdapter.Update(newDS.Films);
        }

        private void btnSaveProducers_Click(object sender, EventArgs e)
        {
            producersTableAdapter.Update(newDS.Producers);
        }

        private void btnDeleteActors_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvActors.CurrentRow.Cells["a_id"].Value;
                global::System.Nullable<int> p_count = (int)queriesTableAdapter1.SQCount_a_id_inFilmsActors(id);
                if (p_count == 0)
                {
                    actorsBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Є фільми із цим актором!", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Неочікувана помилка", "Помилка видалення");
            }
        }

        private void btnDeleteProducer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvProducers.CurrentRow.Cells["p_id"].Value;
                global::System.Nullable<int> p_count = (int)queriesTableAdapter1.SQCount_p_id_InFilms(id);
                if (p_count == 0)
                {
                    producersBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("У режисера є фільми!", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Неочікувана помилка", "Помилка видалення");
            }
        }

        private void btnDeleteGenres_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvGenres.CurrentRow.Cells["g_id"].Value;
                global::System.Nullable<int> p_count = (int)queriesTableAdapter1.SQCount_g_id_InFilmsGenres(id);
                if (p_count == 0)
                {
                    genresBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Існують фільми із даним жанром!", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Неочікувана помилка", "Помилка видалення");
            }
        }

        private void btnDeleteViewers_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvViewers.CurrentRow.Cells["v_id"].Value;
                global::System.Nullable<int> p_count = (int)queriesTableAdapter1.SQCount_v_id_InViewersFilms(id);
                if (p_count == 0)
                {
                    viewersBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("До глядача прив'язані фільми!", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Неочікувана помилка", "Помилка видалення");
            }
        }

        private void btnSaveViewers_Click(object sender, EventArgs e)
        {
            viewersTableAdapter.Update(newDS.Viewers);
        }

        private void btnSaveGenres_Click(object sender, EventArgs e)
        {
            genresTableAdapter.Update(newDS.Genres);
        }

        private void btnDeleteFillms_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvFilms.CurrentRow.Cells["f_id"].Value;
                global::System.Nullable<int> p_count = (int)queriesTableAdapter1.SQCount_f_id_InFilmsActors(id);
                if (p_count == 0)
                {
                    p_count = (int)queriesTableAdapter1.SQCount_f_id_InFilmsGenres(id);
                    if (p_count == 0)
                    {
                        p_count = (int)queriesTableAdapter1.SQCount_f_id_InViewersFilms(id);
                        filmsBindingSource.RemoveCurrent();
                    }
                }
                else
                {
                    MessageBox.Show("До глядача прив'язані фільми!", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Неочікувана помилка", "Помилка видалення");
            }
        }

        private void btnSaveFilmsGenres_Click(object sender, EventArgs e)
        {
            filmsGenresTableAdapter.Update(newDS.FilmsGenres);
        }

        private void btnSaveFilmsActors_Click(object sender, EventArgs e)
        {
            filmsActorsTableAdapter.Update(newDS.FilmsActors);
        }

        private void btnSaveViewersFilms_Click(object sender, EventArgs e)
        {
            viewersFilmsTableAdapter.Update(newDS.ViewersFilms);
        }

        private void btnDeleteViewersFilms_Click(object sender, EventArgs e)
        {
            viewersFilmsBindingSource.RemoveCurrent();
        }

        private void btnDeleteFilmsActors_Click(object sender, EventArgs e)
        {
            filmsActorsBindingSource.RemoveCurrent();
        }

        private void btnDeleteFilmsGenres_Click(object sender, EventArgs e)
        {
            filmsGenresBindingSource.RemoveCurrent();
        }

        private void tabActors_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchFilms_Click(object sender, EventArgs e)
        {
            string fname = cmbSearchFilmsName.Text;
            int fyear = -1;
            if (cmbSearchFilmsYear.Text != "")
            {
                fyear = Convert.ToInt32(cmbSearchFilmsYear.Text);
            }
            string fgenre = cmbSearchFilmsGenre.Text;
            string fproducer = cmbSearchFilmsProducer.Text;
            string factor = cmbSearchFilmsActor.Text;

            findedFilmsNewTableAdapter.FillByz(newDS.FindedFilmsNew, fname, fyear, fgenre, fproducer, factor);

            if (fname != "")
            {
                if (fyear != -1)
                {
                    if (fgenre != "")
                    {
                        if (fproducer != "")
                        {
                            if (factor != "")
                            {
                                findedFilmsNewTableAdapter.FillByNameYearGenreProducerActor(newDS.FindedFilmsNew, fname, fyear, fgenre, fproducer, factor);
                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = txtbLogin.Text;
            string password = txtbPassword.Text;
            global::System.Nullable<int> id_count = (int)queriesTableAdapter1.SQCOunt_v_id_inViewers_By_v_username_password(username, password);
            if (id_count != 0)
            {
                id = (int)queriesTableAdapter1.SQReturn_v_id_By_v_username_password_InViewers(username, password);
                admin = (bool)queriesTableAdapter1.SQReturn_v_admin_By_v_id_InViewers(id);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchGenre_Click(object sender, EventArgs e)
        {
            string name = cmbSearchGenre.Text;
            if (name != "")
            {
                findedGenresTableAdapter.FillByName(newDS.FindedGenres, name);
            }
            else
            {
                findedGenresTableAdapter.Fill(newDS.FindedGenres);
            }
        }

        private void cmbSearchFilmsYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchFilmsProducer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchProducer_Click(object sender, EventArgs e)
        {
            string name = cmbSearchProducerName.Text;
            int birth = -1;
            int death = -1;
            if (cmbSearchProducerBirth.Text != "")
            {
                birth = Convert.ToInt32(cmbSearchProducerBirth.Text);
            }
            if (cmbSearchProducerDeath.Text != "")
            {
                death = Convert.ToInt32(cmbSearchProducerDeath.Text);
            }

            findedProducersTableAdapter.FillByNameBirthDeath(newDS.FindedProducers, name, birth, death);
        }

        private void btnSearchActor_Click(object sender, EventArgs e)
        {
            string name = cmbSearchActorName.Text;
            int birth = -1;
            int death = -1;
            if (cmbSearchActorBirth.Text != "")
            {
                birth = Convert.ToInt32(cmbSearchActorBirth.Text);
            }
            if (cmbSearchActorDeath.Text != "")
            {
                death = Convert.ToInt32(cmbSearchActorDeath.Text);
            }

            findedActorsTableAdapter.FillByNameBirthDeath(newDS.FindedActors, name, birth, death);
        }
    }
}
