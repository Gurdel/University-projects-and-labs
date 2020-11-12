namespace LabBD
{
    partial class FormS1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.s1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFilms = new LabBD.DSFilms();
            this.queriesTableAdapter1 = new LabBD.DSFilmsTableAdapters.QueriesTableAdapter();
            this.s1TableAdapter = new LabBD.DSFilmsTableAdapters.S1TableAdapter();
            this.gidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gidDataGridViewTextBoxColumn,
            this.gnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.s1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // s1BindingSource
            // 
            this.s1BindingSource.DataMember = "S1";
            this.s1BindingSource.DataSource = this.dSFilms;
            // 
            // dSFilms
            // 
            this.dSFilms.DataSetName = "DSFilms";
            this.dSFilms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s1TableAdapter
            // 
            this.s1TableAdapter.ClearBeforeFill = true;
            // 
            // gidDataGridViewTextBoxColumn
            // 
            this.gidDataGridViewTextBoxColumn.DataPropertyName = "g_id";
            this.gidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.gidDataGridViewTextBoxColumn.Name = "gidDataGridViewTextBoxColumn";
            this.gidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gnameDataGridViewTextBoxColumn
            // 
            this.gnameDataGridViewTextBoxColumn.DataPropertyName = "g_name";
            this.gnameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.gnameDataGridViewTextBoxColumn.Name = "gnameDataGridViewTextBoxColumn";
            this.gnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.gnameDataGridViewTextBoxColumn.Width = 300;
            // 
            // FormS1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormS1";
            this.Text = "Запит 1";
            this.Load += new System.EventHandler(this.FormS1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DSFilmsTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource s1BindingSource;
        private DSFilms dSFilms;
        private DSFilmsTableAdapters.S1TableAdapter s1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnameDataGridViewTextBoxColumn;
    }
}