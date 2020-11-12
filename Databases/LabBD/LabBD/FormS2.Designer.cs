namespace LabBD
{
    partial class FormS2
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
            this.s2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFilms = new LabBD.DSFilms();
            this.s2TableAdapter = new LabBD.DSFilmsTableAdapters.S2TableAdapter();
            this.queriesTableAdapter1 = new LabBD.DSFilmsTableAdapters.QueriesTableAdapter();
            this.aidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adeathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2BindingSource)).BeginInit();
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
            this.aidDataGridViewTextBoxColumn,
            this.anameDataGridViewTextBoxColumn,
            this.abirthDataGridViewTextBoxColumn,
            this.adeathDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.s2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // s2BindingSource
            // 
            this.s2BindingSource.DataMember = "S2";
            this.s2BindingSource.DataSource = this.dSFilms;
            // 
            // dSFilms
            // 
            this.dSFilms.DataSetName = "DSFilms";
            this.dSFilms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s2TableAdapter
            // 
            this.s2TableAdapter.ClearBeforeFill = true;
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
            this.anameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abirthDataGridViewTextBoxColumn
            // 
            this.abirthDataGridViewTextBoxColumn.DataPropertyName = "a_birth";
            this.abirthDataGridViewTextBoxColumn.HeaderText = "a_birth";
            this.abirthDataGridViewTextBoxColumn.Name = "abirthDataGridViewTextBoxColumn";
            this.abirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adeathDataGridViewTextBoxColumn
            // 
            this.adeathDataGridViewTextBoxColumn.DataPropertyName = "a_death";
            this.adeathDataGridViewTextBoxColumn.HeaderText = "a_death";
            this.adeathDataGridViewTextBoxColumn.Name = "adeathDataGridViewTextBoxColumn";
            this.adeathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormS2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormS2";
            this.Text = "Запит 2";
            this.Load += new System.EventHandler(this.FormS2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource s2BindingSource;
        private DSFilms dSFilms;
        private DSFilmsTableAdapters.S2TableAdapter s2TableAdapter;
        private DSFilmsTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdeathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adeathDataGridViewTextBoxColumn;
    }
}