namespace LabBD
{
    partial class FormS8
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
            this.dSFilms = new LabBD.DSFilms();
            this.s8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s8TableAdapter = new LabBD.DSFilmsTableAdapters.S8TableAdapter();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdeathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s8BindingSource)).BeginInit();
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
            this.pidDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.pbirthDataGridViewTextBoxColumn,
            this.pdeathDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.s8BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // dSFilms
            // 
            this.dSFilms.DataSetName = "DSFilms";
            this.dSFilms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s8BindingSource
            // 
            this.s8BindingSource.DataMember = "S8";
            this.s8BindingSource.DataSource = this.dSFilms;
            // 
            // s8TableAdapter
            // 
            this.s8TableAdapter.ClearBeforeFill = true;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "p_id";
            this.pidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "p_name";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pbirthDataGridViewTextBoxColumn
            // 
            this.pbirthDataGridViewTextBoxColumn.DataPropertyName = "p_birth";
            this.pbirthDataGridViewTextBoxColumn.HeaderText = "Рік народження";
            this.pbirthDataGridViewTextBoxColumn.Name = "pbirthDataGridViewTextBoxColumn";
            this.pbirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pdeathDataGridViewTextBoxColumn
            // 
            this.pdeathDataGridViewTextBoxColumn.DataPropertyName = "p_death";
            this.pdeathDataGridViewTextBoxColumn.HeaderText = "Рік смерті";
            this.pdeathDataGridViewTextBoxColumn.Name = "pdeathDataGridViewTextBoxColumn";
            this.pdeathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormS8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormS8";
            this.Text = "Запит 8";
            this.Load += new System.EventHandler(this.FormS8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s8BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdeathDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource s8BindingSource;
        private DSFilms dSFilms;
        private DSFilmsTableAdapters.S8TableAdapter s8TableAdapter;
    }
}