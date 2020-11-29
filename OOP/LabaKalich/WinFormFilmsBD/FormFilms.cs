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
        int minYear = 1983;
        int maxYear = 2019;
        int maxLength = 99;
        string oldGenreName = "";
        string oldFilmName = "";
        string oldFilmYear = "";
        string oldGenresList = "";
        string oldActorsList = "";
        string addFilmGenres = "";
        string addFilmActors = "";

        public FormFilms()
        {
            InitializeComponent();

            kActorsTableAdapter1.Fill(kalichDS1.Actors);
            kFilmsTableAdapter1.Fill(kalichDS1.Films);
            kGenresTableAdapter1.Fill(kalichDS1.Genres);
            kProducers1TableAdapter1.Fill(kalichDS1.Producers1);
            kViewersTableAdapter1.Fill(kalichDS1.Viewers);

            kFindedFilmsTableAdapter1.Fill(kalichDS.KFindedFilms);
            kFindedActorsTableAdapter1.Fill(kalichDS1.KFindedActors);
            kFindedGenresTableAdapter1.Fill(kalichDS1.KFindedGenres);
            kFindedProducersTableAdapter1.Fill(kalichDS1.KFindedProducers);
        }

        private void AllVisibleFalse()
        {
            tabControlChenging.Visible = false;
            tabControlSearch.Visible = false;
            btnRegistr.Visible = false;
            btnRegistration.Visible = false;
            btnEnter.Visible = false;
            btnExit.Visible = false;
            btnEditing.Visible = false;
            btnList.Visible = false;
            btnRegCancel.Visible = false;
            btnEndEdit.Visible = false;
            btnSaveAllChanges.Visible = false;
            btnBuy.Visible = false;
            btnWish.Visible = false;
            btnWatch.Visible = false;
            btnListEnd.Visible = false;
            lblRegLogin.Visible = false;
            lblRegName.Visible = false;
            lblRegPassword.Visible = false;
            txtbRegistrationName.Visible = false;
            txtbRegistrationPassword.Visible = false;
            txtbRegistrationUsername.Visible = false;
            lblBuy.Visible = lblWatch.Visible = lblWish.Visible = false;
            cmbBuy.Visible = cmbWatch.Visible = cmbWish.Visible = false;
            rtbWish.Visible = rtbWatch.Visible = rtbBuy.Visible = false;
            lblEditFilms.Visible = cmbEditFilmProducer.Visible = false;
            btnClearWish.Visible = false;
        }

        private void btnSaveActors_Click(object sender, EventArgs e)
        {
            kActorsTableAdapter1.Update(kalichDS1.Actors);
            MessageBox.Show("Збережено");
        }

        private void btnSaveFilms_Click(object sender, EventArgs e)
        {
            kViewersTableAdapter1.Update(kalichDS1.Viewers);
            kProducers1TableAdapter1.Update(kalichDS1.Producers1);
            kFilmsTableAdapter1.Update(kalichDS1.Films);
            MessageBox.Show("Збережено");
        }

        private void btnSaveProducers_Click(object sender, EventArgs e)
        {
            kProducers1TableAdapter1.Update(kalichDS1.Producers1);
            MessageBox.Show("Збережено");
        }

        private void btnDeleteActors_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvActors.CurrentRow.Cells["a_id"].Value;
                global::System.Nullable<int> p_count = (int)kQueriesTableAdapter1.SQCount_a_id_InFilms(Convert.ToString(id));
                if (p_count == 0)
                {
                    kActorsBindingSource.RemoveCurrent();
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
                global::System.Nullable<int> p_count = (int)kQueriesTableAdapter1.SQCount_p_id_InFilms(id);
                if (p_count == 0)
                {
                    kProducers1BindingSource.RemoveCurrent();
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
                string name = (string)dgvGenres.CurrentRow.Cells["g_name"].Value;
                name = name.TrimEnd(' ');
                global::System.Nullable<int> p_count = (int)kQueriesTableAdapter1.SQCount_g_name_InFilms(name);
                if (p_count == 0)
                {
                    kGenresBindingSource.RemoveCurrent();
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
                kViewersBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Неочікувана помилка", "Помилка видалення");
            }
        }

        private void btnSaveViewers_Click(object sender, EventArgs e)
        {
            kViewersTableAdapter1.Update(kalichDS1.Viewers);
            MessageBox.Show("Збережено");
        }

        private void btnSaveGenres_Click(object sender, EventArgs e)
        {
            kGenresTableAdapter1.Update(kalichDS1.Genres);
            kFilmsTableAdapter1.Update(kalichDS1.Films);
            MessageBox.Show("Збережено");
        }

        private void btnDeleteFillms_Click(object sender, EventArgs e)
        {
            try
            {
                int year = (int)dgvFilms.CurrentRow.Cells["f_year"].Value;
                string name = (string)dgvFilms.CurrentRow.Cells["f_name"].Value;
                int pid = (int)dgvFilms.CurrentRow.Cells["f_producer"].Value;
                name = name.TrimEnd(' ');
                string buf = "*" + name + "_" + Convert.ToString(year) + "*";
                oldFilmName = buf;

                int p_count = dgvProducers.RowCount;
                for (int i = 0; i < p_count; ++i)
                {
                    try
                    {
                        string oldProducerFilms = (string)dgvProducers.Rows[i].Cells["p_filmslist"].Value;

                        if (oldProducerFilms.Contains(oldFilmName))
                        {
                            int n = oldProducerFilms.IndexOf(oldFilmName);
                            oldProducerFilms = oldProducerFilms.Remove(n, oldFilmName.Length);
                            dgvProducers.Rows[i].Cells["p_filmslist"].Value = oldProducerFilms;
                        }
                    }
                    catch { }
                }

                int v_count = dgvViewers.RowCount;
                for (int i = 0; i < v_count; ++i)
                {
                    try
                    {
                        string oldWishList = (string)dgvViewers.Rows[i].Cells["v_wishlist"].Value;
                        if (oldWishList.Contains(oldFilmName))
                        {
                            int n = oldWishList.IndexOf(oldFilmName);
                            oldWishList = oldWishList.Remove(n, oldFilmName.Length);
                            dgvViewers.Rows[i].Cells["v_wishlist"].Value = oldWishList;
                        }
                    }
                    catch { }
                    try
                    {
                        string oldWatchedList = (string)dgvViewers.Rows[i].Cells["v_watchedlist"].Value;
                        if (oldWatchedList.Contains(oldFilmName))
                        {
                            int n = oldWatchedList.IndexOf(oldFilmName);
                            oldWatchedList = oldWatchedList.Remove(n, oldFilmName.Length);
                            dgvViewers.Rows[i].Cells["v_watchedlist"].Value = oldWatchedList;
                        }
                    }
                    catch { }
                    try
                    {
                        string oldBoughtList = (string)dgvViewers.Rows[i].Cells["v_boughtlist"].Value;
                        if (oldBoughtList.Contains(oldFilmName))
                        {
                            int n = oldBoughtList.IndexOf(oldFilmName);
                            oldBoughtList = oldBoughtList.Remove(n, oldFilmName.Length);
                            dgvViewers.Rows[i].Cells["v_boughtlist"].Value = oldBoughtList;
                        }
                    }
                    catch { }
                }
                kFilmsBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Неочікувана помилка", "Помилка видалення");
            }
        }

        private void btnSearchFilms_Click(object sender, EventArgs e)
        {
            string fname = cmbSearchFilmsName.Text;
            fname = fname.TrimEnd(' ');
            int fyear = -1;
            if (cmbSearchFilmsYear.Text != "")
            {
                try { fyear = Convert.ToInt32(cmbSearchFilmsYear.Text); }
                catch { }
            }
            string fgenre = cmbSearchFilmsGenre.Text;
            fgenre = fgenre.TrimEnd(' ');
            if (fgenre != "") fgenre = "*" + fgenre + "*";
            string fproducer = cmbSearchFilmsProducer.Text;
            string factor = cmbSearchFilmsActor.Text;
            if (factor != "")
            {
                factor = Convert.ToString(kQueriesTableAdapter1.SQGet_a_id_By_a_name(factor));
                factor = "*" + factor + "*";
            }

            if (fproducer != "")
            {
                kFindedFilmsTableAdapter1.FillByNameYearGenreActorProducer(kalichDS.KFindedFilms, fname, fyear, fgenre, factor, fproducer);
            }
            else
            {
                kFindedFilmsTableAdapter1.FillByNameYearGenreActor(kalichDS.KFindedFilms, fname, fyear, fgenre, factor);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = txtbLogin.Text;
            string password = txtbPassword.Text;
            global::System.Nullable<int> id_count = (int)kQueriesTableAdapter1.SQCount_v_id_InViewersBy_username_password(username, password);
            if (id_count != 0)
            {
                AllVisibleFalse();
                id = (int)kQueriesTableAdapter1.SQGet_v_id_InViewers_by_username_password(username, password);
                if(kQueriesTableAdapter1.SQGet_v_admin_InViewers_by_id(id)!= null)
                    admin = (bool)kQueriesTableAdapter1.SQGet_v_admin_InViewers_by_id(id);
                btnList.Visible = true;
                if(admin)
                {
                    btnEditing.Visible = true;
                }
                btnExit.Visible = true;
                tabControlSearch.Visible = true;
                btnBuy.Visible = true;
                btnWatch.Visible = true;
                btnWish.Visible = true;
            }
            else
            {
                MessageBox.Show("Користувача не знайдено", "Помилка");
            }
        }

        private void btnSearchGenre_Click(object sender, EventArgs e)
        {
            string name = cmbSearchGenre.Text;
            kFindedGenresTableAdapter1.FillByName(kalichDS1.KFindedGenres, name);
        }

        private void btnSearchProducer_Click(object sender, EventArgs e)
        {
            string name = cmbSearchProducerName.Text;
            string film = "";
            kFindedProducersTableAdapter1.FillByNameFilm(kalichDS1.KFindedProducers, name, film);
        }

        private void btnSearchActor_Click(object sender, EventArgs e)
        {
            string name = cmbSearchActorName.Text;
            kFindedActorsTableAdapter1.FillByName(kalichDS1.KFindedActors, name);
        }

        private void dgvGenres_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldGenreName = "";
            try
            {
                oldGenreName = (string)dgvGenres.CurrentRow.Cells["g_name"].Value;
                oldGenreName = oldGenreName.TrimEnd(' ');
            }
            catch { }
        }

        private void dgvGenres_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newGenreName = "";
            try
            {
                newGenreName = (string)dgvGenres.CurrentRow.Cells["g_name"].Value;
                newGenreName = newGenreName.TrimEnd(' ');
            }
            catch { }
            if(newGenreName=="" || newGenreName.Contains("*") || newGenreName.Length > maxLength)
            {
                
                dgvGenres.CurrentRow.Cells["g_name"].Value = oldGenreName;
                MessageBox.Show("Некоректні дані", "Помилка");
            }
            else
            if (oldGenreName != newGenreName)
            {
                int f_count = dgvFilms.RowCount;
                oldGenreName = "*" + oldGenreName + "*";
                newGenreName = "*" + newGenreName + "*";
                for (int i = 0; i < f_count; ++i)
                {
                    try
                    {
                        string oldFilmGenres = (string)dgvFilms.Rows[i].Cells["f_genreslist"].Value;
                        if (oldFilmGenres.Contains(oldGenreName))
                        {
                            int n = oldFilmGenres.IndexOf(oldGenreName);
                            oldFilmGenres = oldFilmGenres.Remove(n, oldGenreName.Length);
                            oldFilmGenres = oldFilmGenres.Insert(0, newGenreName);
                            dgvFilms.Rows[i].Cells["f_genreslist"].Value = oldFilmGenres;
                        }
                    }
                    catch { }
                }
            }
        }

        private void dgvFilms_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldFilmName = "";
            oldFilmYear = "";
            try
            {
                oldFilmName = (string)dgvFilms.CurrentRow.Cells["f_name"].Value;
                oldFilmName = oldFilmName.TrimEnd(' ');
                oldFilmYear = Convert.ToString((int)dgvFilms.CurrentRow.Cells["f_year"].Value);
                dgvFilms.CurrentRow.Cells["f_name"].Value = oldFilmName;
            }
            catch { }
        }

        private void dgvFilms_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newFilmName = "";
            string newFilmYear = "";
            int year = -1;
            try
            {
                newFilmName = (string)dgvFilms.CurrentRow.Cells["f_name"].Value;
                newFilmName = newFilmName.TrimEnd(' ');
                newFilmYear = Convert.ToString((int)dgvFilms.CurrentRow.Cells["f_year"].Value);
                year = (int)dgvFilms.CurrentRow.Cells["f_year"].Value;
            }
            catch { }
            if(year <minYear || year > maxYear || newFilmName.Contains("*") || newFilmName.Contains("_") || newFilmName == "" || newFilmName.Length > maxLength)
            {
                MessageBox.Show("Некоректні дані", "Помилка");
                dgvFilms.CurrentRow.Cells["f_name"].Value = oldFilmName;
                dgvFilms.CurrentRow.Cells["f_year"].Value = oldFilmYear;
            }
            else
            if (oldFilmName != newFilmName || oldFilmYear != newFilmYear)
            {
                oldFilmName ="*"+ oldFilmName + "_" + oldFilmYear+"*";
                newFilmName = "*"+newFilmName + "_" + newFilmYear+"*";

                int p_count = dgvProducers.RowCount;
                for (int i = 0; i < p_count; ++i)
                {
                    try
                    {
                        string oldProducerFilms = (string)dgvProducers.Rows[i].Cells["p_filmslist"].Value;

                        if (oldProducerFilms.Contains(oldFilmName))
                        {
                            int n = oldProducerFilms.IndexOf(oldFilmName);
                            oldProducerFilms = oldProducerFilms.Remove(n, oldFilmName.Length);
                            oldProducerFilms = oldProducerFilms.Insert(0, newFilmName);
                            dgvProducers.Rows[i].Cells["p_filmslist"].Value = oldProducerFilms;
                        }
                    }
                    catch { }
                }

                int v_count = dgvViewers.RowCount;
                for (int i = 0; i < v_count; ++i)
                {
                    try
                    {
                        string oldWishList = (string)dgvViewers.Rows[i].Cells["v_wishlist"].Value;
                        if (oldWishList.Contains(oldFilmName))
                        {
                            int n = oldWishList.IndexOf(oldFilmName);
                            oldWishList = oldWishList.Remove(n, oldFilmName.Length);
                            oldWishList = oldWishList.Insert(0, newFilmName);
                            dgvViewers.Rows[i].Cells["v_wishlist"].Value = oldWishList;
                        }
                    }
                    catch { }
                    try
                    {
                        string oldWatchedList = (string)dgvViewers.Rows[i].Cells["v_watchedlist"].Value;
                        if (oldWatchedList.Contains(oldFilmName))
                        {
                            int n = oldWatchedList.IndexOf(oldFilmName);
                            oldWatchedList = oldWatchedList.Remove(n, oldFilmName.Length);
                            oldWatchedList = oldWatchedList.Insert(0, newFilmName);
                            dgvViewers.Rows[i].Cells["v_watchedlist"].Value = oldWatchedList;
                        }
                    }
                    catch { }
                    try
                    {
                        string oldBoughtList = (string)dgvViewers.Rows[i].Cells["v_boughtlist"].Value;
                        if (oldBoughtList.Contains(oldFilmName))
                        {
                            int n = oldBoughtList.IndexOf(oldFilmName);
                            oldBoughtList = oldBoughtList.Remove(n, oldFilmName.Length);
                            oldBoughtList = oldBoughtList.Insert(0, newFilmName);
                            dgvViewers.Rows[i].Cells["v_boughtlist"].Value = oldBoughtList;
                        }
                    }
                    catch { }
                }
            }
        }

        private void dgvViewers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddFilmSelectGenre_Click(object sender, EventArgs e)
        {
            string genre = cmbAddFilmGenres.Text;
            if (cmbAddFilmGenres.Items.Contains(genre))
            {

            }
            else
            {
                addFilmGenres += "*" + genre + "*";
                cmbAddFilmSelectedGenres.Items.Add(genre);
            }

        }

        private void btnAddFilmSelectActor_Click(object sender, EventArgs e)
        {
            string actor = cmbAddFilmActors.Text;
            if (cmbAddFilmActors.Items.Contains(actor))
            {

            }
            else
            {
                addFilmActors += "*" + Convert.ToString(kQueriesTableAdapter1.SQGet_a_id_By_a_name(actor)) + "*";
                cmbAddFilmSelectedActors.Items.Add(actor);
            }
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            string name = txtbAddFilmName.Text;
            string producer = cmbAddFilmProducer.Text;
            if (name =="" || txtbAddFilmYear.Text == "" || producer =="")
            {
                MessageBox.Show("Введіть необхідні дані", "Помилка");
            }
            else
            {

                int year = -1;
                try { year = Convert.ToInt32(txtbAddFilmYear.Text); }
                catch {  }
                
                if ((int)kQueriesTableAdapter1.SQCount_film_name_year_InFilms(name,(year)) != 0)
                {
                    MessageBox.Show("Такий фільм вже існує", "Помилка");
                }
                else
                {
                    if (year < minYear || year > maxYear || name.Contains("*") || name.Contains("_") || name.Length > maxLength)
                        MessageBox.Show("Некоректні дані", "Помилка");
                    else
                    {
                        int pid = (int)(kQueriesTableAdapter1.SQGet_p_id_ByName(producer));
                        kQueriesTableAdapter1.InsertFilm(name, year, addFilmGenres, addFilmActors, pid);
                        kFilmsTableAdapter1.Fill(kalichDS1.Films);

                        string update = "";
                        try
                        {
                            update = (string)kQueriesTableAdapter1.SQGet_p_filmslist_by_p_id_InProducers(pid);
                        }
                        catch { }
                        update += "*" + name + "_" + Convert.ToString(year) + "*";
                        kQueriesTableAdapter1.Update_p_filmslist_by_p_id_InProducers(update, pid);
                        kProducers1TableAdapter1.Fill(kalichDS1.Producers1);
                        MessageBox.Show("Додано");
                    }
                }
            }
        }

        private void btnAddFilmClear_Click(object sender, EventArgs e)
        {
            txtbAddFilmName.Text = "";
            txtbAddFilmYear.Text = "";
            cmbAddFilmSelectedActors.Items.Clear();
            cmbAddFilmSelectedGenres.Items.Clear();
            addFilmActors = "";
            addFilmGenres = "";
        }

        private void btnFilmsAddNew_Click(object sender, EventArgs e)
        {
            txtbAddFilmName.Text = "";
            txtbAddFilmYear.Text = "";
            cmbAddFilmSelectedActors.Items.Clear();
            cmbAddFilmSelectedGenres.Items.Clear();
            addFilmActors = "";
            addFilmGenres = "";
            btnEditFilmStart.Visible = true;

            dgvFilms.Visible = false;
            btnFilmsAddNew.Visible = false;
            lblAddFilmName.Visible = lblAddFilmProducer.Visible = lblAddFilmYear.Visible = true;
            txtbAddFilmName.Visible = txtbAddFilmYear.Visible = true;
            cmbAddFilmActors.Visible = cmbAddFilmGenres.Visible = cmbAddFilmProducer.Visible = 
                cmbAddFilmSelectedActors.Visible = cmbAddFilmSelectedGenres.Visible = true;
            btnAddFilm.Visible = btnAddFilmClear.Visible = btnAddFilmSelectActor.Visible = btnAddFilmSelectGenre.Visible = true;
            btnFilmEndAdd.Visible = true;
        }

        private void brnAddGenre_Click(object sender, EventArgs e)
        {
            string genre = txtbAddGenre.Text;
            if (genre == "" || genre.Contains("*") || genre.Length > maxLength)
                MessageBox.Show("Некоректні дані", "Помилка");
            else
            {
                if ((int)kQueriesTableAdapter1.SQCount_g_name_InGenres(genre) != 0)
                {
                    MessageBox.Show("Такий жанр вже існує", "Помилка");
                }
                else
                {
                    kQueriesTableAdapter1.InsertGenre(genre);
                    kGenresTableAdapter1.Fill(kalichDS1.Genres);
                    MessageBox.Show("Додано");
                }
            }
        }

        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            string name = txtbAddProducer.Text;
            if ((int)kQueriesTableAdapter1.SQCount_p_name_InProducers(name) != 0 || name.Length>49)
            {
                MessageBox.Show("Такий режисер вже існує", "Помилка");
            }
            else
            {
                kQueriesTableAdapter1.InsertProducer(name);
                kProducers1TableAdapter1.Fill(kalichDS1.Producers1);
                MessageBox.Show("Додано");
            }
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            string name = txtbRegistrationName.Text;
            string username = txtbRegistrationUsername.Text;
            string password = txtbRegistrationPassword.Text;
            if (username != "" && password != "")
            {
                if ((int)kQueriesTableAdapter1.SQCount_v_id_by_username_InViewers(username) != 0)
                {
                    MessageBox.Show("Такий користувач вже існує", "Помилка");
                }
                else
                {
                    kQueriesTableAdapter1.InsertViewer(name, username, password);
                    kViewersTableAdapter1.Fill(kalichDS1.Viewers);

                    MessageBox.Show("Зареєстровано");
                    txtbLogin.Text = username;
                    txtbPassword.Text = password;
                    AllVisibleFalse();
                    id = (int)kQueriesTableAdapter1.SQGet_v_id_InViewers_by_username_password(username, password);
                    if (kQueriesTableAdapter1.SQGet_v_admin_InViewers_by_id(id) != null)
                        admin = (bool)kQueriesTableAdapter1.SQGet_v_admin_InViewers_by_id(id);
                    btnList.Visible = true;
                    if (admin)
                    {
                        btnEditing.Visible = true;
                    }
                    btnExit.Visible = true;
                    tabControlSearch.Visible = true;

                    btnBuy.Visible = true;
                    btnWatch.Visible = true;
                    btnWish.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Введіть необхідні дані", "Помилка");
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                int fyear = Convert.ToInt32((int)dgvSearchFilms.CurrentRow.Cells["fyear"].Value);
                string fname = (string)dgvSearchFilms.CurrentRow.Cells["fname"].Value;
                fname = fname.TrimEnd(' ');
                string buf ="*"+ fname + "_" + Convert.ToString(fyear) + "*";
                string list = (string)kQueriesTableAdapter1.SQGet_v_boughtlist_InViewers(id);
                if (list!=null && list.Contains(buf))
                {
                    MessageBox.Show("Цей фільм вже куплено", "Помилка");
                }
                else
                {
                    list += buf;
                    kQueriesTableAdapter1.Update_v_boughtlist(list, id);
                    kViewersTableAdapter1.Fill(kalichDS1.Viewers);
                    MessageBox.Show("Ви купили фільм");
                }
            }
            catch { }
        }

        private void btnWish_Click(object sender, EventArgs e)
        {
            try
            {
                int fyear = Convert.ToInt32((int)dgvSearchFilms.CurrentRow.Cells["fyear"].Value);
                string fname = (string)dgvSearchFilms.CurrentRow.Cells["fname"].Value;
                fname = fname.TrimEnd(' ');
                string buf = "*"+fname + "_" + Convert.ToString(fyear) + "*";
                string list = (string)kQueriesTableAdapter1.SQGet_v_wishlist_InViewers(id);
                if (list != null && list.Contains(buf))
                {
                    MessageBox.Show("Цей фільм вже додано в список бажань", "Помилка");
                }
                else
                {
                    list += buf;
                    kQueriesTableAdapter1.Update_v_wishlist(list, id);
                    kViewersTableAdapter1.Fill(kalichDS1.Viewers);
                    MessageBox.Show("Додано в список бажань");
                }
            }
            catch { }
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            try
            {
                int fyear = Convert.ToInt32((int)dgvSearchFilms.CurrentRow.Cells["fyear"].Value);
                string fname = (string)dgvSearchFilms.CurrentRow.Cells["fname"].Value;
                fname = fname.TrimEnd(' ');
                string buf = "*"+fname + "_" + Convert.ToString(fyear) + "*";
                string list = (string)kQueriesTableAdapter1.SQGet_v_boughtlist_InViewers(id);
                if (list != null && list.Contains(buf))
                {
                    list = (string)kQueriesTableAdapter1.SQGet_v_watchedlist_InViewers(id);
                    if (list == null || !list.Contains(buf))
                    {
                        list += buf;
                        kQueriesTableAdapter1.Update_v_watchedlist(list, id);
                        kViewersTableAdapter1.Fill(kalichDS1.Viewers);
                        MessageBox.Show("Приємного перегляду");
                    }
                }
                else
                {
                    MessageBox.Show("Спочатку купіть цей фільм", "Помилка");
                }
            }
            catch { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            id = -1;
            admin = false;
            AllVisibleFalse();
            btnEnter.Visible = true;
            btnRegistration.Visible = true;
            txtbLogin.Text = "";
            txtbPassword.Text = "";
            tabControlSearch.Visible = true;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            btnEnter.Visible = true;
            lblRegLogin.Visible = true;
            lblRegName.Visible = true;
            lblRegPassword.Visible = true;
            txtbRegistrationName.Visible = true;
            txtbRegistrationPassword.Visible = true;
            txtbRegistrationUsername.Visible = true;
            btnRegistr.Visible = true;
            btnRegCancel.Visible = true;
            txtbRegistrationName.Text = "";
            txtbRegistrationPassword.Text = "";
            txtbRegistrationUsername.Text = "";
        }

        private void btnRegCancel_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            btnEnter.Visible = true;
            btnRegistration.Visible = true;
            tabControlSearch.Visible = true;
        }

        private void btnEditing_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            tabControlChenging.Visible = true;
            btnExit.Visible = true;
            btnList.Visible = true;
            btnSaveAllChanges.Visible = true;
            btnEndEdit.Visible = true;
        }

        private void btnEndEdit_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            tabControlSearch.Visible = true;
            btnExit.Visible = true;
            btnList.Visible = true;
            btnEditing.Visible = true;
            btnBuy.Visible = true;
            btnWatch.Visible = true;
            btnWish.Visible = true;
            kFindedFilmsTableAdapter1.Fill(kalichDS.KFindedFilms);
        }

        private void btnFilmEndAdd_Click(object sender, EventArgs e)
        {
            btnEditFilmStart.Visible = true;

            dgvFilms.Visible = true;
            btnFilmsAddNew.Visible = true;
            lblAddFilmName.Visible = lblAddFilmProducer.Visible = lblAddFilmYear.Visible = false;
            txtbAddFilmName.Visible = txtbAddFilmYear.Visible = false;
            cmbAddFilmActors.Visible = cmbAddFilmGenres.Visible = cmbAddFilmProducer.Visible =
                cmbAddFilmSelectedActors.Visible = cmbAddFilmSelectedGenres.Visible = false;
            btnAddFilm.Visible = btnAddFilmClear.Visible = btnAddFilmSelectActor.Visible = btnAddFilmSelectGenre.Visible = false;
            lblEditFilmsName.Visible = lblEditFilmsYear.Visible =
                btnEditFilmClear.Visible = btnEditFilmEdit.Visible = btnEditFilmsAddActor.Visible = btnEditFilmsAddGenre.Visible =
                cmbEditFilmActor.Visible = cmbEditFilmChooseActors.Visible = cmbEditFilmChooseGenres.Visible =
                cmbEditFilmName.Visible = cmbEditFilmsGenre.Visible = cmbEditFilmYear.Visible = btnFilmEndAdd.Visible = false;
            lblEditFilms.Visible = cmbEditFilmProducer.Visible = false;
        }

        private void btnSaveAllChanges_Click(object sender, EventArgs e)
        {
            kViewersTableAdapter1.Update(kalichDS1.Viewers);
            kProducers1TableAdapter1.Update(kalichDS1.Producers1);
            kGenresTableAdapter1.Update(kalichDS1.Genres);
            kActorsTableAdapter1.Update(kalichDS1.Actors);
            kFilmsTableAdapter1.Update(kalichDS1.Films);
            MessageBox.Show("Збережено");
        }

        private void btnGenreAddNew_Click(object sender, EventArgs e)
        {
            dgvGenres.Visible = false;
            btnGenreAddNew.Visible = false;
            btnGenresEndAdd.Visible = true;
            lblAddGenre.Visible = txtbAddGenre.Visible = btnAddGenre.Visible = true;
        }

        private void btnGenresEndAdd_Click(object sender, EventArgs e)
        {
            btnGenreAddNew.Visible = true;
            dgvGenres.Visible = true;
            btnGenresEndAdd.Visible = false;
            lblAddGenre.Visible = txtbAddGenre.Visible = btnAddGenre.Visible = false;
        }

        private void btnProducerAddNew_Click(object sender, EventArgs e)
        {
            txtbAddProducer.Text = "";
            dgvProducers.Visible = btnProducerAddNew.Visible = false;
            btnProducerEndAdd.Visible = btnAddProducer.Visible = lblAddProducer.Visible = txtbAddProducer.Visible = true;
        }

        private void btnProducerEndAdd_Click(object sender, EventArgs e)
        {
            dgvProducers.Visible = btnProducerAddNew.Visible = true;
            btnProducerEndAdd.Visible = btnAddProducer.Visible = lblAddProducer.Visible = txtbAddProducer.Visible = false;
        }

        private void btnActorAddNew_Click(object sender, EventArgs e)
        {
            dgvActors.Visible = btnActorAddNew.Visible = false;
            lblAddActor.Visible = btnActorEndAdd.Visible = txtbAddActor.Visible = btnAddActor.Visible = true;
        }

        private void btnActorEndAdd_Click(object sender, EventArgs e)
        {
            dgvActors.Visible = btnActorAddNew.Visible = true;
            lblAddActor.Visible = btnActorEndAdd.Visible = txtbAddActor.Visible = btnAddActor.Visible = false;
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            string aname = txtbAddActor.Text;
            if ((int)kQueriesTableAdapter1.SQCount_a_id_InActors_by_name(aname) == 0)
            {
                kQueriesTableAdapter1.InsertActor(aname);
                kActorsTableAdapter1.Fill(kalichDS1.Actors);
                MessageBox.Show("Додано");
            }
            else
            {
                MessageBox.Show("Такий актор вже існує", "Помилка");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            if (admin)
            {
                btnEditing.Visible = true;
            }
            btnExit.Visible =btnListEnd.Visible = true;
            lblBuy.Visible = lblWatch.Visible = lblWish.Visible = true;
            //cmbBuy.Visible = cmbWatch.Visible = cmbWish.Visible = true;
            rtbWish.Visible = rtbWatch.Visible = rtbBuy.Visible = true;
            btnClearWish.Visible = true;

            cmbWish.Items.Clear();
            cmbWatch.Items.Clear();
            cmbBuy.Items.Clear();

            rtbBuy.Clear();
            rtbWatch.Clear();
            rtbWish.Clear();

            string list = (string)kQueriesTableAdapter1.SQGet_v_boughtlist_InViewers(id);
            if (list != null)
            {
                string[] split = list.Split('*');
                foreach(string s in split)
                {
                    if (s == "")
                    {
                        continue;
                    }
                    string[] split2 = s.Split('_');
                    cmbBuy.Items.Add(split2[0] + " " + split2[1]);
                    rtbBuy.AppendText(split2[0] + " " + split2[1] + "\n");
                }
            }
            list = (string)kQueriesTableAdapter1.SQGet_v_watchedlist_InViewers(id);
            if (list != null)
            {
                string[] split = list.Split('*');
                foreach (string s in split)
                {
                    if (s == "")
                    {
                        continue;
                    }
                    string[] split2 = s.Split('_');
                    cmbWatch.Items.Add(split2[0] + " " + split2[1]);
                    rtbWatch.AppendText(split2[0] + " " + split2[1] + "\n");
                }
            }
            list = (string)kQueriesTableAdapter1.SQGet_v_wishlist_InViewers(id);
            if (list != null)
            {
                string[] split = list.Split('*');
                foreach (string s in split)
                {
                    if (s == "")
                    {
                        continue;
                    }
                    string[] split2 = s.Split('_');
                    cmbWish.Items.Add(split2[0] + " " + split2[1]);
                    rtbWish.AppendText(split2[0] + " " + split2[1] + "\n");
                }
            }
        }

        private void btnListEnd_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            tabControlSearch.Visible = true;
            if (admin)
            {
                btnEditing.Visible = true;
            }
            btnExit.Visible = btnList.Visible = true;
            
            btnBuy.Visible = true;
            btnWatch.Visible = true;
            btnWish.Visible = true;
        }

        private void btnEditFilmStart_Click(object sender, EventArgs e)
        {
            btnEditFilmStart.Visible = false;
            oldGenresList = "";
            oldActorsList = "";
            lblEditFilmsName.Visible = lblEditFilmsYear.Visible =
                btnEditFilmClear.Visible = btnEditFilmEdit.Visible = btnEditFilmsAddActor.Visible = btnEditFilmsAddGenre.Visible =
                cmbEditFilmActor.Visible = cmbEditFilmChooseActors.Visible = cmbEditFilmChooseGenres.Visible =
                cmbEditFilmName.Visible = cmbEditFilmsGenre.Visible = cmbEditFilmYear.Visible = true;
            btnFilmEndAdd.Visible = true;
            dgvFilms.Visible = false;
            btnFilmsAddNew.Visible = false;
            lblAddFilmName.Visible = lblAddFilmProducer.Visible = lblAddFilmYear.Visible = false;
            txtbAddFilmName.Visible = txtbAddFilmYear.Visible = false;
            cmbAddFilmActors.Visible = cmbAddFilmGenres.Visible = cmbAddFilmProducer.Visible =
                cmbAddFilmSelectedActors.Visible = cmbAddFilmSelectedGenres.Visible = false;
            btnAddFilm.Visible = btnAddFilmClear.Visible = btnAddFilmSelectActor.Visible = btnAddFilmSelectGenre.Visible = false;
            cmbEditFilmChooseActors.Items.Clear();
            cmbEditFilmChooseGenres.Items.Clear();
            lblEditFilms.Visible = cmbEditFilmProducer.Visible = true;
        }

        private void btnEditFilmClear_Click(object sender, EventArgs e)
        {
            cmbEditFilmChooseActors.Items.Clear();
            cmbEditFilmChooseGenres.Items.Clear();
            oldGenresList = "";
            oldActorsList = "";
        }

        private void btnEditFilmsAddGenre_Click(object sender, EventArgs e)
        {
            string genre = cmbEditFilmsGenre.Text;
            if (!cmbEditFilmChooseGenres.Items.Contains(genre))
            {
                cmbEditFilmChooseGenres.Items.Add(genre);
                oldGenresList += "*" + genre + "*";
            }
        }

        private void btnEditFilmsAddActor_Click(object sender, EventArgs e)
        {
            string actor = cmbEditFilmActor.Text;
            if (!cmbEditFilmChooseActors.Items.Contains(actor))
            {
                cmbEditFilmChooseActors.Items.Add(actor);
                oldActorsList += "*" + Convert.ToString(kQueriesTableAdapter1.SQGet_a_id_By_a_name(actor)) + "*";
            }
        }

        private void btnEditFilmEdit_Click(object sender, EventArgs e)
        {
            string name = cmbEditFilmName.Text;
            int year = Convert.ToInt32(cmbEditFilmYear.Text);
            string p_name = cmbEditFilmProducer.Text;
            
            
            try
            {
                int p_id = (int)kQueriesTableAdapter1.SQGet_p_id_ByName(p_name);
                int old_p_id = (int)kQueriesTableAdapter1.SQGet_f_producer_by_f_name_year_InFilms(name, year);
                if (old_p_id != p_id)
                {
                    string old_p_filmslist = Convert.ToString(kQueriesTableAdapter1.SQGet_p_filmslist_by_p_id_InProducers(old_p_id));
                    string buf = "*" + name.TrimEnd(' ') + "_" + Convert.ToString(year) + "*";
                    if (old_p_filmslist.Contains(buf))
                    {
                        int pos = old_p_filmslist.IndexOf(buf);
                        int count = buf.Length;
                        old_p_filmslist = old_p_filmslist.Remove(pos, count);
                    }
                    kQueriesTableAdapter1.Update_p_filmslist_by_p_id_InProducers(old_p_filmslist, old_p_id);

                    old_p_filmslist = Convert.ToString(kQueriesTableAdapter1.SQGet_p_filmslist_by_p_id_InProducers(p_id));
                    old_p_filmslist = old_p_filmslist.Insert(0, buf);
                    kQueriesTableAdapter1.Update_p_filmslist_by_p_id_InProducers(old_p_filmslist, p_id);
                }
                kQueriesTableAdapter1.Update_f_genreslist_actorslist_by_name_year_InFilms(oldGenresList, oldActorsList, p_id, name, year);


                kFilmsTableAdapter1.Fill(kalichDS1.Films);
                kProducers1TableAdapter1.Fill(kalichDS1.Producers1);
            }
            catch { MessageBox.Show("Некоректні дані"); }
        }

        private void FormFilms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kalichDS1.FilmsYear' table. You can move, or remove it, as needed.
            this.filmsYearTableAdapter.Fill(this.kalichDS1.FilmsYear);

        }

        private void btnClearWish_Click(object sender, EventArgs e)
        {
            kQueriesTableAdapter1.Update_v_wishlist("", id);
            kViewersTableAdapter1.Fill(kalichDS.Viewers);
            rtbWish.Clear();
        }

        private void dgvSearchFilms_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string name = (string)dgvSearchFilms.CurrentRow.Cells["fname"].Value;
                int year = (int)dgvSearchFilms.CurrentRow.Cells["fyear"].Value;
                FormAllAboutFilms2 detal = new FormAllAboutFilms2(name, year);
                detal.Show();
            }
            catch { }
        }
    }
}
