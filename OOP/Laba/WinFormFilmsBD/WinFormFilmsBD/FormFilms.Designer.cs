namespace WinFormFilmsBD
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
            this.tabControlFilms = new System.Windows.Forms.TabControl();
            this.tabActors = new System.Windows.Forms.TabPage();
            this.btnDeleteActors = new System.Windows.Forms.Button();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.a_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_death = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newDS = new WinFormFilmsBD.NewDS();
            this.btnSaveActors = new System.Windows.Forms.Button();
            this.tabFilms = new System.Windows.Forms.TabPage();
            this.btnDeleteFilms = new System.Windows.Forms.Button();
            this.btnSaveFilms = new System.Windows.Forms.Button();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.f_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabGenres = new System.Windows.Forms.TabPage();
            this.btnDeleteGenres = new System.Windows.Forms.Button();
            this.btnSaveGenres = new System.Windows.Forms.Button();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.g_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabProducers = new System.Windows.Forms.TabPage();
            this.btnDeleteProducer = new System.Windows.Forms.Button();
            this.btnSaveProducers = new System.Windows.Forms.Button();
            this.dgvProducers = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_death = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabViewers = new System.Windows.Forms.TabPage();
            this.btnDeleteViewers = new System.Windows.Forms.Button();
            this.btnSaveViewers = new System.Windows.Forms.Button();
            this.dgvViewers = new System.Windows.Forms.DataGridView();
            this.v_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viewersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabFilmsGenres = new System.Windows.Forms.TabPage();
            this.dgvFilmsGenres = new System.Windows.Forms.DataGridView();
            this.fg_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fg_f_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fg_g_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsGenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteFilmsGenres = new System.Windows.Forms.Button();
            this.btnSaveFilmsGenres = new System.Windows.Forms.Button();
            this.tabFilmsActors = new System.Windows.Forms.TabPage();
            this.dgvFilmsActors = new System.Windows.Forms.DataGridView();
            this.fa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fa_f_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fa_a_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsActorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteFilmsActors = new System.Windows.Forms.Button();
            this.btnSaveFilmsActors = new System.Windows.Forms.Button();
            this.tabViewersFilms = new System.Windows.Forms.TabPage();
            this.dgvViewersFilms = new System.Windows.Forms.DataGridView();
            this.vf_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vf_f_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vf_v_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewersFilmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteViewersFilms = new System.Windows.Forms.Button();
            this.btnSaveViewersFilms = new System.Windows.Forms.Button();
            this.dgvSearchFilms = new System.Windows.Forms.DataGridView();
            this.fidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findedFilmsNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.FilmsTableAdapter();
            this.actorsTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.ActorsTableAdapter();
            this.genresTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.GenresTableAdapter();
            this.producersTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.ProducersTableAdapter();
            this.viewersTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.ViewersTableAdapter();
            this.filmsGenresTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.FilmsGenresTableAdapter();
            this.filmsActorsTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.FilmsActorsTableAdapter();
            this.viewersFilmsTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.ViewersFilmsTableAdapter();
            this.findedFilmsNewTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.FindedFilmsNewTableAdapter();
            this.queriesTableAdapter1 = new WinFormFilmsBD.NewDSTableAdapters.QueriesTableAdapter();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnEditing = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSearchFilms = new System.Windows.Forms.Button();
            this.cmbSearchFilmsName = new System.Windows.Forms.ComboBox();
            this.filmsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSearchFilmsActor = new System.Windows.Forms.ComboBox();
            this.actorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSearchFilmsProducer = new System.Windows.Forms.ComboBox();
            this.producersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSearchFilmsGenre = new System.Windows.Forms.ComboBox();
            this.genresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSearchFilmsYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabContro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSearchGenres = new System.Windows.Forms.DataGridView();
            this.gidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findedGenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchGenre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSearchGenre = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvSearchProducers = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdeathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findedProducersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSearchProducerBirth = new System.Windows.Forms.ComboBox();
            this.cmbSearchProducerDeath = new System.Windows.Forms.ComboBox();
            this.cmbSearchProducerName = new System.Windows.Forms.ComboBox();
            this.btnSearchProducer = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvSearchActors = new System.Windows.Forms.DataGridView();
            this.btnSearchActor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSearchActorBirth = new System.Windows.Forms.ComboBox();
            this.cmbSearchActorDeath = new System.Windows.Forms.ComboBox();
            this.cmbSearchActorName = new System.Windows.Forms.ComboBox();
            this.filmsGenresTableAdapter1 = new WinFormFilmsBD.FilmsBDDataSet3TableAdapters.FilmsGenresTableAdapter();
            this.findedGenresTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.FindedGenresTableAdapter();
            this.findedProducersTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.FindedProducersTableAdapter();
            this.findedActorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findedActorsTableAdapter = new WinFormFilmsBD.NewDSTableAdapters.FindedActorsTableAdapter();
            this.aidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adeathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlFilms.SuspendLayout();
            this.tabActors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDS)).BeginInit();
            this.tabFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            this.tabGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            this.tabProducers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).BeginInit();
            this.tabViewers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewersBindingSource)).BeginInit();
            this.tabFilmsGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsGenresBindingSource)).BeginInit();
            this.tabFilmsActors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsActorsBindingSource)).BeginInit();
            this.tabViewersFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewersFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewersFilmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedFilmsNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource1)).BeginInit();
            this.tabContro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedGenresBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProducers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedProducersBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedActorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlFilms
            // 
            this.tabControlFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlFilms.Controls.Add(this.tabActors);
            this.tabControlFilms.Controls.Add(this.tabFilms);
            this.tabControlFilms.Controls.Add(this.tabGenres);
            this.tabControlFilms.Controls.Add(this.tabProducers);
            this.tabControlFilms.Controls.Add(this.tabViewers);
            this.tabControlFilms.Controls.Add(this.tabFilmsGenres);
            this.tabControlFilms.Controls.Add(this.tabFilmsActors);
            this.tabControlFilms.Controls.Add(this.tabViewersFilms);
            this.tabControlFilms.Location = new System.Drawing.Point(12, 403);
            this.tabControlFilms.Name = "tabControlFilms";
            this.tabControlFilms.SelectedIndex = 0;
            this.tabControlFilms.Size = new System.Drawing.Size(933, 270);
            this.tabControlFilms.TabIndex = 0;
            // 
            // tabActors
            // 
            this.tabActors.Controls.Add(this.btnDeleteActors);
            this.tabActors.Controls.Add(this.dgvActors);
            this.tabActors.Controls.Add(this.btnSaveActors);
            this.tabActors.Location = new System.Drawing.Point(4, 22);
            this.tabActors.Name = "tabActors";
            this.tabActors.Padding = new System.Windows.Forms.Padding(3);
            this.tabActors.Size = new System.Drawing.Size(925, 244);
            this.tabActors.TabIndex = 8;
            this.tabActors.Text = "Актори";
            this.tabActors.UseVisualStyleBackColor = true;
            this.tabActors.Click += new System.EventHandler(this.tabActors_Click);
            // 
            // btnDeleteActors
            // 
            this.btnDeleteActors.Location = new System.Drawing.Point(89, 7);
            this.btnDeleteActors.Name = "btnDeleteActors";
            this.btnDeleteActors.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteActors.TabIndex = 2;
            this.btnDeleteActors.Text = "Видалити";
            this.btnDeleteActors.UseVisualStyleBackColor = true;
            this.btnDeleteActors.Click += new System.EventHandler(this.btnDeleteActors_Click);
            // 
            // dgvActors
            // 
            this.dgvActors.AutoGenerateColumns = false;
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a_id,
            this.a_name,
            this.a_birth,
            this.a_death});
            this.dgvActors.DataSource = this.actorsBindingSource;
            this.dgvActors.Location = new System.Drawing.Point(7, 37);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(755, 318);
            this.dgvActors.TabIndex = 1;
            // 
            // a_id
            // 
            this.a_id.DataPropertyName = "a_id";
            this.a_id.HeaderText = "a_id";
            this.a_id.Name = "a_id";
            this.a_id.ReadOnly = true;
            // 
            // a_name
            // 
            this.a_name.DataPropertyName = "a_name";
            this.a_name.HeaderText = "a_name";
            this.a_name.Name = "a_name";
            // 
            // a_birth
            // 
            this.a_birth.DataPropertyName = "a_birth";
            this.a_birth.HeaderText = "a_birth";
            this.a_birth.Name = "a_birth";
            // 
            // a_death
            // 
            this.a_death.DataPropertyName = "a_death";
            this.a_death.HeaderText = "a_death";
            this.a_death.Name = "a_death";
            // 
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "Actors";
            this.actorsBindingSource.DataSource = this.newDS;
            // 
            // newDS
            // 
            this.newDS.DataSetName = "NewDS";
            this.newDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSaveActors
            // 
            this.btnSaveActors.Location = new System.Drawing.Point(7, 7);
            this.btnSaveActors.Name = "btnSaveActors";
            this.btnSaveActors.Size = new System.Drawing.Size(75, 23);
            this.btnSaveActors.TabIndex = 0;
            this.btnSaveActors.Text = "Зберегти";
            this.btnSaveActors.UseVisualStyleBackColor = true;
            this.btnSaveActors.Click += new System.EventHandler(this.btnSaveActors_Click);
            // 
            // tabFilms
            // 
            this.tabFilms.Controls.Add(this.btnDeleteFilms);
            this.tabFilms.Controls.Add(this.btnSaveFilms);
            this.tabFilms.Controls.Add(this.dgvFilms);
            this.tabFilms.Location = new System.Drawing.Point(4, 22);
            this.tabFilms.Name = "tabFilms";
            this.tabFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilms.Size = new System.Drawing.Size(925, 244);
            this.tabFilms.TabIndex = 1;
            this.tabFilms.Text = "Фільми";
            this.tabFilms.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFilms
            // 
            this.btnDeleteFilms.Location = new System.Drawing.Point(89, 6);
            this.btnDeleteFilms.Name = "btnDeleteFilms";
            this.btnDeleteFilms.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFilms.TabIndex = 2;
            this.btnDeleteFilms.Text = "Видалити";
            this.btnDeleteFilms.UseVisualStyleBackColor = true;
            this.btnDeleteFilms.Click += new System.EventHandler(this.btnDeleteFillms_Click);
            // 
            // btnSaveFilms
            // 
            this.btnSaveFilms.Location = new System.Drawing.Point(8, 6);
            this.btnSaveFilms.Name = "btnSaveFilms";
            this.btnSaveFilms.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFilms.TabIndex = 1;
            this.btnSaveFilms.Text = "Зберегти";
            this.btnSaveFilms.UseVisualStyleBackColor = true;
            this.btnSaveFilms.Click += new System.EventHandler(this.btnSaveFilms_Click);
            // 
            // dgvFilms
            // 
            this.dgvFilms.AutoGenerateColumns = false;
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f_id,
            this.d_name,
            this.f_year,
            this.f_producer});
            this.dgvFilms.DataSource = this.filmsBindingSource;
            this.dgvFilms.Location = new System.Drawing.Point(7, 36);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.Size = new System.Drawing.Size(755, 319);
            this.dgvFilms.TabIndex = 0;
            // 
            // f_id
            // 
            this.f_id.DataPropertyName = "f_id";
            this.f_id.HeaderText = "f_id";
            this.f_id.Name = "f_id";
            this.f_id.ReadOnly = true;
            // 
            // d_name
            // 
            this.d_name.DataPropertyName = "d_name";
            this.d_name.HeaderText = "d_name";
            this.d_name.Name = "d_name";
            // 
            // f_year
            // 
            this.f_year.DataPropertyName = "f_year";
            this.f_year.HeaderText = "f_year";
            this.f_year.Name = "f_year";
            // 
            // f_producer
            // 
            this.f_producer.DataPropertyName = "f_producer";
            this.f_producer.HeaderText = "f_producer";
            this.f_producer.Name = "f_producer";
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.newDS;
            // 
            // tabGenres
            // 
            this.tabGenres.Controls.Add(this.btnDeleteGenres);
            this.tabGenres.Controls.Add(this.btnSaveGenres);
            this.tabGenres.Controls.Add(this.dgvGenres);
            this.tabGenres.Location = new System.Drawing.Point(4, 22);
            this.tabGenres.Name = "tabGenres";
            this.tabGenres.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenres.Size = new System.Drawing.Size(925, 244);
            this.tabGenres.TabIndex = 2;
            this.tabGenres.Text = "Жанри";
            this.tabGenres.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGenres
            // 
            this.btnDeleteGenres.Location = new System.Drawing.Point(89, 7);
            this.btnDeleteGenres.Name = "btnDeleteGenres";
            this.btnDeleteGenres.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGenres.TabIndex = 2;
            this.btnDeleteGenres.Text = "Видалити";
            this.btnDeleteGenres.UseVisualStyleBackColor = true;
            this.btnDeleteGenres.Click += new System.EventHandler(this.btnDeleteGenres_Click);
            // 
            // btnSaveGenres
            // 
            this.btnSaveGenres.Location = new System.Drawing.Point(7, 7);
            this.btnSaveGenres.Name = "btnSaveGenres";
            this.btnSaveGenres.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGenres.TabIndex = 1;
            this.btnSaveGenres.Text = "Зберегти";
            this.btnSaveGenres.UseVisualStyleBackColor = true;
            this.btnSaveGenres.Click += new System.EventHandler(this.btnSaveGenres_Click);
            // 
            // dgvGenres
            // 
            this.dgvGenres.AutoGenerateColumns = false;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g_id,
            this.g_name});
            this.dgvGenres.DataSource = this.genresBindingSource;
            this.dgvGenres.Location = new System.Drawing.Point(6, 36);
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.Size = new System.Drawing.Size(756, 319);
            this.dgvGenres.TabIndex = 0;
            // 
            // g_id
            // 
            this.g_id.DataPropertyName = "g_id";
            this.g_id.HeaderText = "g_id";
            this.g_id.Name = "g_id";
            this.g_id.ReadOnly = true;
            // 
            // g_name
            // 
            this.g_name.DataPropertyName = "g_name";
            this.g_name.HeaderText = "g_name";
            this.g_name.Name = "g_name";
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.newDS;
            // 
            // tabProducers
            // 
            this.tabProducers.Controls.Add(this.btnDeleteProducer);
            this.tabProducers.Controls.Add(this.btnSaveProducers);
            this.tabProducers.Controls.Add(this.dgvProducers);
            this.tabProducers.Location = new System.Drawing.Point(4, 22);
            this.tabProducers.Name = "tabProducers";
            this.tabProducers.Size = new System.Drawing.Size(925, 244);
            this.tabProducers.TabIndex = 3;
            this.tabProducers.Text = "Режисери";
            this.tabProducers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProducer
            // 
            this.btnDeleteProducer.Location = new System.Drawing.Point(84, 3);
            this.btnDeleteProducer.Name = "btnDeleteProducer";
            this.btnDeleteProducer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProducer.TabIndex = 2;
            this.btnDeleteProducer.Text = "Видалити";
            this.btnDeleteProducer.UseVisualStyleBackColor = true;
            this.btnDeleteProducer.Click += new System.EventHandler(this.btnDeleteProducer_Click);
            // 
            // btnSaveProducers
            // 
            this.btnSaveProducers.Location = new System.Drawing.Point(3, 3);
            this.btnSaveProducers.Name = "btnSaveProducers";
            this.btnSaveProducers.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProducers.TabIndex = 1;
            this.btnSaveProducers.Text = "Зберегти";
            this.btnSaveProducers.UseVisualStyleBackColor = true;
            this.btnSaveProducers.Click += new System.EventHandler(this.btnSaveProducers_Click);
            // 
            // dgvProducers
            // 
            this.dgvProducers.AutoGenerateColumns = false;
            this.dgvProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.p_name,
            this.p_birth,
            this.p_death});
            this.dgvProducers.DataSource = this.producersBindingSource;
            this.dgvProducers.Location = new System.Drawing.Point(3, 32);
            this.dgvProducers.Name = "dgvProducers";
            this.dgvProducers.Size = new System.Drawing.Size(762, 326);
            this.dgvProducers.TabIndex = 0;
            // 
            // p_id
            // 
            this.p_id.DataPropertyName = "p_id";
            this.p_id.HeaderText = "p_id";
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            // 
            // p_name
            // 
            this.p_name.DataPropertyName = "p_name";
            this.p_name.HeaderText = "p_name";
            this.p_name.Name = "p_name";
            // 
            // p_birth
            // 
            this.p_birth.DataPropertyName = "p_birth";
            this.p_birth.HeaderText = "p_birth";
            this.p_birth.Name = "p_birth";
            // 
            // p_death
            // 
            this.p_death.DataPropertyName = "p_death";
            this.p_death.HeaderText = "p_death";
            this.p_death.Name = "p_death";
            // 
            // producersBindingSource
            // 
            this.producersBindingSource.DataMember = "Producers";
            this.producersBindingSource.DataSource = this.newDS;
            // 
            // tabViewers
            // 
            this.tabViewers.Controls.Add(this.btnDeleteViewers);
            this.tabViewers.Controls.Add(this.btnSaveViewers);
            this.tabViewers.Controls.Add(this.dgvViewers);
            this.tabViewers.Location = new System.Drawing.Point(4, 22);
            this.tabViewers.Name = "tabViewers";
            this.tabViewers.Size = new System.Drawing.Size(925, 244);
            this.tabViewers.TabIndex = 4;
            this.tabViewers.Text = "Глядачі";
            this.tabViewers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteViewers
            // 
            this.btnDeleteViewers.Location = new System.Drawing.Point(86, 4);
            this.btnDeleteViewers.Name = "btnDeleteViewers";
            this.btnDeleteViewers.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteViewers.TabIndex = 2;
            this.btnDeleteViewers.Text = "Видалити";
            this.btnDeleteViewers.UseVisualStyleBackColor = true;
            this.btnDeleteViewers.Click += new System.EventHandler(this.btnDeleteViewers_Click);
            // 
            // btnSaveViewers
            // 
            this.btnSaveViewers.Location = new System.Drawing.Point(4, 4);
            this.btnSaveViewers.Name = "btnSaveViewers";
            this.btnSaveViewers.Size = new System.Drawing.Size(75, 23);
            this.btnSaveViewers.TabIndex = 1;
            this.btnSaveViewers.Text = "Зберегти";
            this.btnSaveViewers.UseVisualStyleBackColor = true;
            this.btnSaveViewers.Click += new System.EventHandler(this.btnSaveViewers_Click);
            // 
            // dgvViewers
            // 
            this.dgvViewers.AutoGenerateColumns = false;
            this.dgvViewers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.v_id,
            this.v_name,
            this.v_username,
            this.v_password,
            this.v_mail,
            this.v_admin});
            this.dgvViewers.DataSource = this.viewersBindingSource;
            this.dgvViewers.Location = new System.Drawing.Point(4, 33);
            this.dgvViewers.Name = "dgvViewers";
            this.dgvViewers.Size = new System.Drawing.Size(761, 325);
            this.dgvViewers.TabIndex = 0;
            // 
            // v_id
            // 
            this.v_id.DataPropertyName = "v_id";
            this.v_id.HeaderText = "v_id";
            this.v_id.Name = "v_id";
            this.v_id.ReadOnly = true;
            // 
            // v_name
            // 
            this.v_name.DataPropertyName = "v_name";
            this.v_name.HeaderText = "v_name";
            this.v_name.Name = "v_name";
            // 
            // v_username
            // 
            this.v_username.DataPropertyName = "v_username";
            this.v_username.HeaderText = "v_username";
            this.v_username.Name = "v_username";
            // 
            // v_password
            // 
            this.v_password.DataPropertyName = "v_password";
            this.v_password.HeaderText = "v_password";
            this.v_password.Name = "v_password";
            // 
            // v_mail
            // 
            this.v_mail.DataPropertyName = "v_mail";
            this.v_mail.HeaderText = "v_mail";
            this.v_mail.Name = "v_mail";
            // 
            // v_admin
            // 
            this.v_admin.DataPropertyName = "v_admin";
            this.v_admin.HeaderText = "v_admin";
            this.v_admin.Name = "v_admin";
            // 
            // viewersBindingSource
            // 
            this.viewersBindingSource.DataMember = "Viewers";
            this.viewersBindingSource.DataSource = this.newDS;
            // 
            // tabFilmsGenres
            // 
            this.tabFilmsGenres.Controls.Add(this.dgvFilmsGenres);
            this.tabFilmsGenres.Controls.Add(this.btnDeleteFilmsGenres);
            this.tabFilmsGenres.Controls.Add(this.btnSaveFilmsGenres);
            this.tabFilmsGenres.Location = new System.Drawing.Point(4, 22);
            this.tabFilmsGenres.Name = "tabFilmsGenres";
            this.tabFilmsGenres.Size = new System.Drawing.Size(925, 244);
            this.tabFilmsGenres.TabIndex = 5;
            this.tabFilmsGenres.Text = "ФільмиЖанри";
            this.tabFilmsGenres.UseVisualStyleBackColor = true;
            // 
            // dgvFilmsGenres
            // 
            this.dgvFilmsGenres.AutoGenerateColumns = false;
            this.dgvFilmsGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmsGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fg_id,
            this.fg_f_id,
            this.fg_g_id});
            this.dgvFilmsGenres.DataSource = this.filmsGenresBindingSource;
            this.dgvFilmsGenres.Location = new System.Drawing.Point(4, 34);
            this.dgvFilmsGenres.Name = "dgvFilmsGenres";
            this.dgvFilmsGenres.Size = new System.Drawing.Size(761, 324);
            this.dgvFilmsGenres.TabIndex = 2;
            // 
            // fg_id
            // 
            this.fg_id.DataPropertyName = "fg_id";
            this.fg_id.HeaderText = "fg_id";
            this.fg_id.Name = "fg_id";
            this.fg_id.ReadOnly = true;
            // 
            // fg_f_id
            // 
            this.fg_f_id.DataPropertyName = "fg_f_id";
            this.fg_f_id.HeaderText = "fg_f_id";
            this.fg_f_id.Name = "fg_f_id";
            // 
            // fg_g_id
            // 
            this.fg_g_id.DataPropertyName = "fg_g_id";
            this.fg_g_id.HeaderText = "fg_g_id";
            this.fg_g_id.Name = "fg_g_id";
            // 
            // filmsGenresBindingSource
            // 
            this.filmsGenresBindingSource.DataMember = "FilmsGenres";
            this.filmsGenresBindingSource.DataSource = this.newDS;
            // 
            // btnDeleteFilmsGenres
            // 
            this.btnDeleteFilmsGenres.Location = new System.Drawing.Point(86, 4);
            this.btnDeleteFilmsGenres.Name = "btnDeleteFilmsGenres";
            this.btnDeleteFilmsGenres.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFilmsGenres.TabIndex = 1;
            this.btnDeleteFilmsGenres.Text = "Видалити";
            this.btnDeleteFilmsGenres.UseVisualStyleBackColor = true;
            this.btnDeleteFilmsGenres.Click += new System.EventHandler(this.btnDeleteFilmsGenres_Click);
            // 
            // btnSaveFilmsGenres
            // 
            this.btnSaveFilmsGenres.Location = new System.Drawing.Point(4, 4);
            this.btnSaveFilmsGenres.Name = "btnSaveFilmsGenres";
            this.btnSaveFilmsGenres.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFilmsGenres.TabIndex = 0;
            this.btnSaveFilmsGenres.Text = "Зберегти";
            this.btnSaveFilmsGenres.UseVisualStyleBackColor = true;
            this.btnSaveFilmsGenres.Click += new System.EventHandler(this.btnSaveFilmsGenres_Click);
            // 
            // tabFilmsActors
            // 
            this.tabFilmsActors.Controls.Add(this.dgvFilmsActors);
            this.tabFilmsActors.Controls.Add(this.btnDeleteFilmsActors);
            this.tabFilmsActors.Controls.Add(this.btnSaveFilmsActors);
            this.tabFilmsActors.Location = new System.Drawing.Point(4, 22);
            this.tabFilmsActors.Name = "tabFilmsActors";
            this.tabFilmsActors.Size = new System.Drawing.Size(925, 244);
            this.tabFilmsActors.TabIndex = 6;
            this.tabFilmsActors.Text = "ФільмиАктори";
            this.tabFilmsActors.UseVisualStyleBackColor = true;
            // 
            // dgvFilmsActors
            // 
            this.dgvFilmsActors.AutoGenerateColumns = false;
            this.dgvFilmsActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmsActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fa_id,
            this.fa_f_id,
            this.fa_a_id});
            this.dgvFilmsActors.DataSource = this.filmsActorsBindingSource;
            this.dgvFilmsActors.Location = new System.Drawing.Point(4, 34);
            this.dgvFilmsActors.Name = "dgvFilmsActors";
            this.dgvFilmsActors.Size = new System.Drawing.Size(761, 324);
            this.dgvFilmsActors.TabIndex = 2;
            // 
            // fa_id
            // 
            this.fa_id.DataPropertyName = "fa_id";
            this.fa_id.HeaderText = "fa_id";
            this.fa_id.Name = "fa_id";
            this.fa_id.ReadOnly = true;
            // 
            // fa_f_id
            // 
            this.fa_f_id.DataPropertyName = "fa_f_id";
            this.fa_f_id.HeaderText = "fa_f_id";
            this.fa_f_id.Name = "fa_f_id";
            // 
            // fa_a_id
            // 
            this.fa_a_id.DataPropertyName = "fa_a_id";
            this.fa_a_id.HeaderText = "fa_a_id";
            this.fa_a_id.Name = "fa_a_id";
            // 
            // filmsActorsBindingSource
            // 
            this.filmsActorsBindingSource.DataMember = "FilmsActors";
            this.filmsActorsBindingSource.DataSource = this.newDS;
            // 
            // btnDeleteFilmsActors
            // 
            this.btnDeleteFilmsActors.Location = new System.Drawing.Point(85, 4);
            this.btnDeleteFilmsActors.Name = "btnDeleteFilmsActors";
            this.btnDeleteFilmsActors.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFilmsActors.TabIndex = 1;
            this.btnDeleteFilmsActors.Text = "Видалити";
            this.btnDeleteFilmsActors.UseVisualStyleBackColor = true;
            this.btnDeleteFilmsActors.Click += new System.EventHandler(this.btnDeleteFilmsActors_Click);
            // 
            // btnSaveFilmsActors
            // 
            this.btnSaveFilmsActors.Location = new System.Drawing.Point(4, 4);
            this.btnSaveFilmsActors.Name = "btnSaveFilmsActors";
            this.btnSaveFilmsActors.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFilmsActors.TabIndex = 0;
            this.btnSaveFilmsActors.Text = "Зберегти";
            this.btnSaveFilmsActors.UseVisualStyleBackColor = true;
            this.btnSaveFilmsActors.Click += new System.EventHandler(this.btnSaveFilmsActors_Click);
            // 
            // tabViewersFilms
            // 
            this.tabViewersFilms.Controls.Add(this.dgvViewersFilms);
            this.tabViewersFilms.Controls.Add(this.btnDeleteViewersFilms);
            this.tabViewersFilms.Controls.Add(this.btnSaveViewersFilms);
            this.tabViewersFilms.Location = new System.Drawing.Point(4, 22);
            this.tabViewersFilms.Name = "tabViewersFilms";
            this.tabViewersFilms.Size = new System.Drawing.Size(925, 244);
            this.tabViewersFilms.TabIndex = 7;
            this.tabViewersFilms.Text = "ГлядачіФільми";
            this.tabViewersFilms.UseVisualStyleBackColor = true;
            // 
            // dgvViewersFilms
            // 
            this.dgvViewersFilms.AutoGenerateColumns = false;
            this.dgvViewersFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewersFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vf_id,
            this.vf_f_id,
            this.vf_v_id});
            this.dgvViewersFilms.DataSource = this.viewersFilmsBindingSource;
            this.dgvViewersFilms.Location = new System.Drawing.Point(4, 34);
            this.dgvViewersFilms.Name = "dgvViewersFilms";
            this.dgvViewersFilms.Size = new System.Drawing.Size(761, 324);
            this.dgvViewersFilms.TabIndex = 2;
            // 
            // vf_id
            // 
            this.vf_id.DataPropertyName = "vf_id";
            this.vf_id.HeaderText = "vf_id";
            this.vf_id.Name = "vf_id";
            this.vf_id.ReadOnly = true;
            // 
            // vf_f_id
            // 
            this.vf_f_id.DataPropertyName = "vf_f_id";
            this.vf_f_id.HeaderText = "vf_f_id";
            this.vf_f_id.Name = "vf_f_id";
            // 
            // vf_v_id
            // 
            this.vf_v_id.DataPropertyName = "vf_v_id";
            this.vf_v_id.HeaderText = "vf_v_id";
            this.vf_v_id.Name = "vf_v_id";
            // 
            // viewersFilmsBindingSource
            // 
            this.viewersFilmsBindingSource.DataMember = "ViewersFilms";
            this.viewersFilmsBindingSource.DataSource = this.newDS;
            // 
            // btnDeleteViewersFilms
            // 
            this.btnDeleteViewersFilms.Location = new System.Drawing.Point(85, 3);
            this.btnDeleteViewersFilms.Name = "btnDeleteViewersFilms";
            this.btnDeleteViewersFilms.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteViewersFilms.TabIndex = 1;
            this.btnDeleteViewersFilms.Text = "Видалити";
            this.btnDeleteViewersFilms.UseVisualStyleBackColor = true;
            this.btnDeleteViewersFilms.Click += new System.EventHandler(this.btnDeleteViewersFilms_Click);
            // 
            // btnSaveViewersFilms
            // 
            this.btnSaveViewersFilms.Location = new System.Drawing.Point(4, 4);
            this.btnSaveViewersFilms.Name = "btnSaveViewersFilms";
            this.btnSaveViewersFilms.Size = new System.Drawing.Size(75, 23);
            this.btnSaveViewersFilms.TabIndex = 0;
            this.btnSaveViewersFilms.Text = "Зберегти";
            this.btnSaveViewersFilms.UseVisualStyleBackColor = true;
            this.btnSaveViewersFilms.Click += new System.EventHandler(this.btnSaveViewersFilms_Click);
            // 
            // dgvSearchFilms
            // 
            this.dgvSearchFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchFilms.AutoGenerateColumns = false;
            this.dgvSearchFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fidDataGridViewTextBoxColumn,
            this.dnameDataGridViewTextBoxColumn,
            this.fyearDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn1});
            this.dgvSearchFilms.DataSource = this.findedFilmsNewBindingSource;
            this.dgvSearchFilms.Enabled = false;
            this.dgvSearchFilms.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchFilms.Name = "dgvSearchFilms";
            this.dgvSearchFilms.Size = new System.Drawing.Size(613, 289);
            this.dgvSearchFilms.TabIndex = 1;
            // 
            // fidDataGridViewTextBoxColumn
            // 
            this.fidDataGridViewTextBoxColumn.DataPropertyName = "f_id";
            this.fidDataGridViewTextBoxColumn.HeaderText = "f_id";
            this.fidDataGridViewTextBoxColumn.Name = "fidDataGridViewTextBoxColumn";
            this.fidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dnameDataGridViewTextBoxColumn
            // 
            this.dnameDataGridViewTextBoxColumn.DataPropertyName = "d_name";
            this.dnameDataGridViewTextBoxColumn.HeaderText = "d_name";
            this.dnameDataGridViewTextBoxColumn.Name = "dnameDataGridViewTextBoxColumn";
            // 
            // fyearDataGridViewTextBoxColumn
            // 
            this.fyearDataGridViewTextBoxColumn.DataPropertyName = "f_year";
            this.fyearDataGridViewTextBoxColumn.HeaderText = "f_year";
            this.fyearDataGridViewTextBoxColumn.Name = "fyearDataGridViewTextBoxColumn";
            // 
            // pnameDataGridViewTextBoxColumn1
            // 
            this.pnameDataGridViewTextBoxColumn1.DataPropertyName = "p_name";
            this.pnameDataGridViewTextBoxColumn1.HeaderText = "p_name";
            this.pnameDataGridViewTextBoxColumn1.Name = "pnameDataGridViewTextBoxColumn1";
            // 
            // findedFilmsNewBindingSource
            // 
            this.findedFilmsNewBindingSource.DataMember = "FindedFilmsNew";
            this.findedFilmsNewBindingSource.DataSource = this.newDS;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // actorsTableAdapter
            // 
            this.actorsTableAdapter.ClearBeforeFill = true;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // producersTableAdapter
            // 
            this.producersTableAdapter.ClearBeforeFill = true;
            // 
            // viewersTableAdapter
            // 
            this.viewersTableAdapter.ClearBeforeFill = true;
            // 
            // filmsGenresTableAdapter
            // 
            this.filmsGenresTableAdapter.ClearBeforeFill = true;
            // 
            // filmsActorsTableAdapter
            // 
            this.filmsActorsTableAdapter.ClearBeforeFill = true;
            // 
            // viewersFilmsTableAdapter
            // 
            this.viewersFilmsTableAdapter.ClearBeforeFill = true;
            // 
            // findedFilmsNewTableAdapter
            // 
            this.findedFilmsNewTableAdapter.ClearBeforeFill = true;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(841, 11);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(106, 23);
            this.btnRegistration.TabIndex = 2;
            this.btnRegistration.Text = "Реєстрація";
            this.btnRegistration.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(729, 11);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(106, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Увійти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnEditing
            // 
            this.btnEditing.Location = new System.Drawing.Point(841, 41);
            this.btnEditing.Name = "btnEditing";
            this.btnEditing.Size = new System.Drawing.Size(106, 23);
            this.btnEditing.TabIndex = 4;
            this.btnEditing.Text = "Редагування";
            this.btnEditing.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(729, 41);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(106, 23);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "Мій список";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(729, 25);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtbLogin
            // 
            this.txtbLogin.Location = new System.Drawing.Point(626, 13);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(100, 20);
            this.txtbLogin.TabIndex = 7;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(626, 43);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(100, 20);
            this.txtbPassword.TabIndex = 8;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(583, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(37, 13);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Логін ";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(575, 46);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Пароль";
            // 
            // btnSearchFilms
            // 
            this.btnSearchFilms.Location = new System.Drawing.Point(6, 160);
            this.btnSearchFilms.Name = "btnSearchFilms";
            this.btnSearchFilms.Size = new System.Drawing.Size(294, 23);
            this.btnSearchFilms.TabIndex = 11;
            this.btnSearchFilms.Text = "Пошук фільмів";
            this.btnSearchFilms.UseVisualStyleBackColor = true;
            this.btnSearchFilms.Click += new System.EventHandler(this.btnSearchFilms_Click);
            // 
            // cmbSearchFilmsName
            // 
            this.cmbSearchFilmsName.DataSource = this.filmsBindingSource1;
            this.cmbSearchFilmsName.DisplayMember = "d_name";
            this.cmbSearchFilmsName.FormattingEnabled = true;
            this.cmbSearchFilmsName.Location = new System.Drawing.Point(120, 6);
            this.cmbSearchFilmsName.Name = "cmbSearchFilmsName";
            this.cmbSearchFilmsName.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsName.TabIndex = 12;
            // 
            // filmsBindingSource1
            // 
            this.filmsBindingSource1.DataMember = "Films";
            this.filmsBindingSource1.DataSource = this.newDS;
            // 
            // cmbSearchFilmsActor
            // 
            this.cmbSearchFilmsActor.DataSource = this.actorsBindingSource1;
            this.cmbSearchFilmsActor.DisplayMember = "a_name";
            this.cmbSearchFilmsActor.FormattingEnabled = true;
            this.cmbSearchFilmsActor.Location = new System.Drawing.Point(120, 114);
            this.cmbSearchFilmsActor.Name = "cmbSearchFilmsActor";
            this.cmbSearchFilmsActor.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsActor.TabIndex = 13;
            // 
            // actorsBindingSource1
            // 
            this.actorsBindingSource1.DataMember = "Actors";
            this.actorsBindingSource1.DataSource = this.newDS;
            // 
            // cmbSearchFilmsProducer
            // 
            this.cmbSearchFilmsProducer.DataSource = this.producersBindingSource1;
            this.cmbSearchFilmsProducer.DisplayMember = "p_name";
            this.cmbSearchFilmsProducer.FormattingEnabled = true;
            this.cmbSearchFilmsProducer.Location = new System.Drawing.Point(120, 87);
            this.cmbSearchFilmsProducer.Name = "cmbSearchFilmsProducer";
            this.cmbSearchFilmsProducer.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsProducer.TabIndex = 14;
            this.cmbSearchFilmsProducer.SelectedIndexChanged += new System.EventHandler(this.cmbSearchFilmsProducer_SelectedIndexChanged);
            // 
            // producersBindingSource1
            // 
            this.producersBindingSource1.DataMember = "Producers";
            this.producersBindingSource1.DataSource = this.newDS;
            // 
            // cmbSearchFilmsGenre
            // 
            this.cmbSearchFilmsGenre.DataSource = this.genresBindingSource1;
            this.cmbSearchFilmsGenre.DisplayMember = "g_name";
            this.cmbSearchFilmsGenre.FormattingEnabled = true;
            this.cmbSearchFilmsGenre.Location = new System.Drawing.Point(120, 60);
            this.cmbSearchFilmsGenre.Name = "cmbSearchFilmsGenre";
            this.cmbSearchFilmsGenre.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsGenre.TabIndex = 15;
            // 
            // genresBindingSource1
            // 
            this.genresBindingSource1.DataMember = "Genres";
            this.genresBindingSource1.DataSource = this.newDS;
            // 
            // cmbSearchFilmsYear
            // 
            this.cmbSearchFilmsYear.DataSource = this.filmsBindingSource1;
            this.cmbSearchFilmsYear.DisplayMember = "f_year";
            this.cmbSearchFilmsYear.FormattingEnabled = true;
            this.cmbSearchFilmsYear.Location = new System.Drawing.Point(120, 33);
            this.cmbSearchFilmsYear.Name = "cmbSearchFilmsYear";
            this.cmbSearchFilmsYear.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsYear.TabIndex = 16;
            this.cmbSearchFilmsYear.SelectedIndexChanged += new System.EventHandler(this.cmbSearchFilmsYear_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Рік";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Режисер";
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
            // tabContro
            // 
            this.tabContro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContro.Controls.Add(this.tabPage1);
            this.tabContro.Controls.Add(this.tabPage2);
            this.tabContro.Controls.Add(this.tabPage3);
            this.tabContro.Controls.Add(this.tabPage4);
            this.tabContro.Location = new System.Drawing.Point(12, 70);
            this.tabContro.Name = "tabContro";
            this.tabContro.SelectedIndex = 0;
            this.tabContro.Size = new System.Drawing.Size(933, 327);
            this.tabContro.TabIndex = 22;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(925, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фільми";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSearchGenres);
            this.tabPage2.Controls.Add(this.btnSearchGenre);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmbSearchGenre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Жанри";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSearchGenres
            // 
            this.dgvSearchGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchGenres.AutoGenerateColumns = false;
            this.dgvSearchGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gidDataGridViewTextBoxColumn,
            this.gnameDataGridViewTextBoxColumn});
            this.dgvSearchGenres.DataSource = this.findedGenresBindingSource;
            this.dgvSearchGenres.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchGenres.Name = "dgvSearchGenres";
            this.dgvSearchGenres.Size = new System.Drawing.Size(613, 289);
            this.dgvSearchGenres.TabIndex = 3;
            // 
            // gidDataGridViewTextBoxColumn
            // 
            this.gidDataGridViewTextBoxColumn.DataPropertyName = "g_id";
            this.gidDataGridViewTextBoxColumn.HeaderText = "g_id";
            this.gidDataGridViewTextBoxColumn.Name = "gidDataGridViewTextBoxColumn";
            this.gidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gnameDataGridViewTextBoxColumn
            // 
            this.gnameDataGridViewTextBoxColumn.DataPropertyName = "g_name";
            this.gnameDataGridViewTextBoxColumn.HeaderText = "g_name";
            this.gnameDataGridViewTextBoxColumn.Name = "gnameDataGridViewTextBoxColumn";
            // 
            // findedGenresBindingSource
            // 
            this.findedGenresBindingSource.DataMember = "FindedGenres";
            this.findedGenresBindingSource.DataSource = this.newDS;
            // 
            // btnSearchGenre
            // 
            this.btnSearchGenre.Location = new System.Drawing.Point(6, 160);
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
            this.cmbSearchGenre.DataSource = this.genresBindingSource;
            this.cmbSearchGenre.DisplayMember = "g_name";
            this.cmbSearchGenre.FormattingEnabled = true;
            this.cmbSearchGenre.Location = new System.Drawing.Point(120, 6);
            this.cmbSearchGenre.Name = "cmbSearchGenre";
            this.cmbSearchGenre.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchGenre.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvSearchProducers);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cmbSearchProducerBirth);
            this.tabPage3.Controls.Add(this.cmbSearchProducerDeath);
            this.tabPage3.Controls.Add(this.cmbSearchProducerName);
            this.tabPage3.Controls.Add(this.btnSearchProducer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(925, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Режисери";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvSearchProducers
            // 
            this.dgvSearchProducers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchProducers.AutoGenerateColumns = false;
            this.dgvSearchProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchProducers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.pbirthDataGridViewTextBoxColumn,
            this.pdeathDataGridViewTextBoxColumn});
            this.dgvSearchProducers.DataSource = this.findedProducersBindingSource;
            this.dgvSearchProducers.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchProducers.Name = "dgvSearchProducers";
            this.dgvSearchProducers.Size = new System.Drawing.Size(613, 289);
            this.dgvSearchProducers.TabIndex = 7;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "p_id";
            this.pidDataGridViewTextBoxColumn.HeaderText = "p_id";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "p_name";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "p_name";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            // 
            // pbirthDataGridViewTextBoxColumn
            // 
            this.pbirthDataGridViewTextBoxColumn.DataPropertyName = "p_birth";
            this.pbirthDataGridViewTextBoxColumn.HeaderText = "p_birth";
            this.pbirthDataGridViewTextBoxColumn.Name = "pbirthDataGridViewTextBoxColumn";
            // 
            // pdeathDataGridViewTextBoxColumn
            // 
            this.pdeathDataGridViewTextBoxColumn.DataPropertyName = "p_death";
            this.pdeathDataGridViewTextBoxColumn.HeaderText = "p_death";
            this.pdeathDataGridViewTextBoxColumn.Name = "pdeathDataGridViewTextBoxColumn";
            // 
            // findedProducersBindingSource
            // 
            this.findedProducersBindingSource.DataMember = "FindedProducers";
            this.findedProducersBindingSource.DataSource = this.newDS;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Рік народження";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Рік смерті";
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
            // cmbSearchProducerBirth
            // 
            this.cmbSearchProducerBirth.DataSource = this.producersBindingSource;
            this.cmbSearchProducerBirth.DisplayMember = "p_birth";
            this.cmbSearchProducerBirth.FormattingEnabled = true;
            this.cmbSearchProducerBirth.Location = new System.Drawing.Point(120, 33);
            this.cmbSearchProducerBirth.Name = "cmbSearchProducerBirth";
            this.cmbSearchProducerBirth.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchProducerBirth.TabIndex = 3;
            // 
            // cmbSearchProducerDeath
            // 
            this.cmbSearchProducerDeath.DataSource = this.producersBindingSource;
            this.cmbSearchProducerDeath.DisplayMember = "p_death";
            this.cmbSearchProducerDeath.FormattingEnabled = true;
            this.cmbSearchProducerDeath.Location = new System.Drawing.Point(120, 60);
            this.cmbSearchProducerDeath.Name = "cmbSearchProducerDeath";
            this.cmbSearchProducerDeath.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchProducerDeath.TabIndex = 2;
            // 
            // cmbSearchProducerName
            // 
            this.cmbSearchProducerName.DataSource = this.producersBindingSource;
            this.cmbSearchProducerName.DisplayMember = "p_name";
            this.cmbSearchProducerName.FormattingEnabled = true;
            this.cmbSearchProducerName.Location = new System.Drawing.Point(120, 6);
            this.cmbSearchProducerName.Name = "cmbSearchProducerName";
            this.cmbSearchProducerName.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchProducerName.TabIndex = 1;
            // 
            // btnSearchProducer
            // 
            this.btnSearchProducer.Location = new System.Drawing.Point(6, 160);
            this.btnSearchProducer.Name = "btnSearchProducer";
            this.btnSearchProducer.Size = new System.Drawing.Size(294, 23);
            this.btnSearchProducer.TabIndex = 0;
            this.btnSearchProducer.Text = "Пошук режисерів";
            this.btnSearchProducer.UseVisualStyleBackColor = true;
            this.btnSearchProducer.Click += new System.EventHandler(this.btnSearchProducer_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvSearchActors);
            this.tabPage4.Controls.Add(this.btnSearchActor);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.cmbSearchActorBirth);
            this.tabPage4.Controls.Add(this.cmbSearchActorDeath);
            this.tabPage4.Controls.Add(this.cmbSearchActorName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(925, 301);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Актори";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvSearchActors
            // 
            this.dgvSearchActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchActors.AutoGenerateColumns = false;
            this.dgvSearchActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aidDataGridViewTextBoxColumn,
            this.anameDataGridViewTextBoxColumn,
            this.abirthDataGridViewTextBoxColumn,
            this.adeathDataGridViewTextBoxColumn});
            this.dgvSearchActors.DataSource = this.findedActorsBindingSource;
            this.dgvSearchActors.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchActors.Name = "dgvSearchActors";
            this.dgvSearchActors.Size = new System.Drawing.Size(613, 289);
            this.dgvSearchActors.TabIndex = 7;
            // 
            // btnSearchActor
            // 
            this.btnSearchActor.Location = new System.Drawing.Point(6, 160);
            this.btnSearchActor.Name = "btnSearchActor";
            this.btnSearchActor.Size = new System.Drawing.Size(294, 23);
            this.btnSearchActor.TabIndex = 6;
            this.btnSearchActor.Text = "Пошук акторів";
            this.btnSearchActor.UseVisualStyleBackColor = true;
            this.btnSearchActor.Click += new System.EventHandler(this.btnSearchActor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Рік народження";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Рік смерті";
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
            // cmbSearchActorBirth
            // 
            this.cmbSearchActorBirth.DataSource = this.actorsBindingSource;
            this.cmbSearchActorBirth.DisplayMember = "a_birth";
            this.cmbSearchActorBirth.FormattingEnabled = true;
            this.cmbSearchActorBirth.Location = new System.Drawing.Point(120, 33);
            this.cmbSearchActorBirth.Name = "cmbSearchActorBirth";
            this.cmbSearchActorBirth.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchActorBirth.TabIndex = 2;
            // 
            // cmbSearchActorDeath
            // 
            this.cmbSearchActorDeath.DataSource = this.actorsBindingSource;
            this.cmbSearchActorDeath.DisplayMember = "a_death";
            this.cmbSearchActorDeath.FormattingEnabled = true;
            this.cmbSearchActorDeath.Location = new System.Drawing.Point(120, 60);
            this.cmbSearchActorDeath.Name = "cmbSearchActorDeath";
            this.cmbSearchActorDeath.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchActorDeath.TabIndex = 1;
            // 
            // cmbSearchActorName
            // 
            this.cmbSearchActorName.DataSource = this.actorsBindingSource;
            this.cmbSearchActorName.DisplayMember = "a_name";
            this.cmbSearchActorName.FormattingEnabled = true;
            this.cmbSearchActorName.Location = new System.Drawing.Point(120, 6);
            this.cmbSearchActorName.Name = "cmbSearchActorName";
            this.cmbSearchActorName.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchActorName.TabIndex = 0;
            // 
            // filmsGenresTableAdapter1
            // 
            this.filmsGenresTableAdapter1.ClearBeforeFill = true;
            // 
            // findedGenresTableAdapter
            // 
            this.findedGenresTableAdapter.ClearBeforeFill = true;
            // 
            // findedProducersTableAdapter
            // 
            this.findedProducersTableAdapter.ClearBeforeFill = true;
            // 
            // findedActorsBindingSource
            // 
            this.findedActorsBindingSource.DataMember = "FindedActors";
            this.findedActorsBindingSource.DataSource = this.newDS;
            // 
            // findedActorsTableAdapter
            // 
            this.findedActorsTableAdapter.ClearBeforeFill = true;
            // 
            // aidDataGridViewTextBoxColumn
            // 
            this.aidDataGridViewTextBoxColumn.DataPropertyName = "a_id";
            this.aidDataGridViewTextBoxColumn.HeaderText = "a_id";
            this.aidDataGridViewTextBoxColumn.Name = "aidDataGridViewTextBoxColumn";
            this.aidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anameDataGridViewTextBoxColumn
            // 
            this.anameDataGridViewTextBoxColumn.DataPropertyName = "a_name";
            this.anameDataGridViewTextBoxColumn.HeaderText = "a_name";
            this.anameDataGridViewTextBoxColumn.Name = "anameDataGridViewTextBoxColumn";
            // 
            // abirthDataGridViewTextBoxColumn
            // 
            this.abirthDataGridViewTextBoxColumn.DataPropertyName = "a_birth";
            this.abirthDataGridViewTextBoxColumn.HeaderText = "a_birth";
            this.abirthDataGridViewTextBoxColumn.Name = "abirthDataGridViewTextBoxColumn";
            // 
            // adeathDataGridViewTextBoxColumn
            // 
            this.adeathDataGridViewTextBoxColumn.DataPropertyName = "a_death";
            this.adeathDataGridViewTextBoxColumn.HeaderText = "a_death";
            this.adeathDataGridViewTextBoxColumn.Name = "adeathDataGridViewTextBoxColumn";
            // 
            // FormFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 685);
            this.Controls.Add(this.tabContro);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnEditing);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.tabControlFilms);
            this.Name = "FormFilms";
            this.Text = "Фільми";
            this.Load += new System.EventHandler(this.FormFilms_Load);
            this.tabControlFilms.ResumeLayout(false);
            this.tabActors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDS)).EndInit();
            this.tabFilms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            this.tabGenres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            this.tabProducers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).EndInit();
            this.tabViewers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewersBindingSource)).EndInit();
            this.tabFilmsGenres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsGenresBindingSource)).EndInit();
            this.tabFilmsActors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsActorsBindingSource)).EndInit();
            this.tabViewersFilms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewersFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewersFilmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedFilmsNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource1)).EndInit();
            this.tabContro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedGenresBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProducers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedProducersBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedActorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFilms;
        private System.Windows.Forms.TabPage tabFilms;
        private System.Windows.Forms.TabPage tabGenres;
        private System.Windows.Forms.TabPage tabProducers;
        private System.Windows.Forms.TabPage tabViewers;
        private System.Windows.Forms.TabPage tabFilmsGenres;
        private System.Windows.Forms.TabPage tabFilmsActors;
        private System.Windows.Forms.TabPage tabViewersFilms;
        private System.Windows.Forms.DataGridView dgvFilms;
        private System.Windows.Forms.DataGridView dgvGenres;
        private System.Windows.Forms.DataGridView dgvProducers;
        private System.Windows.Forms.DataGridView dgvViewers;
        private System.Windows.Forms.Button btnSaveFilms;
        private System.Windows.Forms.Button btnSaveProducers;
        private System.Windows.Forms.TabPage tabActors;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.Button btnSaveActors;
        private System.Windows.Forms.Button btnDeleteActors;
        private System.Windows.Forms.Button btnDeleteProducer;
        private System.Windows.Forms.Button btnDeleteFilms;
        private System.Windows.Forms.Button btnDeleteGenres;
        private System.Windows.Forms.Button btnSaveGenres;
        private System.Windows.Forms.Button btnDeleteViewers;
        private System.Windows.Forms.Button btnSaveViewers;
        private System.Windows.Forms.Button btnDeleteFilmsGenres;
        private System.Windows.Forms.Button btnSaveFilmsGenres;
        private System.Windows.Forms.Button btnDeleteFilmsActors;
        private System.Windows.Forms.Button btnSaveFilmsActors;
        private System.Windows.Forms.Button btnDeleteViewersFilms;
        private System.Windows.Forms.Button btnSaveViewersFilms;
        private System.Windows.Forms.DataGridView dgvFilmsGenres;
        private System.Windows.Forms.DataGridView dgvFilmsActors;
        private System.Windows.Forms.DataGridView dgvViewersFilms;
        private NewDS newDS;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private NewDSTableAdapters.FilmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private NewDSTableAdapters.ActorsTableAdapter actorsTableAdapter;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private NewDSTableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.BindingSource producersBindingSource;
        private NewDSTableAdapters.ProducersTableAdapter producersTableAdapter;
        private System.Windows.Forms.BindingSource viewersBindingSource;
        private NewDSTableAdapters.ViewersTableAdapter viewersTableAdapter;
        private System.Windows.Forms.BindingSource filmsGenresBindingSource;
        private NewDSTableAdapters.FilmsGenresTableAdapter filmsGenresTableAdapter;
        private System.Windows.Forms.BindingSource filmsActorsBindingSource;
        private NewDSTableAdapters.FilmsActorsTableAdapter filmsActorsTableAdapter;
        private System.Windows.Forms.BindingSource viewersFilmsBindingSource;
        private NewDSTableAdapters.ViewersFilmsTableAdapter viewersFilmsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_death;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_death;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_mail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn v_admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fg_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fg_f_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fg_g_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fa_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fa_f_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fa_a_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vf_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vf_f_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vf_v_id;
        private System.Windows.Forms.DataGridView dgvSearchFilms;
        private System.Windows.Forms.BindingSource findedFilmsNewBindingSource;
        private NewDSTableAdapters.FindedFilmsNewTableAdapter findedFilmsNewTableAdapter;
        private NewDSTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnEditing;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSearchFilms;
        private System.Windows.Forms.ComboBox cmbSearchFilmsName;
        private System.Windows.Forms.BindingSource filmsBindingSource1;
        private System.Windows.Forms.ComboBox cmbSearchFilmsActor;
        private System.Windows.Forms.ComboBox cmbSearchFilmsProducer;
        private System.Windows.Forms.ComboBox cmbSearchFilmsGenre;
        private System.Windows.Forms.ComboBox cmbSearchFilmsYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource actorsBindingSource1;
        private System.Windows.Forms.BindingSource producersBindingSource1;
        private System.Windows.Forms.BindingSource genresBindingSource1;
        private System.Windows.Forms.TabControl tabContro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSearchGenres;
        private System.Windows.Forms.Button btnSearchGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSearchGenre;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvSearchProducers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSearchProducerBirth;
        private System.Windows.Forms.ComboBox cmbSearchProducerDeath;
        private System.Windows.Forms.ComboBox cmbSearchProducerName;
        private System.Windows.Forms.Button btnSearchProducer;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvSearchActors;
        private System.Windows.Forms.Button btnSearchActor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSearchActorBirth;
        private System.Windows.Forms.ComboBox cmbSearchActorDeath;
        private System.Windows.Forms.ComboBox cmbSearchActorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdeathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn1;
        private FilmsBDDataSet3TableAdapters.FilmsGenresTableAdapter filmsGenresTableAdapter1;
        private System.Windows.Forms.BindingSource findedGenresBindingSource;
        private NewDSTableAdapters.FindedGenresTableAdapter findedGenresTableAdapter;
        private System.Windows.Forms.BindingSource findedProducersBindingSource;
        private NewDSTableAdapters.FindedProducersTableAdapter findedProducersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adeathDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource findedActorsBindingSource;
        private NewDSTableAdapters.FindedActorsTableAdapter findedActorsTableAdapter;
    }
}

