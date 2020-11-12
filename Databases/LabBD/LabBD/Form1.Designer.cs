namespace LabBD
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbS1_name = new System.Windows.Forms.ComboBox();
            this.producersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFilms = new LabBD.DSFilms();
            this.btnS8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudS8 = new System.Windows.Forms.NumericUpDown();
            this.btnS1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbS1_id = new System.Windows.Forms.ComboBox();
            this.btnS7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudS7 = new System.Windows.Forms.NumericUpDown();
            this.btnS2 = new System.Windows.Forms.Button();
            this.cmbS6_name = new System.Windows.Forms.ComboBox();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbS2_id = new System.Windows.Forms.ComboBox();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbS6_id = new System.Windows.Forms.ComboBox();
            this.cmbS2_name = new System.Windows.Forms.ComboBox();
            this.btnS6 = new System.Windows.Forms.Button();
            this.nudS3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnS3 = new System.Windows.Forms.Button();
            this.cmbS5_name = new System.Windows.Forms.ComboBox();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cmbS5_id = new System.Windows.Forms.ComboBox();
            this.nudS4 = new System.Windows.Forms.NumericUpDown();
            this.btnS5 = new System.Windows.Forms.Button();
            this.btnS4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabFilms = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteFilm = new System.Windows.Forms.Button();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fproducer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProducers = new System.Windows.Forms.TabPage();
            this.btnDeleteProducer = new System.Windows.Forms.Button();
            this.btnAddProducer = new System.Windows.Forms.Button();
            this.dgvProducers = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdeath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabActors = new System.Windows.Forms.TabPage();
            this.btnDeleteActor = new System.Windows.Forms.Button();
            this.btnAddActor = new System.Windows.Forms.Button();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.aid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adeath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabGenres = new System.Windows.Forms.TabPage();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFilmsActors = new System.Windows.Forms.TabPage();
            this.btnDeleteFilmActor = new System.Windows.Forms.Button();
            this.btnAddFilmActor = new System.Windows.Forms.Button();
            this.dgvFilmsActors = new System.Windows.Forms.DataGridView();
            this.faidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fafidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsActorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabFilmsGenres = new System.Windows.Forms.TabPage();
            this.btnDeleteFilmGenre = new System.Windows.Forms.Button();
            this.btnAddFilmGenre = new System.Windows.Forms.Button();
            this.dgvFilmsGenres = new System.Windows.Forms.DataGridView();
            this.fgidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fgfidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fggidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsGenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFilms2 = new LabBD.DSFilms();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dSFilms1 = new LabBD.DSFilms();
            this.filmsTableAdapter = new LabBD.DSFilmsTableAdapters.FilmsTableAdapter();
            this.producersTableAdapter = new LabBD.DSFilmsTableAdapters.ProducersTableAdapter();
            this.actorsTableAdapter = new LabBD.DSFilmsTableAdapters.ActorsTableAdapter();
            this.genresTableAdapter = new LabBD.DSFilmsTableAdapters.GenresTableAdapter();
            this.queriesTableAdapter = new LabBD.DSFilmsTableAdapters.QueriesTableAdapter();
            this.filmsGenresTableAdapter = new LabBD.DSFilmsTableAdapters.FilmsGenresTableAdapter();
            this.filmsActorsTableAdapter = new LabBD.DSFilmsTableAdapters.FilmsActorsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS4)).BeginInit();
            this.tabFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.tabProducers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducers)).BeginInit();
            this.tabActors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.tabGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.tabFilmsActors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsActorsBindingSource)).BeginInit();
            this.tabFilmsGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsGenresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabFilms);
            this.tabControl1.Controls.Add(this.tabProducers);
            this.tabControl1.Controls.Add(this.tabActors);
            this.tabControl1.Controls.Add(this.tabGenres);
            this.tabControl1.Controls.Add(this.tabFilmsActors);
            this.tabControl1.Controls.Add(this.tabFilmsGenres);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 290);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cmbS1_name);
            this.tabPage1.Controls.Add(this.btnS8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudS8);
            this.tabPage1.Controls.Add(this.btnS1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cmbS1_id);
            this.tabPage1.Controls.Add(this.btnS7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nudS7);
            this.tabPage1.Controls.Add(this.btnS2);
            this.tabPage1.Controls.Add(this.cmbS6_name);
            this.tabPage1.Controls.Add(this.cmbS2_id);
            this.tabPage1.Controls.Add(this.cmbS6_id);
            this.tabPage1.Controls.Add(this.cmbS2_name);
            this.tabPage1.Controls.Add(this.btnS6);
            this.tabPage1.Controls.Add(this.nudS3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnS3);
            this.tabPage1.Controls.Add(this.cmbS5_name);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbS5_id);
            this.tabPage1.Controls.Add(this.nudS4);
            this.tabPage1.Controls.Add(this.btnS5);
            this.tabPage1.Controls.Add(this.btnS4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(723, 264);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Меню";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(427, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Продюсери, які народилися не раніше заданого року й зняли фільми в усіх жанрах";
            // 
            // cmbS1_name
            // 
            this.cmbS1_name.DataSource = this.producersBindingSource;
            this.cmbS1_name.DisplayMember = "p_name";
            this.cmbS1_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbS1_name.FormattingEnabled = true;
            this.cmbS1_name.Location = new System.Drawing.Point(54, 20);
            this.cmbS1_name.Name = "cmbS1_name";
            this.cmbS1_name.Size = new System.Drawing.Size(148, 21);
            this.cmbS1_name.TabIndex = 7;
            // 
            // producersBindingSource
            // 
            this.producersBindingSource.DataMember = "Producers";
            this.producersBindingSource.DataSource = this.dSFilms;
            // 
            // dSFilms
            // 
            this.dSFilms.DataSetName = "DSFilms";
            this.dSFilms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnS8
            // 
            this.btnS8.Location = new System.Drawing.Point(208, 220);
            this.btnS8.Name = "btnS8";
            this.btnS8.Size = new System.Drawing.Size(75, 23);
            this.btnS8.TabIndex = 31;
            this.btnS8.Text = "Запит 8";
            this.btnS8.UseVisualStyleBackColor = true;
            this.btnS8.Click += new System.EventHandler(this.btnS8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Жанри фільмів заданого продюсера";
            // 
            // nudS8
            // 
            this.nudS8.Location = new System.Drawing.Point(6, 220);
            this.nudS8.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.nudS8.Name = "nudS8";
            this.nudS8.Size = new System.Drawing.Size(196, 20);
            this.nudS8.TabIndex = 30;
            this.nudS8.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // btnS1
            // 
            this.btnS1.Location = new System.Drawing.Point(208, 18);
            this.btnS1.Name = "btnS1";
            this.btnS1.Size = new System.Drawing.Size(75, 23);
            this.btnS1.TabIndex = 5;
            this.btnS1.Text = "Запит 1";
            this.btnS1.UseVisualStyleBackColor = true;
            this.btnS1.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Жанри, які є тільки у фільмах, знятих не раніше заданого року";
            // 
            // cmbS1_id
            // 
            this.cmbS1_id.DataSource = this.producersBindingSource;
            this.cmbS1_id.DisplayMember = "p_id";
            this.cmbS1_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbS1_id.FormattingEnabled = true;
            this.cmbS1_id.Location = new System.Drawing.Point(6, 20);
            this.cmbS1_id.Name = "cmbS1_id";
            this.cmbS1_id.Size = new System.Drawing.Size(42, 21);
            this.cmbS1_id.TabIndex = 6;
            // 
            // btnS7
            // 
            this.btnS7.Location = new System.Drawing.Point(208, 191);
            this.btnS7.Name = "btnS7";
            this.btnS7.Size = new System.Drawing.Size(75, 23);
            this.btnS7.TabIndex = 28;
            this.btnS7.Text = "Запит 7";
            this.btnS7.UseVisualStyleBackColor = true;
            this.btnS7.Click += new System.EventHandler(this.btnS7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Продюсери, у чиїх фільмах знімався заданий актор";
            // 
            // nudS7
            // 
            this.nudS7.Location = new System.Drawing.Point(6, 191);
            this.nudS7.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.nudS7.Minimum = new decimal(new int[] {
            1888,
            0,
            0,
            0});
            this.nudS7.Name = "nudS7";
            this.nudS7.Size = new System.Drawing.Size(196, 20);
            this.nudS7.TabIndex = 27;
            this.nudS7.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // btnS2
            // 
            this.btnS2.Location = new System.Drawing.Point(208, 45);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(75, 23);
            this.btnS2.TabIndex = 10;
            this.btnS2.Text = "Запит 2";
            this.btnS2.UseVisualStyleBackColor = true;
            this.btnS2.Click += new System.EventHandler(this.btnS2_Click);
            // 
            // cmbS6_name
            // 
            this.cmbS6_name.DataSource = this.filmsBindingSource;
            this.cmbS6_name.DisplayMember = "d_name";
            this.cmbS6_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbS6_name.FormattingEnabled = true;
            this.cmbS6_name.Location = new System.Drawing.Point(54, 164);
            this.cmbS6_name.Name = "cmbS6_name";
            this.cmbS6_name.Size = new System.Drawing.Size(148, 21);
            this.cmbS6_name.TabIndex = 26;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.dSFilms;
            // 
            // cmbS2_id
            // 
            this.cmbS2_id.DataSource = this.actorsBindingSource;
            this.cmbS2_id.DisplayMember = "a_id";
            this.cmbS2_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbS2_id.FormattingEnabled = true;
            this.cmbS2_id.Location = new System.Drawing.Point(6, 47);
            this.cmbS2_id.Name = "cmbS2_id";
            this.cmbS2_id.Size = new System.Drawing.Size(42, 21);
            this.cmbS2_id.TabIndex = 11;
            // 
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "Actors";
            this.actorsBindingSource.DataSource = this.dSFilms;
            // 
            // cmbS6_id
            // 
            this.cmbS6_id.DataSource = this.filmsBindingSource;
            this.cmbS6_id.DisplayMember = "f_id";
            this.cmbS6_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbS6_id.FormattingEnabled = true;
            this.cmbS6_id.Location = new System.Drawing.Point(6, 164);
            this.cmbS6_id.Name = "cmbS6_id";
            this.cmbS6_id.Size = new System.Drawing.Size(42, 21);
            this.cmbS6_id.TabIndex = 25;
            // 
            // cmbS2_name
            // 
            this.cmbS2_name.DataSource = this.actorsBindingSource;
            this.cmbS2_name.DisplayMember = "a_name";
            this.cmbS2_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbS2_name.FormattingEnabled = true;
            this.cmbS2_name.Location = new System.Drawing.Point(54, 47);
            this.cmbS2_name.Name = "cmbS2_name";
            this.cmbS2_name.Size = new System.Drawing.Size(148, 21);
            this.cmbS2_name.TabIndex = 12;
            // 
            // btnS6
            // 
            this.btnS6.Location = new System.Drawing.Point(208, 162);
            this.btnS6.Name = "btnS6";
            this.btnS6.Size = new System.Drawing.Size(75, 23);
            this.btnS6.TabIndex = 24;
            this.btnS6.Text = "Запит 6";
            this.btnS6.UseVisualStyleBackColor = true;
            this.btnS6.Click += new System.EventHandler(this.btnS6_Click);
            // 
            // nudS3
            // 
            this.nudS3.Location = new System.Drawing.Point(6, 75);
            this.nudS3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudS3.Name = "nudS3";
            this.nudS3.Size = new System.Drawing.Size(196, 20);
            this.nudS3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Фільми, в яких немає інших жанрів, ніж в обраного фільму";
            // 
            // btnS3
            // 
            this.btnS3.Location = new System.Drawing.Point(208, 75);
            this.btnS3.Name = "btnS3";
            this.btnS3.Size = new System.Drawing.Size(75, 23);
            this.btnS3.TabIndex = 14;
            this.btnS3.Text = "Запит 3";
            this.btnS3.UseVisualStyleBackColor = true;
            this.btnS3.Click += new System.EventHandler(this.btnS3_Click);
            // 
            // cmbS5_name
            // 
            this.cmbS5_name.DataSource = this.genresBindingSource;
            this.cmbS5_name.DisplayMember = "g_name";
            this.cmbS5_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbS5_name.FormattingEnabled = true;
            this.cmbS5_name.Location = new System.Drawing.Point(54, 135);
            this.cmbS5_name.Name = "cmbS5_name";
            this.cmbS5_name.Size = new System.Drawing.Size(148, 21);
            this.cmbS5_name.TabIndex = 22;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.dSFilms;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Фільми, у яких не менше заданої кількості акторів";
            // 
            // cmbS5_id
            // 
            this.cmbS5_id.DataSource = this.genresBindingSource;
            this.cmbS5_id.DisplayMember = "g_id";
            this.cmbS5_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbS5_id.FormattingEnabled = true;
            this.cmbS5_id.Location = new System.Drawing.Point(6, 135);
            this.cmbS5_id.Name = "cmbS5_id";
            this.cmbS5_id.Size = new System.Drawing.Size(42, 21);
            this.cmbS5_id.TabIndex = 21;
            // 
            // nudS4
            // 
            this.nudS4.Location = new System.Drawing.Point(6, 104);
            this.nudS4.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.nudS4.Name = "nudS4";
            this.nudS4.Size = new System.Drawing.Size(196, 20);
            this.nudS4.TabIndex = 16;
            this.nudS4.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // btnS5
            // 
            this.btnS5.Location = new System.Drawing.Point(208, 133);
            this.btnS5.Name = "btnS5";
            this.btnS5.Size = new System.Drawing.Size(75, 23);
            this.btnS5.TabIndex = 20;
            this.btnS5.Text = "Запит 5";
            this.btnS5.UseVisualStyleBackColor = true;
            this.btnS5.Click += new System.EventHandler(this.btnS5_Click);
            // 
            // btnS4
            // 
            this.btnS4.Location = new System.Drawing.Point(208, 104);
            this.btnS4.Name = "btnS4";
            this.btnS4.Size = new System.Drawing.Size(75, 23);
            this.btnS4.TabIndex = 17;
            this.btnS4.Text = "Запит 4";
            this.btnS4.UseVisualStyleBackColor = true;
            this.btnS4.Click += new System.EventHandler(this.btnS4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Фільми із заданим жанром";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Фільми, у яких немає акторів, які народилися до заданого року";
            // 
            // tabFilms
            // 
            this.tabFilms.Controls.Add(this.button1);
            this.tabFilms.Controls.Add(this.btnDeleteFilm);
            this.tabFilms.Controls.Add(this.btnAddFilm);
            this.tabFilms.Controls.Add(this.dgvFilms);
            this.tabFilms.Location = new System.Drawing.Point(4, 22);
            this.tabFilms.Name = "tabFilms";
            this.tabFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilms.Size = new System.Drawing.Size(723, 264);
            this.tabFilms.TabIndex = 0;
            this.tabFilms.Text = "Фільми";
            this.tabFilms.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Змінити продюсера";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteFilm
            // 
            this.btnDeleteFilm.Location = new System.Drawing.Point(87, 6);
            this.btnDeleteFilm.Name = "btnDeleteFilm";
            this.btnDeleteFilm.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFilm.TabIndex = 2;
            this.btnDeleteFilm.Text = "Видалити";
            this.btnDeleteFilm.UseVisualStyleBackColor = true;
            this.btnDeleteFilm.Click += new System.EventHandler(this.btnDeleteFilm_Click);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(6, 6);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(75, 23);
            this.btnAddFilm.TabIndex = 1;
            this.btnAddFilm.Text = "Додати";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // dgvFilms
            // 
            this.dgvFilms.AllowUserToAddRows = false;
            this.dgvFilms.AllowUserToDeleteRows = false;
            this.dgvFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilms.AutoGenerateColumns = false;
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fid,
            this.dname,
            this.fyear,
            this.fproducer});
            this.dgvFilms.DataSource = this.filmsBindingSource;
            this.dgvFilms.Location = new System.Drawing.Point(6, 35);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.Size = new System.Drawing.Size(830, 223);
            this.dgvFilms.TabIndex = 0;
            this.dgvFilms.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvFilms_CellBeginEdit);
            this.dgvFilms.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilms_CellEndEdit);
            this.dgvFilms.DoubleClick += new System.EventHandler(this.dgvFilms_DoubleClick);
            // 
            // fid
            // 
            this.fid.DataPropertyName = "f_id";
            this.fid.HeaderText = "ID";
            this.fid.Name = "fid";
            this.fid.ReadOnly = true;
            // 
            // dname
            // 
            this.dname.DataPropertyName = "d_name";
            this.dname.HeaderText = "Назва";
            this.dname.Name = "dname";
            this.dname.Width = 200;
            // 
            // fyear
            // 
            this.fyear.DataPropertyName = "f_year";
            this.fyear.HeaderText = "Рік";
            this.fyear.Name = "fyear";
            // 
            // fproducer
            // 
            this.fproducer.DataPropertyName = "f_producer";
            this.fproducer.HeaderText = "Продюсер ID";
            this.fproducer.Name = "fproducer";
            this.fproducer.ReadOnly = true;
            // 
            // tabProducers
            // 
            this.tabProducers.Controls.Add(this.btnDeleteProducer);
            this.tabProducers.Controls.Add(this.btnAddProducer);
            this.tabProducers.Controls.Add(this.dgvProducers);
            this.tabProducers.Location = new System.Drawing.Point(4, 22);
            this.tabProducers.Name = "tabProducers";
            this.tabProducers.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducers.Size = new System.Drawing.Size(723, 264);
            this.tabProducers.TabIndex = 1;
            this.tabProducers.Text = "Продюсери";
            this.tabProducers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProducer
            // 
            this.btnDeleteProducer.Location = new System.Drawing.Point(87, 6);
            this.btnDeleteProducer.Name = "btnDeleteProducer";
            this.btnDeleteProducer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProducer.TabIndex = 4;
            this.btnDeleteProducer.Text = "Видалити";
            this.btnDeleteProducer.UseVisualStyleBackColor = true;
            this.btnDeleteProducer.Click += new System.EventHandler(this.btnDeleteProducer_Click);
            // 
            // btnAddProducer
            // 
            this.btnAddProducer.Location = new System.Drawing.Point(6, 6);
            this.btnAddProducer.Name = "btnAddProducer";
            this.btnAddProducer.Size = new System.Drawing.Size(75, 23);
            this.btnAddProducer.TabIndex = 3;
            this.btnAddProducer.Text = "Додати";
            this.btnAddProducer.UseVisualStyleBackColor = true;
            this.btnAddProducer.Click += new System.EventHandler(this.btnAddProducer_Click);
            // 
            // dgvProducers
            // 
            this.dgvProducers.AllowUserToAddRows = false;
            this.dgvProducers.AllowUserToDeleteRows = false;
            this.dgvProducers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducers.AutoGenerateColumns = false;
            this.dgvProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.pname,
            this.pbirth,
            this.pdeath});
            this.dgvProducers.DataSource = this.producersBindingSource;
            this.dgvProducers.Location = new System.Drawing.Point(6, 35);
            this.dgvProducers.Name = "dgvProducers";
            this.dgvProducers.Size = new System.Drawing.Size(711, 223);
            this.dgvProducers.TabIndex = 1;
            this.dgvProducers.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvProducers_CellBeginEdit);
            this.dgvProducers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducers_CellEndEdit);
            // 
            // pid
            // 
            this.pid.DataPropertyName = "p_id";
            this.pid.HeaderText = "ID";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            // 
            // pname
            // 
            this.pname.DataPropertyName = "p_name";
            this.pname.HeaderText = "Ім\'я";
            this.pname.Name = "pname";
            this.pname.Width = 200;
            // 
            // pbirth
            // 
            this.pbirth.DataPropertyName = "p_birth";
            this.pbirth.HeaderText = "Рік народження";
            this.pbirth.Name = "pbirth";
            this.pbirth.Width = 120;
            // 
            // pdeath
            // 
            this.pdeath.DataPropertyName = "p_death";
            this.pdeath.HeaderText = "Рік смерті";
            this.pdeath.Name = "pdeath";
            // 
            // tabActors
            // 
            this.tabActors.Controls.Add(this.btnDeleteActor);
            this.tabActors.Controls.Add(this.btnAddActor);
            this.tabActors.Controls.Add(this.dgvActors);
            this.tabActors.Location = new System.Drawing.Point(4, 22);
            this.tabActors.Name = "tabActors";
            this.tabActors.Size = new System.Drawing.Size(723, 264);
            this.tabActors.TabIndex = 2;
            this.tabActors.Text = "Актори";
            this.tabActors.UseVisualStyleBackColor = true;
            // 
            // btnDeleteActor
            // 
            this.btnDeleteActor.Location = new System.Drawing.Point(87, 6);
            this.btnDeleteActor.Name = "btnDeleteActor";
            this.btnDeleteActor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteActor.TabIndex = 4;
            this.btnDeleteActor.Text = "Видалити";
            this.btnDeleteActor.UseVisualStyleBackColor = true;
            this.btnDeleteActor.Click += new System.EventHandler(this.btnDeleteActor_Click);
            // 
            // btnAddActor
            // 
            this.btnAddActor.Location = new System.Drawing.Point(6, 6);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(75, 23);
            this.btnAddActor.TabIndex = 3;
            this.btnAddActor.Text = "Додати";
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // dgvActors
            // 
            this.dgvActors.AllowUserToAddRows = false;
            this.dgvActors.AllowUserToDeleteRows = false;
            this.dgvActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActors.AutoGenerateColumns = false;
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aid,
            this.aname,
            this.abirth,
            this.adeath});
            this.dgvActors.DataSource = this.actorsBindingSource;
            this.dgvActors.Location = new System.Drawing.Point(6, 35);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(703, 187);
            this.dgvActors.TabIndex = 1;
            this.dgvActors.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvActors_CellBeginEdit);
            this.dgvActors.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActors_CellEndEdit);
            // 
            // aid
            // 
            this.aid.DataPropertyName = "a_id";
            this.aid.HeaderText = "ID";
            this.aid.Name = "aid";
            this.aid.ReadOnly = true;
            // 
            // aname
            // 
            this.aname.DataPropertyName = "a_name";
            this.aname.HeaderText = "Ім\'я";
            this.aname.Name = "aname";
            this.aname.Width = 200;
            // 
            // abirth
            // 
            this.abirth.DataPropertyName = "a_birth";
            this.abirth.HeaderText = "Рік народження";
            this.abirth.Name = "abirth";
            this.abirth.Width = 120;
            // 
            // adeath
            // 
            this.adeath.DataPropertyName = "a_death";
            this.adeath.HeaderText = "Рік смерті";
            this.adeath.Name = "adeath";
            // 
            // tabGenres
            // 
            this.tabGenres.Controls.Add(this.btnDeleteGenre);
            this.tabGenres.Controls.Add(this.btnAddGenre);
            this.tabGenres.Controls.Add(this.dgvGenres);
            this.tabGenres.Location = new System.Drawing.Point(4, 22);
            this.tabGenres.Name = "tabGenres";
            this.tabGenres.Size = new System.Drawing.Size(723, 264);
            this.tabGenres.TabIndex = 3;
            this.tabGenres.Text = "Жанри";
            this.tabGenres.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(87, 6);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGenre.TabIndex = 6;
            this.btnDeleteGenre.Text = "Видалити";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(6, 6);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAddGenre.TabIndex = 5;
            this.btnAddGenre.Text = "Додати";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGenres.AutoGenerateColumns = false;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gid,
            this.gname});
            this.dgvGenres.DataSource = this.genresBindingSource;
            this.dgvGenres.Location = new System.Drawing.Point(6, 35);
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.Size = new System.Drawing.Size(703, 187);
            this.dgvGenres.TabIndex = 1;
            this.dgvGenres.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvGenres_CellBeginEdit);
            this.dgvGenres.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenres_CellEndEdit);
            // 
            // gid
            // 
            this.gid.DataPropertyName = "g_id";
            this.gid.HeaderText = "ID";
            this.gid.Name = "gid";
            this.gid.ReadOnly = true;
            // 
            // gname
            // 
            this.gname.DataPropertyName = "g_name";
            this.gname.HeaderText = "Назва";
            this.gname.Name = "gname";
            this.gname.Width = 300;
            // 
            // tabFilmsActors
            // 
            this.tabFilmsActors.Controls.Add(this.btnDeleteFilmActor);
            this.tabFilmsActors.Controls.Add(this.btnAddFilmActor);
            this.tabFilmsActors.Controls.Add(this.dgvFilmsActors);
            this.tabFilmsActors.Location = new System.Drawing.Point(4, 22);
            this.tabFilmsActors.Name = "tabFilmsActors";
            this.tabFilmsActors.Size = new System.Drawing.Size(723, 264);
            this.tabFilmsActors.TabIndex = 4;
            this.tabFilmsActors.Text = "Фільми-Актори";
            this.tabFilmsActors.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFilmActor
            // 
            this.btnDeleteFilmActor.Location = new System.Drawing.Point(87, 6);
            this.btnDeleteFilmActor.Name = "btnDeleteFilmActor";
            this.btnDeleteFilmActor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFilmActor.TabIndex = 6;
            this.btnDeleteFilmActor.Text = "Видалити";
            this.btnDeleteFilmActor.UseVisualStyleBackColor = true;
            this.btnDeleteFilmActor.Click += new System.EventHandler(this.btnDeleteFilmActor_Click);
            // 
            // btnAddFilmActor
            // 
            this.btnAddFilmActor.Location = new System.Drawing.Point(6, 6);
            this.btnAddFilmActor.Name = "btnAddFilmActor";
            this.btnAddFilmActor.Size = new System.Drawing.Size(75, 23);
            this.btnAddFilmActor.TabIndex = 5;
            this.btnAddFilmActor.Text = "Додати";
            this.btnAddFilmActor.UseVisualStyleBackColor = true;
            this.btnAddFilmActor.Click += new System.EventHandler(this.btnAddFilmActor_Click);
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
            this.faaidDataGridViewTextBoxColumn});
            this.dgvFilmsActors.DataSource = this.filmsActorsBindingSource;
            this.dgvFilmsActors.Location = new System.Drawing.Point(6, 35);
            this.dgvFilmsActors.Name = "dgvFilmsActors";
            this.dgvFilmsActors.ReadOnly = true;
            this.dgvFilmsActors.Size = new System.Drawing.Size(703, 187);
            this.dgvFilmsActors.TabIndex = 1;
            // 
            // faidDataGridViewTextBoxColumn
            // 
            this.faidDataGridViewTextBoxColumn.DataPropertyName = "fa_id";
            this.faidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.faidDataGridViewTextBoxColumn.Name = "faidDataGridViewTextBoxColumn";
            this.faidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fafidDataGridViewTextBoxColumn
            // 
            this.fafidDataGridViewTextBoxColumn.DataPropertyName = "fa_f_id";
            this.fafidDataGridViewTextBoxColumn.HeaderText = "Фільм ID";
            this.fafidDataGridViewTextBoxColumn.Name = "fafidDataGridViewTextBoxColumn";
            this.fafidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faaidDataGridViewTextBoxColumn
            // 
            this.faaidDataGridViewTextBoxColumn.DataPropertyName = "fa_a_id";
            this.faaidDataGridViewTextBoxColumn.HeaderText = "Актор ID";
            this.faaidDataGridViewTextBoxColumn.Name = "faaidDataGridViewTextBoxColumn";
            this.faaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmsActorsBindingSource
            // 
            this.filmsActorsBindingSource.DataMember = "FilmsActors";
            this.filmsActorsBindingSource.DataSource = this.dSFilms;
            // 
            // tabFilmsGenres
            // 
            this.tabFilmsGenres.Controls.Add(this.btnDeleteFilmGenre);
            this.tabFilmsGenres.Controls.Add(this.btnAddFilmGenre);
            this.tabFilmsGenres.Controls.Add(this.dgvFilmsGenres);
            this.tabFilmsGenres.Location = new System.Drawing.Point(4, 22);
            this.tabFilmsGenres.Name = "tabFilmsGenres";
            this.tabFilmsGenres.Size = new System.Drawing.Size(723, 264);
            this.tabFilmsGenres.TabIndex = 5;
            this.tabFilmsGenres.Text = "Фільми-Жанри";
            this.tabFilmsGenres.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFilmGenre
            // 
            this.btnDeleteFilmGenre.Location = new System.Drawing.Point(87, 6);
            this.btnDeleteFilmGenre.Name = "btnDeleteFilmGenre";
            this.btnDeleteFilmGenre.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFilmGenre.TabIndex = 6;
            this.btnDeleteFilmGenre.Text = "Видалити";
            this.btnDeleteFilmGenre.UseVisualStyleBackColor = true;
            this.btnDeleteFilmGenre.Click += new System.EventHandler(this.btnDeleteFilmGenre_Click);
            // 
            // btnAddFilmGenre
            // 
            this.btnAddFilmGenre.Location = new System.Drawing.Point(6, 6);
            this.btnAddFilmGenre.Name = "btnAddFilmGenre";
            this.btnAddFilmGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAddFilmGenre.TabIndex = 5;
            this.btnAddFilmGenre.Text = "Додати";
            this.btnAddFilmGenre.UseVisualStyleBackColor = true;
            this.btnAddFilmGenre.Click += new System.EventHandler(this.btnAddFilmGenre_Click);
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
            this.fggidDataGridViewTextBoxColumn});
            this.dgvFilmsGenres.DataSource = this.filmsGenresBindingSource;
            this.dgvFilmsGenres.Location = new System.Drawing.Point(6, 35);
            this.dgvFilmsGenres.Name = "dgvFilmsGenres";
            this.dgvFilmsGenres.ReadOnly = true;
            this.dgvFilmsGenres.Size = new System.Drawing.Size(703, 187);
            this.dgvFilmsGenres.TabIndex = 1;
            // 
            // fgidDataGridViewTextBoxColumn
            // 
            this.fgidDataGridViewTextBoxColumn.DataPropertyName = "fg_id";
            this.fgidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.fgidDataGridViewTextBoxColumn.Name = "fgidDataGridViewTextBoxColumn";
            this.fgidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fgfidDataGridViewTextBoxColumn
            // 
            this.fgfidDataGridViewTextBoxColumn.DataPropertyName = "fg_f_id";
            this.fgfidDataGridViewTextBoxColumn.HeaderText = "Фільм ID";
            this.fgfidDataGridViewTextBoxColumn.Name = "fgfidDataGridViewTextBoxColumn";
            this.fgfidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fggidDataGridViewTextBoxColumn
            // 
            this.fggidDataGridViewTextBoxColumn.DataPropertyName = "fg_g_id";
            this.fggidDataGridViewTextBoxColumn.HeaderText = "Жанр ID";
            this.fggidDataGridViewTextBoxColumn.Name = "fggidDataGridViewTextBoxColumn";
            this.fggidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmsGenresBindingSource
            // 
            this.filmsGenresBindingSource.DataMember = "FilmsGenres";
            this.filmsGenresBindingSource.DataSource = this.dSFilms2;
            // 
            // dSFilms2
            // 
            this.dSFilms2.DataSetName = "DSFilms";
            this.dSFilms2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(12, 12);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(100, 40);
            this.btnSaveAll.TabIndex = 1;
            this.btnSaveAll.Text = "Зберегти";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(118, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Оновити";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dSFilms1
            // 
            this.dSFilms1.DataSetName = "DSFilms";
            this.dSFilms1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // producersTableAdapter
            // 
            this.producersTableAdapter.ClearBeforeFill = true;
            // 
            // actorsTableAdapter
            // 
            this.actorsTableAdapter.ClearBeforeFill = true;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // filmsGenresTableAdapter
            // 
            this.filmsGenresTableAdapter.ClearBeforeFill = true;
            // 
            // filmsActorsTableAdapter
            // 
            this.filmsActorsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 45F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(479, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 79);
            this.label1.TabIndex = 3;
            this.label1.Text = "Красиво";
            // 
            // FormFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSaveAll);
            this.Name = "FormFilms";
            this.Text = "Шевченко Максим К-27";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS4)).EndInit();
            this.tabFilms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.tabProducers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducers)).EndInit();
            this.tabActors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.tabGenres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.tabFilmsActors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsActorsBindingSource)).EndInit();
            this.tabFilmsGenres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmsGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsGenresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFilms;
        private System.Windows.Forms.TabPage tabProducers;
        private System.Windows.Forms.TabPage tabActors;
        private System.Windows.Forms.TabPage tabGenres;
        private System.Windows.Forms.TabPage tabFilmsActors;
        private System.Windows.Forms.TabPage tabFilmsGenres;
        private System.Windows.Forms.DataGridView dgvFilms;
        private System.Windows.Forms.DataGridView dgvProducers;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.DataGridView dgvGenres;
        private System.Windows.Forms.DataGridView dgvFilmsActors;
        private System.Windows.Forms.DataGridView dgvFilmsGenres;
        private DSFilms dSFilms;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private DSFilmsTableAdapters.FilmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.BindingSource producersBindingSource;
        private DSFilmsTableAdapters.ProducersTableAdapter producersTableAdapter;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private DSFilmsTableAdapters.ActorsTableAdapter actorsTableAdapter;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private DSFilmsTableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.Button btnDeleteFilm;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.Button btnDeleteProducer;
        private System.Windows.Forms.Button btnAddProducer;
        private System.Windows.Forms.Button btnDeleteActor;
        private System.Windows.Forms.Button btnAddActor;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnDeleteFilmActor;
        private System.Windows.Forms.Button btnAddFilmActor;
        private System.Windows.Forms.Button btnDeleteFilmGenre;
        private System.Windows.Forms.Button btnAddFilmGenre;
        private DSFilms dSFilms1;
        private DSFilmsTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnUpdate;
        private DSFilms dSFilms2;
        private System.Windows.Forms.BindingSource filmsGenresBindingSource;
        private DSFilmsTableAdapters.FilmsGenresTableAdapter filmsGenresTableAdapter;
        private System.Windows.Forms.BindingSource filmsActorsBindingSource;
        private DSFilmsTableAdapters.FilmsActorsTableAdapter filmsActorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdeath;
        private System.Windows.Forms.DataGridViewTextBoxColumn aid;
        private System.Windows.Forms.DataGridViewTextBoxColumn aname;
        private System.Windows.Forms.DataGridViewTextBoxColumn abirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn adeath;
        private System.Windows.Forms.DataGridViewTextBoxColumn gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn faidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fafidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgfidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fggidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn fproducer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnS1;
        private System.Windows.Forms.ComboBox cmbS1_id;
        private System.Windows.Forms.ComboBox cmbS1_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbS2_name;
        private System.Windows.Forms.ComboBox cmbS2_id;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.NumericUpDown nudS3;
        private System.Windows.Forms.Button btnS3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnS4;
        private System.Windows.Forms.NumericUpDown nudS4;
        private System.Windows.Forms.ComboBox cmbS5_name;
        private System.Windows.Forms.ComboBox cmbS5_id;
        private System.Windows.Forms.Button btnS5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbS6_name;
        private System.Windows.Forms.ComboBox cmbS6_id;
        private System.Windows.Forms.Button btnS6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnS7;
        private System.Windows.Forms.NumericUpDown nudS7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnS8;
        private System.Windows.Forms.NumericUpDown nudS8;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

