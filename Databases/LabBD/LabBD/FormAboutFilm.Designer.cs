namespace LabBD
{
    partial class FormAboutFilm
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
            this.lblActors = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rtbProducer = new System.Windows.Forms.RichTextBox();
            this.rtbYear = new System.Windows.Forms.RichTextBox();
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.queriesTableAdapter = new LabBD.DSFilmsTableAdapters.QueriesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aboutGenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFilms = new LabBD.DSFilms();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.aboutActorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFilms1 = new LabBD.DSFilms();
            this.aboutGenresTableAdapter = new LabBD.DSFilmsTableAdapters.AboutGenresTableAdapter();
            this.aboutActorsTableAdapter = new LabBD.DSFilmsTableAdapters.AboutActorsTableAdapter();
            this.gnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutGenresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutActorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActors
            // 
            this.lblActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActors.AutoSize = true;
            this.lblActors.Location = new System.Drawing.Point(12, 214);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(84, 13);
            this.lblActors.TabIndex = 19;
            this.lblActors.Text = "Список акторів";
            // 
            // lblProducer
            // 
            this.lblProducer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(12, 62);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(52, 13);
            this.lblProducer.TabIndex = 18;
            this.lblProducer.Text = "Режисер";
            // 
            // lblGenres
            // 
            this.lblGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenres.AutoSize = true;
            this.lblGenres.Location = new System.Drawing.Point(12, 88);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(81, 13);
            this.lblGenres.TabIndex = 17;
            this.lblGenres.Text = "Список жанрів";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 36);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(22, 13);
            this.lblYear.TabIndex = 16;
            this.lblYear.Text = "Рік";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Назва";
            // 
            // rtbProducer
            // 
            this.rtbProducer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbProducer.Location = new System.Drawing.Point(116, 62);
            this.rtbProducer.Name = "rtbProducer";
            this.rtbProducer.ReadOnly = true;
            this.rtbProducer.Size = new System.Drawing.Size(672, 23);
            this.rtbProducer.TabIndex = 12;
            this.rtbProducer.Text = "";
            // 
            // rtbYear
            // 
            this.rtbYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbYear.Location = new System.Drawing.Point(116, 36);
            this.rtbYear.Name = "rtbYear";
            this.rtbYear.ReadOnly = true;
            this.rtbYear.Size = new System.Drawing.Size(672, 23);
            this.rtbYear.TabIndex = 11;
            this.rtbYear.Text = "";
            // 
            // rtbName
            // 
            this.rtbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbName.Location = new System.Drawing.Point(116, 10);
            this.rtbName.Name = "rtbName";
            this.rtbName.ReadOnly = true;
            this.rtbName.Size = new System.Drawing.Size(672, 23);
            this.rtbName.TabIndex = 10;
            this.rtbName.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gnameDataGridViewTextBoxColumn,
            this.gidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aboutGenresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(116, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(672, 117);
            this.dataGridView1.TabIndex = 20;
            // 
            // aboutGenresBindingSource
            // 
            this.aboutGenresBindingSource.DataMember = "AboutGenres";
            this.aboutGenresBindingSource.DataSource = this.dSFilms;
            // 
            // dSFilms
            // 
            this.dSFilms.DataSetName = "DSFilms";
            this.dSFilms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aidDataGridViewTextBoxColumn,
            this.anameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.aboutActorsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(116, 214);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(672, 122);
            this.dataGridView2.TabIndex = 21;
            // 
            // aboutActorsBindingSource
            // 
            this.aboutActorsBindingSource.DataMember = "AboutActors";
            this.aboutActorsBindingSource.DataSource = this.dSFilms1;
            // 
            // dSFilms1
            // 
            this.dSFilms1.DataSetName = "DSFilms";
            this.dSFilms1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aboutGenresTableAdapter
            // 
            this.aboutGenresTableAdapter.ClearBeforeFill = true;
            // 
            // aboutActorsTableAdapter
            // 
            this.aboutActorsTableAdapter.ClearBeforeFill = true;
            // 
            // gnameDataGridViewTextBoxColumn
            // 
            this.gnameDataGridViewTextBoxColumn.DataPropertyName = "g_name";
            this.gnameDataGridViewTextBoxColumn.HeaderText = "ID";
            this.gnameDataGridViewTextBoxColumn.Name = "gnameDataGridViewTextBoxColumn";
            this.gnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gidDataGridViewTextBoxColumn
            // 
            this.gidDataGridViewTextBoxColumn.DataPropertyName = "g_id";
            this.gidDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.gidDataGridViewTextBoxColumn.Name = "gidDataGridViewTextBoxColumn";
            this.gidDataGridViewTextBoxColumn.ReadOnly = true;
            this.gidDataGridViewTextBoxColumn.Width = 400;
            // 
            // aidDataGridViewTextBoxColumn
            // 
            this.aidDataGridViewTextBoxColumn.DataPropertyName = "a_id";
            this.aidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.aidDataGridViewTextBoxColumn.Name = "aidDataGridViewTextBoxColumn";
            this.aidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anameDataGridViewTextBoxColumn
            // 
            this.anameDataGridViewTextBoxColumn.DataPropertyName = "a_name";
            this.anameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.anameDataGridViewTextBoxColumn.Name = "anameDataGridViewTextBoxColumn";
            this.anameDataGridViewTextBoxColumn.ReadOnly = true;
            this.anameDataGridViewTextBoxColumn.Width = 400;
            // 
            // FormAboutFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rtbProducer);
            this.Controls.Add(this.rtbYear);
            this.Controls.Add(this.rtbName);
            this.Name = "FormAboutFilm";
            this.Text = "Детальна інформація про фільм";
            this.Load += new System.EventHandler(this.FormAboutFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutGenresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutActorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox rtbProducer;
        private System.Windows.Forms.RichTextBox rtbYear;
        private System.Windows.Forms.RichTextBox rtbName;
        private DSFilmsTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource aboutGenresBindingSource;
        private DSFilms dSFilms;
        private DSFilmsTableAdapters.AboutGenresTableAdapter aboutGenresTableAdapter;
        private System.Windows.Forms.BindingSource aboutActorsBindingSource;
        private DSFilms dSFilms1;
        private DSFilmsTableAdapters.AboutActorsTableAdapter aboutActorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn;
    }
}