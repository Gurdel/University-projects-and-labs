namespace LabBD
{
    partial class FormS6
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
            this.fidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFilms = new LabBD.DSFilms();
            this.s5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s5TableAdapter = new LabBD.DSFilmsTableAdapters.S5TableAdapter();
            this.s6TableAdapter = new LabBD.DSFilmsTableAdapters.S6TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s5BindingSource)).BeginInit();
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
            this.fidDataGridViewTextBoxColumn,
            this.dnameDataGridViewTextBoxColumn,
            this.fyearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.s6BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // fidDataGridViewTextBoxColumn
            // 
            this.fidDataGridViewTextBoxColumn.DataPropertyName = "f_id";
            this.fidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.fidDataGridViewTextBoxColumn.Name = "fidDataGridViewTextBoxColumn";
            this.fidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dnameDataGridViewTextBoxColumn
            // 
            this.dnameDataGridViewTextBoxColumn.DataPropertyName = "d_name";
            this.dnameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.dnameDataGridViewTextBoxColumn.Name = "dnameDataGridViewTextBoxColumn";
            this.dnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fyearDataGridViewTextBoxColumn
            // 
            this.fyearDataGridViewTextBoxColumn.DataPropertyName = "f_year";
            this.fyearDataGridViewTextBoxColumn.HeaderText = "Рік";
            this.fyearDataGridViewTextBoxColumn.Name = "fyearDataGridViewTextBoxColumn";
            this.fyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // s6BindingSource
            // 
            this.s6BindingSource.DataMember = "S6";
            this.s6BindingSource.DataSource = this.dSFilms;
            // 
            // dSFilms
            // 
            this.dSFilms.DataSetName = "DSFilms";
            this.dSFilms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s5BindingSource
            // 
            this.s5BindingSource.DataMember = "S5";
            this.s5BindingSource.DataSource = this.dSFilms;
            // 
            // s5TableAdapter
            // 
            this.s5TableAdapter.ClearBeforeFill = true;
            // 
            // s6TableAdapter
            // 
            this.s6TableAdapter.ClearBeforeFill = true;
            // 
            // FormS6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormS6";
            this.Text = "Запит 6";
            this.Load += new System.EventHandler(this.FormS6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource s6BindingSource;
        private DSFilms dSFilms;
        private System.Windows.Forms.BindingSource s5BindingSource;
        private DSFilmsTableAdapters.S5TableAdapter s5TableAdapter;
        private DSFilmsTableAdapters.S6TableAdapter s6TableAdapter;
    }
}