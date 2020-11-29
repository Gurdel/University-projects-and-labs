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
            this.tabControlChenging = new System.Windows.Forms.TabControl();
            this.tabFilms = new System.Windows.Forms.TabPage();
            this.lblEditFilms = new System.Windows.Forms.Label();
            this.cmbEditFilmProducer = new System.Windows.Forms.ComboBox();
            this.kProducers1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kalichDS1 = new WinFormFilmsBD.KalichDS();
            this.btnEditFilmStart = new System.Windows.Forms.Button();
            this.cmbEditFilmYear = new System.Windows.Forms.ComboBox();
            this.kFilmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEditFilmName = new System.Windows.Forms.ComboBox();
            this.lblEditFilmsYear = new System.Windows.Forms.Label();
            this.lblEditFilmsName = new System.Windows.Forms.Label();
            this.btnEditFilmClear = new System.Windows.Forms.Button();
            this.btnEditFilmsAddActor = new System.Windows.Forms.Button();
            this.btnEditFilmsAddGenre = new System.Windows.Forms.Button();
            this.cmbEditFilmChooseGenres = new System.Windows.Forms.ComboBox();
            this.btnEditFilmEdit = new System.Windows.Forms.Button();
            this.cmbEditFilmActor = new System.Windows.Forms.ComboBox();
            this.kActorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEditFilmChooseActors = new System.Windows.Forms.ComboBox();
            this.cmbEditFilmsGenre = new System.Windows.Forms.ComboBox();
            this.kGenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFilmEndAdd = new System.Windows.Forms.Button();
            this.lblAddFilmProducer = new System.Windows.Forms.Label();
            this.lblAddFilmYear = new System.Windows.Forms.Label();
            this.lblAddFilmName = new System.Windows.Forms.Label();
            this.btnAddFilmClear = new System.Windows.Forms.Button();
            this.txtbAddFilmName = new System.Windows.Forms.TextBox();
            this.btnAddFilmSelectActor = new System.Windows.Forms.Button();
            this.txtbAddFilmYear = new System.Windows.Forms.TextBox();
            this.btnAddFilmSelectGenre = new System.Windows.Forms.Button();
            this.cmbAddFilmSelectedGenres = new System.Windows.Forms.ComboBox();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.cmbAddFilmActors = new System.Windows.Forms.ComboBox();
            this.cmbAddFilmProducer = new System.Windows.Forms.ComboBox();
            this.cmbAddFilmSelectedActors = new System.Windows.Forms.ComboBox();
            this.cmbAddFilmGenres = new System.Windows.Forms.ComboBox();
            this.btnFilmsAddNew = new System.Windows.Forms.Button();
            this.btnDeleteFilms = new System.Windows.Forms.Button();
            this.btnSaveFilms = new System.Windows.Forms.Button();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.tabGenres = new System.Windows.Forms.TabPage();
            this.btnGenresEndAdd = new System.Windows.Forms.Button();
            this.txtbAddGenre = new System.Windows.Forms.TextBox();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnGenreAddNew = new System.Windows.Forms.Button();
            this.lblAddGenre = new System.Windows.Forms.Label();
            this.btnDeleteGenres = new System.Windows.Forms.Button();
            this.btnSaveGenres = new System.Windows.Forms.Button();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.g_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProducers = new System.Windows.Forms.TabPage();
            this.btnProducerEndAdd = new System.Windows.Forms.Button();
            this.txtbAddProducer = new System.Windows.Forms.TextBox();
            this.btnAddProducer = new System.Windows.Forms.Button();
            this.btnProducerAddNew = new System.Windows.Forms.Button();
            this.lblAddProducer = new System.Windows.Forms.Label();
            this.btnDeleteProducer = new System.Windows.Forms.Button();
            this.btnSaveProducers = new System.Windows.Forms.Button();
            this.dgvProducers = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_filmslist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabActors = new System.Windows.Forms.TabPage();
            this.btnAddActor = new System.Windows.Forms.Button();
            this.txtbAddActor = new System.Windows.Forms.TextBox();
            this.lblAddActor = new System.Windows.Forms.Label();
            this.btnActorEndAdd = new System.Windows.Forms.Button();
            this.btnActorAddNew = new System.Windows.Forms.Button();
            this.btnDeleteActors = new System.Windows.Forms.Button();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.a_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveActors = new System.Windows.Forms.Button();
            this.tabViewers = new System.Windows.Forms.TabPage();
            this.btnDeleteViewers = new System.Windows.Forms.Button();
            this.btnSaveViewers = new System.Windows.Forms.Button();
            this.dgvViewers = new System.Windows.Forms.DataGridView();
            this.v_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_wishlist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_watchedlist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_boughtlist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kViewersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSearchFilms = new System.Windows.Forms.DataGridView();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kFindedFilmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kalichDS = new WinFormFilmsBD.KalichDS();
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
            this.cmbSearchFilmsActor = new System.Windows.Forms.ComboBox();
            this.cmbSearchFilmsProducer = new System.Windows.Forms.ComboBox();
            this.cmbSearchFilmsGenre = new System.Windows.Forms.ComboBox();
            this.cmbSearchFilmsYear = new System.Windows.Forms.ComboBox();
            this.filmsYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlSearch = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnWish = new System.Windows.Forms.Button();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSearchGenres = new System.Windows.Forms.DataGridView();
            this.gnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kFindedGenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchGenre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSearchGenre = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvSearchProducers = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kFindedProducersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSearchProducerName = new System.Windows.Forms.ComboBox();
            this.btnSearchProducer = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvSearchActors = new System.Windows.Forms.DataGridView();
            this.aidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kFindedActorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchActor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSearchActorName = new System.Windows.Forms.ComboBox();
            this.kActorsTableAdapter1 = new WinFormFilmsBD.KalichDSTableAdapters.KActorsTableAdapter();
            this.kFilmsTableAdapter1 = new WinFormFilmsBD.KalichDSTableAdapters.KFilmsTableAdapter();
            this.kGenresTableAdapter1 = new WinFormFilmsBD.KalichDSTableAdapters.KGenresTableAdapter();
            this.kViewersTableAdapter1 = new WinFormFilmsBD.KalichDSTableAdapters.KViewersTableAdapter();
            this.kProducers1TableAdapter1 = new WinFormFilmsBD.KalichDSTableAdapters.KProducers1TableAdapter();
            this.kQueriesTableAdapter1 = new WinFormFilmsBD.KalichDSTableAdapters.KQueriesTableAdapter();
            this.kFindedFilmsTableAdapter1 = new WinFormFilmsBD.KalichDSTableAdapters.KFindedFilmsTableAdapter();
            this.kFindedGenresTableAdapter1 = new WinFormFilmsBD.KalichDSTableAdapters.KFindedGenresTableAdapter();
            this.kFindedActorsTableAdapter1 = new WinFormFilmsBD.KalichDSTableAdapters.KFindedActorsTableAdapter();
            this.kFindedProducersTableAdapter1 = new WinFormFilmsBD.KalichDSTableAdapters.KFindedProducersTableAdapter();
            this.txtbRegistrationUsername = new System.Windows.Forms.TextBox();
            this.txtbRegistrationName = new System.Windows.Forms.TextBox();
            this.txtbRegistrationPassword = new System.Windows.Forms.TextBox();
            this.btnRegistr = new System.Windows.Forms.Button();
            this.lblRegLogin = new System.Windows.Forms.Label();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.lblRegName = new System.Windows.Forms.Label();
            this.btnRegCancel = new System.Windows.Forms.Button();
            this.btnEndEdit = new System.Windows.Forms.Button();
            this.btnSaveAllChanges = new System.Windows.Forms.Button();
            this.cmbWish = new System.Windows.Forms.ComboBox();
            this.cmbBuy = new System.Windows.Forms.ComboBox();
            this.cmbWatch = new System.Windows.Forms.ComboBox();
            this.lblWish = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblWatch = new System.Windows.Forms.Label();
            this.btnListEnd = new System.Windows.Forms.Button();
            this.rtbWish = new System.Windows.Forms.RichTextBox();
            this.rtbWatch = new System.Windows.Forms.RichTextBox();
            this.rtbBuy = new System.Windows.Forms.RichTextBox();
            this.filmsYearTableAdapter = new WinFormFilmsBD.KalichDSTableAdapters.FilmsYearTableAdapter();
            this.btnClearWish = new System.Windows.Forms.Button();
            this.f_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_genreslist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_actorslist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlChenging.SuspendLayout();
            this.tabFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kProducers1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalichDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFilmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kActorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kGenresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.tabGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.tabProducers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducers)).BeginInit();
            this.tabActors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.tabViewers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kViewersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFindedFilmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalichDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsYearBindingSource)).BeginInit();
            this.tabControlSearch.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFindedGenresBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProducers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFindedProducersBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFindedActorsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tabControlChenging.Location = new System.Drawing.Point(20, 355);
            this.tabControlChenging.Name = "tabControlChenging";
            this.tabControlChenging.SelectedIndex = 0;
            this.tabControlChenging.Size = new System.Drawing.Size(933, 280);
            this.tabControlChenging.TabIndex = 0;
            this.tabControlChenging.Visible = false;
            // 
            // tabFilms
            // 
            this.tabFilms.Controls.Add(this.lblEditFilms);
            this.tabFilms.Controls.Add(this.cmbEditFilmProducer);
            this.tabFilms.Controls.Add(this.btnEditFilmStart);
            this.tabFilms.Controls.Add(this.cmbEditFilmYear);
            this.tabFilms.Controls.Add(this.cmbEditFilmName);
            this.tabFilms.Controls.Add(this.lblEditFilmsYear);
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
            this.tabFilms.Controls.Add(this.lblAddFilmYear);
            this.tabFilms.Controls.Add(this.lblAddFilmName);
            this.tabFilms.Controls.Add(this.btnAddFilmClear);
            this.tabFilms.Controls.Add(this.txtbAddFilmName);
            this.tabFilms.Controls.Add(this.btnAddFilmSelectActor);
            this.tabFilms.Controls.Add(this.txtbAddFilmYear);
            this.tabFilms.Controls.Add(this.btnAddFilmSelectGenre);
            this.tabFilms.Controls.Add(this.cmbAddFilmSelectedGenres);
            this.tabFilms.Controls.Add(this.btnAddFilm);
            this.tabFilms.Controls.Add(this.cmbAddFilmActors);
            this.tabFilms.Controls.Add(this.cmbAddFilmProducer);
            this.tabFilms.Controls.Add(this.cmbAddFilmSelectedActors);
            this.tabFilms.Controls.Add(this.cmbAddFilmGenres);
            this.tabFilms.Controls.Add(this.btnFilmsAddNew);
            this.tabFilms.Controls.Add(this.btnDeleteFilms);
            this.tabFilms.Controls.Add(this.btnSaveFilms);
            this.tabFilms.Controls.Add(this.dgvFilms);
            this.tabFilms.Location = new System.Drawing.Point(4, 22);
            this.tabFilms.Name = "tabFilms";
            this.tabFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilms.Size = new System.Drawing.Size(925, 254);
            this.tabFilms.TabIndex = 1;
            this.tabFilms.Text = "Фільми";
            this.tabFilms.UseVisualStyleBackColor = true;
            this.tabFilms.UseWaitCursor = true;
            // 
            // lblEditFilms
            // 
            this.lblEditFilms.AutoSize = true;
            this.lblEditFilms.Location = new System.Drawing.Point(522, 153);
            this.lblEditFilms.Name = "lblEditFilms";
            this.lblEditFilms.Size = new System.Drawing.Size(52, 13);
            this.lblEditFilms.TabIndex = 36;
            this.lblEditFilms.Text = "Режисер";
            this.lblEditFilms.UseWaitCursor = true;
            this.lblEditFilms.Visible = false;
            // 
            // cmbEditFilmProducer
            // 
            this.cmbEditFilmProducer.DataSource = this.kProducers1BindingSource;
            this.cmbEditFilmProducer.DisplayMember = "p_name";
            this.cmbEditFilmProducer.FormattingEnabled = true;
            this.cmbEditFilmProducer.Location = new System.Drawing.Point(603, 145);
            this.cmbEditFilmProducer.Name = "cmbEditFilmProducer";
            this.cmbEditFilmProducer.Size = new System.Drawing.Size(121, 21);
            this.cmbEditFilmProducer.TabIndex = 35;
            this.cmbEditFilmProducer.UseWaitCursor = true;
            this.cmbEditFilmProducer.Visible = false;
            // 
            // kProducers1BindingSource
            // 
            this.kProducers1BindingSource.DataMember = "Producers1";
            this.kProducers1BindingSource.DataSource = this.kalichDS1;
            // 
            // kalichDS1
            // 
            this.kalichDS1.DataSetName = "KalichDS";
            this.kalichDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEditFilmStart
            // 
            this.btnEditFilmStart.Location = new System.Drawing.Point(345, 5);
            this.btnEditFilmStart.Name = "btnEditFilmStart";
            this.btnEditFilmStart.Size = new System.Drawing.Size(87, 23);
            this.btnEditFilmStart.TabIndex = 34;
            this.btnEditFilmStart.Text = "Редагувати";
            this.btnEditFilmStart.UseVisualStyleBackColor = true;
            this.btnEditFilmStart.UseWaitCursor = true;
            this.btnEditFilmStart.Click += new System.EventHandler(this.btnEditFilmStart_Click);
            // 
            // cmbEditFilmYear
            // 
            this.cmbEditFilmYear.DataSource = this.kFilmsBindingSource;
            this.cmbEditFilmYear.DisplayMember = "f_year";
            this.cmbEditFilmYear.FormattingEnabled = true;
            this.cmbEditFilmYear.Location = new System.Drawing.Point(602, 64);
            this.cmbEditFilmYear.Name = "cmbEditFilmYear";
            this.cmbEditFilmYear.Size = new System.Drawing.Size(121, 21);
            this.cmbEditFilmYear.TabIndex = 33;
            this.cmbEditFilmYear.UseWaitCursor = true;
            this.cmbEditFilmYear.Visible = false;
            // 
            // kFilmsBindingSource
            // 
            this.kFilmsBindingSource.DataMember = "Films";
            this.kFilmsBindingSource.DataSource = this.kalichDS1;
            // 
            // cmbEditFilmName
            // 
            this.cmbEditFilmName.DataSource = this.kFilmsBindingSource;
            this.cmbEditFilmName.DisplayMember = "f_name";
            this.cmbEditFilmName.FormattingEnabled = true;
            this.cmbEditFilmName.Location = new System.Drawing.Point(602, 37);
            this.cmbEditFilmName.Name = "cmbEditFilmName";
            this.cmbEditFilmName.Size = new System.Drawing.Size(121, 21);
            this.cmbEditFilmName.TabIndex = 32;
            this.cmbEditFilmName.UseWaitCursor = true;
            this.cmbEditFilmName.Visible = false;
            // 
            // lblEditFilmsYear
            // 
            this.lblEditFilmsYear.AutoSize = true;
            this.lblEditFilmsYear.Location = new System.Drawing.Point(536, 68);
            this.lblEditFilmsYear.Name = "lblEditFilmsYear";
            this.lblEditFilmsYear.Size = new System.Drawing.Size(22, 13);
            this.lblEditFilmsYear.TabIndex = 31;
            this.lblEditFilmsYear.Text = "Рік";
            this.lblEditFilmsYear.UseWaitCursor = true;
            this.lblEditFilmsYear.Visible = false;
            // 
            // lblEditFilmsName
            // 
            this.lblEditFilmsName.AutoSize = true;
            this.lblEditFilmsName.Location = new System.Drawing.Point(527, 45);
            this.lblEditFilmsName.Name = "lblEditFilmsName";
            this.lblEditFilmsName.Size = new System.Drawing.Size(39, 13);
            this.lblEditFilmsName.TabIndex = 30;
            this.lblEditFilmsName.Text = "Назва";
            this.lblEditFilmsName.UseWaitCursor = true;
            this.lblEditFilmsName.Visible = false;
            // 
            // btnEditFilmClear
            // 
            this.btnEditFilmClear.Location = new System.Drawing.Point(603, 201);
            this.btnEditFilmClear.Name = "btnEditFilmClear";
            this.btnEditFilmClear.Size = new System.Drawing.Size(120, 23);
            this.btnEditFilmClear.TabIndex = 29;
            this.btnEditFilmClear.Text = "Очистити";
            this.btnEditFilmClear.UseVisualStyleBackColor = true;
            this.btnEditFilmClear.UseWaitCursor = true;
            this.btnEditFilmClear.Visible = false;
            this.btnEditFilmClear.Click += new System.EventHandler(this.btnEditFilmClear_Click);
            // 
            // btnEditFilmsAddActor
            // 
            this.btnEditFilmsAddActor.Location = new System.Drawing.Point(498, 118);
            this.btnEditFilmsAddActor.Name = "btnEditFilmsAddActor";
            this.btnEditFilmsAddActor.Size = new System.Drawing.Size(98, 23);
            this.btnEditFilmsAddActor.TabIndex = 28;
            this.btnEditFilmsAddActor.Text = "Вибрати актора";
            this.btnEditFilmsAddActor.UseVisualStyleBackColor = true;
            this.btnEditFilmsAddActor.UseWaitCursor = true;
            this.btnEditFilmsAddActor.Visible = false;
            this.btnEditFilmsAddActor.Click += new System.EventHandler(this.btnEditFilmsAddActor_Click);
            // 
            // btnEditFilmsAddGenre
            // 
            this.btnEditFilmsAddGenre.Location = new System.Drawing.Point(498, 91);
            this.btnEditFilmsAddGenre.Name = "btnEditFilmsAddGenre";
            this.btnEditFilmsAddGenre.Size = new System.Drawing.Size(98, 23);
            this.btnEditFilmsAddGenre.TabIndex = 27;
            this.btnEditFilmsAddGenre.Text = "Вибрати жанр";
            this.btnEditFilmsAddGenre.UseVisualStyleBackColor = true;
            this.btnEditFilmsAddGenre.UseWaitCursor = true;
            this.btnEditFilmsAddGenre.Visible = false;
            this.btnEditFilmsAddGenre.Click += new System.EventHandler(this.btnEditFilmsAddGenre_Click);
            // 
            // cmbEditFilmChooseGenres
            // 
            this.cmbEditFilmChooseGenres.FormattingEnabled = true;
            this.cmbEditFilmChooseGenres.Location = new System.Drawing.Point(729, 91);
            this.cmbEditFilmChooseGenres.Name = "cmbEditFilmChooseGenres";
            this.cmbEditFilmChooseGenres.Size = new System.Drawing.Size(121, 21);
            this.cmbEditFilmChooseGenres.TabIndex = 22;
            this.cmbEditFilmChooseGenres.UseWaitCursor = true;
            this.cmbEditFilmChooseGenres.Visible = false;
            // 
            // btnEditFilmEdit
            // 
            this.btnEditFilmEdit.Location = new System.Drawing.Point(749, 201);
            this.btnEditFilmEdit.Name = "btnEditFilmEdit";
            this.btnEditFilmEdit.Size = new System.Drawing.Size(101, 23);
            this.btnEditFilmEdit.TabIndex = 26;
            this.btnEditFilmEdit.Text = "Зберегти";
            this.btnEditFilmEdit.UseVisualStyleBackColor = true;
            this.btnEditFilmEdit.UseWaitCursor = true;
            this.btnEditFilmEdit.Visible = false;
            this.btnEditFilmEdit.Click += new System.EventHandler(this.btnEditFilmEdit_Click);
            // 
            // cmbEditFilmActor
            // 
            this.cmbEditFilmActor.DataSource = this.kActorsBindingSource;
            this.cmbEditFilmActor.DisplayMember = "a_name";
            this.cmbEditFilmActor.FormattingEnabled = true;
            this.cmbEditFilmActor.Location = new System.Drawing.Point(602, 118);
            this.cmbEditFilmActor.Name = "cmbEditFilmActor";
            this.cmbEditFilmActor.Size = new System.Drawing.Size(121, 21);
            this.cmbEditFilmActor.TabIndex = 23;
            this.cmbEditFilmActor.UseWaitCursor = true;
            this.cmbEditFilmActor.Visible = false;
            // 
            // kActorsBindingSource
            // 
            this.kActorsBindingSource.DataMember = "Actors";
            this.kActorsBindingSource.DataSource = this.kalichDS1;
            // 
            // cmbEditFilmChooseActors
            // 
            this.cmbEditFilmChooseActors.FormattingEnabled = true;
            this.cmbEditFilmChooseActors.Location = new System.Drawing.Point(729, 118);
            this.cmbEditFilmChooseActors.Name = "cmbEditFilmChooseActors";
            this.cmbEditFilmChooseActors.Size = new System.Drawing.Size(121, 21);
            this.cmbEditFilmChooseActors.TabIndex = 24;
            this.cmbEditFilmChooseActors.UseWaitCursor = true;
            this.cmbEditFilmChooseActors.Visible = false;
            // 
            // cmbEditFilmsGenre
            // 
            this.cmbEditFilmsGenre.DataSource = this.kGenresBindingSource;
            this.cmbEditFilmsGenre.DisplayMember = "g_name";
            this.cmbEditFilmsGenre.FormattingEnabled = true;
            this.cmbEditFilmsGenre.Location = new System.Drawing.Point(602, 91);
            this.cmbEditFilmsGenre.Name = "cmbEditFilmsGenre";
            this.cmbEditFilmsGenre.Size = new System.Drawing.Size(121, 21);
            this.cmbEditFilmsGenre.TabIndex = 21;
            this.cmbEditFilmsGenre.UseWaitCursor = true;
            this.cmbEditFilmsGenre.Visible = false;
            // 
            // kGenresBindingSource
            // 
            this.kGenresBindingSource.DataMember = "Genres";
            this.kGenresBindingSource.DataSource = this.kalichDS1;
            // 
            // btnFilmEndAdd
            // 
            this.btnFilmEndAdd.Location = new System.Drawing.Point(264, 5);
            this.btnFilmEndAdd.Name = "btnFilmEndAdd";
            this.btnFilmEndAdd.Size = new System.Drawing.Size(75, 23);
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
            this.lblAddFilmProducer.Location = new System.Drawing.Point(136, 162);
            this.lblAddFilmProducer.Name = "lblAddFilmProducer";
            this.lblAddFilmProducer.Size = new System.Drawing.Size(52, 13);
            this.lblAddFilmProducer.TabIndex = 17;
            this.lblAddFilmProducer.Text = "Режисер";
            this.lblAddFilmProducer.UseWaitCursor = true;
            this.lblAddFilmProducer.Visible = false;
            // 
            // lblAddFilmYear
            // 
            this.lblAddFilmYear.AutoSize = true;
            this.lblAddFilmYear.Location = new System.Drawing.Point(151, 77);
            this.lblAddFilmYear.Name = "lblAddFilmYear";
            this.lblAddFilmYear.Size = new System.Drawing.Size(22, 13);
            this.lblAddFilmYear.TabIndex = 16;
            this.lblAddFilmYear.Text = "Рік";
            this.lblAddFilmYear.UseWaitCursor = true;
            this.lblAddFilmYear.Visible = false;
            // 
            // lblAddFilmName
            // 
            this.lblAddFilmName.AutoSize = true;
            this.lblAddFilmName.Location = new System.Drawing.Point(142, 54);
            this.lblAddFilmName.Name = "lblAddFilmName";
            this.lblAddFilmName.Size = new System.Drawing.Size(39, 13);
            this.lblAddFilmName.TabIndex = 15;
            this.lblAddFilmName.Text = "Назва";
            this.lblAddFilmName.UseWaitCursor = true;
            this.lblAddFilmName.Visible = false;
            // 
            // btnAddFilmClear
            // 
            this.btnAddFilmClear.Location = new System.Drawing.Point(218, 210);
            this.btnAddFilmClear.Name = "btnAddFilmClear";
            this.btnAddFilmClear.Size = new System.Drawing.Size(120, 23);
            this.btnAddFilmClear.TabIndex = 13;
            this.btnAddFilmClear.Text = "Очистити";
            this.btnAddFilmClear.UseVisualStyleBackColor = true;
            this.btnAddFilmClear.UseWaitCursor = true;
            this.btnAddFilmClear.Visible = false;
            this.btnAddFilmClear.Click += new System.EventHandler(this.btnAddFilmClear_Click);
            // 
            // txtbAddFilmName
            // 
            this.txtbAddFilmName.Location = new System.Drawing.Point(217, 48);
            this.txtbAddFilmName.Name = "txtbAddFilmName";
            this.txtbAddFilmName.Size = new System.Drawing.Size(122, 20);
            this.txtbAddFilmName.TabIndex = 3;
            this.txtbAddFilmName.UseWaitCursor = true;
            this.txtbAddFilmName.Visible = false;
            // 
            // btnAddFilmSelectActor
            // 
            this.btnAddFilmSelectActor.Location = new System.Drawing.Point(113, 127);
            this.btnAddFilmSelectActor.Name = "btnAddFilmSelectActor";
            this.btnAddFilmSelectActor.Size = new System.Drawing.Size(98, 23);
            this.btnAddFilmSelectActor.TabIndex = 12;
            this.btnAddFilmSelectActor.Text = "Вибрати актора";
            this.btnAddFilmSelectActor.UseVisualStyleBackColor = true;
            this.btnAddFilmSelectActor.UseWaitCursor = true;
            this.btnAddFilmSelectActor.Visible = false;
            this.btnAddFilmSelectActor.Click += new System.EventHandler(this.btnAddFilmSelectActor_Click);
            // 
            // txtbAddFilmYear
            // 
            this.txtbAddFilmYear.Location = new System.Drawing.Point(218, 74);
            this.txtbAddFilmYear.Name = "txtbAddFilmYear";
            this.txtbAddFilmYear.Size = new System.Drawing.Size(121, 20);
            this.txtbAddFilmYear.TabIndex = 4;
            this.txtbAddFilmYear.UseWaitCursor = true;
            this.txtbAddFilmYear.Visible = false;
            // 
            // btnAddFilmSelectGenre
            // 
            this.btnAddFilmSelectGenre.Location = new System.Drawing.Point(113, 100);
            this.btnAddFilmSelectGenre.Name = "btnAddFilmSelectGenre";
            this.btnAddFilmSelectGenre.Size = new System.Drawing.Size(98, 23);
            this.btnAddFilmSelectGenre.TabIndex = 11;
            this.btnAddFilmSelectGenre.Text = "Вибрати жанр";
            this.btnAddFilmSelectGenre.UseVisualStyleBackColor = true;
            this.btnAddFilmSelectGenre.UseWaitCursor = true;
            this.btnAddFilmSelectGenre.Visible = false;
            this.btnAddFilmSelectGenre.Click += new System.EventHandler(this.btnAddFilmSelectGenre_Click);
            // 
            // cmbAddFilmSelectedGenres
            // 
            this.cmbAddFilmSelectedGenres.FormattingEnabled = true;
            this.cmbAddFilmSelectedGenres.Location = new System.Drawing.Point(344, 100);
            this.cmbAddFilmSelectedGenres.Name = "cmbAddFilmSelectedGenres";
            this.cmbAddFilmSelectedGenres.Size = new System.Drawing.Size(121, 21);
            this.cmbAddFilmSelectedGenres.TabIndex = 6;
            this.cmbAddFilmSelectedGenres.UseWaitCursor = true;
            this.cmbAddFilmSelectedGenres.Visible = false;
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(364, 210);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(101, 23);
            this.btnAddFilm.TabIndex = 10;
            this.btnAddFilm.Text = "Додати";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.UseWaitCursor = true;
            this.btnAddFilm.Visible = false;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // cmbAddFilmActors
            // 
            this.cmbAddFilmActors.DataSource = this.kActorsBindingSource;
            this.cmbAddFilmActors.DisplayMember = "a_name";
            this.cmbAddFilmActors.FormattingEnabled = true;
            this.cmbAddFilmActors.Location = new System.Drawing.Point(217, 127);
            this.cmbAddFilmActors.Name = "cmbAddFilmActors";
            this.cmbAddFilmActors.Size = new System.Drawing.Size(121, 21);
            this.cmbAddFilmActors.TabIndex = 7;
            this.cmbAddFilmActors.UseWaitCursor = true;
            this.cmbAddFilmActors.Visible = false;
            // 
            // cmbAddFilmProducer
            // 
            this.cmbAddFilmProducer.DataSource = this.kProducers1BindingSource;
            this.cmbAddFilmProducer.DisplayMember = "p_name";
            this.cmbAddFilmProducer.FormattingEnabled = true;
            this.cmbAddFilmProducer.Location = new System.Drawing.Point(217, 154);
            this.cmbAddFilmProducer.Name = "cmbAddFilmProducer";
            this.cmbAddFilmProducer.Size = new System.Drawing.Size(121, 21);
            this.cmbAddFilmProducer.TabIndex = 9;
            this.cmbAddFilmProducer.UseWaitCursor = true;
            this.cmbAddFilmProducer.Visible = false;
            // 
            // cmbAddFilmSelectedActors
            // 
            this.cmbAddFilmSelectedActors.FormattingEnabled = true;
            this.cmbAddFilmSelectedActors.Location = new System.Drawing.Point(344, 127);
            this.cmbAddFilmSelectedActors.Name = "cmbAddFilmSelectedActors";
            this.cmbAddFilmSelectedActors.Size = new System.Drawing.Size(121, 21);
            this.cmbAddFilmSelectedActors.TabIndex = 8;
            this.cmbAddFilmSelectedActors.UseWaitCursor = true;
            this.cmbAddFilmSelectedActors.Visible = false;
            // 
            // cmbAddFilmGenres
            // 
            this.cmbAddFilmGenres.DataSource = this.kGenresBindingSource;
            this.cmbAddFilmGenres.DisplayMember = "g_name";
            this.cmbAddFilmGenres.FormattingEnabled = true;
            this.cmbAddFilmGenres.Location = new System.Drawing.Point(217, 100);
            this.cmbAddFilmGenres.Name = "cmbAddFilmGenres";
            this.cmbAddFilmGenres.Size = new System.Drawing.Size(121, 21);
            this.cmbAddFilmGenres.TabIndex = 5;
            this.cmbAddFilmGenres.UseWaitCursor = true;
            this.cmbAddFilmGenres.Visible = false;
            // 
            // btnFilmsAddNew
            // 
            this.btnFilmsAddNew.Location = new System.Drawing.Point(170, 6);
            this.btnFilmsAddNew.Name = "btnFilmsAddNew";
            this.btnFilmsAddNew.Size = new System.Drawing.Size(87, 23);
            this.btnFilmsAddNew.TabIndex = 14;
            this.btnFilmsAddNew.Text = "Новий фільм";
            this.btnFilmsAddNew.UseVisualStyleBackColor = true;
            this.btnFilmsAddNew.UseWaitCursor = true;
            this.btnFilmsAddNew.Click += new System.EventHandler(this.btnFilmsAddNew_Click);
            // 
            // btnDeleteFilms
            // 
            this.btnDeleteFilms.Location = new System.Drawing.Point(89, 6);
            this.btnDeleteFilms.Name = "btnDeleteFilms";
            this.btnDeleteFilms.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFilms.TabIndex = 2;
            this.btnDeleteFilms.Text = "Видалити";
            this.btnDeleteFilms.UseVisualStyleBackColor = true;
            this.btnDeleteFilms.UseWaitCursor = true;
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
            this.btnSaveFilms.UseWaitCursor = true;
            this.btnSaveFilms.Click += new System.EventHandler(this.btnSaveFilms_Click);
            // 
            // dgvFilms
            // 
            this.dgvFilms.AllowUserToAddRows = false;
            this.dgvFilms.AllowUserToDeleteRows = false;
            this.dgvFilms.AutoGenerateColumns = false;
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f_name,
            this.f_year,
            this.f_genreslist,
            this.f_actorslist,
            this.f_producer});
            this.dgvFilms.DataSource = this.kFilmsBindingSource;
            this.dgvFilms.Location = new System.Drawing.Point(6, 35);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.Size = new System.Drawing.Size(885, 203);
            this.dgvFilms.TabIndex = 0;
            this.dgvFilms.UseWaitCursor = true;
            this.dgvFilms.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvFilms_CellBeginEdit);
            this.dgvFilms.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilms_CellEndEdit);
            // 
            // tabGenres
            // 
            this.tabGenres.Controls.Add(this.btnGenresEndAdd);
            this.tabGenres.Controls.Add(this.txtbAddGenre);
            this.tabGenres.Controls.Add(this.btnAddGenre);
            this.tabGenres.Controls.Add(this.btnGenreAddNew);
            this.tabGenres.Controls.Add(this.lblAddGenre);
            this.tabGenres.Controls.Add(this.btnDeleteGenres);
            this.tabGenres.Controls.Add(this.btnSaveGenres);
            this.tabGenres.Controls.Add(this.dgvGenres);
            this.tabGenres.Location = new System.Drawing.Point(4, 22);
            this.tabGenres.Name = "tabGenres";
            this.tabGenres.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenres.Size = new System.Drawing.Size(925, 254);
            this.tabGenres.TabIndex = 2;
            this.tabGenres.Text = "Жанри";
            this.tabGenres.UseVisualStyleBackColor = true;
            // 
            // btnGenresEndAdd
            // 
            this.btnGenresEndAdd.Location = new System.Drawing.Point(264, 7);
            this.btnGenresEndAdd.Name = "btnGenresEndAdd";
            this.btnGenresEndAdd.Size = new System.Drawing.Size(75, 23);
            this.btnGenresEndAdd.TabIndex = 7;
            this.btnGenresEndAdd.Text = "Таблиця";
            this.btnGenresEndAdd.UseVisualStyleBackColor = true;
            this.btnGenresEndAdd.Visible = false;
            this.btnGenresEndAdd.Click += new System.EventHandler(this.btnGenresEndAdd_Click);
            // 
            // txtbAddGenre
            // 
            this.txtbAddGenre.Location = new System.Drawing.Point(348, 67);
            this.txtbAddGenre.Name = "txtbAddGenre";
            this.txtbAddGenre.Size = new System.Drawing.Size(100, 20);
            this.txtbAddGenre.TabIndex = 6;
            this.txtbAddGenre.Visible = false;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(364, 127);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAddGenre.TabIndex = 5;
            this.btnAddGenre.Text = "Додати";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Visible = false;
            this.btnAddGenre.Click += new System.EventHandler(this.brnAddGenre_Click);
            // 
            // btnGenreAddNew
            // 
            this.btnGenreAddNew.Location = new System.Drawing.Point(171, 7);
            this.btnGenreAddNew.Name = "btnGenreAddNew";
            this.btnGenreAddNew.Size = new System.Drawing.Size(86, 23);
            this.btnGenreAddNew.TabIndex = 4;
            this.btnGenreAddNew.Text = "Новий жанр";
            this.btnGenreAddNew.UseVisualStyleBackColor = true;
            this.btnGenreAddNew.Click += new System.EventHandler(this.btnGenreAddNew_Click);
            // 
            // lblAddGenre
            // 
            this.lblAddGenre.AutoSize = true;
            this.lblAddGenre.Location = new System.Drawing.Point(258, 67);
            this.lblAddGenre.Name = "lblAddGenre";
            this.lblAddGenre.Size = new System.Drawing.Size(73, 13);
            this.lblAddGenre.TabIndex = 3;
            this.lblAddGenre.Text = "Назва жанру";
            this.lblAddGenre.Visible = false;
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
            this.g_name});
            this.dgvGenres.DataSource = this.kGenresBindingSource;
            this.dgvGenres.Location = new System.Drawing.Point(6, 36);
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.Size = new System.Drawing.Size(236, 202);
            this.dgvGenres.TabIndex = 0;
            this.dgvGenres.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvGenres_CellBeginEdit);
            this.dgvGenres.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenres_CellEndEdit);
            // 
            // g_name
            // 
            this.g_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.g_name.DataPropertyName = "g_name";
            this.g_name.HeaderText = "g_name";
            this.g_name.Name = "g_name";
            this.g_name.Width = 70;
            // 
            // tabProducers
            // 
            this.tabProducers.Controls.Add(this.btnProducerEndAdd);
            this.tabProducers.Controls.Add(this.txtbAddProducer);
            this.tabProducers.Controls.Add(this.btnAddProducer);
            this.tabProducers.Controls.Add(this.btnProducerAddNew);
            this.tabProducers.Controls.Add(this.lblAddProducer);
            this.tabProducers.Controls.Add(this.btnDeleteProducer);
            this.tabProducers.Controls.Add(this.btnSaveProducers);
            this.tabProducers.Controls.Add(this.dgvProducers);
            this.tabProducers.Location = new System.Drawing.Point(4, 22);
            this.tabProducers.Name = "tabProducers";
            this.tabProducers.Size = new System.Drawing.Size(925, 254);
            this.tabProducers.TabIndex = 3;
            this.tabProducers.Text = "Режисери";
            this.tabProducers.UseVisualStyleBackColor = true;
            // 
            // btnProducerEndAdd
            // 
            this.btnProducerEndAdd.Location = new System.Drawing.Point(275, 2);
            this.btnProducerEndAdd.Name = "btnProducerEndAdd";
            this.btnProducerEndAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProducerEndAdd.TabIndex = 11;
            this.btnProducerEndAdd.Text = "Таблиця";
            this.btnProducerEndAdd.UseVisualStyleBackColor = true;
            this.btnProducerEndAdd.Visible = false;
            this.btnProducerEndAdd.Click += new System.EventHandler(this.btnProducerEndAdd_Click);
            // 
            // txtbAddProducer
            // 
            this.txtbAddProducer.Location = new System.Drawing.Point(541, 43);
            this.txtbAddProducer.Name = "txtbAddProducer";
            this.txtbAddProducer.Size = new System.Drawing.Size(100, 20);
            this.txtbAddProducer.TabIndex = 10;
            this.txtbAddProducer.Visible = false;
            // 
            // btnAddProducer
            // 
            this.btnAddProducer.Location = new System.Drawing.Point(541, 81);
            this.btnAddProducer.Name = "btnAddProducer";
            this.btnAddProducer.Size = new System.Drawing.Size(75, 23);
            this.btnAddProducer.TabIndex = 9;
            this.btnAddProducer.Text = "Додати";
            this.btnAddProducer.UseVisualStyleBackColor = true;
            this.btnAddProducer.Visible = false;
            this.btnAddProducer.Click += new System.EventHandler(this.btnAddProducer_Click);
            // 
            // btnProducerAddNew
            // 
            this.btnProducerAddNew.Location = new System.Drawing.Point(165, 3);
            this.btnProducerAddNew.Name = "btnProducerAddNew";
            this.btnProducerAddNew.Size = new System.Drawing.Size(103, 23);
            this.btnProducerAddNew.TabIndex = 8;
            this.btnProducerAddNew.Text = "Новий режисер";
            this.btnProducerAddNew.UseVisualStyleBackColor = true;
            this.btnProducerAddNew.Click += new System.EventHandler(this.btnProducerAddNew_Click);
            // 
            // lblAddProducer
            // 
            this.lblAddProducer.AutoSize = true;
            this.lblAddProducer.Location = new System.Drawing.Point(509, 43);
            this.lblAddProducer.Name = "lblAddProducer";
            this.lblAddProducer.Size = new System.Drawing.Size(26, 13);
            this.lblAddProducer.TabIndex = 7;
            this.lblAddProducer.Text = "Ім\'я";
            this.lblAddProducer.Visible = false;
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
            this.p_filmslist});
            this.dgvProducers.DataSource = this.kProducers1BindingSource;
            this.dgvProducers.Location = new System.Drawing.Point(3, 43);
            this.dgvProducers.Name = "dgvProducers";
            this.dgvProducers.Size = new System.Drawing.Size(901, 161);
            this.dgvProducers.TabIndex = 0;
            // 
            // p_id
            // 
            this.p_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_id.DataPropertyName = "p_id";
            this.p_id.HeaderText = "p_id";
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            this.p_id.Width = 52;
            // 
            // p_name
            // 
            this.p_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_name.DataPropertyName = "p_name";
            this.p_name.HeaderText = "p_name";
            this.p_name.Name = "p_name";
            this.p_name.Width = 70;
            // 
            // p_filmslist
            // 
            this.p_filmslist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_filmslist.DataPropertyName = "p_filmslist";
            this.p_filmslist.HeaderText = "p_filmslist";
            this.p_filmslist.Name = "p_filmslist";
            this.p_filmslist.Width = 76;
            // 
            // tabActors
            // 
            this.tabActors.Controls.Add(this.btnAddActor);
            this.tabActors.Controls.Add(this.txtbAddActor);
            this.tabActors.Controls.Add(this.lblAddActor);
            this.tabActors.Controls.Add(this.btnActorEndAdd);
            this.tabActors.Controls.Add(this.btnActorAddNew);
            this.tabActors.Controls.Add(this.btnDeleteActors);
            this.tabActors.Controls.Add(this.dgvActors);
            this.tabActors.Controls.Add(this.btnSaveActors);
            this.tabActors.Location = new System.Drawing.Point(4, 22);
            this.tabActors.Name = "tabActors";
            this.tabActors.Padding = new System.Windows.Forms.Padding(3);
            this.tabActors.Size = new System.Drawing.Size(925, 254);
            this.tabActors.TabIndex = 8;
            this.tabActors.Text = "Актори";
            this.tabActors.UseVisualStyleBackColor = true;
            // 
            // btnAddActor
            // 
            this.btnAddActor.Location = new System.Drawing.Point(507, 91);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(75, 23);
            this.btnAddActor.TabIndex = 7;
            this.btnAddActor.Text = "Додати";
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Visible = false;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // txtbAddActor
            // 
            this.txtbAddActor.Location = new System.Drawing.Point(507, 55);
            this.txtbAddActor.Name = "txtbAddActor";
            this.txtbAddActor.Size = new System.Drawing.Size(100, 20);
            this.txtbAddActor.TabIndex = 6;
            this.txtbAddActor.Visible = false;
            // 
            // lblAddActor
            // 
            this.lblAddActor.AutoSize = true;
            this.lblAddActor.Location = new System.Drawing.Point(471, 55);
            this.lblAddActor.Name = "lblAddActor";
            this.lblAddActor.Size = new System.Drawing.Size(26, 13);
            this.lblAddActor.TabIndex = 5;
            this.lblAddActor.Text = "Ім\'я";
            this.lblAddActor.Visible = false;
            // 
            // btnActorEndAdd
            // 
            this.btnActorEndAdd.Location = new System.Drawing.Point(258, 7);
            this.btnActorEndAdd.Name = "btnActorEndAdd";
            this.btnActorEndAdd.Size = new System.Drawing.Size(81, 23);
            this.btnActorEndAdd.TabIndex = 4;
            this.btnActorEndAdd.Text = "Таблиця";
            this.btnActorEndAdd.UseVisualStyleBackColor = true;
            this.btnActorEndAdd.Visible = false;
            this.btnActorEndAdd.Click += new System.EventHandler(this.btnActorEndAdd_Click);
            // 
            // btnActorAddNew
            // 
            this.btnActorAddNew.Location = new System.Drawing.Point(171, 7);
            this.btnActorAddNew.Name = "btnActorAddNew";
            this.btnActorAddNew.Size = new System.Drawing.Size(81, 23);
            this.btnActorAddNew.TabIndex = 3;
            this.btnActorAddNew.Text = "Новий актор";
            this.btnActorAddNew.UseVisualStyleBackColor = true;
            this.btnActorAddNew.Click += new System.EventHandler(this.btnActorAddNew_Click);
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
            this.a_name});
            this.dgvActors.DataSource = this.kActorsBindingSource;
            this.dgvActors.Location = new System.Drawing.Point(7, 38);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(349, 213);
            this.dgvActors.TabIndex = 1;
            // 
            // a_id
            // 
            this.a_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.a_id.DataPropertyName = "a_id";
            this.a_id.HeaderText = "a_id";
            this.a_id.Name = "a_id";
            this.a_id.ReadOnly = true;
            this.a_id.Width = 52;
            // 
            // a_name
            // 
            this.a_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.a_name.DataPropertyName = "a_name";
            this.a_name.HeaderText = "a_name";
            this.a_name.Name = "a_name";
            this.a_name.Width = 70;
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
            // tabViewers
            // 
            this.tabViewers.Controls.Add(this.btnDeleteViewers);
            this.tabViewers.Controls.Add(this.btnSaveViewers);
            this.tabViewers.Controls.Add(this.dgvViewers);
            this.tabViewers.Location = new System.Drawing.Point(4, 22);
            this.tabViewers.Name = "tabViewers";
            this.tabViewers.Size = new System.Drawing.Size(925, 254);
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
            this.v_wishlist,
            this.v_watchedlist,
            this.v_boughtlist,
            this.v_admin});
            this.dgvViewers.DataSource = this.kViewersBindingSource;
            this.dgvViewers.Location = new System.Drawing.Point(3, 33);
            this.dgvViewers.Name = "dgvViewers";
            this.dgvViewers.Size = new System.Drawing.Size(919, 208);
            this.dgvViewers.TabIndex = 0;
            this.dgvViewers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewers_CellEnter);
            // 
            // v_id
            // 
            this.v_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.v_id.DataPropertyName = "v_id";
            this.v_id.HeaderText = "v_id";
            this.v_id.Name = "v_id";
            this.v_id.ReadOnly = true;
            this.v_id.Visible = false;
            // 
            // v_name
            // 
            this.v_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.v_name.DataPropertyName = "v_name";
            this.v_name.HeaderText = "v_name";
            this.v_name.Name = "v_name";
            this.v_name.ReadOnly = true;
            this.v_name.Width = 70;
            // 
            // v_username
            // 
            this.v_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.v_username.DataPropertyName = "v_username";
            this.v_username.HeaderText = "v_username";
            this.v_username.Name = "v_username";
            this.v_username.ReadOnly = true;
            this.v_username.Width = 90;
            // 
            // v_password
            // 
            this.v_password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.v_password.DataPropertyName = "v_password";
            this.v_password.HeaderText = "v_password";
            this.v_password.Name = "v_password";
            this.v_password.ReadOnly = true;
            this.v_password.Width = 89;
            // 
            // v_wishlist
            // 
            this.v_wishlist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.v_wishlist.DataPropertyName = "v_wishlist";
            this.v_wishlist.HeaderText = "v_wishlist";
            this.v_wishlist.Name = "v_wishlist";
            this.v_wishlist.ReadOnly = true;
            this.v_wishlist.Width = 77;
            // 
            // v_watchedlist
            // 
            this.v_watchedlist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.v_watchedlist.DataPropertyName = "v_watchedlist";
            this.v_watchedlist.HeaderText = "v_watchedlist";
            this.v_watchedlist.Name = "v_watchedlist";
            this.v_watchedlist.ReadOnly = true;
            this.v_watchedlist.Width = 97;
            // 
            // v_boughtlist
            // 
            this.v_boughtlist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.v_boughtlist.DataPropertyName = "v_boughtlist";
            this.v_boughtlist.HeaderText = "v_boughtlist";
            this.v_boughtlist.Name = "v_boughtlist";
            this.v_boughtlist.ReadOnly = true;
            this.v_boughtlist.Width = 89;
            // 
            // v_admin
            // 
            this.v_admin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.v_admin.DataPropertyName = "v_admin";
            this.v_admin.HeaderText = "v_admin";
            this.v_admin.Name = "v_admin";
            this.v_admin.Width = 53;
            // 
            // kViewersBindingSource
            // 
            this.kViewersBindingSource.DataMember = "Viewers";
            this.kViewersBindingSource.DataSource = this.kalichDS1;
            // 
            // dgvSearchFilms
            // 
            this.dgvSearchFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchFilms.AutoGenerateColumns = false;
            this.dgvSearchFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fname,
            this.fyear,
            this.pname});
            this.dgvSearchFilms.DataSource = this.kFindedFilmsBindingSource;
            this.dgvSearchFilms.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchFilms.Name = "dgvSearchFilms";
            this.dgvSearchFilms.ReadOnly = true;
            this.dgvSearchFilms.Size = new System.Drawing.Size(621, 210);
            this.dgvSearchFilms.TabIndex = 1;
            this.dgvSearchFilms.DoubleClick += new System.EventHandler(this.dgvSearchFilms_DoubleClick);
            // 
            // fname
            // 
            this.fname.DataPropertyName = "f_name";
            this.fname.HeaderText = "Назва";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 150;
            // 
            // fyear
            // 
            this.fyear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fyear.DataPropertyName = "f_year";
            this.fyear.HeaderText = "Рік";
            this.fyear.Name = "fyear";
            this.fyear.ReadOnly = true;
            this.fyear.Width = 47;
            // 
            // pname
            // 
            this.pname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pname.DataPropertyName = "p_name";
            this.pname.HeaderText = "Режисер";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.Width = 77;
            // 
            // kFindedFilmsBindingSource
            // 
            this.kFindedFilmsBindingSource.DataMember = "KFindedFilms";
            this.kFindedFilmsBindingSource.DataSource = this.kalichDS;
            // 
            // kalichDS
            // 
            this.kalichDS.DataSetName = "KalichDS";
            this.kalichDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(841, 11);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(106, 23);
            this.btnRegistration.TabIndex = 2;
            this.btnRegistration.Text = "Реєстрація";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
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
            this.btnEditing.Visible = false;
            this.btnEditing.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(729, 41);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(106, 23);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "Мій список";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Visible = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(729, -4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.cmbSearchFilmsName.DataSource = this.kFilmsBindingSource;
            this.cmbSearchFilmsName.DisplayMember = "f_name";
            this.cmbSearchFilmsName.FormattingEnabled = true;
            this.cmbSearchFilmsName.Location = new System.Drawing.Point(120, 6);
            this.cmbSearchFilmsName.Name = "cmbSearchFilmsName";
            this.cmbSearchFilmsName.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsName.TabIndex = 12;
            // 
            // cmbSearchFilmsActor
            // 
            this.cmbSearchFilmsActor.DataSource = this.kActorsBindingSource;
            this.cmbSearchFilmsActor.DisplayMember = "a_name";
            this.cmbSearchFilmsActor.FormattingEnabled = true;
            this.cmbSearchFilmsActor.Location = new System.Drawing.Point(120, 114);
            this.cmbSearchFilmsActor.Name = "cmbSearchFilmsActor";
            this.cmbSearchFilmsActor.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsActor.TabIndex = 13;
            // 
            // cmbSearchFilmsProducer
            // 
            this.cmbSearchFilmsProducer.DataSource = this.kProducers1BindingSource;
            this.cmbSearchFilmsProducer.DisplayMember = "p_name";
            this.cmbSearchFilmsProducer.FormattingEnabled = true;
            this.cmbSearchFilmsProducer.Location = new System.Drawing.Point(120, 87);
            this.cmbSearchFilmsProducer.Name = "cmbSearchFilmsProducer";
            this.cmbSearchFilmsProducer.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsProducer.TabIndex = 14;
            // 
            // cmbSearchFilmsGenre
            // 
            this.cmbSearchFilmsGenre.DataSource = this.kGenresBindingSource;
            this.cmbSearchFilmsGenre.DisplayMember = "g_name";
            this.cmbSearchFilmsGenre.FormattingEnabled = true;
            this.cmbSearchFilmsGenre.Location = new System.Drawing.Point(120, 60);
            this.cmbSearchFilmsGenre.Name = "cmbSearchFilmsGenre";
            this.cmbSearchFilmsGenre.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsGenre.TabIndex = 15;
            // 
            // cmbSearchFilmsYear
            // 
            this.cmbSearchFilmsYear.DataSource = this.filmsYearBindingSource;
            this.cmbSearchFilmsYear.DisplayMember = "f_year";
            this.cmbSearchFilmsYear.FormattingEnabled = true;
            this.cmbSearchFilmsYear.Location = new System.Drawing.Point(120, 33);
            this.cmbSearchFilmsYear.Name = "cmbSearchFilmsYear";
            this.cmbSearchFilmsYear.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchFilmsYear.TabIndex = 16;
            // 
            // filmsYearBindingSource
            // 
            this.filmsYearBindingSource.DataMember = "FilmsYear";
            this.filmsYearBindingSource.DataSource = this.kalichDS1;
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
            // tabControlSearch
            // 
            this.tabControlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSearch.Controls.Add(this.tabPage1);
            this.tabControlSearch.Controls.Add(this.tabPage2);
            this.tabControlSearch.Controls.Add(this.tabPage3);
            this.tabControlSearch.Controls.Add(this.tabPage4);
            this.tabControlSearch.Location = new System.Drawing.Point(12, 86);
            this.tabControlSearch.Name = "tabControlSearch";
            this.tabControlSearch.SelectedIndex = 0;
            this.tabControlSearch.Size = new System.Drawing.Size(941, 245);
            this.tabControlSearch.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnWish);
            this.tabPage1.Controls.Add(this.btnWatch);
            this.tabPage1.Controls.Add(this.cmbSearchFilmsGenre);
            this.tabPage1.Controls.Add(this.btnSearchFilms);
            this.tabPage1.Controls.Add(this.btnBuy);
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
            this.tabPage1.Size = new System.Drawing.Size(933, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фільми";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnWish
            // 
            this.btnWish.Location = new System.Drawing.Point(106, 189);
            this.btnWish.Name = "btnWish";
            this.btnWish.Size = new System.Drawing.Size(95, 23);
            this.btnWish.TabIndex = 31;
            this.btnWish.Text = "Зберегти";
            this.btnWish.UseVisualStyleBackColor = true;
            this.btnWish.Visible = false;
            this.btnWish.Click += new System.EventHandler(this.btnWish_Click);
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(205, 189);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(95, 23);
            this.btnWatch.TabIndex = 32;
            this.btnWatch.Text = "Дивитися";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Visible = false;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(6, 189);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(95, 23);
            this.btnBuy.TabIndex = 30;
            this.btnBuy.Text = "Купити";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Visible = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
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
            this.tabPage2.Size = new System.Drawing.Size(933, 219);
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
            this.gnameDataGridViewTextBoxColumn});
            this.dgvSearchGenres.DataSource = this.kFindedGenresBindingSource;
            this.dgvSearchGenres.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchGenres.Name = "dgvSearchGenres";
            this.dgvSearchGenres.ReadOnly = true;
            this.dgvSearchGenres.Size = new System.Drawing.Size(617, 207);
            this.dgvSearchGenres.TabIndex = 3;
            // 
            // gnameDataGridViewTextBoxColumn
            // 
            this.gnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gnameDataGridViewTextBoxColumn.DataPropertyName = "g_name";
            this.gnameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.gnameDataGridViewTextBoxColumn.Name = "gnameDataGridViewTextBoxColumn";
            this.gnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.gnameDataGridViewTextBoxColumn.Width = 64;
            // 
            // kFindedGenresBindingSource
            // 
            this.kFindedGenresBindingSource.DataMember = "KFindedGenres";
            this.kFindedGenresBindingSource.DataSource = this.kalichDS1;
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
            this.cmbSearchGenre.DataSource = this.kGenresBindingSource;
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
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cmbSearchProducerName);
            this.tabPage3.Controls.Add(this.btnSearchProducer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(933, 219);
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
            this.pnameDataGridViewTextBoxColumn});
            this.dgvSearchProducers.DataSource = this.kFindedProducersBindingSource;
            this.dgvSearchProducers.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchProducers.Name = "dgvSearchProducers";
            this.dgvSearchProducers.ReadOnly = true;
            this.dgvSearchProducers.Size = new System.Drawing.Size(617, 207);
            this.dgvSearchProducers.TabIndex = 7;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "p_id";
            this.pidDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pidDataGridViewTextBoxColumn.Width = 66;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "p_name";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pnameDataGridViewTextBoxColumn.Width = 51;
            // 
            // kFindedProducersBindingSource
            // 
            this.kFindedProducersBindingSource.DataMember = "KFindedProducers";
            this.kFindedProducersBindingSource.DataSource = this.kalichDS1;
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
            this.cmbSearchProducerName.DataSource = this.kProducers1BindingSource;
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
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.cmbSearchActorName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(933, 219);
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
            this.anameDataGridViewTextBoxColumn});
            this.dgvSearchActors.DataSource = this.kFindedActorsBindingSource;
            this.dgvSearchActors.Location = new System.Drawing.Point(306, 6);
            this.dgvSearchActors.Name = "dgvSearchActors";
            this.dgvSearchActors.ReadOnly = true;
            this.dgvSearchActors.Size = new System.Drawing.Size(617, 207);
            this.dgvSearchActors.TabIndex = 7;
            // 
            // aidDataGridViewTextBoxColumn
            // 
            this.aidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.aidDataGridViewTextBoxColumn.DataPropertyName = "a_id";
            this.aidDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.aidDataGridViewTextBoxColumn.Name = "aidDataGridViewTextBoxColumn";
            this.aidDataGridViewTextBoxColumn.ReadOnly = true;
            this.aidDataGridViewTextBoxColumn.Width = 66;
            // 
            // anameDataGridViewTextBoxColumn
            // 
            this.anameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.anameDataGridViewTextBoxColumn.DataPropertyName = "a_name";
            this.anameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.anameDataGridViewTextBoxColumn.Name = "anameDataGridViewTextBoxColumn";
            this.anameDataGridViewTextBoxColumn.ReadOnly = true;
            this.anameDataGridViewTextBoxColumn.Width = 51;
            // 
            // kFindedActorsBindingSource
            // 
            this.kFindedActorsBindingSource.DataMember = "KFindedActors";
            this.kFindedActorsBindingSource.DataSource = this.kalichDS1;
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
            this.cmbSearchActorName.DataSource = this.kActorsBindingSource;
            this.cmbSearchActorName.DisplayMember = "a_name";
            this.cmbSearchActorName.FormattingEnabled = true;
            this.cmbSearchActorName.Location = new System.Drawing.Point(120, 6);
            this.cmbSearchActorName.Name = "cmbSearchActorName";
            this.cmbSearchActorName.Size = new System.Drawing.Size(180, 21);
            this.cmbSearchActorName.TabIndex = 0;
            // 
            // kActorsTableAdapter1
            // 
            this.kActorsTableAdapter1.ClearBeforeFill = true;
            // 
            // kFilmsTableAdapter1
            // 
            this.kFilmsTableAdapter1.ClearBeforeFill = true;
            // 
            // kGenresTableAdapter1
            // 
            this.kGenresTableAdapter1.ClearBeforeFill = true;
            // 
            // kViewersTableAdapter1
            // 
            this.kViewersTableAdapter1.ClearBeforeFill = true;
            // 
            // kProducers1TableAdapter1
            // 
            this.kProducers1TableAdapter1.ClearBeforeFill = true;
            // 
            // kFindedFilmsTableAdapter1
            // 
            this.kFindedFilmsTableAdapter1.ClearBeforeFill = true;
            // 
            // kFindedGenresTableAdapter1
            // 
            this.kFindedGenresTableAdapter1.ClearBeforeFill = true;
            // 
            // kFindedActorsTableAdapter1
            // 
            this.kFindedActorsTableAdapter1.ClearBeforeFill = true;
            // 
            // kFindedProducersTableAdapter1
            // 
            this.kFindedProducersTableAdapter1.ClearBeforeFill = true;
            // 
            // txtbRegistrationUsername
            // 
            this.txtbRegistrationUsername.Location = new System.Drawing.Point(845, 77);
            this.txtbRegistrationUsername.Name = "txtbRegistrationUsername";
            this.txtbRegistrationUsername.Size = new System.Drawing.Size(100, 20);
            this.txtbRegistrationUsername.TabIndex = 23;
            this.txtbRegistrationUsername.Visible = false;
            // 
            // txtbRegistrationName
            // 
            this.txtbRegistrationName.Location = new System.Drawing.Point(845, 129);
            this.txtbRegistrationName.Name = "txtbRegistrationName";
            this.txtbRegistrationName.Size = new System.Drawing.Size(100, 20);
            this.txtbRegistrationName.TabIndex = 24;
            this.txtbRegistrationName.Visible = false;
            // 
            // txtbRegistrationPassword
            // 
            this.txtbRegistrationPassword.Location = new System.Drawing.Point(845, 103);
            this.txtbRegistrationPassword.Name = "txtbRegistrationPassword";
            this.txtbRegistrationPassword.Size = new System.Drawing.Size(100, 20);
            this.txtbRegistrationPassword.TabIndex = 25;
            this.txtbRegistrationPassword.Visible = false;
            // 
            // btnRegistr
            // 
            this.btnRegistr.Location = new System.Drawing.Point(792, 156);
            this.btnRegistr.Name = "btnRegistr";
            this.btnRegistr.Size = new System.Drawing.Size(154, 23);
            this.btnRegistr.TabIndex = 26;
            this.btnRegistr.Text = "Зареєструватися";
            this.btnRegistr.UseVisualStyleBackColor = true;
            this.btnRegistr.Visible = false;
            this.btnRegistr.Click += new System.EventHandler(this.btnRegistr_Click);
            // 
            // lblRegLogin
            // 
            this.lblRegLogin.AutoSize = true;
            this.lblRegLogin.Location = new System.Drawing.Point(789, 83);
            this.lblRegLogin.Name = "lblRegLogin";
            this.lblRegLogin.Size = new System.Drawing.Size(34, 13);
            this.lblRegLogin.TabIndex = 27;
            this.lblRegLogin.Text = "Логін";
            this.lblRegLogin.Visible = false;
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Location = new System.Drawing.Point(789, 110);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(45, 13);
            this.lblRegPassword.TabIndex = 28;
            this.lblRegPassword.Text = "Пароль";
            this.lblRegPassword.Visible = false;
            // 
            // lblRegName
            // 
            this.lblRegName.AutoSize = true;
            this.lblRegName.Location = new System.Drawing.Point(789, 132);
            this.lblRegName.Name = "lblRegName";
            this.lblRegName.Size = new System.Drawing.Size(26, 13);
            this.lblRegName.TabIndex = 29;
            this.lblRegName.Text = "Ім\'я";
            this.lblRegName.Visible = false;
            // 
            // btnRegCancel
            // 
            this.btnRegCancel.Location = new System.Drawing.Point(793, 185);
            this.btnRegCancel.Name = "btnRegCancel";
            this.btnRegCancel.Size = new System.Drawing.Size(154, 23);
            this.btnRegCancel.TabIndex = 30;
            this.btnRegCancel.Text = "Скасувати";
            this.btnRegCancel.UseVisualStyleBackColor = true;
            this.btnRegCancel.Visible = false;
            this.btnRegCancel.Click += new System.EventHandler(this.btnRegCancel_Click);
            // 
            // btnEndEdit
            // 
            this.btnEndEdit.Location = new System.Drawing.Point(841, 57);
            this.btnEndEdit.Name = "btnEndEdit";
            this.btnEndEdit.Size = new System.Drawing.Size(106, 23);
            this.btnEndEdit.TabIndex = 31;
            this.btnEndEdit.Text = "Пошук";
            this.btnEndEdit.UseVisualStyleBackColor = true;
            this.btnEndEdit.Visible = false;
            this.btnEndEdit.Click += new System.EventHandler(this.btnEndEdit_Click);
            // 
            // btnSaveAllChanges
            // 
            this.btnSaveAllChanges.Location = new System.Drawing.Point(841, -4);
            this.btnSaveAllChanges.Name = "btnSaveAllChanges";
            this.btnSaveAllChanges.Size = new System.Drawing.Size(106, 23);
            this.btnSaveAllChanges.TabIndex = 32;
            this.btnSaveAllChanges.Text = "Зберегти все";
            this.btnSaveAllChanges.UseVisualStyleBackColor = true;
            this.btnSaveAllChanges.Visible = false;
            this.btnSaveAllChanges.Click += new System.EventHandler(this.btnSaveAllChanges_Click);
            // 
            // cmbWish
            // 
            this.cmbWish.FormattingEnabled = true;
            this.cmbWish.Location = new System.Drawing.Point(379, 3);
            this.cmbWish.Name = "cmbWish";
            this.cmbWish.Size = new System.Drawing.Size(121, 21);
            this.cmbWish.TabIndex = 33;
            this.cmbWish.Visible = false;
            // 
            // cmbBuy
            // 
            this.cmbBuy.FormattingEnabled = true;
            this.cmbBuy.Location = new System.Drawing.Point(379, 30);
            this.cmbBuy.Name = "cmbBuy";
            this.cmbBuy.Size = new System.Drawing.Size(121, 21);
            this.cmbBuy.TabIndex = 34;
            this.cmbBuy.Visible = false;
            // 
            // cmbWatch
            // 
            this.cmbWatch.FormattingEnabled = true;
            this.cmbWatch.Location = new System.Drawing.Point(379, 59);
            this.cmbWatch.Name = "cmbWatch";
            this.cmbWatch.Size = new System.Drawing.Size(121, 21);
            this.cmbWatch.TabIndex = 35;
            this.cmbWatch.Visible = false;
            // 
            // lblWish
            // 
            this.lblWish.AutoSize = true;
            this.lblWish.Location = new System.Drawing.Point(13, 11);
            this.lblWish.Name = "lblWish";
            this.lblWish.Size = new System.Drawing.Size(41, 13);
            this.lblWish.TabIndex = 36;
            this.lblWish.Text = "Обрані";
            this.lblWish.Visible = false;
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Location = new System.Drawing.Point(140, 11);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(45, 13);
            this.lblBuy.TabIndex = 37;
            this.lblBuy.Text = "Куплені";
            this.lblBuy.Visible = false;
            // 
            // lblWatch
            // 
            this.lblWatch.AutoSize = true;
            this.lblWatch.Location = new System.Drawing.Point(267, 10);
            this.lblWatch.Name = "lblWatch";
            this.lblWatch.Size = new System.Drawing.Size(68, 13);
            this.lblWatch.TabIndex = 38;
            this.lblWatch.Text = "Переглянуті";
            this.lblWatch.Visible = false;
            // 
            // btnListEnd
            // 
            this.btnListEnd.Location = new System.Drawing.Point(729, 57);
            this.btnListEnd.Name = "btnListEnd";
            this.btnListEnd.Size = new System.Drawing.Size(106, 23);
            this.btnListEnd.TabIndex = 39;
            this.btnListEnd.Text = "Пошук";
            this.btnListEnd.UseVisualStyleBackColor = true;
            this.btnListEnd.Visible = false;
            this.btnListEnd.Click += new System.EventHandler(this.btnListEnd_Click);
            // 
            // rtbWish
            // 
            this.rtbWish.Location = new System.Drawing.Point(12, 30);
            this.rtbWish.Name = "rtbWish";
            this.rtbWish.ReadOnly = true;
            this.rtbWish.Size = new System.Drawing.Size(108, 205);
            this.rtbWish.TabIndex = 40;
            this.rtbWish.Text = "";
            this.rtbWish.Visible = false;
            // 
            // rtbWatch
            // 
            this.rtbWatch.Location = new System.Drawing.Point(263, 30);
            this.rtbWatch.Name = "rtbWatch";
            this.rtbWatch.ReadOnly = true;
            this.rtbWatch.Size = new System.Drawing.Size(108, 205);
            this.rtbWatch.TabIndex = 41;
            this.rtbWatch.Text = "";
            this.rtbWatch.Visible = false;
            // 
            // rtbBuy
            // 
            this.rtbBuy.Location = new System.Drawing.Point(135, 30);
            this.rtbBuy.Name = "rtbBuy";
            this.rtbBuy.ReadOnly = true;
            this.rtbBuy.Size = new System.Drawing.Size(108, 205);
            this.rtbBuy.TabIndex = 42;
            this.rtbBuy.Text = "";
            this.rtbBuy.Visible = false;
            // 
            // filmsYearTableAdapter
            // 
            this.filmsYearTableAdapter.ClearBeforeFill = true;
            // 
            // btnClearWish
            // 
            this.btnClearWish.Location = new System.Drawing.Point(12, 241);
            this.btnClearWish.Name = "btnClearWish";
            this.btnClearWish.Size = new System.Drawing.Size(359, 23);
            this.btnClearWish.TabIndex = 43;
            this.btnClearWish.Text = "Очистити список обраних";
            this.btnClearWish.UseVisualStyleBackColor = true;
            this.btnClearWish.Visible = false;
            this.btnClearWish.Click += new System.EventHandler(this.btnClearWish_Click);
            // 
            // f_name
            // 
            this.f_name.DataPropertyName = "f_name";
            this.f_name.HeaderText = "f_name";
            this.f_name.Name = "f_name";
            this.f_name.Width = 67;
            // 
            // f_year
            // 
            this.f_year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.f_year.DataPropertyName = "f_year";
            this.f_year.HeaderText = "f_year";
            this.f_year.Name = "f_year";
            this.f_year.Width = 61;
            // 
            // f_genreslist
            // 
            this.f_genreslist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.f_genreslist.DataPropertyName = "f_genreslist";
            this.f_genreslist.HeaderText = "f_genreslist";
            this.f_genreslist.Name = "f_genreslist";
            this.f_genreslist.ReadOnly = true;
            this.f_genreslist.Width = 85;
            // 
            // f_actorslist
            // 
            this.f_actorslist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.f_actorslist.DataPropertyName = "f_actorslist";
            this.f_actorslist.HeaderText = "f_actorslist";
            this.f_actorslist.Name = "f_actorslist";
            this.f_actorslist.ReadOnly = true;
            this.f_actorslist.Width = 82;
            // 
            // f_producer
            // 
            this.f_producer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.f_producer.DataPropertyName = "f_producer";
            this.f_producer.HeaderText = "f_director";
            this.f_producer.Name = "f_producer";
            this.f_producer.ReadOnly = true;
            this.f_producer.Width = 76;
            // 
            // FormFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 685);
            this.Controls.Add(this.btnClearWish);
            this.Controls.Add(this.rtbBuy);
            this.Controls.Add(this.rtbWatch);
            this.Controls.Add(this.rtbWish);
            this.Controls.Add(this.btnListEnd);
            this.Controls.Add(this.lblWatch);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.lblWish);
            this.Controls.Add(this.cmbWatch);
            this.Controls.Add(this.cmbBuy);
            this.Controls.Add(this.cmbWish);
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
            this.Controls.Add(this.tabControlSearch);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnEditing);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.tabControlChenging);
            this.Name = "FormFilms";
            this.Text = "Фільми";
            this.Load += new System.EventHandler(this.FormFilms_Load);
            this.tabControlChenging.ResumeLayout(false);
            this.tabFilms.ResumeLayout(false);
            this.tabFilms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kProducers1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalichDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFilmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kActorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kGenresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.tabGenres.ResumeLayout(false);
            this.tabGenres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.tabProducers.ResumeLayout(false);
            this.tabProducers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducers)).EndInit();
            this.tabActors.ResumeLayout(false);
            this.tabActors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.tabViewers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kViewersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFindedFilmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalichDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsYearBindingSource)).EndInit();
            this.tabControlSearch.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFindedGenresBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProducers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFindedProducersBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFindedActorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlChenging;
        private System.Windows.Forms.TabPage tabFilms;
        private System.Windows.Forms.TabPage tabGenres;
        private System.Windows.Forms.TabPage tabProducers;
        private System.Windows.Forms.TabPage tabViewers;
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
        private System.Windows.Forms.DataGridView dgvSearchFilms;
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
        private System.Windows.Forms.ComboBox cmbSearchFilmsActor;
        private System.Windows.Forms.ComboBox cmbSearchFilmsProducer;
        private System.Windows.Forms.ComboBox cmbSearchFilmsGenre;
        private System.Windows.Forms.ComboBox cmbSearchFilmsYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControlSearch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSearchGenres;
        private System.Windows.Forms.Button btnSearchGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSearchGenre;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvSearchActors;
        private System.Windows.Forms.Button btnSearchActor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSearchActorName;
        private KalichDS kalichDS1;
        private KalichDSTableAdapters.KActorsTableAdapter kActorsTableAdapter1;
        private KalichDSTableAdapters.KFilmsTableAdapter kFilmsTableAdapter1;
        private KalichDSTableAdapters.KGenresTableAdapter kGenresTableAdapter1;
        private KalichDSTableAdapters.KViewersTableAdapter kViewersTableAdapter1;
        private System.Windows.Forms.BindingSource kActorsBindingSource;
        private System.Windows.Forms.BindingSource kFilmsBindingSource;
        private System.Windows.Forms.BindingSource kGenresBindingSource;
        private System.Windows.Forms.BindingSource kViewersBindingSource;
        private System.Windows.Forms.BindingSource kProducers1BindingSource;
        private KalichDSTableAdapters.KProducers1TableAdapter kProducers1TableAdapter1;
        private KalichDSTableAdapters.KQueriesTableAdapter kQueriesTableAdapter1;
        private System.Windows.Forms.BindingSource kFindedFilmsBindingSource;
        private KalichDS kalichDS;
        private KalichDSTableAdapters.KFindedFilmsTableAdapter kFindedFilmsTableAdapter1;
        private System.Windows.Forms.BindingSource kFindedGenresBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvSearchProducers;
        private System.Windows.Forms.BindingSource kFindedProducersBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSearchProducerName;
        private System.Windows.Forms.Button btnSearchProducer;
        private System.Windows.Forms.BindingSource kFindedActorsBindingSource;
        private KalichDSTableAdapters.KFindedGenresTableAdapter kFindedGenresTableAdapter1;
        private KalichDSTableAdapters.KFindedActorsTableAdapter kFindedActorsTableAdapter1;
        private KalichDSTableAdapters.KFindedProducersTableAdapter kFindedProducersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_name;
        private System.Windows.Forms.Button btnAddFilmSelectActor;
        private System.Windows.Forms.Button btnAddFilmSelectGenre;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.ComboBox cmbAddFilmProducer;
        private System.Windows.Forms.ComboBox cmbAddFilmSelectedActors;
        private System.Windows.Forms.ComboBox cmbAddFilmActors;
        private System.Windows.Forms.ComboBox cmbAddFilmSelectedGenres;
        private System.Windows.Forms.ComboBox cmbAddFilmGenres;
        private System.Windows.Forms.TextBox txtbAddFilmYear;
        private System.Windows.Forms.TextBox txtbAddFilmName;
        private System.Windows.Forms.Button btnAddFilmClear;
        private System.Windows.Forms.Button btnFilmsAddNew;
        private System.Windows.Forms.Label lblAddFilmProducer;
        private System.Windows.Forms.Label lblAddFilmYear;
        private System.Windows.Forms.Label lblAddFilmName;
        private System.Windows.Forms.TextBox txtbAddGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnGenreAddNew;
        private System.Windows.Forms.Label lblAddGenre;
        private System.Windows.Forms.TextBox txtbAddProducer;
        private System.Windows.Forms.Button btnAddProducer;
        private System.Windows.Forms.Button btnProducerAddNew;
        private System.Windows.Forms.Label lblAddProducer;
        private System.Windows.Forms.TextBox txtbRegistrationUsername;
        private System.Windows.Forms.TextBox txtbRegistrationName;
        private System.Windows.Forms.TextBox txtbRegistrationPassword;
        private System.Windows.Forms.Button btnRegistr;
        private System.Windows.Forms.Label lblRegLogin;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Label lblRegName;
        private System.Windows.Forms.Button btnWish;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRegCancel;
        private System.Windows.Forms.Button btnEndEdit;
        private System.Windows.Forms.Button btnSaveAllChanges;
        private System.Windows.Forms.Button btnFilmEndAdd;
        private System.Windows.Forms.Button btnGenresEndAdd;
        private System.Windows.Forms.Button btnProducerEndAdd;
        private System.Windows.Forms.Button btnAddActor;
        private System.Windows.Forms.TextBox txtbAddActor;
        private System.Windows.Forms.Label lblAddActor;
        private System.Windows.Forms.Button btnActorEndAdd;
        private System.Windows.Forms.Button btnActorAddNew;
        private System.Windows.Forms.ComboBox cmbWish;
        private System.Windows.Forms.ComboBox cmbBuy;
        private System.Windows.Forms.ComboBox cmbWatch;
        private System.Windows.Forms.Label lblWish;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblWatch;
        private System.Windows.Forms.Button btnListEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEditFilmStart;
        private System.Windows.Forms.ComboBox cmbEditFilmYear;
        private System.Windows.Forms.ComboBox cmbEditFilmName;
        private System.Windows.Forms.Label lblEditFilmsYear;
        private System.Windows.Forms.Label lblEditFilmsName;
        private System.Windows.Forms.Button btnEditFilmClear;
        private System.Windows.Forms.Button btnEditFilmsAddActor;
        private System.Windows.Forms.Button btnEditFilmsAddGenre;
        private System.Windows.Forms.ComboBox cmbEditFilmChooseGenres;
        private System.Windows.Forms.Button btnEditFilmEdit;
        private System.Windows.Forms.ComboBox cmbEditFilmActor;
        private System.Windows.Forms.ComboBox cmbEditFilmChooseActors;
        private System.Windows.Forms.ComboBox cmbEditFilmsGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.RichTextBox rtbWish;
        private System.Windows.Forms.RichTextBox rtbWatch;
        private System.Windows.Forms.RichTextBox rtbBuy;
        private System.Windows.Forms.BindingSource filmsYearBindingSource;
        private KalichDSTableAdapters.FilmsYearTableAdapter filmsYearTableAdapter;
        private System.Windows.Forms.Label lblEditFilms;
        private System.Windows.Forms.ComboBox cmbEditFilmProducer;
        private System.Windows.Forms.Button btnClearWish;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_filmslist;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_wishlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_watchedlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_boughtlist;
        private System.Windows.Forms.DataGridViewCheckBoxColumn v_admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_genreslist;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_actorslist;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_producer;
    }
}

