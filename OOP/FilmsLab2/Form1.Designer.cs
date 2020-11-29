namespace FilmsLab2
{
    partial class FormFilms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbSearchFilmsGenre = new System.Windows.Forms.ComboBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchFilms = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlSearch = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClearSearchFilm = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.cmbSearchFilmsName = new System.Windows.Forms.ComboBox();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSearchFilmsActor = new System.Windows.Forms.ComboBox();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSearchFilmsProducer = new System.Windows.Forms.ComboBox();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearchFilmsYear = new System.Windows.Forms.ComboBox();
            this.unicFilmYear = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSearchFilms = new System.Windows.Forms.DataGridView();
            this.d_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsActors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsGenres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewersFilms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findedFilmsBS = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClearSearchGenre = new System.Windows.Forms.Button();
            this.dgvSearchGenres = new System.Windows.Forms.DataGridView();
            this.gnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsGenresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findedGenresBS = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchGenre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSearchGenre = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClearSearchProducer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSearchProducerBirth = new System.Windows.Forms.ComboBox();
            this.unicProducerBirth = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSearchProducerDeath = new System.Windows.Forms.ComboBox();
            this.unicProducerDeath = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSearchProducers = new System.Windows.Forms.DataGridView();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_death = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findedProducerBS = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSearchProducerName = new System.Windows.Forms.ComboBox();
            this.btnSearchProducer = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnClearSearchActor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSearchActorDeath = new System.Windows.Forms.ComboBox();
            this.unicActorDeath = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSearchActorBirth = new System.Windows.Forms.ComboBox();
            this.unicActorBirth = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSearchActors = new System.Windows.Forms.DataGridView();
            this.a_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_death = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsActorsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findedActorsBS = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchActor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSearchActorName = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnEditing = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnListEnd = new System.Windows.Forms.Button();
            this.btnSaveAllChanges = new System.Windows.Forms.Button();
            this.btnEndEdit = new System.Windows.Forms.Button();
            this.btnRegCancel = new System.Windows.Forms.Button();
            this.lblRegName = new System.Windows.Forms.Label();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.lblRegLogin = new System.Windows.Forms.Label();
            this.btnRegistr = new System.Windows.Forms.Button();
            this.txtbRegistrationPassword = new System.Windows.Forms.TextBox();
            this.txtbRegistrationName = new System.Windows.Forms.TextBox();
            this.txtbRegistrationUsername = new System.Windows.Forms.TextBox();
            this.viewerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsActorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewersFilmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRegMail = new System.Windows.Forms.Label();
            this.txtbRegistrationMail = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.dnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fproducerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsActorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsGenresDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewersFilmsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listFilmsBS = new System.Windows.Forms.BindingSource(this.components);
            this.btnListDelete = new System.Windows.Forms.Button();
            this.tabViewersFilms = new System.Windows.Forms.TabPage();
            this.dgvViewersFilms = new System.Windows.Forms.DataGridView();
            this.vfidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfvidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFilmsActors = new System.Windows.Forms.TabPage();
            this.dgvFilmsActors = new System.Windows.Forms.DataGridView();
            this.faidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fafidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFilmsGenres = new System.Windows.Forms.TabPage();
            this.dgvFilmsGenres = new System.Windows.Forms.DataGridView();
            this.fgidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fgfidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fggidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabViewers = new System.Windows.Forms.TabPage();
            this.btnDeleteViewers = new System.Windows.Forms.Button();
            this.dgvViewers = new System.Windows.Forms.DataGridView();
            this.vid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vadmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viewersFilmsDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabActors = new System.Windows.Forms.TabPage();
            this.chbAddActor = new System.Windows.Forms.CheckBox();
            this.lblAddActorBirth = new System.Windows.Forms.Label();
            this.lblAddActorDeath = new System.Windows.Forms.Label();
            this.nudAddActorDeath = new System.Windows.Forms.NumericUpDown();
            this.nudAddActorBirth = new System.Windows.Forms.NumericUpDown();
            this.btnAddActor = new System.Windows.Forms.Button();
            this.txtbAddActorName = new System.Windows.Forms.TextBox();
            this.lblAddActorName = new System.Windows.Forms.Label();
            this.btnActorEndAdd = new System.Windows.Forms.Button();
            this.btnActorAddNew = new System.Windows.Forms.Button();
            this.btnDeleteActors = new System.Windows.Forms.Button();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.aidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adeath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsActorsDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProducers = new System.Windows.Forms.TabPage();
            this.chbAddProducer = new System.Windows.Forms.CheckBox();
            this.lblAddProducerBirth = new System.Windows.Forms.Label();
            this.lblAddProducerDeath = new System.Windows.Forms.Label();
            this.nudAddProducerDeath = new System.Windows.Forms.NumericUpDown();
            this.nudAddProducerBirth = new System.Windows.Forms.NumericUpDown();
            this.btnProducerEndAdd = new System.Windows.Forms.Button();
            this.txtbAddProducerName = new System.Windows.Forms.TextBox();
            this.btnAddProducer = new System.Windows.Forms.Button();
            this.btnProducerAddNew = new System.Windows.Forms.Button();
            this.lblAddProducerName = new System.Windows.Forms.Label();
            this.btnDeleteProducer = new System.Windows.Forms.Button();
            this.dgvProducers = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdeath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabGenres = new System.Windows.Forms.TabPage();
            this.btnGenresEndAdd = new System.Windows.Forms.Button();
            this.txtbAddGenre = new System.Windows.Forms.TextBox();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnGenreAddNew = new System.Windows.Forms.Button();
            this.lblAddGenre = new System.Windows.Forms.Label();
            this.btnDeleteGenres = new System.Windows.Forms.Button();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.gidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsGenresDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFilms = new System.Windows.Forms.TabPage();
            this.chbEditFilmProducer = new System.Windows.Forms.CheckBox();
            this.rtbEditFilmProducer = new System.Windows.Forms.RichTextBox();
            this.btnEditFilmDeleteActor = new System.Windows.Forms.Button();
            this.lblEditFilmProducer = new System.Windows.Forms.Label();
            this.cmbEditFilmProducer = new System.Windows.Forms.ComboBox();
            this.btnEditFilmDeleteGenre = new System.Windows.Forms.Button();
            this.cmbEditFilmId = new System.Windows.Forms.ComboBox();
            this.lblEditFilmId = new System.Windows.Forms.Label();
            this.btnAddFilmDeleteActor = new System.Windows.Forms.Button();
            this.btnEditFilmStart = new System.Windows.Forms.Button();
            this.cmbEditFilmYear = new System.Windows.Forms.ComboBox();
            this.btnAddFilmDeleteGenre = new System.Windows.Forms.Button();
            this.cmbEditFilmName = new System.Windows.Forms.ComboBox();
            this.lblEditFilmsYear = new System.Windows.Forms.Label();
            this.nudAddFilmYear = new System.Windows.Forms.NumericUpDown();
            this.lblEditFilmsName = new System.Windows.Forms.Label();
            this.btnEditFilmClear = new System.Windows.Forms.Button();
            this.btnEditFilmsAddActor = new System.Windows.Forms.Button();
            this.btnEditFilmsAddGenre = new System.Windows.Forms.Button();
            this.cmbEditFilmChooseGenres = new System.Windows.Forms.ComboBox();
            this.btnEditFilmEdit = new System.Windows.Forms.Button();
            this.cmbEditFilmActor = new System.Windows.Forms.ComboBox();
            this.cmbEditFilmChooseActors = new System.Windows.Forms.ComboBox();
            this.cmbEditFilmsGenre = new System.Windows.Forms.ComboBox();
            this.btnFilmEndAdd = new System.Windows.Forms.Button();
            this.lblAddFilmProducer = new System.Windows.Forms.Label();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.ffid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ffyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ffproducer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsActorsDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsGenresDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewersFilmsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFilmsAddNew = new System.Windows.Forms.Button();
            this.btnDeleteFilms = new System.Windows.Forms.Button();
            this.lblAddFilmYear = new System.Windows.Forms.Label();
            this.txtbAddFilmName = new System.Windows.Forms.TextBox();
            this.cmbAddFilmActors = new System.Windows.Forms.ComboBox();
            this.lblAddFilmName = new System.Windows.Forms.Label();
            this.cmbAddFilmGenres = new System.Windows.Forms.ComboBox();
            this.cmbAddFilmSelectedActors = new System.Windows.Forms.ComboBox();
            this.btnAddFilmClear = new System.Windows.Forms.Button();
            this.cmbAddFilmSelectedGenres = new System.Windows.Forms.ComboBox();
            this.cmbAddFilmProducer = new System.Windows.Forms.ComboBox();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.btnAddFilmSelectGenre = new System.Windows.Forms.Button();
            this.btnAddFilmSelectActor = new System.Windows.Forms.Button();
            this.tabControlChenging = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            this.tabControlSearch.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unicFilmYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedFilmsBS)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedGenresBS)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unicProducerBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unicProducerDeath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProducers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedProducerBS)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unicActorDeath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unicActorBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedActorsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsGenreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsActorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewersFilmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFilmsBS)).BeginInit();
            this.tabViewersFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewersFilms)).BeginInit();
            this.tabFilmsActors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsActors)).BeginInit();
            this.tabFilmsGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsGenres)).BeginInit();
            this.tabViewers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewers)).BeginInit();
            this.tabActors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddActorDeath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddActorBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.tabProducers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddProducerDeath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddProducerBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducers)).BeginInit();
            this.tabGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.tabFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddFilmYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.tabControlChenging.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSearchFilmsGenre
            // 
            this.cmbSearchFilmsGenre.DataSource = this.genreBindingSource;
            this.cmbSearchFilmsGenre.DisplayMember = "g_name";
            this.cmbSearchFilmsGenre.FormattingEnabled = true;
            this.cmbSearchFilmsGenre.Location = new System.Drawing.Point(120, 60);
            this.cmbSearchFilmsGenre.Name = "cmbSearchFilmsGenre";
            this.cmbSearchFilmsGenre.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsGenre.TabIndex = 15;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(FilmsLab2.Genre);
            // 
            // btnSearchFilms
            // 
            this.btnSearchFilms.Location = new System.Drawing.Point(6, 143);
            this.btnSearchFilms.Name = "btnSearchFilms";
            this.btnSearchFilms.Size = new System.Drawing.Size(294, 23);
            this.btnSearchFilms.TabIndex = 11;
            this.btnSearchFilms.Text = "Пошук фільмів";
            this.btnSearchFilms.UseVisualStyleBackColor = true;
            this.btnSearchFilms.Click += new System.EventHandler(this.btnSearchFilms_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Режисер";
            // 
            // tabControlSearch
            // 
            this.tabControlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSearch.Controls.Add(this.tabPage1);
            this.tabControlSearch.Controls.Add(this.tabPage2);
            this.tabControlSearch.Controls.Add(this.tabPage3);
            this.tabControlSearch.Controls.Add(this.tabPage4);
            this.tabControlSearch.Location = new System.Drawing.Point(12, 68);
            this.tabControlSearch.Name = "tabControlSearch";
            this.tabControlSearch.SelectedIndex = 0;
            this.tabControlSearch.Size = new System.Drawing.Size(760, 336);
            this.tabControlSearch.TabIndex = 53;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClearSearchFilm);
            this.tabPage1.Controls.Add(this.btnAddToList);
            this.tabPage1.Controls.Add(this.cmbSearchFilmsGenre);
            this.tabPage1.Controls.Add(this.btnSearchFilms);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbSearchFilmsName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbSearchFilmsActor);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbSearchFilmsProducer);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbSearchFilmsYear);
            this.tabPage1.Controls.Add(this.dgvSearchFilms);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фільми";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClearSearchFilm
            // 
            this.btnClearSearchFilm.Location = new System.Drawing.Point(6, 172);
            this.btnClearSearchFilm.Name = "btnClearSearchFilm";
            this.btnClearSearchFilm.Size = new System.Drawing.Size(294, 23);
            this.btnClearSearchFilm.TabIndex = 32;
            this.btnClearSearchFilm.Text = "Очистити";
            this.btnClearSearchFilm.UseVisualStyleBackColor = true;
            this.btnClearSearchFilm.Click += new System.EventHandler(this.btnClearSearchFilm_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(6, 201);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(294, 23);
            this.btnAddToList.TabIndex = 31;
            this.btnAddToList.Text = "Додати в список";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Visible = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // cmbSearchFilmsName
            // 
            this.cmbSearchFilmsName.DataSource = this.filmBindingSource;
            this.cmbSearchFilmsName.DisplayMember = "d_name";
            this.cmbSearchFilmsName.FormattingEnabled = true;
            this.cmbSearchFilmsName.Location = new System.Drawing.Point(120, 6);
            this.cmbSearchFilmsName.Name = "cmbSearchFilmsName";
            this.cmbSearchFilmsName.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsName.TabIndex = 12;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataSource = typeof(FilmsLab2.Film);
            // 
            // cmbSearchFilmsActor
            // 
            this.cmbSearchFilmsActor.DataSource = this.actorBindingSource;
            this.cmbSearchFilmsActor.DisplayMember = "a_name";
            this.cmbSearchFilmsActor.FormattingEnabled = true;
            this.cmbSearchFilmsActor.Location = new System.Drawing.Point(120, 114);
            this.cmbSearchFilmsActor.Name = "cmbSearchFilmsActor";
            this.cmbSearchFilmsActor.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsActor.TabIndex = 13;
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataSource = typeof(FilmsLab2.Actor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Актор";
            // 
            // cmbSearchFilmsProducer
            // 
            this.cmbSearchFilmsProducer.DataSource = this.producerBindingSource;
            this.cmbSearchFilmsProducer.DisplayMember = "p_name";
            this.cmbSearchFilmsProducer.FormattingEnabled = true;
            this.cmbSearchFilmsProducer.Location = new System.Drawing.Point(120, 87);
            this.cmbSearchFilmsProducer.Name = "cmbSearchFilmsProducer";
            this.cmbSearchFilmsProducer.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsProducer.TabIndex = 14;
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataSource = typeof(FilmsLab2.Producer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Рік";
            // 
            // cmbSearchFilmsYear
            // 
            this.cmbSearchFilmsYear.DataSource = this.unicFilmYear;
            this.cmbSearchFilmsYear.DisplayMember = "f_year";
            this.cmbSearchFilmsYear.FormattingEnabled = true;
            this.cmbSearchFilmsYear.Location = new System.Drawing.Point(120, 33);
            this.cmbSearchFilmsYear.Name = "cmbSearchFilmsYear";
            this.cmbSearchFilmsYear.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsYear.TabIndex = 16;
            // 
            // unicFilmYear
            // 
            this.unicFilmYear.DataSource = typeof(FilmsLab2.Film);
            // 
            // dgvSearchFilms
            // 
            this.dgvSearchFilms.AllowUserToAddRows = false;
            this.dgvSearchFilms.AllowUserToDeleteRows = false;
            this.dgvSearchFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchFilms.AutoGenerateColumns = false;
            this.dgvSearchFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.d_name,
            this.f_id,
            this.f_year,
            this.f_producer,
            this.producer,
            this.filmsActors,
            this.filmsGenres,
            this.viewersFilms});
            this.dgvSearchFilms.DataSource = this.findedFilmsBS;
            this.dgvSearchFilms.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchFilms.Name = "dgvSearchFilms";
            this.dgvSearchFilms.ReadOnly = true;
            this.dgvSearchFilms.Size = new System.Drawing.Size(440, 301);
            this.dgvSearchFilms.TabIndex = 1;
            this.dgvSearchFilms.DoubleClick += new System.EventHandler(this.dgvSearchFilms_DoubleClick);
            // 
            // d_name
            // 
            this.d_name.DataPropertyName = "d_name";
            this.d_name.HeaderText = "Назва";
            this.d_name.Name = "d_name";
            this.d_name.ReadOnly = true;
            // 
            // f_id
            // 
            this.f_id.DataPropertyName = "f_id";
            this.f_id.HeaderText = "f_id";
            this.f_id.Name = "f_id";
            this.f_id.ReadOnly = true;
            this.f_id.Visible = false;
            // 
            // f_year
            // 
            this.f_year.DataPropertyName = "f_year";
            this.f_year.HeaderText = "Рік";
            this.f_year.Name = "f_year";
            this.f_year.ReadOnly = true;
            // 
            // f_producer
            // 
            this.f_producer.DataPropertyName = "f_producer";
            this.f_producer.HeaderText = "f_producer";
            this.f_producer.Name = "f_producer";
            this.f_producer.ReadOnly = true;
            this.f_producer.Visible = false;
            // 
            // producer
            // 
            this.producer.DataPropertyName = "Producer";
            this.producer.HeaderText = "Producer";
            this.producer.Name = "producer";
            this.producer.ReadOnly = true;
            this.producer.Visible = false;
            // 
            // filmsActors
            // 
            this.filmsActors.DataPropertyName = "FilmsActors";
            this.filmsActors.HeaderText = "FilmsActors";
            this.filmsActors.Name = "filmsActors";
            this.filmsActors.ReadOnly = true;
            this.filmsActors.Visible = false;
            // 
            // filmsGenres
            // 
            this.filmsGenres.DataPropertyName = "FilmsGenres";
            this.filmsGenres.HeaderText = "FilmsGenres";
            this.filmsGenres.Name = "filmsGenres";
            this.filmsGenres.ReadOnly = true;
            this.filmsGenres.Visible = false;
            // 
            // viewersFilms
            // 
            this.viewersFilms.DataPropertyName = "ViewersFilms";
            this.viewersFilms.HeaderText = "ViewersFilms";
            this.viewersFilms.Name = "viewersFilms";
            this.viewersFilms.ReadOnly = true;
            this.viewersFilms.Visible = false;
            // 
            // findedFilmsBS
            // 
            this.findedFilmsBS.DataSource = typeof(FilmsLab2.Film);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Назва";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClearSearchGenre);
            this.tabPage2.Controls.Add(this.dgvSearchGenres);
            this.tabPage2.Controls.Add(this.btnSearchGenre);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmbSearchGenre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Жанри";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearSearchGenre
            // 
            this.btnClearSearchGenre.Location = new System.Drawing.Point(6, 172);
            this.btnClearSearchGenre.Name = "btnClearSearchGenre";
            this.btnClearSearchGenre.Size = new System.Drawing.Size(294, 23);
            this.btnClearSearchGenre.TabIndex = 33;
            this.btnClearSearchGenre.Text = "Очистити";
            this.btnClearSearchGenre.UseVisualStyleBackColor = true;
            this.btnClearSearchGenre.Click += new System.EventHandler(this.btnClearSearchGenre_Click);
            // 
            // dgvSearchGenres
            // 
            this.dgvSearchGenres.AllowUserToAddRows = false;
            this.dgvSearchGenres.AllowUserToDeleteRows = false;
            this.dgvSearchGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchGenres.AutoGenerateColumns = false;
            this.dgvSearchGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gnameDataGridViewTextBoxColumn,
            this.gidDataGridViewTextBoxColumn,
            this.filmsGenresDataGridViewTextBoxColumn});
            this.dgvSearchGenres.DataSource = this.findedGenresBS;
            this.dgvSearchGenres.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchGenres.Name = "dgvSearchGenres";
            this.dgvSearchGenres.ReadOnly = true;
            this.dgvSearchGenres.Size = new System.Drawing.Size(440, 301);
            this.dgvSearchGenres.TabIndex = 3;
            // 
            // gnameDataGridViewTextBoxColumn
            // 
            this.gnameDataGridViewTextBoxColumn.DataPropertyName = "g_name";
            this.gnameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.gnameDataGridViewTextBoxColumn.Name = "gnameDataGridViewTextBoxColumn";
            this.gnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gidDataGridViewTextBoxColumn
            // 
            this.gidDataGridViewTextBoxColumn.DataPropertyName = "g_id";
            this.gidDataGridViewTextBoxColumn.HeaderText = "g_id";
            this.gidDataGridViewTextBoxColumn.Name = "gidDataGridViewTextBoxColumn";
            this.gidDataGridViewTextBoxColumn.ReadOnly = true;
            this.gidDataGridViewTextBoxColumn.Visible = false;
            // 
            // filmsGenresDataGridViewTextBoxColumn
            // 
            this.filmsGenresDataGridViewTextBoxColumn.DataPropertyName = "FilmsGenres";
            this.filmsGenresDataGridViewTextBoxColumn.HeaderText = "FilmsGenres";
            this.filmsGenresDataGridViewTextBoxColumn.Name = "filmsGenresDataGridViewTextBoxColumn";
            this.filmsGenresDataGridViewTextBoxColumn.ReadOnly = true;
            this.filmsGenresDataGridViewTextBoxColumn.Visible = false;
            // 
            // findedGenresBS
            // 
            this.findedGenresBS.DataSource = typeof(FilmsLab2.Genre);
            // 
            // btnSearchGenre
            // 
            this.btnSearchGenre.Location = new System.Drawing.Point(6, 143);
            this.btnSearchGenre.Name = "btnSearchGenre";
            this.btnSearchGenre.Size = new System.Drawing.Size(294, 23);
            this.btnSearchGenre.TabIndex = 2;
            this.btnSearchGenre.Text = "Пошук жанрів";
            this.btnSearchGenre.UseVisualStyleBackColor = true;
            this.btnSearchGenre.Click += new System.EventHandler(this.btnSearchGenre_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Жанр";
            // 
            // cmbSearchGenre
            // 
            this.cmbSearchGenre.DataSource = this.genreBindingSource;
            this.cmbSearchGenre.DisplayMember = "g_name";
            this.cmbSearchGenre.FormattingEnabled = true;
            this.cmbSearchGenre.Location = new System.Drawing.Point(120, 6);
            this.cmbSearchGenre.Name = "cmbSearchGenre";
            this.cmbSearchGenre.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchGenre.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClearSearchProducer);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cmbSearchProducerBirth);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.cmbSearchProducerDeath);
            this.tabPage3.Controls.Add(this.dgvSearchProducers);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cmbSearchProducerName);
            this.tabPage3.Controls.Add(this.btnSearchProducer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(752, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Режисери";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClearSearchProducer
            // 
            this.btnClearSearchProducer.Location = new System.Drawing.Point(6, 172);
            this.btnClearSearchProducer.Name = "btnClearSearchProducer";
            this.btnClearSearchProducer.Size = new System.Drawing.Size(294, 23);
            this.btnClearSearchProducer.TabIndex = 34;
            this.btnClearSearchProducer.Text = "Очистити";
            this.btnClearSearchProducer.UseVisualStyleBackColor = true;
            this.btnClearSearchProducer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Рік народження";
            // 
            // cmbSearchProducerBirth
            // 
            this.cmbSearchProducerBirth.DataSource = this.unicProducerBirth;
            this.cmbSearchProducerBirth.DisplayMember = "p_birth";
            this.cmbSearchProducerBirth.FormattingEnabled = true;
            this.cmbSearchProducerBirth.Location = new System.Drawing.Point(120, 33);
            this.cmbSearchProducerBirth.Name = "cmbSearchProducerBirth";
            this.cmbSearchProducerBirth.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchProducerBirth.TabIndex = 10;
            // 
            // unicProducerBirth
            // 
            this.unicProducerBirth.DataSource = typeof(FilmsLab2.Producer);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Рік смерті";
            // 
            // cmbSearchProducerDeath
            // 
            this.cmbSearchProducerDeath.DataSource = this.unicProducerDeath;
            this.cmbSearchProducerDeath.DisplayMember = "p_death";
            this.cmbSearchProducerDeath.FormattingEnabled = true;
            this.cmbSearchProducerDeath.Location = new System.Drawing.Point(120, 60);
            this.cmbSearchProducerDeath.Name = "cmbSearchProducerDeath";
            this.cmbSearchProducerDeath.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchProducerDeath.TabIndex = 8;
            // 
            // unicProducerDeath
            // 
            this.unicProducerDeath.DataSource = typeof(FilmsLab2.Producer);
            // 
            // dgvSearchProducers
            // 
            this.dgvSearchProducers.AllowUserToAddRows = false;
            this.dgvSearchProducers.AllowUserToDeleteRows = false;
            this.dgvSearchProducers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchProducers.AutoGenerateColumns = false;
            this.dgvSearchProducers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchProducers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_name,
            this.p_id,
            this.p_birth,
            this.p_death,
            this.filmsDataGridViewTextBoxColumn});
            this.dgvSearchProducers.DataSource = this.findedProducerBS;
            this.dgvSearchProducers.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchProducers.Name = "dgvSearchProducers";
            this.dgvSearchProducers.ReadOnly = true;
            this.dgvSearchProducers.Size = new System.Drawing.Size(440, 301);
            this.dgvSearchProducers.TabIndex = 7;
            // 
            // p_name
            // 
            this.p_name.DataPropertyName = "p_name";
            this.p_name.HeaderText = "Ім\'я";
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            // 
            // p_id
            // 
            this.p_id.DataPropertyName = "p_id";
            this.p_id.HeaderText = "p_id";
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            this.p_id.Visible = false;
            // 
            // p_birth
            // 
            this.p_birth.DataPropertyName = "p_birth";
            this.p_birth.HeaderText = "Рік народження";
            this.p_birth.Name = "p_birth";
            this.p_birth.ReadOnly = true;
            // 
            // p_death
            // 
            this.p_death.DataPropertyName = "p_death";
            this.p_death.HeaderText = "Рік смерті";
            this.p_death.Name = "p_death";
            this.p_death.ReadOnly = true;
            // 
            // filmsDataGridViewTextBoxColumn
            // 
            this.filmsDataGridViewTextBoxColumn.DataPropertyName = "Films";
            this.filmsDataGridViewTextBoxColumn.HeaderText = "Films";
            this.filmsDataGridViewTextBoxColumn.Name = "filmsDataGridViewTextBoxColumn";
            this.filmsDataGridViewTextBoxColumn.ReadOnly = true;
            this.filmsDataGridViewTextBoxColumn.Visible = false;
            // 
            // findedProducerBS
            // 
            this.findedProducerBS.DataSource = typeof(FilmsLab2.Producer);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ім\'я";
            // 
            // cmbSearchProducerName
            // 
            this.cmbSearchProducerName.DataSource = this.producerBindingSource;
            this.cmbSearchProducerName.DisplayMember = "p_name";
            this.cmbSearchProducerName.FormattingEnabled = true;
            this.cmbSearchProducerName.Location = new System.Drawing.Point(120, 6);
            this.cmbSearchProducerName.Name = "cmbSearchProducerName";
            this.cmbSearchProducerName.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchProducerName.TabIndex = 1;
            // 
            // btnSearchProducer
            // 
            this.btnSearchProducer.Location = new System.Drawing.Point(6, 143);
            this.btnSearchProducer.Name = "btnSearchProducer";
            this.btnSearchProducer.Size = new System.Drawing.Size(294, 23);
            this.btnSearchProducer.TabIndex = 0;
            this.btnSearchProducer.Text = "Пошук режисерів";
            this.btnSearchProducer.UseVisualStyleBackColor = true;
            this.btnSearchProducer.Click += new System.EventHandler(this.btnSearchProducer_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnClearSearchActor);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.cmbSearchActorDeath);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.cmbSearchActorBirth);
            this.tabPage4.Controls.Add(this.dgvSearchActors);
            this.tabPage4.Controls.Add(this.btnSearchActor);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.cmbSearchActorName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(752, 310);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Актори";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnClearSearchActor
            // 
            this.btnClearSearchActor.Location = new System.Drawing.Point(6, 172);
            this.btnClearSearchActor.Name = "btnClearSearchActor";
            this.btnClearSearchActor.Size = new System.Drawing.Size(294, 23);
            this.btnClearSearchActor.TabIndex = 35;
            this.btnClearSearchActor.Text = "Очистити";
            this.btnClearSearchActor.UseVisualStyleBackColor = true;
            this.btnClearSearchActor.Click += new System.EventHandler(this.btnClearSearchActor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Рік смерті";
            // 
            // cmbSearchActorDeath
            // 
            this.cmbSearchActorDeath.DataSource = this.unicActorDeath;
            this.cmbSearchActorDeath.DisplayMember = "a_death";
            this.cmbSearchActorDeath.FormattingEnabled = true;
            this.cmbSearchActorDeath.Location = new System.Drawing.Point(120, 60);
            this.cmbSearchActorDeath.Name = "cmbSearchActorDeath";
            this.cmbSearchActorDeath.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchActorDeath.TabIndex = 10;
            // 
            // unicActorDeath
            // 
            this.unicActorDeath.DataSource = typeof(FilmsLab2.Actor);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Рік народження";
            // 
            // cmbSearchActorBirth
            // 
            this.cmbSearchActorBirth.DataSource = this.unicActorBirth;
            this.cmbSearchActorBirth.DisplayMember = "a_birth";
            this.cmbSearchActorBirth.FormattingEnabled = true;
            this.cmbSearchActorBirth.Location = new System.Drawing.Point(120, 33);
            this.cmbSearchActorBirth.Name = "cmbSearchActorBirth";
            this.cmbSearchActorBirth.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchActorBirth.TabIndex = 8;
            // 
            // unicActorBirth
            // 
            this.unicActorBirth.DataSource = typeof(FilmsLab2.Actor);
            // 
            // dgvSearchActors
            // 
            this.dgvSearchActors.AllowUserToAddRows = false;
            this.dgvSearchActors.AllowUserToDeleteRows = false;
            this.dgvSearchActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchActors.AutoGenerateColumns = false;
            this.dgvSearchActors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a_name,
            this.a_id,
            this.a_birth,
            this.a_death,
            this.filmsActorsDataGridViewTextBoxColumn1});
            this.dgvSearchActors.DataSource = this.findedActorsBS;
            this.dgvSearchActors.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchActors.Name = "dgvSearchActors";
            this.dgvSearchActors.ReadOnly = true;
            this.dgvSearchActors.Size = new System.Drawing.Size(440, 301);
            this.dgvSearchActors.TabIndex = 7;
            // 
            // a_name
            // 
            this.a_name.DataPropertyName = "a_name";
            this.a_name.HeaderText = "Ім\'я";
            this.a_name.Name = "a_name";
            this.a_name.ReadOnly = true;
            // 
            // a_id
            // 
            this.a_id.DataPropertyName = "a_id";
            this.a_id.HeaderText = "a_id";
            this.a_id.Name = "a_id";
            this.a_id.ReadOnly = true;
            this.a_id.Visible = false;
            // 
            // a_birth
            // 
            this.a_birth.DataPropertyName = "a_birth";
            this.a_birth.HeaderText = "Рік народження";
            this.a_birth.Name = "a_birth";
            this.a_birth.ReadOnly = true;
            // 
            // a_death
            // 
            this.a_death.DataPropertyName = "a_death";
            this.a_death.HeaderText = "Рік смерті";
            this.a_death.Name = "a_death";
            this.a_death.ReadOnly = true;
            // 
            // filmsActorsDataGridViewTextBoxColumn1
            // 
            this.filmsActorsDataGridViewTextBoxColumn1.DataPropertyName = "FilmsActors";
            this.filmsActorsDataGridViewTextBoxColumn1.HeaderText = "FilmsActors";
            this.filmsActorsDataGridViewTextBoxColumn1.Name = "filmsActorsDataGridViewTextBoxColumn1";
            this.filmsActorsDataGridViewTextBoxColumn1.ReadOnly = true;
            this.filmsActorsDataGridViewTextBoxColumn1.Visible = false;
            // 
            // findedActorsBS
            // 
            this.findedActorsBS.DataSource = typeof(FilmsLab2.Actor);
            // 
            // btnSearchActor
            // 
            this.btnSearchActor.Location = new System.Drawing.Point(6, 143);
            this.btnSearchActor.Name = "btnSearchActor";
            this.btnSearchActor.Size = new System.Drawing.Size(294, 23);
            this.btnSearchActor.TabIndex = 6;
            this.btnSearchActor.Text = "Пошук акторів";
            this.btnSearchActor.UseVisualStyleBackColor = true;
            this.btnSearchActor.Click += new System.EventHandler(this.btnSearchActor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ім\'я";
            // 
            // cmbSearchActorName
            // 
            this.cmbSearchActorName.DataSource = this.actorBindingSource;
            this.cmbSearchActorName.DisplayMember = "a_name";
            this.cmbSearchActorName.FormattingEnabled = true;
            this.cmbSearchActorName.Location = new System.Drawing.Point(120, 6);
            this.cmbSearchActorName.Name = "cmbSearchActorName";
            this.cmbSearchActorName.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchActorName.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(229, 43);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 52;
            this.lblPassword.Text = "Пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(229, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(37, 13);
            this.lblLogin.TabIndex = 51;
            this.lblLogin.Text = "Логін ";
            // 
            // txtbPassword
            // 
            this.txtbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPassword.Location = new System.Drawing.Point(280, 40);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(160, 20);
            this.txtbPassword.TabIndex = 50;
            // 
            // txtbLogin
            // 
            this.txtbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbLogin.Location = new System.Drawing.Point(280, 13);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(160, 20);
            this.txtbLogin.TabIndex = 49;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(446, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 21);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.Location = new System.Drawing.Point(446, 39);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(160, 21);
            this.btnList.TabIndex = 47;
            this.btnList.Text = "Мій список";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistration.Location = new System.Drawing.Point(612, 12);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(160, 21);
            this.btnRegistration.TabIndex = 44;
            this.btnRegistration.Text = "Реєстрація";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnEditing
            // 
            this.btnEditing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditing.Location = new System.Drawing.Point(612, 39);
            this.btnEditing.Name = "btnEditing";
            this.btnEditing.Size = new System.Drawing.Size(160, 21);
            this.btnEditing.TabIndex = 46;
            this.btnEditing.Text = "Редагування";
            this.btnEditing.UseVisualStyleBackColor = true;
            this.btnEditing.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.Location = new System.Drawing.Point(447, 12);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(160, 21);
            this.btnEnter.TabIndex = 45;
            this.btnEnter.Text = "Увійти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnListEnd
            // 
            this.btnListEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListEnd.Location = new System.Drawing.Point(446, 39);
            this.btnListEnd.Name = "btnListEnd";
            this.btnListEnd.Size = new System.Drawing.Size(160, 21);
            this.btnListEnd.TabIndex = 70;
            this.btnListEnd.Text = "Пошук";
            this.btnListEnd.UseVisualStyleBackColor = true;
            this.btnListEnd.Click += new System.EventHandler(this.btnListEnd_Click);
            // 
            // btnSaveAllChanges
            // 
            this.btnSaveAllChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAllChanges.Location = new System.Drawing.Point(612, 12);
            this.btnSaveAllChanges.Name = "btnSaveAllChanges";
            this.btnSaveAllChanges.Size = new System.Drawing.Size(160, 21);
            this.btnSaveAllChanges.TabIndex = 63;
            this.btnSaveAllChanges.Text = "Зберегти все";
            this.btnSaveAllChanges.UseVisualStyleBackColor = true;
            this.btnSaveAllChanges.Click += new System.EventHandler(this.btnSaveAllChanges_Click);
            // 
            // btnEndEdit
            // 
            this.btnEndEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndEdit.Location = new System.Drawing.Point(612, 39);
            this.btnEndEdit.Name = "btnEndEdit";
            this.btnEndEdit.Size = new System.Drawing.Size(160, 21);
            this.btnEndEdit.TabIndex = 62;
            this.btnEndEdit.Text = "Пошук";
            this.btnEndEdit.UseVisualStyleBackColor = true;
            this.btnEndEdit.Click += new System.EventHandler(this.btnEndEdit_Click);
            // 
            // btnRegCancel
            // 
            this.btnRegCancel.Location = new System.Drawing.Point(203, 250);
            this.btnRegCancel.Name = "btnRegCancel";
            this.btnRegCancel.Size = new System.Drawing.Size(190, 21);
            this.btnRegCancel.TabIndex = 61;
            this.btnRegCancel.Text = "Скасувати";
            this.btnRegCancel.UseVisualStyleBackColor = true;
            this.btnRegCancel.Click += new System.EventHandler(this.btnRegCancel_Click);
            // 
            // lblRegName
            // 
            this.lblRegName.AutoSize = true;
            this.lblRegName.Location = new System.Drawing.Point(200, 182);
            this.lblRegName.Name = "lblRegName";
            this.lblRegName.Size = new System.Drawing.Size(26, 13);
            this.lblRegName.TabIndex = 60;
            this.lblRegName.Text = "Ім\'я";
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Location = new System.Drawing.Point(200, 156);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(45, 13);
            this.lblRegPassword.TabIndex = 59;
            this.lblRegPassword.Text = "Пароль";
            // 
            // lblRegLogin
            // 
            this.lblRegLogin.AutoSize = true;
            this.lblRegLogin.Location = new System.Drawing.Point(200, 130);
            this.lblRegLogin.Name = "lblRegLogin";
            this.lblRegLogin.Size = new System.Drawing.Size(34, 13);
            this.lblRegLogin.TabIndex = 58;
            this.lblRegLogin.Text = "Логін";
            // 
            // btnRegistr
            // 
            this.btnRegistr.Location = new System.Drawing.Point(410, 250);
            this.btnRegistr.Name = "btnRegistr";
            this.btnRegistr.Size = new System.Drawing.Size(190, 21);
            this.btnRegistr.TabIndex = 57;
            this.btnRegistr.Text = "Зареєструватися";
            this.btnRegistr.UseVisualStyleBackColor = true;
            this.btnRegistr.Click += new System.EventHandler(this.btnRegistr_Click);
            // 
            // txtbRegistrationPassword
            // 
            this.txtbRegistrationPassword.Location = new System.Drawing.Point(260, 153);
            this.txtbRegistrationPassword.Name = "txtbRegistrationPassword";
            this.txtbRegistrationPassword.Size = new System.Drawing.Size(340, 20);
            this.txtbRegistrationPassword.TabIndex = 56;
            // 
            // txtbRegistrationName
            // 
            this.txtbRegistrationName.Location = new System.Drawing.Point(260, 179);
            this.txtbRegistrationName.Name = "txtbRegistrationName";
            this.txtbRegistrationName.Size = new System.Drawing.Size(340, 20);
            this.txtbRegistrationName.TabIndex = 55;
            // 
            // txtbRegistrationUsername
            // 
            this.txtbRegistrationUsername.Location = new System.Drawing.Point(260, 127);
            this.txtbRegistrationUsername.Name = "txtbRegistrationUsername";
            this.txtbRegistrationUsername.Size = new System.Drawing.Size(340, 20);
            this.txtbRegistrationUsername.TabIndex = 54;
            // 
            // viewerBindingSource
            // 
            this.viewerBindingSource.DataSource = typeof(FilmsLab2.Viewer);
            // 
            // filmsGenreBindingSource
            // 
            this.filmsGenreBindingSource.DataSource = typeof(FilmsLab2.FilmsGenre);
            // 
            // filmsActorBindingSource
            // 
            this.filmsActorBindingSource.DataSource = typeof(FilmsLab2.FilmsActor);
            // 
            // viewersFilmBindingSource
            // 
            this.viewersFilmBindingSource.DataSource = typeof(FilmsLab2.ViewersFilm);
            // 
            // lblRegMail
            // 
            this.lblRegMail.AutoSize = true;
            this.lblRegMail.Location = new System.Drawing.Point(200, 208);
            this.lblRegMail.Name = "lblRegMail";
            this.lblRegMail.Size = new System.Drawing.Size(40, 13);
            this.lblRegMail.TabIndex = 75;
            this.lblRegMail.Text = "Пошта";
            // 
            // txtbRegistrationMail
            // 
            this.txtbRegistrationMail.Location = new System.Drawing.Point(260, 205);
            this.txtbRegistrationMail.Name = "txtbRegistrationMail";
            this.txtbRegistrationMail.Size = new System.Drawing.Size(340, 20);
            this.txtbRegistrationMail.TabIndex = 74;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dnameDataGridViewTextBoxColumn,
            this.fid,
            this.fyearDataGridViewTextBoxColumn,
            this.fproducerDataGridViewTextBoxColumn,
            this.producerDataGridViewTextBoxColumn,
            this.filmsActorsDataGridViewTextBoxColumn,
            this.filmsGenresDataGridViewTextBoxColumn1,
            this.viewersFilmsDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.listFilmsBS;
            this.dgvList.Location = new System.Drawing.Point(12, 81);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(760, 259);
            this.dgvList.TabIndex = 76;
            this.dgvList.DoubleClick += new System.EventHandler(this.dgvList_DoubleClick);
            // 
            // dnameDataGridViewTextBoxColumn
            // 
            this.dnameDataGridViewTextBoxColumn.DataPropertyName = "d_name";
            this.dnameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.dnameDataGridViewTextBoxColumn.Name = "dnameDataGridViewTextBoxColumn";
            // 
            // fid
            // 
            this.fid.DataPropertyName = "f_id";
            this.fid.HeaderText = "f_id";
            this.fid.Name = "fid";
            this.fid.Visible = false;
            // 
            // fyearDataGridViewTextBoxColumn
            // 
            this.fyearDataGridViewTextBoxColumn.DataPropertyName = "f_year";
            this.fyearDataGridViewTextBoxColumn.HeaderText = "Рік";
            this.fyearDataGridViewTextBoxColumn.Name = "fyearDataGridViewTextBoxColumn";
            // 
            // fproducerDataGridViewTextBoxColumn
            // 
            this.fproducerDataGridViewTextBoxColumn.DataPropertyName = "f_producer";
            this.fproducerDataGridViewTextBoxColumn.HeaderText = "f_producer";
            this.fproducerDataGridViewTextBoxColumn.Name = "fproducerDataGridViewTextBoxColumn";
            this.fproducerDataGridViewTextBoxColumn.Visible = false;
            // 
            // producerDataGridViewTextBoxColumn
            // 
            this.producerDataGridViewTextBoxColumn.DataPropertyName = "Producer";
            this.producerDataGridViewTextBoxColumn.HeaderText = "Producer";
            this.producerDataGridViewTextBoxColumn.Name = "producerDataGridViewTextBoxColumn";
            this.producerDataGridViewTextBoxColumn.Visible = false;
            // 
            // filmsActorsDataGridViewTextBoxColumn
            // 
            this.filmsActorsDataGridViewTextBoxColumn.DataPropertyName = "FilmsActors";
            this.filmsActorsDataGridViewTextBoxColumn.HeaderText = "FilmsActors";
            this.filmsActorsDataGridViewTextBoxColumn.Name = "filmsActorsDataGridViewTextBoxColumn";
            this.filmsActorsDataGridViewTextBoxColumn.Visible = false;
            // 
            // filmsGenresDataGridViewTextBoxColumn1
            // 
            this.filmsGenresDataGridViewTextBoxColumn1.DataPropertyName = "FilmsGenres";
            this.filmsGenresDataGridViewTextBoxColumn1.HeaderText = "FilmsGenres";
            this.filmsGenresDataGridViewTextBoxColumn1.Name = "filmsGenresDataGridViewTextBoxColumn1";
            this.filmsGenresDataGridViewTextBoxColumn1.Visible = false;
            // 
            // viewersFilmsDataGridViewTextBoxColumn
            // 
            this.viewersFilmsDataGridViewTextBoxColumn.DataPropertyName = "ViewersFilms";
            this.viewersFilmsDataGridViewTextBoxColumn.HeaderText = "ViewersFilms";
            this.viewersFilmsDataGridViewTextBoxColumn.Name = "viewersFilmsDataGridViewTextBoxColumn";
            this.viewersFilmsDataGridViewTextBoxColumn.Visible = false;
            // 
            // listFilmsBS
            // 
            this.listFilmsBS.DataSource = typeof(FilmsLab2.Film);
            // 
            // btnListDelete
            // 
            this.btnListDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListDelete.Location = new System.Drawing.Point(12, 357);
            this.btnListDelete.Name = "btnListDelete";
            this.btnListDelete.Size = new System.Drawing.Size(760, 23);
            this.btnListDelete.TabIndex = 77;
            this.btnListDelete.Text = "Видалити";
            this.btnListDelete.UseVisualStyleBackColor = true;
            this.btnListDelete.Visible = false;
            this.btnListDelete.Click += new System.EventHandler(this.btnListDelete_Click);
            // 
            // tabViewersFilms
            // 
            this.tabViewersFilms.Controls.Add(this.dgvViewersFilms);
            this.tabViewersFilms.Location = new System.Drawing.Point(4, 22);
            this.tabViewersFilms.Name = "tabViewersFilms";
            this.tabViewersFilms.Size = new System.Drawing.Size(752, 310);
            this.tabViewersFilms.TabIndex = 11;
            this.tabViewersFilms.Text = "ГлядачіФільми";
            this.tabViewersFilms.UseVisualStyleBackColor = true;
            // 
            // dgvViewersFilms
            // 
            this.dgvViewersFilms.AllowUserToAddRows = false;
            this.dgvViewersFilms.AllowUserToDeleteRows = false;
            this.dgvViewersFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewersFilms.AutoGenerateColumns = false;
            this.dgvViewersFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewersFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vfidDataGridViewTextBoxColumn,
            this.vffidDataGridViewTextBoxColumn,
            this.vfvidDataGridViewTextBoxColumn,
            this.filmDataGridViewTextBoxColumn2,
            this.viewerDataGridViewTextBoxColumn});
            this.dgvViewersFilms.DataSource = this.viewersFilmBindingSource;
            this.dgvViewersFilms.Location = new System.Drawing.Point(6, 33);
            this.dgvViewersFilms.Name = "dgvViewersFilms";
            this.dgvViewersFilms.Size = new System.Drawing.Size(740, 274);
            this.dgvViewersFilms.TabIndex = 2;
            // 
            // vfidDataGridViewTextBoxColumn
            // 
            this.vfidDataGridViewTextBoxColumn.DataPropertyName = "vf_id";
            this.vfidDataGridViewTextBoxColumn.HeaderText = "vf_id";
            this.vfidDataGridViewTextBoxColumn.Name = "vfidDataGridViewTextBoxColumn";
            this.vfidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vffidDataGridViewTextBoxColumn
            // 
            this.vffidDataGridViewTextBoxColumn.DataPropertyName = "vf_f_id";
            this.vffidDataGridViewTextBoxColumn.HeaderText = "vf_f_id";
            this.vffidDataGridViewTextBoxColumn.Name = "vffidDataGridViewTextBoxColumn";
            this.vffidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vfvidDataGridViewTextBoxColumn
            // 
            this.vfvidDataGridViewTextBoxColumn.DataPropertyName = "vf_v_id";
            this.vfvidDataGridViewTextBoxColumn.HeaderText = "vf_v_id";
            this.vfvidDataGridViewTextBoxColumn.Name = "vfvidDataGridViewTextBoxColumn";
            this.vfvidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmDataGridViewTextBoxColumn2
            // 
            this.filmDataGridViewTextBoxColumn2.DataPropertyName = "Film";
            this.filmDataGridViewTextBoxColumn2.HeaderText = "Film";
            this.filmDataGridViewTextBoxColumn2.Name = "filmDataGridViewTextBoxColumn2";
            this.filmDataGridViewTextBoxColumn2.Visible = false;
            // 
            // viewerDataGridViewTextBoxColumn
            // 
            this.viewerDataGridViewTextBoxColumn.DataPropertyName = "Viewer";
            this.viewerDataGridViewTextBoxColumn.HeaderText = "Viewer";
            this.viewerDataGridViewTextBoxColumn.Name = "viewerDataGridViewTextBoxColumn";
            this.viewerDataGridViewTextBoxColumn.Visible = false;
            // 
            // tabFilmsActors
            // 
            this.tabFilmsActors.Controls.Add(this.dgvFilmsActors);
            this.tabFilmsActors.Location = new System.Drawing.Point(4, 22);
            this.tabFilmsActors.Name = "tabFilmsActors";
            this.tabFilmsActors.Size = new System.Drawing.Size(752, 310);
            this.tabFilmsActors.TabIndex = 10;
            this.tabFilmsActors.Text = "ФільмиАктори";
            this.tabFilmsActors.UseVisualStyleBackColor = true;
            // 
            // dgvFilmsActors
            // 
            this.dgvFilmsActors.AllowUserToAddRows = false;
            this.dgvFilmsActors.AllowUserToDeleteRows = false;
            this.dgvFilmsActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilmsActors.AutoGenerateColumns = false;
            this.dgvFilmsActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmsActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faidDataGridViewTextBoxColumn,
            this.fafidDataGridViewTextBoxColumn,
            this.faaidDataGridViewTextBoxColumn,
            this.actorDataGridViewTextBoxColumn,
            this.filmDataGridViewTextBoxColumn1});
            this.dgvFilmsActors.DataSource = this.filmsActorBindingSource;
            this.dgvFilmsActors.Location = new System.Drawing.Point(6, 33);
            this.dgvFilmsActors.Name = "dgvFilmsActors";
            this.dgvFilmsActors.Size = new System.Drawing.Size(740, 274);
            this.dgvFilmsActors.TabIndex = 2;
            // 
            // faidDataGridViewTextBoxColumn
            // 
            this.faidDataGridViewTextBoxColumn.DataPropertyName = "fa_id";
            this.faidDataGridViewTextBoxColumn.HeaderText = "fa_id";
            this.faidDataGridViewTextBoxColumn.Name = "faidDataGridViewTextBoxColumn";
            this.faidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fafidDataGridViewTextBoxColumn
            // 
            this.fafidDataGridViewTextBoxColumn.DataPropertyName = "fa_f_id";
            this.fafidDataGridViewTextBoxColumn.HeaderText = "fa_f_id";
            this.fafidDataGridViewTextBoxColumn.Name = "fafidDataGridViewTextBoxColumn";
            this.fafidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faaidDataGridViewTextBoxColumn
            // 
            this.faaidDataGridViewTextBoxColumn.DataPropertyName = "fa_a_id";
            this.faaidDataGridViewTextBoxColumn.HeaderText = "fa_a_id";
            this.faaidDataGridViewTextBoxColumn.Name = "faaidDataGridViewTextBoxColumn";
            this.faaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actorDataGridViewTextBoxColumn
            // 
            this.actorDataGridViewTextBoxColumn.DataPropertyName = "Actor";
            this.actorDataGridViewTextBoxColumn.HeaderText = "Actor";
            this.actorDataGridViewTextBoxColumn.Name = "actorDataGridViewTextBoxColumn";
            this.actorDataGridViewTextBoxColumn.Visible = false;
            // 
            // filmDataGridViewTextBoxColumn1
            // 
            this.filmDataGridViewTextBoxColumn1.DataPropertyName = "Film";
            this.filmDataGridViewTextBoxColumn1.HeaderText = "Film";
            this.filmDataGridViewTextBoxColumn1.Name = "filmDataGridViewTextBoxColumn1";
            this.filmDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tabFilmsGenres
            // 
            this.tabFilmsGenres.Controls.Add(this.dgvFilmsGenres);
            this.tabFilmsGenres.Location = new System.Drawing.Point(4, 22);
            this.tabFilmsGenres.Name = "tabFilmsGenres";
            this.tabFilmsGenres.Size = new System.Drawing.Size(752, 310);
            this.tabFilmsGenres.TabIndex = 9;
            this.tabFilmsGenres.Text = "ФільмиЖанри";
            this.tabFilmsGenres.UseVisualStyleBackColor = true;
            // 
            // dgvFilmsGenres
            // 
            this.dgvFilmsGenres.AllowUserToAddRows = false;
            this.dgvFilmsGenres.AllowUserToDeleteRows = false;
            this.dgvFilmsGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilmsGenres.AutoGenerateColumns = false;
            this.dgvFilmsGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmsGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fgidDataGridViewTextBoxColumn,
            this.fgfidDataGridViewTextBoxColumn,
            this.fggidDataGridViewTextBoxColumn,
            this.filmDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn});
            this.dgvFilmsGenres.DataSource = this.filmsGenreBindingSource;
            this.dgvFilmsGenres.Location = new System.Drawing.Point(6, 33);
            this.dgvFilmsGenres.Name = "dgvFilmsGenres";
            this.dgvFilmsGenres.Size = new System.Drawing.Size(740, 274);
            this.dgvFilmsGenres.TabIndex = 2;
            // 
            // fgidDataGridViewTextBoxColumn
            // 
            this.fgidDataGridViewTextBoxColumn.DataPropertyName = "fg_id";
            this.fgidDataGridViewTextBoxColumn.HeaderText = "fg_id";
            this.fgidDataGridViewTextBoxColumn.Name = "fgidDataGridViewTextBoxColumn";
            this.fgidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fgfidDataGridViewTextBoxColumn
            // 
            this.fgfidDataGridViewTextBoxColumn.DataPropertyName = "fg_f_id";
            this.fgfidDataGridViewTextBoxColumn.HeaderText = "fg_f_id";
            this.fgfidDataGridViewTextBoxColumn.Name = "fgfidDataGridViewTextBoxColumn";
            this.fgfidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fggidDataGridViewTextBoxColumn
            // 
            this.fggidDataGridViewTextBoxColumn.DataPropertyName = "fg_g_id";
            this.fggidDataGridViewTextBoxColumn.HeaderText = "fg_g_id";
            this.fggidDataGridViewTextBoxColumn.Name = "fggidDataGridViewTextBoxColumn";
            this.fggidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmDataGridViewTextBoxColumn
            // 
            this.filmDataGridViewTextBoxColumn.DataPropertyName = "Film";
            this.filmDataGridViewTextBoxColumn.HeaderText = "Film";
            this.filmDataGridViewTextBoxColumn.Name = "filmDataGridViewTextBoxColumn";
            this.filmDataGridViewTextBoxColumn.Visible = false;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Visible = false;
            // 
            // tabViewers
            // 
            this.tabViewers.Controls.Add(this.btnDeleteViewers);
            this.tabViewers.Controls.Add(this.dgvViewers);
            this.tabViewers.Location = new System.Drawing.Point(4, 22);
            this.tabViewers.Name = "tabViewers";
            this.tabViewers.Size = new System.Drawing.Size(752, 310);
            this.tabViewers.TabIndex = 4;
            this.tabViewers.Text = "Глядачі";
            this.tabViewers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteViewers
            // 
            this.btnDeleteViewers.Location = new System.Drawing.Point(6, 6);
            this.btnDeleteViewers.Name = "btnDeleteViewers";
            this.btnDeleteViewers.Size = new System.Drawing.Size(160, 21);
            this.btnDeleteViewers.TabIndex = 2;
            this.btnDeleteViewers.Text = "Видалити";
            this.btnDeleteViewers.UseVisualStyleBackColor = true;
            this.btnDeleteViewers.Click += new System.EventHandler(this.btnDeleteViewers_Click);
            // 
            // dgvViewers
            // 
            this.dgvViewers.AllowUserToAddRows = false;
            this.dgvViewers.AllowUserToDeleteRows = false;
            this.dgvViewers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewers.AutoGenerateColumns = false;
            this.dgvViewers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vid,
            this.vname,
            this.vusername,
            this.vpassword,
            this.vmail,
            this.vadmin,
            this.viewersFilmsDataGridViewTextBoxColumn2});
            this.dgvViewers.DataSource = this.viewerBindingSource;
            this.dgvViewers.Location = new System.Drawing.Point(6, 33);
            this.dgvViewers.Name = "dgvViewers";
            this.dgvViewers.Size = new System.Drawing.Size(740, 274);
            this.dgvViewers.TabIndex = 0;
            // 
            // vid
            // 
            this.vid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vid.DataPropertyName = "v_id";
            this.vid.HeaderText = "v_id";
            this.vid.Name = "vid";
            this.vid.ReadOnly = true;
            this.vid.Width = 52;
            // 
            // vname
            // 
            this.vname.DataPropertyName = "v_name";
            this.vname.HeaderText = "v_name";
            this.vname.Name = "vname";
            this.vname.ReadOnly = true;
            // 
            // vusername
            // 
            this.vusername.DataPropertyName = "v_username";
            this.vusername.HeaderText = "v_username";
            this.vusername.Name = "vusername";
            this.vusername.ReadOnly = true;
            // 
            // vpassword
            // 
            this.vpassword.DataPropertyName = "v_password";
            this.vpassword.HeaderText = "v_password";
            this.vpassword.Name = "vpassword";
            this.vpassword.ReadOnly = true;
            // 
            // vmail
            // 
            this.vmail.DataPropertyName = "v_mail";
            this.vmail.HeaderText = "v_mail";
            this.vmail.Name = "vmail";
            this.vmail.ReadOnly = true;
            // 
            // vadmin
            // 
            this.vadmin.DataPropertyName = "v_admin";
            this.vadmin.HeaderText = "v_admin";
            this.vadmin.Name = "vadmin";
            // 
            // viewersFilmsDataGridViewTextBoxColumn2
            // 
            this.viewersFilmsDataGridViewTextBoxColumn2.DataPropertyName = "ViewersFilms";
            this.viewersFilmsDataGridViewTextBoxColumn2.HeaderText = "ViewersFilms";
            this.viewersFilmsDataGridViewTextBoxColumn2.Name = "viewersFilmsDataGridViewTextBoxColumn2";
            this.viewersFilmsDataGridViewTextBoxColumn2.Visible = false;
            // 
            // tabActors
            // 
            this.tabActors.Controls.Add(this.chbAddActor);
            this.tabActors.Controls.Add(this.lblAddActorBirth);
            this.tabActors.Controls.Add(this.lblAddActorDeath);
            this.tabActors.Controls.Add(this.nudAddActorDeath);
            this.tabActors.Controls.Add(this.nudAddActorBirth);
            this.tabActors.Controls.Add(this.btnAddActor);
            this.tabActors.Controls.Add(this.txtbAddActorName);
            this.tabActors.Controls.Add(this.lblAddActorName);
            this.tabActors.Controls.Add(this.btnActorEndAdd);
            this.tabActors.Controls.Add(this.btnActorAddNew);
            this.tabActors.Controls.Add(this.btnDeleteActors);
            this.tabActors.Controls.Add(this.dgvActors);
            this.tabActors.Location = new System.Drawing.Point(4, 22);
            this.tabActors.Name = "tabActors";
            this.tabActors.Padding = new System.Windows.Forms.Padding(3);
            this.tabActors.Size = new System.Drawing.Size(752, 310);
            this.tabActors.TabIndex = 8;
            this.tabActors.Text = "Актори";
            this.tabActors.UseVisualStyleBackColor = true;
            // 
            // chbAddActor
            // 
            this.chbAddActor.AutoSize = true;
            this.chbAddActor.Location = new System.Drawing.Point(342, 108);
            this.chbAddActor.Name = "chbAddActor";
            this.chbAddActor.Size = new System.Drawing.Size(77, 17);
            this.chbAddActor.TabIndex = 21;
            this.chbAddActor.Text = "Ще живий";
            this.chbAddActor.UseVisualStyleBackColor = true;
            this.chbAddActor.Visible = false;
            // 
            // lblAddActorBirth
            // 
            this.lblAddActorBirth.AutoSize = true;
            this.lblAddActorBirth.Location = new System.Drawing.Point(69, 83);
            this.lblAddActorBirth.Name = "lblAddActorBirth";
            this.lblAddActorBirth.Size = new System.Drawing.Size(87, 13);
            this.lblAddActorBirth.TabIndex = 20;
            this.lblAddActorBirth.Text = "Рік народження";
            this.lblAddActorBirth.Visible = false;
            // 
            // lblAddActorDeath
            // 
            this.lblAddActorDeath.AutoSize = true;
            this.lblAddActorDeath.Location = new System.Drawing.Point(69, 109);
            this.lblAddActorDeath.Name = "lblAddActorDeath";
            this.lblAddActorDeath.Size = new System.Drawing.Size(58, 13);
            this.lblAddActorDeath.TabIndex = 19;
            this.lblAddActorDeath.Text = "Рік смерті";
            this.lblAddActorDeath.Visible = false;
            // 
            // nudAddActorDeath
            // 
            this.nudAddActorDeath.Location = new System.Drawing.Point(172, 107);
            this.nudAddActorDeath.Name = "nudAddActorDeath";
            this.nudAddActorDeath.Size = new System.Drawing.Size(160, 20);
            this.nudAddActorDeath.TabIndex = 18;
            this.nudAddActorDeath.Visible = false;
            // 
            // nudAddActorBirth
            // 
            this.nudAddActorBirth.Location = new System.Drawing.Point(172, 81);
            this.nudAddActorBirth.Name = "nudAddActorBirth";
            this.nudAddActorBirth.Size = new System.Drawing.Size(160, 20);
            this.nudAddActorBirth.TabIndex = 17;
            this.nudAddActorBirth.Visible = false;
            // 
            // btnAddActor
            // 
            this.btnAddActor.Location = new System.Drawing.Point(172, 145);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(160, 21);
            this.btnAddActor.TabIndex = 7;
            this.btnAddActor.Text = "Додати";
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Visible = false;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // txtbAddActorName
            // 
            this.txtbAddActorName.Location = new System.Drawing.Point(172, 55);
            this.txtbAddActorName.Name = "txtbAddActorName";
            this.txtbAddActorName.Size = new System.Drawing.Size(160, 20);
            this.txtbAddActorName.TabIndex = 6;
            this.txtbAddActorName.Visible = false;
            // 
            // lblAddActorName
            // 
            this.lblAddActorName.AutoSize = true;
            this.lblAddActorName.Location = new System.Drawing.Point(69, 60);
            this.lblAddActorName.Name = "lblAddActorName";
            this.lblAddActorName.Size = new System.Drawing.Size(26, 13);
            this.lblAddActorName.TabIndex = 5;
            this.lblAddActorName.Text = "Ім\'я";
            this.lblAddActorName.Visible = false;
            // 
            // btnActorEndAdd
            // 
            this.btnActorEndAdd.Location = new System.Drawing.Point(338, 6);
            this.btnActorEndAdd.Name = "btnActorEndAdd";
            this.btnActorEndAdd.Size = new System.Drawing.Size(160, 21);
            this.btnActorEndAdd.TabIndex = 4;
            this.btnActorEndAdd.Text = "Таблиця";
            this.btnActorEndAdd.UseVisualStyleBackColor = true;
            this.btnActorEndAdd.Visible = false;
            this.btnActorEndAdd.Click += new System.EventHandler(this.btnActorEndAdd_Click);
            // 
            // btnActorAddNew
            // 
            this.btnActorAddNew.Location = new System.Drawing.Point(172, 6);
            this.btnActorAddNew.Name = "btnActorAddNew";
            this.btnActorAddNew.Size = new System.Drawing.Size(160, 21);
            this.btnActorAddNew.TabIndex = 3;
            this.btnActorAddNew.Text = "Новий актор";
            this.btnActorAddNew.UseVisualStyleBackColor = true;
            this.btnActorAddNew.Click += new System.EventHandler(this.btnActorAddNew_Click);
            // 
            // btnDeleteActors
            // 
            this.btnDeleteActors.Location = new System.Drawing.Point(6, 6);
            this.btnDeleteActors.Name = "btnDeleteActors";
            this.btnDeleteActors.Size = new System.Drawing.Size(160, 21);
            this.btnDeleteActors.TabIndex = 2;
            this.btnDeleteActors.Text = "Видалити";
            this.btnDeleteActors.UseVisualStyleBackColor = true;
            this.btnDeleteActors.Click += new System.EventHandler(this.btnDeleteActors_Click);
            // 
            // dgvActors
            // 
            this.dgvActors.AllowUserToAddRows = false;
            this.dgvActors.AllowUserToDeleteRows = false;
            this.dgvActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActors.AutoGenerateColumns = false;
            this.dgvActors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aidDataGridViewTextBoxColumn1,
            this.aname,
            this.abirth,
            this.adeath,
            this.filmsActorsDataGridViewTextBoxColumn3});
            this.dgvActors.DataSource = this.actorBindingSource;
            this.dgvActors.Location = new System.Drawing.Point(6, 33);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(740, 274);
            this.dgvActors.TabIndex = 1;
            this.dgvActors.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvActors_CellBeginEdit);
            this.dgvActors.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActors_CellEndEdit);
            // 
            // aidDataGridViewTextBoxColumn1
            // 
            this.aidDataGridViewTextBoxColumn1.DataPropertyName = "a_id";
            this.aidDataGridViewTextBoxColumn1.HeaderText = "a_id";
            this.aidDataGridViewTextBoxColumn1.Name = "aidDataGridViewTextBoxColumn1";
            this.aidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aname
            // 
            this.aname.DataPropertyName = "a_name";
            this.aname.HeaderText = "a_name";
            this.aname.Name = "aname";
            // 
            // abirth
            // 
            this.abirth.DataPropertyName = "a_birth";
            this.abirth.HeaderText = "a_birth";
            this.abirth.Name = "abirth";
            // 
            // adeath
            // 
            this.adeath.DataPropertyName = "a_death";
            this.adeath.HeaderText = "a_death";
            this.adeath.Name = "adeath";
            // 
            // filmsActorsDataGridViewTextBoxColumn3
            // 
            this.filmsActorsDataGridViewTextBoxColumn3.DataPropertyName = "FilmsActors";
            this.filmsActorsDataGridViewTextBoxColumn3.HeaderText = "FilmsActors";
            this.filmsActorsDataGridViewTextBoxColumn3.Name = "filmsActorsDataGridViewTextBoxColumn3";
            this.filmsActorsDataGridViewTextBoxColumn3.Visible = false;
            // 
            // tabProducers
            // 
            this.tabProducers.Controls.Add(this.chbAddProducer);
            this.tabProducers.Controls.Add(this.lblAddProducerBirth);
            this.tabProducers.Controls.Add(this.lblAddProducerDeath);
            this.tabProducers.Controls.Add(this.nudAddProducerDeath);
            this.tabProducers.Controls.Add(this.nudAddProducerBirth);
            this.tabProducers.Controls.Add(this.btnProducerEndAdd);
            this.tabProducers.Controls.Add(this.txtbAddProducerName);
            this.tabProducers.Controls.Add(this.btnAddProducer);
            this.tabProducers.Controls.Add(this.btnProducerAddNew);
            this.tabProducers.Controls.Add(this.lblAddProducerName);
            this.tabProducers.Controls.Add(this.btnDeleteProducer);
            this.tabProducers.Controls.Add(this.dgvProducers);
            this.tabProducers.Location = new System.Drawing.Point(4, 22);
            this.tabProducers.Name = "tabProducers";
            this.tabProducers.Size = new System.Drawing.Size(752, 310);
            this.tabProducers.TabIndex = 3;
            this.tabProducers.Text = "Режисери";
            this.tabProducers.UseVisualStyleBackColor = true;
            // 
            // chbAddProducer
            // 
            this.chbAddProducer.AutoSize = true;
            this.chbAddProducer.Location = new System.Drawing.Point(342, 108);
            this.chbAddProducer.Name = "chbAddProducer";
            this.chbAddProducer.Size = new System.Drawing.Size(77, 17);
            this.chbAddProducer.TabIndex = 16;
            this.chbAddProducer.Text = "Ще живий";
            this.chbAddProducer.UseVisualStyleBackColor = true;
            this.chbAddProducer.Visible = false;
            // 
            // lblAddProducerBirth
            // 
            this.lblAddProducerBirth.AutoSize = true;
            this.lblAddProducerBirth.Location = new System.Drawing.Point(69, 83);
            this.lblAddProducerBirth.Name = "lblAddProducerBirth";
            this.lblAddProducerBirth.Size = new System.Drawing.Size(87, 13);
            this.lblAddProducerBirth.TabIndex = 15;
            this.lblAddProducerBirth.Text = "Рік народження";
            this.lblAddProducerBirth.Visible = false;
            // 
            // lblAddProducerDeath
            // 
            this.lblAddProducerDeath.AutoSize = true;
            this.lblAddProducerDeath.Location = new System.Drawing.Point(69, 109);
            this.lblAddProducerDeath.Name = "lblAddProducerDeath";
            this.lblAddProducerDeath.Size = new System.Drawing.Size(58, 13);
            this.lblAddProducerDeath.TabIndex = 14;
            this.lblAddProducerDeath.Text = "Рік смерті";
            this.lblAddProducerDeath.Visible = false;
            // 
            // nudAddProducerDeath
            // 
            this.nudAddProducerDeath.Location = new System.Drawing.Point(172, 107);
            this.nudAddProducerDeath.Name = "nudAddProducerDeath";
            this.nudAddProducerDeath.Size = new System.Drawing.Size(160, 20);
            this.nudAddProducerDeath.TabIndex = 13;
            this.nudAddProducerDeath.Visible = false;
            // 
            // nudAddProducerBirth
            // 
            this.nudAddProducerBirth.Location = new System.Drawing.Point(172, 81);
            this.nudAddProducerBirth.Name = "nudAddProducerBirth";
            this.nudAddProducerBirth.Size = new System.Drawing.Size(160, 20);
            this.nudAddProducerBirth.TabIndex = 12;
            this.nudAddProducerBirth.Visible = false;
            // 
            // btnProducerEndAdd
            // 
            this.btnProducerEndAdd.Location = new System.Drawing.Point(338, 6);
            this.btnProducerEndAdd.Name = "btnProducerEndAdd";
            this.btnProducerEndAdd.Size = new System.Drawing.Size(160, 21);
            this.btnProducerEndAdd.TabIndex = 11;
            this.btnProducerEndAdd.Text = "Таблиця";
            this.btnProducerEndAdd.UseVisualStyleBackColor = true;
            this.btnProducerEndAdd.Visible = false;
            this.btnProducerEndAdd.Click += new System.EventHandler(this.btnProducerEndAdd_Click);
            // 
            // txtbAddProducerName
            // 
            this.txtbAddProducerName.Location = new System.Drawing.Point(172, 55);
            this.txtbAddProducerName.Name = "txtbAddProducerName";
            this.txtbAddProducerName.Size = new System.Drawing.Size(160, 20);
            this.txtbAddProducerName.TabIndex = 10;
            this.txtbAddProducerName.Visible = false;
            // 
            // btnAddProducer
            // 
            this.btnAddProducer.Location = new System.Drawing.Point(172, 145);
            this.btnAddProducer.Name = "btnAddProducer";
            this.btnAddProducer.Size = new System.Drawing.Size(160, 21);
            this.btnAddProducer.TabIndex = 9;
            this.btnAddProducer.Text = "Додати";
            this.btnAddProducer.UseVisualStyleBackColor = true;
            this.btnAddProducer.Visible = false;
            this.btnAddProducer.Click += new System.EventHandler(this.btnAddProducer_Click);
            // 
            // btnProducerAddNew
            // 
            this.btnProducerAddNew.Location = new System.Drawing.Point(172, 6);
            this.btnProducerAddNew.Name = "btnProducerAddNew";
            this.btnProducerAddNew.Size = new System.Drawing.Size(160, 21);
            this.btnProducerAddNew.TabIndex = 8;
            this.btnProducerAddNew.Text = "Новий режисер";
            this.btnProducerAddNew.UseVisualStyleBackColor = true;
            this.btnProducerAddNew.Click += new System.EventHandler(this.btnProducerAddNew_Click);
            // 
            // lblAddProducerName
            // 
            this.lblAddProducerName.AutoSize = true;
            this.lblAddProducerName.Location = new System.Drawing.Point(69, 60);
            this.lblAddProducerName.Name = "lblAddProducerName";
            this.lblAddProducerName.Size = new System.Drawing.Size(26, 13);
            this.lblAddProducerName.TabIndex = 7;
            this.lblAddProducerName.Text = "Ім\'я";
            this.lblAddProducerName.Visible = false;
            // 
            // btnDeleteProducer
            // 
            this.btnDeleteProducer.Location = new System.Drawing.Point(6, 6);
            this.btnDeleteProducer.Name = "btnDeleteProducer";
            this.btnDeleteProducer.Size = new System.Drawing.Size(160, 21);
            this.btnDeleteProducer.TabIndex = 2;
            this.btnDeleteProducer.Text = "Видалити";
            this.btnDeleteProducer.UseVisualStyleBackColor = true;
            this.btnDeleteProducer.Click += new System.EventHandler(this.btnDeleteProducer_Click);
            // 
            // dgvProducers
            // 
            this.dgvProducers.AllowUserToAddRows = false;
            this.dgvProducers.AllowUserToDeleteRows = false;
            this.dgvProducers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducers.AutoGenerateColumns = false;
            this.dgvProducers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn1,
            this.pname,
            this.pbirth,
            this.pdeath,
            this.filmsDataGridViewTextBoxColumn1});
            this.dgvProducers.DataSource = this.producerBindingSource;
            this.dgvProducers.Location = new System.Drawing.Point(6, 33);
            this.dgvProducers.Name = "dgvProducers";
            this.dgvProducers.Size = new System.Drawing.Size(740, 274);
            this.dgvProducers.TabIndex = 0;
            this.dgvProducers.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvProducers_CellBeginEdit);
            this.dgvProducers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducers_CellEndEdit);
            // 
            // pidDataGridViewTextBoxColumn1
            // 
            this.pidDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pidDataGridViewTextBoxColumn1.DataPropertyName = "p_id";
            this.pidDataGridViewTextBoxColumn1.HeaderText = "d_id";
            this.pidDataGridViewTextBoxColumn1.Name = "pidDataGridViewTextBoxColumn1";
            this.pidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pidDataGridViewTextBoxColumn1.Width = 52;
            // 
            // pname
            // 
            this.pname.DataPropertyName = "p_name";
            this.pname.HeaderText = "d_name";
            this.pname.Name = "pname";
            // 
            // pbirth
            // 
            this.pbirth.DataPropertyName = "p_birth";
            this.pbirth.HeaderText = "d_birth";
            this.pbirth.Name = "pbirth";
            // 
            // pdeath
            // 
            this.pdeath.DataPropertyName = "p_death";
            this.pdeath.HeaderText = "d_death";
            this.pdeath.Name = "pdeath";
            // 
            // filmsDataGridViewTextBoxColumn1
            // 
            this.filmsDataGridViewTextBoxColumn1.DataPropertyName = "Films";
            this.filmsDataGridViewTextBoxColumn1.HeaderText = "Films";
            this.filmsDataGridViewTextBoxColumn1.Name = "filmsDataGridViewTextBoxColumn1";
            this.filmsDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tabGenres
            // 
            this.tabGenres.Controls.Add(this.btnGenresEndAdd);
            this.tabGenres.Controls.Add(this.txtbAddGenre);
            this.tabGenres.Controls.Add(this.btnAddGenre);
            this.tabGenres.Controls.Add(this.btnGenreAddNew);
            this.tabGenres.Controls.Add(this.lblAddGenre);
            this.tabGenres.Controls.Add(this.btnDeleteGenres);
            this.tabGenres.Controls.Add(this.dgvGenres);
            this.tabGenres.Location = new System.Drawing.Point(4, 22);
            this.tabGenres.Name = "tabGenres";
            this.tabGenres.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenres.Size = new System.Drawing.Size(752, 310);
            this.tabGenres.TabIndex = 2;
            this.tabGenres.Text = "Жанри";
            this.tabGenres.UseVisualStyleBackColor = true;
            // 
            // btnGenresEndAdd
            // 
            this.btnGenresEndAdd.Location = new System.Drawing.Point(338, 6);
            this.btnGenresEndAdd.Name = "btnGenresEndAdd";
            this.btnGenresEndAdd.Size = new System.Drawing.Size(160, 21);
            this.btnGenresEndAdd.TabIndex = 7;
            this.btnGenresEndAdd.Text = "Таблиця";
            this.btnGenresEndAdd.UseVisualStyleBackColor = true;
            this.btnGenresEndAdd.Visible = false;
            this.btnGenresEndAdd.Click += new System.EventHandler(this.btnGenresEndAdd_Click);
            // 
            // txtbAddGenre
            // 
            this.txtbAddGenre.Location = new System.Drawing.Point(172, 55);
            this.txtbAddGenre.Name = "txtbAddGenre";
            this.txtbAddGenre.Size = new System.Drawing.Size(160, 20);
            this.txtbAddGenre.TabIndex = 6;
            this.txtbAddGenre.Visible = false;
            this.txtbAddGenre.TextChanged += new System.EventHandler(this.txtbAddGenre_TextChanged);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(172, 103);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(160, 21);
            this.btnAddGenre.TabIndex = 5;
            this.btnAddGenre.Text = "Додати";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Visible = false;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnGenreAddNew
            // 
            this.btnGenreAddNew.Location = new System.Drawing.Point(172, 6);
            this.btnGenreAddNew.Name = "btnGenreAddNew";
            this.btnGenreAddNew.Size = new System.Drawing.Size(160, 21);
            this.btnGenreAddNew.TabIndex = 4;
            this.btnGenreAddNew.Text = "Новий жанр";
            this.btnGenreAddNew.UseVisualStyleBackColor = true;
            this.btnGenreAddNew.Click += new System.EventHandler(this.btnGenreAddNew_Click);
            // 
            // lblAddGenre
            // 
            this.lblAddGenre.AutoSize = true;
            this.lblAddGenre.Location = new System.Drawing.Point(69, 60);
            this.lblAddGenre.Name = "lblAddGenre";
            this.lblAddGenre.Size = new System.Drawing.Size(73, 13);
            this.lblAddGenre.TabIndex = 3;
            this.lblAddGenre.Text = "Назва жанру";
            this.lblAddGenre.Visible = false;
            this.lblAddGenre.Click += new System.EventHandler(this.lblAddGenre_Click);
            // 
            // btnDeleteGenres
            // 
            this.btnDeleteGenres.Location = new System.Drawing.Point(6, 6);
            this.btnDeleteGenres.Name = "btnDeleteGenres";
            this.btnDeleteGenres.Size = new System.Drawing.Size(160, 21);
            this.btnDeleteGenres.TabIndex = 2;
            this.btnDeleteGenres.Text = "Видалити";
            this.btnDeleteGenres.UseVisualStyleBackColor = true;
            this.btnDeleteGenres.Click += new System.EventHandler(this.btnDeleteGenres_Click);
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGenres.AutoGenerateColumns = false;
            this.dgvGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gidDataGridViewTextBoxColumn1,
            this.gname,
            this.filmsGenresDataGridViewTextBoxColumn2});
            this.dgvGenres.DataSource = this.genreBindingSource;
            this.dgvGenres.Location = new System.Drawing.Point(6, 33);
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.Size = new System.Drawing.Size(740, 274);
            this.dgvGenres.TabIndex = 0;
            this.dgvGenres.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvGenres_CellBeginEdit);
            this.dgvGenres.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenres_CellEndEdit);
            // 
            // gidDataGridViewTextBoxColumn1
            // 
            this.gidDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gidDataGridViewTextBoxColumn1.DataPropertyName = "g_id";
            this.gidDataGridViewTextBoxColumn1.HeaderText = "g_id";
            this.gidDataGridViewTextBoxColumn1.Name = "gidDataGridViewTextBoxColumn1";
            this.gidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.gidDataGridViewTextBoxColumn1.Width = 52;
            // 
            // gname
            // 
            this.gname.DataPropertyName = "g_name";
            this.gname.HeaderText = "g_name";
            this.gname.Name = "gname";
            // 
            // filmsGenresDataGridViewTextBoxColumn2
            // 
            this.filmsGenresDataGridViewTextBoxColumn2.DataPropertyName = "FilmsGenres";
            this.filmsGenresDataGridViewTextBoxColumn2.HeaderText = "FilmsGenres";
            this.filmsGenresDataGridViewTextBoxColumn2.Name = "filmsGenresDataGridViewTextBoxColumn2";
            this.filmsGenresDataGridViewTextBoxColumn2.Visible = false;
            // 
            // tabFilms
            // 
            this.tabFilms.Controls.Add(this.chbEditFilmProducer);
            this.tabFilms.Controls.Add(this.rtbEditFilmProducer);
            this.tabFilms.Controls.Add(this.btnEditFilmDeleteActor);
            this.tabFilms.Controls.Add(this.lblEditFilmProducer);
            this.tabFilms.Controls.Add(this.cmbEditFilmProducer);
            this.tabFilms.Controls.Add(this.btnEditFilmDeleteGenre);
            this.tabFilms.Controls.Add(this.cmbEditFilmId);
            this.tabFilms.Controls.Add(this.lblEditFilmId);
            this.tabFilms.Controls.Add(this.btnAddFilmDeleteActor);
            this.tabFilms.Controls.Add(this.btnEditFilmStart);
            this.tabFilms.Controls.Add(this.cmbEditFilmYear);
            this.tabFilms.Controls.Add(this.btnAddFilmDeleteGenre);
            this.tabFilms.Controls.Add(this.cmbEditFilmName);
            this.tabFilms.Controls.Add(this.lblEditFilmsYear);
            this.tabFilms.Controls.Add(this.nudAddFilmYear);
            this.tabFilms.Controls.Add(this.lblEditFilmsName);
            this.tabFilms.Controls.Add(this.btnEditFilmClear);
            this.tabFilms.Controls.Add(this.btnEditFilmsAddActor);
            this.tabFilms.Controls.Add(this.btnEditFilmsAddGenre);
            this.tabFilms.Controls.Add(this.cmbEditFilmChooseGenres);
            this.tabFilms.Controls.Add(this.btnEditFilmEdit);
            this.tabFilms.Controls.Add(this.cmbEditFilmActor);
            this.tabFilms.Controls.Add(this.cmbEditFilmChooseActors);
            this.tabFilms.Controls.Add(this.cmbEditFilmsGenre);
            this.tabFilms.Controls.Add(this.btnFilmEndAdd);
            this.tabFilms.Controls.Add(this.lblAddFilmProducer);
            this.tabFilms.Controls.Add(this.dgvFilms);
            this.tabFilms.Controls.Add(this.btnFilmsAddNew);
            this.tabFilms.Controls.Add(this.btnDeleteFilms);
            this.tabFilms.Controls.Add(this.lblAddFilmYear);
            this.tabFilms.Controls.Add(this.txtbAddFilmName);
            this.tabFilms.Controls.Add(this.cmbAddFilmActors);
            this.tabFilms.Controls.Add(this.lblAddFilmName);
            this.tabFilms.Controls.Add(this.cmbAddFilmGenres);
            this.tabFilms.Controls.Add(this.cmbAddFilmSelectedActors);
            this.tabFilms.Controls.Add(this.btnAddFilmClear);
            this.tabFilms.Controls.Add(this.cmbAddFilmSelectedGenres);
            this.tabFilms.Controls.Add(this.cmbAddFilmProducer);
            this.tabFilms.Controls.Add(this.btnAddFilm);
            this.tabFilms.Controls.Add(this.btnAddFilmSelectGenre);
            this.tabFilms.Controls.Add(this.btnAddFilmSelectActor);
            this.tabFilms.Location = new System.Drawing.Point(4, 22);
            this.tabFilms.Name = "tabFilms";
            this.tabFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilms.Size = new System.Drawing.Size(752, 310);
            this.tabFilms.TabIndex = 1;
            this.tabFilms.Text = "Фільми";
            this.tabFilms.UseVisualStyleBackColor = true;
            this.tabFilms.UseWaitCursor = true;
            // 
            // chbEditFilmProducer
            // 
            this.chbEditFilmProducer.AutoSize = true;
            this.chbEditFilmProducer.Location = new System.Drawing.Point(504, 134);
            this.chbEditFilmProducer.Name = "chbEditFilmProducer";
            this.chbEditFilmProducer.Size = new System.Drawing.Size(119, 17);
            this.chbEditFilmProducer.TabIndex = 43;
            this.chbEditFilmProducer.Text = "Змінити режисера";
            this.chbEditFilmProducer.UseVisualStyleBackColor = true;
            this.chbEditFilmProducer.UseWaitCursor = true;
            this.chbEditFilmProducer.Visible = false;
            // 
            // rtbEditFilmProducer
            // 
            this.rtbEditFilmProducer.Location = new System.Drawing.Point(172, 130);
            this.rtbEditFilmProducer.Name = "rtbEditFilmProducer";
            this.rtbEditFilmProducer.ReadOnly = true;
            this.rtbEditFilmProducer.Size = new System.Drawing.Size(160, 21);
            this.rtbEditFilmProducer.TabIndex = 42;
            this.rtbEditFilmProducer.Text = "";
            this.rtbEditFilmProducer.UseWaitCursor = true;
            this.rtbEditFilmProducer.Visible = false;
            // 
            // btnEditFilmDeleteActor
            // 
            this.btnEditFilmDeleteActor.Location = new System.Drawing.Point(504, 182);
            this.btnEditFilmDeleteActor.Name = "btnEditFilmDeleteActor";
            this.btnEditFilmDeleteActor.Size = new System.Drawing.Size(160, 21);
            this.btnEditFilmDeleteActor.TabIndex = 41;
            this.btnEditFilmDeleteActor.Text = "Видалити актора";
            this.btnEditFilmDeleteActor.UseVisualStyleBackColor = true;
            this.btnEditFilmDeleteActor.UseWaitCursor = true;
            this.btnEditFilmDeleteActor.Visible = false;
            this.btnEditFilmDeleteActor.Click += new System.EventHandler(this.btnEditFilmDeleteActor_Click);
            // 
            // lblEditFilmProducer
            // 
            this.lblEditFilmProducer.AutoSize = true;
            this.lblEditFilmProducer.Location = new System.Drawing.Point(47, 132);
            this.lblEditFilmProducer.Name = "lblEditFilmProducer";
            this.lblEditFilmProducer.Size = new System.Drawing.Size(52, 13);
            this.lblEditFilmProducer.TabIndex = 41;
            this.lblEditFilmProducer.Text = "Режисер";
            this.lblEditFilmProducer.UseWaitCursor = true;
            this.lblEditFilmProducer.Visible = false;
            // 
            // cmbEditFilmProducer
            // 
            this.cmbEditFilmProducer.DataSource = this.producerBindingSource;
            this.cmbEditFilmProducer.DisplayMember = "p_name";
            this.cmbEditFilmProducer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditFilmProducer.FormattingEnabled = true;
            this.cmbEditFilmProducer.Location = new System.Drawing.Point(338, 132);
            this.cmbEditFilmProducer.Name = "cmbEditFilmProducer";
            this.cmbEditFilmProducer.Size = new System.Drawing.Size(160, 21);
            this.cmbEditFilmProducer.TabIndex = 40;
            this.cmbEditFilmProducer.UseWaitCursor = true;
            this.cmbEditFilmProducer.Visible = false;
            // 
            // btnEditFilmDeleteGenre
            // 
            this.btnEditFilmDeleteGenre.Location = new System.Drawing.Point(504, 157);
            this.btnEditFilmDeleteGenre.Name = "btnEditFilmDeleteGenre";
            this.btnEditFilmDeleteGenre.Size = new System.Drawing.Size(160, 21);
            this.btnEditFilmDeleteGenre.TabIndex = 40;
            this.btnEditFilmDeleteGenre.Text = "Видалити жанр";
            this.btnEditFilmDeleteGenre.UseVisualStyleBackColor = true;
            this.btnEditFilmDeleteGenre.UseWaitCursor = true;
            this.btnEditFilmDeleteGenre.Visible = false;
            this.btnEditFilmDeleteGenre.Click += new System.EventHandler(this.btnEditFilmDeleteGenre_Click);
            // 
            // cmbEditFilmId
            // 
            this.cmbEditFilmId.DataSource = this.filmBindingSource;
            this.cmbEditFilmId.DisplayMember = "f_id";
            this.cmbEditFilmId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditFilmId.FormattingEnabled = true;
            this.cmbEditFilmId.Location = new System.Drawing.Point(172, 51);
            this.cmbEditFilmId.Name = "cmbEditFilmId";
            this.cmbEditFilmId.Size = new System.Drawing.Size(160, 21);
            this.cmbEditFilmId.TabIndex = 39;
            this.cmbEditFilmId.UseWaitCursor = true;
            this.cmbEditFilmId.Visible = false;
            this.cmbEditFilmId.SelectedValueChanged += new System.EventHandler(this.cmbEditFilmId_SelectedValueChanged);
            // 
            // lblEditFilmId
            // 
            this.lblEditFilmId.AutoSize = true;
            this.lblEditFilmId.Location = new System.Drawing.Point(47, 54);
            this.lblEditFilmId.Name = "lblEditFilmId";
            this.lblEditFilmId.Size = new System.Drawing.Size(18, 13);
            this.lblEditFilmId.TabIndex = 38;
            this.lblEditFilmId.Text = "ID";
            this.lblEditFilmId.UseWaitCursor = true;
            this.lblEditFilmId.Visible = false;
            // 
            // btnAddFilmDeleteActor
            // 
            this.btnAddFilmDeleteActor.Location = new System.Drawing.Point(504, 183);
            this.btnAddFilmDeleteActor.Name = "btnAddFilmDeleteActor";
            this.btnAddFilmDeleteActor.Size = new System.Drawing.Size(160, 21);
            this.btnAddFilmDeleteActor.TabIndex = 37;
            this.btnAddFilmDeleteActor.Text = "Видалити актора";
            this.btnAddFilmDeleteActor.UseVisualStyleBackColor = true;
            this.btnAddFilmDeleteActor.UseWaitCursor = true;
            this.btnAddFilmDeleteActor.Visible = false;
            this.btnAddFilmDeleteActor.Click += new System.EventHandler(this.btnAddFilmDeleteActor_Click);
            // 
            // btnEditFilmStart
            // 
            this.btnEditFilmStart.Location = new System.Drawing.Point(338, 6);
            this.btnEditFilmStart.Name = "btnEditFilmStart";
            this.btnEditFilmStart.Size = new System.Drawing.Size(160, 21);
            this.btnEditFilmStart.TabIndex = 34;
            this.btnEditFilmStart.Text = "Редагувати";
            this.btnEditFilmStart.UseVisualStyleBackColor = true;
            this.btnEditFilmStart.UseWaitCursor = true;
            this.btnEditFilmStart.Click += new System.EventHandler(this.btnEditFilmStart_Click);
            // 
            // cmbEditFilmYear
            // 
            this.cmbEditFilmYear.DataSource = this.filmBindingSource;
            this.cmbEditFilmYear.DisplayMember = "f_year";
            this.cmbEditFilmYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditFilmYear.FormattingEnabled = true;
            this.cmbEditFilmYear.Location = new System.Drawing.Point(172, 105);
            this.cmbEditFilmYear.Name = "cmbEditFilmYear";
            this.cmbEditFilmYear.Size = new System.Drawing.Size(160, 21);
            this.cmbEditFilmYear.TabIndex = 33;
            this.cmbEditFilmYear.UseWaitCursor = true;
            this.cmbEditFilmYear.Visible = false;
            this.cmbEditFilmYear.SelectedValueChanged += new System.EventHandler(this.cmbEditFilmYear_SelectedValueChanged);
            // 
            // btnAddFilmDeleteGenre
            // 
            this.btnAddFilmDeleteGenre.Location = new System.Drawing.Point(504, 157);
            this.btnAddFilmDeleteGenre.Name = "btnAddFilmDeleteGenre";
            this.btnAddFilmDeleteGenre.Size = new System.Drawing.Size(160, 21);
            this.btnAddFilmDeleteGenre.TabIndex = 36;
            this.btnAddFilmDeleteGenre.Text = "Видалити жанр";
            this.btnAddFilmDeleteGenre.UseVisualStyleBackColor = true;
            this.btnAddFilmDeleteGenre.UseWaitCursor = true;
            this.btnAddFilmDeleteGenre.Visible = false;
            this.btnAddFilmDeleteGenre.Click += new System.EventHandler(this.btnAddFilmDeleteGenre_Click);
            // 
            // cmbEditFilmName
            // 
            this.cmbEditFilmName.DataSource = this.filmBindingSource;
            this.cmbEditFilmName.DisplayMember = "d_name";
            this.cmbEditFilmName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditFilmName.FormattingEnabled = true;
            this.cmbEditFilmName.Location = new System.Drawing.Point(172, 78);
            this.cmbEditFilmName.Name = "cmbEditFilmName";
            this.cmbEditFilmName.Size = new System.Drawing.Size(160, 21);
            this.cmbEditFilmName.TabIndex = 32;
            this.cmbEditFilmName.UseWaitCursor = true;
            this.cmbEditFilmName.Visible = false;
            this.cmbEditFilmName.SelectedValueChanged += new System.EventHandler(this.cmbEditFilmName_SelectedValueChanged);
            // 
            // lblEditFilmsYear
            // 
            this.lblEditFilmsYear.AutoSize = true;
            this.lblEditFilmsYear.Location = new System.Drawing.Point(47, 106);
            this.lblEditFilmsYear.Name = "lblEditFilmsYear";
            this.lblEditFilmsYear.Size = new System.Drawing.Size(22, 13);
            this.lblEditFilmsYear.TabIndex = 31;
            this.lblEditFilmsYear.Text = "Рік";
            this.lblEditFilmsYear.UseWaitCursor = true;
            this.lblEditFilmsYear.Visible = false;
            // 
            // nudAddFilmYear
            // 
            this.nudAddFilmYear.Location = new System.Drawing.Point(172, 104);
            this.nudAddFilmYear.Name = "nudAddFilmYear";
            this.nudAddFilmYear.Size = new System.Drawing.Size(160, 20);
            this.nudAddFilmYear.TabIndex = 35;
            this.nudAddFilmYear.UseWaitCursor = true;
            this.nudAddFilmYear.Visible = false;
            // 
            // lblEditFilmsName
            // 
            this.lblEditFilmsName.AutoSize = true;
            this.lblEditFilmsName.Location = new System.Drawing.Point(47, 81);
            this.lblEditFilmsName.Name = "lblEditFilmsName";
            this.lblEditFilmsName.Size = new System.Drawing.Size(39, 13);
            this.lblEditFilmsName.TabIndex = 30;
            this.lblEditFilmsName.Text = "Назва";
            this.lblEditFilmsName.UseWaitCursor = true;
            this.lblEditFilmsName.Visible = false;
            // 
            // btnEditFilmClear
            // 
            this.btnEditFilmClear.Location = new System.Drawing.Point(338, 210);
            this.btnEditFilmClear.Name = "btnEditFilmClear";
            this.btnEditFilmClear.Size = new System.Drawing.Size(160, 21);
            this.btnEditFilmClear.TabIndex = 29;
            this.btnEditFilmClear.Text = "Очистити";
            this.btnEditFilmClear.UseVisualStyleBackColor = true;
            this.btnEditFilmClear.UseWaitCursor = true;
            this.btnEditFilmClear.Visible = false;
            this.btnEditFilmClear.Click += new System.EventHandler(this.btnEditFilmClear_Click);
            // 
            // btnEditFilmsAddActor
            // 
            this.btnEditFilmsAddActor.Location = new System.Drawing.Point(8, 184);
            this.btnEditFilmsAddActor.Name = "btnEditFilmsAddActor";
            this.btnEditFilmsAddActor.Size = new System.Drawing.Size(160, 21);
            this.btnEditFilmsAddActor.TabIndex = 28;
            this.btnEditFilmsAddActor.Text = "Вибрати актора";
            this.btnEditFilmsAddActor.UseVisualStyleBackColor = true;
            this.btnEditFilmsAddActor.UseWaitCursor = true;
            this.btnEditFilmsAddActor.Visible = false;
            this.btnEditFilmsAddActor.Click += new System.EventHandler(this.btnEditFilmsAddActor_Click);
            // 
            // btnEditFilmsAddGenre
            // 
            this.btnEditFilmsAddGenre.Location = new System.Drawing.Point(6, 157);
            this.btnEditFilmsAddGenre.Name = "btnEditFilmsAddGenre";
            this.btnEditFilmsAddGenre.Size = new System.Drawing.Size(160, 21);
            this.btnEditFilmsAddGenre.TabIndex = 27;
            this.btnEditFilmsAddGenre.Text = "Вибрати жанр";
            this.btnEditFilmsAddGenre.UseVisualStyleBackColor = true;
            this.btnEditFilmsAddGenre.UseWaitCursor = true;
            this.btnEditFilmsAddGenre.Visible = false;
            this.btnEditFilmsAddGenre.Click += new System.EventHandler(this.btnEditFilmsAddGenre_Click);
            // 
            // cmbEditFilmChooseGenres
            // 
            this.cmbEditFilmChooseGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditFilmChooseGenres.FormattingEnabled = true;
            this.cmbEditFilmChooseGenres.Location = new System.Drawing.Point(338, 157);
            this.cmbEditFilmChooseGenres.Name = "cmbEditFilmChooseGenres";
            this.cmbEditFilmChooseGenres.Size = new System.Drawing.Size(160, 21);
            this.cmbEditFilmChooseGenres.TabIndex = 22;
            this.cmbEditFilmChooseGenres.UseWaitCursor = true;
            this.cmbEditFilmChooseGenres.Visible = false;
            // 
            // btnEditFilmEdit
            // 
            this.btnEditFilmEdit.Location = new System.Drawing.Point(172, 210);
            this.btnEditFilmEdit.Name = "btnEditFilmEdit";
            this.btnEditFilmEdit.Size = new System.Drawing.Size(160, 21);
            this.btnEditFilmEdit.TabIndex = 26;
            this.btnEditFilmEdit.Text = "Редагувати";
            this.btnEditFilmEdit.UseVisualStyleBackColor = true;
            this.btnEditFilmEdit.UseWaitCursor = true;
            this.btnEditFilmEdit.Visible = false;
            this.btnEditFilmEdit.Click += new System.EventHandler(this.btnEditFilmEdit_Click);
            // 
            // cmbEditFilmActor
            // 
            this.cmbEditFilmActor.DataSource = this.actorBindingSource;
            this.cmbEditFilmActor.DisplayMember = "a_name";
            this.cmbEditFilmActor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditFilmActor.FormattingEnabled = true;
            this.cmbEditFilmActor.Location = new System.Drawing.Point(172, 183);
            this.cmbEditFilmActor.Name = "cmbEditFilmActor";
            this.cmbEditFilmActor.Size = new System.Drawing.Size(160, 21);
            this.cmbEditFilmActor.TabIndex = 23;
            this.cmbEditFilmActor.UseWaitCursor = true;
            this.cmbEditFilmActor.Visible = false;
            // 
            // cmbEditFilmChooseActors
            // 
            this.cmbEditFilmChooseActors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditFilmChooseActors.FormattingEnabled = true;
            this.cmbEditFilmChooseActors.Location = new System.Drawing.Point(338, 183);
            this.cmbEditFilmChooseActors.Name = "cmbEditFilmChooseActors";
            this.cmbEditFilmChooseActors.Size = new System.Drawing.Size(160, 21);
            this.cmbEditFilmChooseActors.TabIndex = 24;
            this.cmbEditFilmChooseActors.UseWaitCursor = true;
            this.cmbEditFilmChooseActors.Visible = false;
            // 
            // cmbEditFilmsGenre
            // 
            this.cmbEditFilmsGenre.DataSource = this.genreBindingSource;
            this.cmbEditFilmsGenre.DisplayMember = "g_name";
            this.cmbEditFilmsGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditFilmsGenre.FormattingEnabled = true;
            this.cmbEditFilmsGenre.Location = new System.Drawing.Point(172, 157);
            this.cmbEditFilmsGenre.Name = "cmbEditFilmsGenre";
            this.cmbEditFilmsGenre.Size = new System.Drawing.Size(160, 21);
            this.cmbEditFilmsGenre.TabIndex = 21;
            this.cmbEditFilmsGenre.UseWaitCursor = true;
            this.cmbEditFilmsGenre.Visible = false;
            // 
            // btnFilmEndAdd
            // 
            this.btnFilmEndAdd.Location = new System.Drawing.Point(6, 6);
            this.btnFilmEndAdd.Name = "btnFilmEndAdd";
            this.btnFilmEndAdd.Size = new System.Drawing.Size(160, 21);
            this.btnFilmEndAdd.TabIndex = 18;
            this.btnFilmEndAdd.Text = "Таблиця";
            this.btnFilmEndAdd.UseVisualStyleBackColor = true;
            this.btnFilmEndAdd.UseWaitCursor = true;
            this.btnFilmEndAdd.Visible = false;
            this.btnFilmEndAdd.Click += new System.EventHandler(this.btnFilmEndAdd_Click);
            // 
            // lblAddFilmProducer
            // 
            this.lblAddFilmProducer.AutoSize = true;
            this.lblAddFilmProducer.Location = new System.Drawing.Point(47, 132);
            this.lblAddFilmProducer.Name = "lblAddFilmProducer";
            this.lblAddFilmProducer.Size = new System.Drawing.Size(52, 13);
            this.lblAddFilmProducer.TabIndex = 17;
            this.lblAddFilmProducer.Text = "Режисер";
            this.lblAddFilmProducer.UseWaitCursor = true;
            this.lblAddFilmProducer.Visible = false;
            // 
            // dgvFilms
            // 
            this.dgvFilms.AllowUserToAddRows = false;
            this.dgvFilms.AllowUserToDeleteRows = false;
            this.dgvFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilms.AutoGenerateColumns = false;
            this.dgvFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ffid,
            this.fdname,
            this.ffyear,
            this.ffproducer,
            this.producerDataGridViewTextBoxColumn1,
            this.filmsActorsDataGridViewTextBoxColumn2,
            this.filmsGenresDataGridViewTextBoxColumn3,
            this.viewersFilmsDataGridViewTextBoxColumn1});
            this.dgvFilms.DataSource = this.filmBindingSource;
            this.dgvFilms.Location = new System.Drawing.Point(6, 33);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.Size = new System.Drawing.Size(740, 274);
            this.dgvFilms.TabIndex = 0;
            this.dgvFilms.UseWaitCursor = true;
            this.dgvFilms.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvFilms_CellBeginEdit);
            this.dgvFilms.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilms_CellEndEdit);
            this.dgvFilms.DoubleClick += new System.EventHandler(this.dgvFilms_DoubleClick);
            // 
            // ffid
            // 
            this.ffid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ffid.DataPropertyName = "f_id";
            this.ffid.HeaderText = "f_id";
            this.ffid.Name = "ffid";
            this.ffid.ReadOnly = true;
            this.ffid.Width = 49;
            // 
            // fdname
            // 
            this.fdname.DataPropertyName = "d_name";
            this.fdname.HeaderText = "f_name";
            this.fdname.Name = "fdname";
            // 
            // ffyear
            // 
            this.ffyear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ffyear.DataPropertyName = "f_year";
            this.ffyear.HeaderText = "f_year";
            this.ffyear.Name = "ffyear";
            this.ffyear.Width = 61;
            // 
            // ffproducer
            // 
            this.ffproducer.DataPropertyName = "f_producer";
            this.ffproducer.HeaderText = "f_director";
            this.ffproducer.Name = "ffproducer";
            this.ffproducer.ReadOnly = true;
            // 
            // producerDataGridViewTextBoxColumn1
            // 
            this.producerDataGridViewTextBoxColumn1.DataPropertyName = "Producer";
            this.producerDataGridViewTextBoxColumn1.HeaderText = "Producer";
            this.producerDataGridViewTextBoxColumn1.Name = "producerDataGridViewTextBoxColumn1";
            this.producerDataGridViewTextBoxColumn1.Visible = false;
            // 
            // filmsActorsDataGridViewTextBoxColumn2
            // 
            this.filmsActorsDataGridViewTextBoxColumn2.DataPropertyName = "FilmsActors";
            this.filmsActorsDataGridViewTextBoxColumn2.HeaderText = "FilmsActors";
            this.filmsActorsDataGridViewTextBoxColumn2.Name = "filmsActorsDataGridViewTextBoxColumn2";
            this.filmsActorsDataGridViewTextBoxColumn2.Visible = false;
            // 
            // filmsGenresDataGridViewTextBoxColumn3
            // 
            this.filmsGenresDataGridViewTextBoxColumn3.DataPropertyName = "FilmsGenres";
            this.filmsGenresDataGridViewTextBoxColumn3.HeaderText = "FilmsGenres";
            this.filmsGenresDataGridViewTextBoxColumn3.Name = "filmsGenresDataGridViewTextBoxColumn3";
            this.filmsGenresDataGridViewTextBoxColumn3.Visible = false;
            // 
            // viewersFilmsDataGridViewTextBoxColumn1
            // 
            this.viewersFilmsDataGridViewTextBoxColumn1.DataPropertyName = "ViewersFilms";
            this.viewersFilmsDataGridViewTextBoxColumn1.HeaderText = "ViewersFilms";
            this.viewersFilmsDataGridViewTextBoxColumn1.Name = "viewersFilmsDataGridViewTextBoxColumn1";
            this.viewersFilmsDataGridViewTextBoxColumn1.Visible = false;
            // 
            // btnFilmsAddNew
            // 
            this.btnFilmsAddNew.Location = new System.Drawing.Point(172, 6);
            this.btnFilmsAddNew.Name = "btnFilmsAddNew";
            this.btnFilmsAddNew.Size = new System.Drawing.Size(160, 21);
            this.btnFilmsAddNew.TabIndex = 14;
            this.btnFilmsAddNew.Text = "Новий фільм";
            this.btnFilmsAddNew.UseVisualStyleBackColor = true;
            this.btnFilmsAddNew.UseWaitCursor = true;
            this.btnFilmsAddNew.Click += new System.EventHandler(this.btnFilmsAddNew_Click);
            // 
            // btnDeleteFilms
            // 
            this.btnDeleteFilms.Location = new System.Drawing.Point(6, 6);
            this.btnDeleteFilms.Name = "btnDeleteFilms";
            this.btnDeleteFilms.Size = new System.Drawing.Size(160, 21);
            this.btnDeleteFilms.TabIndex = 2;
            this.btnDeleteFilms.Text = "Видалити";
            this.btnDeleteFilms.UseVisualStyleBackColor = true;
            this.btnDeleteFilms.UseWaitCursor = true;
            this.btnDeleteFilms.Click += new System.EventHandler(this.btnDeleteFilms_Click);
            // 
            // lblAddFilmYear
            // 
            this.lblAddFilmYear.AutoSize = true;
            this.lblAddFilmYear.Location = new System.Drawing.Point(47, 105);
            this.lblAddFilmYear.Name = "lblAddFilmYear";
            this.lblAddFilmYear.Size = new System.Drawing.Size(22, 13);
            this.lblAddFilmYear.TabIndex = 16;
            this.lblAddFilmYear.Text = "Рік";
            this.lblAddFilmYear.UseWaitCursor = true;
            this.lblAddFilmYear.Visible = false;
            // 
            // txtbAddFilmName
            // 
            this.txtbAddFilmName.Location = new System.Drawing.Point(172, 78);
            this.txtbAddFilmName.Name = "txtbAddFilmName";
            this.txtbAddFilmName.Size = new System.Drawing.Size(160, 20);
            this.txtbAddFilmName.TabIndex = 3;
            this.txtbAddFilmName.UseWaitCursor = true;
            this.txtbAddFilmName.Visible = false;
            // 
            // cmbAddFilmActors
            // 
            this.cmbAddFilmActors.DataSource = this.actorBindingSource;
            this.cmbAddFilmActors.DisplayMember = "a_name";
            this.cmbAddFilmActors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddFilmActors.FormattingEnabled = true;
            this.cmbAddFilmActors.Location = new System.Drawing.Point(172, 184);
            this.cmbAddFilmActors.Name = "cmbAddFilmActors";
            this.cmbAddFilmActors.Size = new System.Drawing.Size(160, 21);
            this.cmbAddFilmActors.TabIndex = 7;
            this.cmbAddFilmActors.UseWaitCursor = true;
            this.cmbAddFilmActors.Visible = false;
            // 
            // lblAddFilmName
            // 
            this.lblAddFilmName.AutoSize = true;
            this.lblAddFilmName.Location = new System.Drawing.Point(47, 80);
            this.lblAddFilmName.Name = "lblAddFilmName";
            this.lblAddFilmName.Size = new System.Drawing.Size(39, 13);
            this.lblAddFilmName.TabIndex = 15;
            this.lblAddFilmName.Text = "Назва";
            this.lblAddFilmName.UseWaitCursor = true;
            this.lblAddFilmName.Visible = false;
            // 
            // cmbAddFilmGenres
            // 
            this.cmbAddFilmGenres.DataSource = this.genreBindingSource;
            this.cmbAddFilmGenres.DisplayMember = "g_name";
            this.cmbAddFilmGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddFilmGenres.FormattingEnabled = true;
            this.cmbAddFilmGenres.Location = new System.Drawing.Point(172, 157);
            this.cmbAddFilmGenres.Name = "cmbAddFilmGenres";
            this.cmbAddFilmGenres.Size = new System.Drawing.Size(160, 21);
            this.cmbAddFilmGenres.TabIndex = 5;
            this.cmbAddFilmGenres.UseWaitCursor = true;
            this.cmbAddFilmGenres.Visible = false;
            // 
            // cmbAddFilmSelectedActors
            // 
            this.cmbAddFilmSelectedActors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddFilmSelectedActors.FormattingEnabled = true;
            this.cmbAddFilmSelectedActors.Location = new System.Drawing.Point(338, 184);
            this.cmbAddFilmSelectedActors.Name = "cmbAddFilmSelectedActors";
            this.cmbAddFilmSelectedActors.Size = new System.Drawing.Size(160, 21);
            this.cmbAddFilmSelectedActors.TabIndex = 8;
            this.cmbAddFilmSelectedActors.UseWaitCursor = true;
            this.cmbAddFilmSelectedActors.Visible = false;
            // 
            // btnAddFilmClear
            // 
            this.btnAddFilmClear.Location = new System.Drawing.Point(338, 211);
            this.btnAddFilmClear.Name = "btnAddFilmClear";
            this.btnAddFilmClear.Size = new System.Drawing.Size(160, 21);
            this.btnAddFilmClear.TabIndex = 13;
            this.btnAddFilmClear.Text = "Очистити";
            this.btnAddFilmClear.UseVisualStyleBackColor = true;
            this.btnAddFilmClear.UseWaitCursor = true;
            this.btnAddFilmClear.Visible = false;
            this.btnAddFilmClear.Click += new System.EventHandler(this.btnAddFilmClear_Click);
            // 
            // cmbAddFilmSelectedGenres
            // 
            this.cmbAddFilmSelectedGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddFilmSelectedGenres.FormattingEnabled = true;
            this.cmbAddFilmSelectedGenres.Location = new System.Drawing.Point(338, 157);
            this.cmbAddFilmSelectedGenres.Name = "cmbAddFilmSelectedGenres";
            this.cmbAddFilmSelectedGenres.Size = new System.Drawing.Size(160, 21);
            this.cmbAddFilmSelectedGenres.TabIndex = 6;
            this.cmbAddFilmSelectedGenres.UseWaitCursor = true;
            this.cmbAddFilmSelectedGenres.Visible = false;
            // 
            // cmbAddFilmProducer
            // 
            this.cmbAddFilmProducer.DataSource = this.producerBindingSource;
            this.cmbAddFilmProducer.DisplayMember = "p_name";
            this.cmbAddFilmProducer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddFilmProducer.FormattingEnabled = true;
            this.cmbAddFilmProducer.Location = new System.Drawing.Point(172, 130);
            this.cmbAddFilmProducer.Name = "cmbAddFilmProducer";
            this.cmbAddFilmProducer.Size = new System.Drawing.Size(160, 21);
            this.cmbAddFilmProducer.TabIndex = 9;
            this.cmbAddFilmProducer.UseWaitCursor = true;
            this.cmbAddFilmProducer.Visible = false;
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(172, 211);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(160, 21);
            this.btnAddFilm.TabIndex = 10;
            this.btnAddFilm.Text = "Додати";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.UseWaitCursor = true;
            this.btnAddFilm.Visible = false;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // btnAddFilmSelectGenre
            // 
            this.btnAddFilmSelectGenre.Location = new System.Drawing.Point(6, 157);
            this.btnAddFilmSelectGenre.Name = "btnAddFilmSelectGenre";
            this.btnAddFilmSelectGenre.Size = new System.Drawing.Size(160, 21);
            this.btnAddFilmSelectGenre.TabIndex = 11;
            this.btnAddFilmSelectGenre.Text = "Вибрати жанр";
            this.btnAddFilmSelectGenre.UseVisualStyleBackColor = true;
            this.btnAddFilmSelectGenre.UseWaitCursor = true;
            this.btnAddFilmSelectGenre.Visible = false;
            this.btnAddFilmSelectGenre.Click += new System.EventHandler(this.btnAddFilmSelectGenre_Click);
            // 
            // btnAddFilmSelectActor
            // 
            this.btnAddFilmSelectActor.Location = new System.Drawing.Point(6, 184);
            this.btnAddFilmSelectActor.Name = "btnAddFilmSelectActor";
            this.btnAddFilmSelectActor.Size = new System.Drawing.Size(160, 21);
            this.btnAddFilmSelectActor.TabIndex = 12;
            this.btnAddFilmSelectActor.Text = "Вибрати актора";
            this.btnAddFilmSelectActor.UseVisualStyleBackColor = true;
            this.btnAddFilmSelectActor.UseWaitCursor = true;
            this.btnAddFilmSelectActor.Visible = false;
            this.btnAddFilmSelectActor.Click += new System.EventHandler(this.btnAddFilmSelectActor_Click);
            // 
            // tabControlChenging
            // 
            this.tabControlChenging.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlChenging.Controls.Add(this.tabFilms);
            this.tabControlChenging.Controls.Add(this.tabGenres);
            this.tabControlChenging.Controls.Add(this.tabProducers);
            this.tabControlChenging.Controls.Add(this.tabActors);
            this.tabControlChenging.Controls.Add(this.tabViewers);
            this.tabControlChenging.Controls.Add(this.tabFilmsGenres);
            this.tabControlChenging.Controls.Add(this.tabFilmsActors);
            this.tabControlChenging.Controls.Add(this.tabViewersFilms);
            this.tabControlChenging.Location = new System.Drawing.Point(12, 68);
            this.tabControlChenging.Name = "tabControlChenging";
            this.tabControlChenging.SelectedIndex = 0;
            this.tabControlChenging.Size = new System.Drawing.Size(760, 336);
            this.tabControlChenging.TabIndex = 43;
            // 
            // FormFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnListDelete);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.lblRegMail);
            this.Controls.Add(this.txtbRegistrationMail);
            this.Controls.Add(this.tabControlSearch);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnEditing);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnListEnd);
            this.Controls.Add(this.btnSaveAllChanges);
            this.Controls.Add(this.btnEndEdit);
            this.Controls.Add(this.btnRegCancel);
            this.Controls.Add(this.lblRegName);
            this.Controls.Add(this.lblRegPassword);
            this.Controls.Add(this.lblRegLogin);
            this.Controls.Add(this.btnRegistr);
            this.Controls.Add(this.txtbRegistrationPassword);
            this.Controls.Add(this.txtbRegistrationName);
            this.Controls.Add(this.txtbRegistrationUsername);
            this.Controls.Add(this.tabControlChenging);
            this.Name = "FormFilms";
            this.Text = "Фільми";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFilms_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.tabControlSearch.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unicFilmYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedFilmsBS)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedGenresBS)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unicProducerBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unicProducerDeath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProducers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedProducerBS)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unicActorDeath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unicActorBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedActorsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsGenreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsActorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewersFilmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFilmsBS)).EndInit();
            this.tabViewersFilms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewersFilms)).EndInit();
            this.tabFilmsActors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsActors)).EndInit();
            this.tabFilmsGenres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsGenres)).EndInit();
            this.tabViewers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewers)).EndInit();
            this.tabActors.ResumeLayout(false);
            this.tabActors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddActorDeath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddActorBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.tabProducers.ResumeLayout(false);
            this.tabProducers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddProducerDeath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddProducerBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducers)).EndInit();
            this.tabGenres.ResumeLayout(false);
            this.tabGenres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.tabFilms.ResumeLayout(false);
            this.tabFilms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddFilmYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.tabControlChenging.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSearchFilmsGenre;
        private System.Windows.Forms.Button btnSearchFilms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControlSearch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.ComboBox cmbSearchFilmsName;
        private System.Windows.Forms.ComboBox cmbSearchFilmsActor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSearchFilmsProducer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearchFilmsYear;
        private System.Windows.Forms.DataGridView dgvSearchFilms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSearchGenres;
        private System.Windows.Forms.Button btnSearchGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSearchGenre;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvSearchProducers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSearchProducerName;
        private System.Windows.Forms.Button btnSearchProducer;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvSearchActors;
        private System.Windows.Forms.Button btnSearchActor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSearchActorName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnEditing;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnListEnd;
        private System.Windows.Forms.Button btnSaveAllChanges;
        private System.Windows.Forms.Button btnEndEdit;
        private System.Windows.Forms.Button btnRegCancel;
        private System.Windows.Forms.Label lblRegName;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Label lblRegLogin;
        private System.Windows.Forms.Button btnRegistr;
        private System.Windows.Forms.TextBox txtbRegistrationPassword;
        private System.Windows.Forms.TextBox txtbRegistrationName;
        private System.Windows.Forms.TextBox txtbRegistrationUsername;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private System.Windows.Forms.BindingSource viewerBindingSource;
        private System.Windows.Forms.Label lblRegMail;
        private System.Windows.Forms.TextBox txtbRegistrationMail;
        private System.Windows.Forms.BindingSource filmsGenreBindingSource;
        private System.Windows.Forms.BindingSource filmsActorBindingSource;
        private System.Windows.Forms.BindingSource viewersFilmBindingSource;
        private System.Windows.Forms.BindingSource findedGenresBS;
        private System.Windows.Forms.BindingSource findedFilmsBS;
        private System.Windows.Forms.BindingSource findedProducerBS;
        private System.Windows.Forms.BindingSource findedActorsBS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSearchProducerBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSearchProducerDeath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSearchActorDeath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSearchActorBirth;
        private System.Windows.Forms.BindingSource unicProducerBirth;
        private System.Windows.Forms.BindingSource unicActorBirth;
        private System.Windows.Forms.BindingSource unicFilmYear;
        private System.Windows.Forms.BindingSource unicProducerDeath;
        private System.Windows.Forms.BindingSource unicActorDeath;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_death;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsActorsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsActors;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewersFilms;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsGenresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_death;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClearSearchFilm;
        private System.Windows.Forms.Button btnClearSearchGenre;
        private System.Windows.Forms.Button btnClearSearchProducer;
        private System.Windows.Forms.Button btnClearSearchActor;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.BindingSource listFilmsBS;
        private System.Windows.Forms.Button btnListDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fproducerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsActorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsGenresDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewersFilmsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabViewersFilms;
        private System.Windows.Forms.DataGridView dgvViewersFilms;
        private System.Windows.Forms.TabPage tabFilmsActors;
        private System.Windows.Forms.DataGridView dgvFilmsActors;
        private System.Windows.Forms.TabPage tabFilmsGenres;
        private System.Windows.Forms.DataGridView dgvFilmsGenres;
        private System.Windows.Forms.TabPage tabViewers;
        private System.Windows.Forms.Button btnDeleteViewers;
        private System.Windows.Forms.DataGridView dgvViewers;
        private System.Windows.Forms.TabPage tabActors;
        private System.Windows.Forms.CheckBox chbAddActor;
        private System.Windows.Forms.Label lblAddActorBirth;
        private System.Windows.Forms.Label lblAddActorDeath;
        private System.Windows.Forms.NumericUpDown nudAddActorDeath;
        private System.Windows.Forms.NumericUpDown nudAddActorBirth;
        private System.Windows.Forms.Button btnAddActor;
        private System.Windows.Forms.TextBox txtbAddActorName;
        private System.Windows.Forms.Label lblAddActorName;
        private System.Windows.Forms.Button btnActorEndAdd;
        private System.Windows.Forms.Button btnActorAddNew;
        private System.Windows.Forms.Button btnDeleteActors;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.TabPage tabProducers;
        private System.Windows.Forms.CheckBox chbAddProducer;
        private System.Windows.Forms.Label lblAddProducerBirth;
        private System.Windows.Forms.Label lblAddProducerDeath;
        private System.Windows.Forms.NumericUpDown nudAddProducerDeath;
        private System.Windows.Forms.NumericUpDown nudAddProducerBirth;
        private System.Windows.Forms.Button btnProducerEndAdd;
        private System.Windows.Forms.TextBox txtbAddProducerName;
        private System.Windows.Forms.Button btnAddProducer;
        private System.Windows.Forms.Button btnProducerAddNew;
        private System.Windows.Forms.Label lblAddProducerName;
        private System.Windows.Forms.Button btnDeleteProducer;
        private System.Windows.Forms.DataGridView dgvProducers;
        private System.Windows.Forms.TabPage tabGenres;
        private System.Windows.Forms.Button btnGenresEndAdd;
        private System.Windows.Forms.TextBox txtbAddGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnGenreAddNew;
        private System.Windows.Forms.Label lblAddGenre;
        private System.Windows.Forms.Button btnDeleteGenres;
        private System.Windows.Forms.DataGridView dgvGenres;
        private System.Windows.Forms.TabPage tabFilms;
        private System.Windows.Forms.Button btnEditFilmStart;
        private System.Windows.Forms.ComboBox cmbEditFilmName;
        private System.Windows.Forms.Label lblEditFilmsYear;
        private System.Windows.Forms.Label lblEditFilmsName;
        private System.Windows.Forms.Button btnEditFilmsAddActor;
        private System.Windows.Forms.Button btnEditFilmsAddGenre;
        private System.Windows.Forms.ComboBox cmbEditFilmChooseGenres;
        private System.Windows.Forms.Button btnEditFilmEdit;
        private System.Windows.Forms.ComboBox cmbEditFilmActor;
        private System.Windows.Forms.ComboBox cmbEditFilmChooseActors;
        private System.Windows.Forms.ComboBox cmbEditFilmsGenre;
        private System.Windows.Forms.Button btnFilmEndAdd;
        private System.Windows.Forms.Label lblAddFilmProducer;
        private System.Windows.Forms.Label lblAddFilmYear;
        private System.Windows.Forms.Label lblAddFilmName;
        private System.Windows.Forms.Button btnAddFilmClear;
        private System.Windows.Forms.TextBox txtbAddFilmName;
        private System.Windows.Forms.Button btnAddFilmSelectActor;
        private System.Windows.Forms.Button btnAddFilmSelectGenre;
        private System.Windows.Forms.ComboBox cmbAddFilmSelectedGenres;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.ComboBox cmbAddFilmActors;
        private System.Windows.Forms.ComboBox cmbAddFilmProducer;
        private System.Windows.Forms.ComboBox cmbAddFilmSelectedActors;
        private System.Windows.Forms.ComboBox cmbAddFilmGenres;
        private System.Windows.Forms.Button btnFilmsAddNew;
        private System.Windows.Forms.Button btnDeleteFilms;
        private System.Windows.Forms.DataGridView dgvFilms;
        private System.Windows.Forms.TabControl tabControlChenging;
        private System.Windows.Forms.NumericUpDown nudAddFilmYear;
        private System.Windows.Forms.ComboBox cmbEditFilmYear;
        private System.Windows.Forms.Button btnAddFilmDeleteActor;
        private System.Windows.Forms.Button btnAddFilmDeleteGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aname;
        private System.Windows.Forms.DataGridViewTextBoxColumn abirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn adeath;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsActorsDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblEditFilmProducer;
        private System.Windows.Forms.ComboBox cmbEditFilmProducer;
        private System.Windows.Forms.ComboBox cmbEditFilmId;
        private System.Windows.Forms.Label lblEditFilmId;
        private System.Windows.Forms.Button btnEditFilmDeleteActor;
        private System.Windows.Forms.Button btnEditFilmDeleteGenre;
        private System.Windows.Forms.Button btnEditFilmClear;
        private System.Windows.Forms.CheckBox chbEditFilmProducer;
        private System.Windows.Forms.RichTextBox rtbEditFilmProducer;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfvidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fafidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgfidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fggidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ffid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ffyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ffproducer;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsActorsDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsGenresDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewersFilmsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vname;
        private System.Windows.Forms.DataGridViewTextBoxColumn vusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn vpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn vmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vadmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewersFilmsDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdeath;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmsGenresDataGridViewTextBoxColumn2;
    }
}

