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
    public partial class FormFilms : Form
    {
        private string oldN = "";
        private int oldB = -1;
        private int oldD = -1;

        public FormFilms()
        {
            InitializeComponent();
            FillAll();
        }

        public void FillAll()
        {
            filmsTableAdapter.Fill(dSFilms.Films);
            producersTableAdapter.Fill(dSFilms.Producers);
            actorsTableAdapter.Fill(dSFilms.Actors);
            genresTableAdapter.Fill(dSFilms.Genres);
            filmsActorsTableAdapter.Fill(dSFilms.FilmsActors);
            filmsGenresTableAdapter.Fill(dSFilms2.FilmsGenres);
        }

        private void SaveAll()
        {
            filmsTableAdapter.Update(dSFilms.Films);
            producersTableAdapter.Update(dSFilms.Producers);
            actorsTableAdapter.Update(dSFilms.Actors);
            genresTableAdapter.Update(dSFilms.Genres);
            filmsGenresTableAdapter.Update(dSFilms2.FilmsGenres);
            filmsActorsTableAdapter.Update(dSFilms.FilmsActors);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFilms.FilmsActors' table. You can move, or remove it, as needed.
            this.filmsActorsTableAdapter.Fill(this.dSFilms.FilmsActors);
            // TODO: This line of code loads data into the 'dSFilms2.FilmsGenres' table. You can move, or remove it, as needed.
            this.filmsGenresTableAdapter.Fill(this.dSFilms2.FilmsGenres);
            this.filmsGenresTableAdapter.Fill(this.dSFilms1.FilmsGenres);
            // TODO: This line of code loads data into the 'dSFilms.FilmsActors' table. You can move, or remove it, as needed.
            this.filmsActorsTableAdapter.Fill(this.dSFilms1.FilmsActors);
            // TODO: This line of code loads data into the 'dSFilms.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.dSFilms.Genres);
            // TODO: This line of code loads data into the 'dSFilms.Actors' table. You can move, or remove it, as needed.
            this.actorsTableAdapter.Fill(this.dSFilms.Actors);
            // TODO: This line of code loads data into the 'dSFilms.Producers' table. You can move, or remove it, as needed.
            this.producersTableAdapter.Fill(this.dSFilms.Producers);
            // TODO: This line of code loads data into the 'dSFilms.Films' table. You can move, or remove it, as needed.
            this.filmsTableAdapter.Fill(this.dSFilms.Films);
        }

        private void btnDeleteProducer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvProducers.CurrentRow.Cells["pid"].Value;
                if ((int)queriesTableAdapter.SQCount_p_id_in_Films(id) == 0)
                {
                    producersBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Існують фільми із цим продюсером", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Щось пішло не так", "Помилка видалення");
            }
        }

        private void btnDeleteActor_Click(object sender, EventArgs e)
        {

            try
            {
                int id = (int)dgvActors.CurrentRow.Cells["aid"].Value;
                if ((int)queriesTableAdapter.SQCounta_id_InFilmsActors(id) == 0)
                {
                    actorsBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Існують фільми із цим актором", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Щось пішло не так", "Помилка видалення");
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {

            try
            {
                int id = (int)dgvGenres.CurrentRow.Cells["gid"].Value;
                if ((int)queriesTableAdapter.SQCount_g_id_InFilmsGenres(id) == 0)
                {
                    genresBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Існують фільми із цим жанром", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Щось пішло не так", "Помилка видалення");
            }
        }

        private void btnDeleteFilmActor_Click(object sender, EventArgs e)
        {
            try
            {
                filmsActorsBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Щось пішло не так", "Помилка видалення");
            }
        }

        private void btnDeleteFilmGenre_Click(object sender, EventArgs e)
        {
            try
            {
                filmsGenresBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Щось пішло не так", "Помилка видалення");
            }
        }

        private void btnDeleteFilm_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvFilms.CurrentRow.Cells["fid"].Value;
                queriesTableAdapter.DeleteAllFilmsActorsWith_f_id(id);
                queriesTableAdapter.DeleteAllFilmsGenresWith_f_id(id);
                filmsBindingSource.RemoveCurrent();
                filmsActorsTableAdapter.Fill(dSFilms.FilmsActors);
                filmsGenresTableAdapter.Fill(dSFilms2.FilmsGenres);
            }
            catch
            {
                MessageBox.Show("Щось пішло не так", "Помилка видалення");
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            SaveAll();
            FillAll();

            MessageBox.Show("Збережено!");
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            FormAddFilm f = new FormAddFilm();
            f.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillAll();
        }

        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            AddProducer f = new AddProducer();
            f.Show();
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            FormAddActor f = new FormAddActor();
            f.Show();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre f = new FormAddGenre();
            f.Show();
        }

        private void btnAddFilmActor_Click(object sender, EventArgs e)
        {
            FormAddFA f = new FormAddFA();
            f.Show();
        }

        private void btnAddFilmGenre_Click(object sender, EventArgs e)
        {
            FormAddFG f = new FormAddFG();
            f.Show();
        }

        private void dgvFilms_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvFilms.CurrentRow.Cells["fid"].Value;
            FormAboutFilm f = new FormAboutFilm(id);
            f.Show();
        }

        private void dgvFilms_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldN = (string)dgvFilms.CurrentRow.Cells["dname"].Value;
            oldB = (int)dgvFilms.CurrentRow.Cells["fyear"].Value;
        }

        private void dgvFilms_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string curN = "";
            try { curN = (string)dgvFilms.CurrentRow.Cells["dname"].Value; } catch { }
            int curB = -1;
            try { curB = (int)dgvFilms.CurrentRow.Cells["fyear"].Value; } catch { }
            
            if (oldN != curN || oldB != curB)
            {
                if (curB > 2019 || curB < 1888 || curB == -1)
                {
                    dgvFilms.CurrentRow.Cells["dname"].Value = oldN;
                    dgvFilms.CurrentRow.Cells["fyear"].Value = oldB;
                    MessageBox.Show("Некоректний рік!");
                }
                else
                {
                    if (string.IsNullOrEmpty(curN) || string.IsNullOrWhiteSpace(curN))
                    {
                        dgvFilms.CurrentRow.Cells["dname"].Value = oldN;
                        dgvFilms.CurrentRow.Cells["fyear"].Value = oldB;
                        MessageBox.Show("Уведіть назву!");
                    }
                    else
                    {
                        int r = dgvFilms.RowCount;
                        int c = 0;
                        for (int i = 0; i < r; ++i)
                        {
                            if ((string)dgvFilms.Rows[i].Cells["dname"].Value == curN &&
                                (int)dgvFilms.Rows[i].Cells["fyear"].Value == curB)
                            {
                                ++c;
                            }
                        }
                        if (c > 1)
                        {
                            dgvFilms.CurrentRow.Cells["dname"].Value = oldN;
                            dgvFilms.CurrentRow.Cells["fyear"].Value = oldB;
                            MessageBox.Show("Такий фільм уже є!");
                        }
                    }
                }
            }
        }

        private void dgvProducers_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldN = (string)dgvProducers.CurrentRow.Cells["pname"].Value;
            oldB = (int)dgvProducers.CurrentRow.Cells["pbirth"].Value;
            oldD = -1;
            try { oldD = (int)dgvProducers.CurrentRow.Cells["pdeath"].Value; } catch { }
        }

        private void dgvProducers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string curN = "";
            try { curN = (string)dgvProducers.CurrentRow.Cells["pname"].Value; } catch { }
            int curB = -1;
            try { curB = (int)dgvProducers.CurrentRow.Cells["pbirth"].Value; } catch { }
            int curD = -1;
            try { curD = (int)dgvProducers.CurrentRow.Cells["pdeath"].Value; } catch { }
               
            if (oldN != curN || oldB != curB || oldD != curD)
            {
                if (curB > 2019 || curB < 0 || curB == -1 || (curD != -1 && (curD < curB || curD > 2019 || curD < 0)))
                {
                    dgvProducers.CurrentRow.Cells["pname"].Value = oldN;
                    dgvProducers.CurrentRow.Cells["pbirth"].Value = oldB;
                    dgvProducers.CurrentRow.Cells["pdeath"].Value = oldD;
                    if (oldD == -1) dgvProducers.CurrentRow.Cells["pdeath"].Value = DBNull.Value;
                    MessageBox.Show("Некоректний рік!");
                }
                else
                {
                    if (string.IsNullOrEmpty(curN) || string.IsNullOrWhiteSpace(curN))
                    {
                        dgvProducers.CurrentRow.Cells["pname"].Value = oldN;
                        dgvProducers.CurrentRow.Cells["pbirth"].Value = oldB;
                        dgvProducers.CurrentRow.Cells["pdeath"].Value = oldD;
                        if (oldD == -1) dgvProducers.CurrentRow.Cells["pdeath"].Value = DBNull.Value;
                        MessageBox.Show("Уведіть ім'я!");
                    }
                    else
                    {
                        int r = dgvProducers.RowCount;
                        int c = 0;
                        for (int i = 0; i < r; ++i)
                        {
                            if ((string)dgvProducers.Rows[i].Cells["pname"].Value == curN &&
                                (int)dgvProducers.Rows[i].Cells["pbirth"].Value == curB)
                            {
                                ++c;
                            }
                        }
                        if (c > 1)
                        {
                            dgvProducers.CurrentRow.Cells["pname"].Value = oldN;
                            dgvProducers.CurrentRow.Cells["pbirth"].Value = oldB;
                            dgvProducers.CurrentRow.Cells["pdeath"].Value = oldD;
                            if (oldD == -1) dgvProducers.CurrentRow.Cells["pdeath"].Value = DBNull.Value;
                            MessageBox.Show("Такий продюсер уже є!");
                        }
                    }
                }
            }
        }

        private void dgvActors_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldN = (string)dgvActors.CurrentRow.Cells["aname"].Value;
            oldB = (int)dgvActors.CurrentRow.Cells["abirth"].Value;
            oldD = -1;
            try { oldD = (int)dgvActors.CurrentRow.Cells["adeath"].Value; } catch { }
        }

        private void dgvActors_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string curN = "";
            try { curN = (string)dgvActors.CurrentRow.Cells["aname"].Value; } catch { }
            int curB = -1;
            try { curB = (int)dgvActors.CurrentRow.Cells["abirth"].Value; } catch { }
            int curD = -1;
            try { curD = (int)dgvActors.CurrentRow.Cells["adeath"].Value; } catch { }

            if (oldN != curN || oldB != curB || oldD != curD)
            {
                if (curB > 2019 || curB < 0 || curB == -1 || (curD != -1 && (curD < curB || curD > 2019 || curD < 0)))
                {
                    dgvActors.CurrentRow.Cells["aname"].Value = oldN;
                    dgvActors.CurrentRow.Cells["abirth"].Value = oldB;
                    dgvActors.CurrentRow.Cells["adeath"].Value = oldD;
                    if (oldD == -1) dgvActors.CurrentRow.Cells["adeath"].Value = DBNull.Value;
                    MessageBox.Show("Некоректний рік!");
                }
                else
                {
                    if (string.IsNullOrEmpty(curN) || string.IsNullOrWhiteSpace(curN))
                    {
                        dgvActors.CurrentRow.Cells["aname"].Value = oldN;
                        dgvActors.CurrentRow.Cells["abirth"].Value = oldB;
                        dgvActors.CurrentRow.Cells["adeath"].Value = oldD;
                        if (oldD == -1) dgvActors.CurrentRow.Cells["adeath"].Value = DBNull.Value;
                        MessageBox.Show("Уведіть ім'я!");
                    }
                    else
                    {
                        int r = dgvActors.RowCount;
                        int c = 0;
                        for (int i = 0; i < r; ++i)
                        {
                            if ((string)dgvActors.Rows[i].Cells["aname"].Value == curN &&
                                (int)dgvActors.Rows[i].Cells["abirth"].Value == curB)
                            {
                                ++c;
                            }
                        }
                        if (c > 1)
                        {
                            dgvActors.CurrentRow.Cells["aname"].Value = oldN;
                            dgvActors.CurrentRow.Cells["abirth"].Value = oldB;
                            dgvActors.CurrentRow.Cells["adeath"].Value = oldD;
                            if (oldD == -1) dgvActors.CurrentRow.Cells["adeath"].Value = DBNull.Value;
                            MessageBox.Show("Такий актор уже є!");
                        }
                    }
                }
            }
        }

        private void dgvGenres_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldN = (string)dgvGenres.CurrentRow.Cells["gname"].Value;
        }

        private void dgvGenres_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string curN = "";
            try { curN = (string)dgvGenres.CurrentRow.Cells["gname"].Value; } catch { }
            if (oldN != curN)
            {
                if (string.IsNullOrEmpty(curN) || string.IsNullOrWhiteSpace(curN))
                {
                    dgvGenres.CurrentRow.Cells["gname"].Value = oldN;
                    MessageBox.Show("Уведіть назву!");
                }
                else
                {
                    int r = dgvGenres.RowCount;
                    int c = 0;
                    for (int i = 0; i < r; ++i)
                    {
                        if ((string)dgvGenres.Rows[i].Cells["gname"].Value == curN)
                        {
                            ++c;
                        }
                    }
                    if (c > 1)
                    {
                        dgvGenres.CurrentRow.Cells["gname"].Value = oldN;
                        MessageBox.Show("Такий жанр уже є!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormChangeProducer f = new FormChangeProducer();
            f.Show();
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            FormS1 f = new FormS1(Convert.ToInt32(cmbS1_id.Text));
            f.Show();
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            FormS2 f = new FormS2(Convert.ToInt32(cmbS2_id.Text));
            f.Show();
        }

        private void btnS3_Click(object sender, EventArgs e)
        {
            FormS3 f = new FormS3((int)nudS3.Value);
            f.Show();
        }

        private void btnS4_Click(object sender, EventArgs e)
        {
            FormS4 f = new FormS4((int)nudS4.Value);
            f.Show();
        }

        private void btnS5_Click(object sender, EventArgs e)
        {
            FormS5 f = new FormS5(Convert.ToInt32(cmbS5_id.Text));
            f.Show();
        }

        private void btnS6_Click(object sender, EventArgs e)
        {
            FormS6 f = new FormS6(Convert.ToInt32(cmbS6_id.Text));
            f.Show();
        }

        private void btnS7_Click(object sender, EventArgs e)
        {
            FormS7 f = new FormS7((int)nudS7.Value);
            f.Show();
        }

        private void btnS8_Click(object sender, EventArgs e)
        {
            FormS8 f = new FormS8((int)nudS8.Value);
            f.Show();
        }
    }
}
