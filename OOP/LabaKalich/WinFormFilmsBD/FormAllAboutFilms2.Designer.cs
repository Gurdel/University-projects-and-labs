﻿namespace WinFormFilmsBD
{
    partial class FormAllAboutFilms2
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
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.rtbYear = new System.Windows.Forms.RichTextBox();
            this.rtbProducer = new System.Windows.Forms.RichTextBox();
            this.rtbActors = new System.Windows.Forms.RichTextBox();
            this.rtbGenres = new System.Windows.Forms.RichTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.kQueriesTableAdapter1 = new WinFormFilmsBD.KalichDSTableAdapters.KQueriesTableAdapter();
            this.SuspendLayout();
            // 
            // rtbName
            // 
            this.rtbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbName.Location = new System.Drawing.Point(116, 12);
            this.rtbName.Name = "rtbName";
            this.rtbName.ReadOnly = true;
            this.rtbName.Size = new System.Drawing.Size(672, 20);
            this.rtbName.TabIndex = 0;
            this.rtbName.Text = "";
            // 
            // rtbYear
            // 
            this.rtbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbYear.Location = new System.Drawing.Point(116, 38);
            this.rtbYear.Name = "rtbYear";
            this.rtbYear.ReadOnly = true;
            this.rtbYear.Size = new System.Drawing.Size(672, 20);
            this.rtbYear.TabIndex = 1;
            this.rtbYear.Text = "";
            // 
            // rtbProducer
            // 
            this.rtbProducer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbProducer.Location = new System.Drawing.Point(116, 64);
            this.rtbProducer.Name = "rtbProducer";
            this.rtbProducer.ReadOnly = true;
            this.rtbProducer.Size = new System.Drawing.Size(672, 20);
            this.rtbProducer.TabIndex = 2;
            this.rtbProducer.Text = "";
            // 
            // rtbActors
            // 
            this.rtbActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbActors.Location = new System.Drawing.Point(116, 216);
            this.rtbActors.Name = "rtbActors";
            this.rtbActors.ReadOnly = true;
            this.rtbActors.Size = new System.Drawing.Size(672, 120);
            this.rtbActors.TabIndex = 3;
            this.rtbActors.Text = "";
            // 
            // rtbGenres
            // 
            this.rtbGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbGenres.Location = new System.Drawing.Point(116, 90);
            this.rtbGenres.Name = "rtbGenres";
            this.rtbGenres.ReadOnly = true;
            this.rtbGenres.Size = new System.Drawing.Size(672, 120);
            this.rtbGenres.TabIndex = 4;
            this.rtbGenres.Text = "";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Назва";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 38);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(22, 13);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Рік";
            // 
            // lblGenres
            // 
            this.lblGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenres.AutoSize = true;
            this.lblGenres.Location = new System.Drawing.Point(12, 90);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(81, 13);
            this.lblGenres.TabIndex = 7;
            this.lblGenres.Text = "Список жанрів";
            // 
            // lblProducer
            // 
            this.lblProducer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(12, 64);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(52, 13);
            this.lblProducer.TabIndex = 8;
            this.lblProducer.Text = "Режисер";
            // 
            // lblActors
            // 
            this.lblActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActors.AutoSize = true;
            this.lblActors.Location = new System.Drawing.Point(12, 216);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(84, 13);
            this.lblActors.TabIndex = 9;
            this.lblActors.Text = "Список акторів";
            // 
            // FormAllAboutFilms2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rtbGenres);
            this.Controls.Add(this.rtbActors);
            this.Controls.Add(this.rtbProducer);
            this.Controls.Add(this.rtbYear);
            this.Controls.Add(this.rtbName);
            this.Name = "FormAllAboutFilms2";
            this.Text = "Детальна інформація про фільм";
            this.Load += new System.EventHandler(this.FormAllAboutFilms2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbName;
        private System.Windows.Forms.RichTextBox rtbYear;
        private System.Windows.Forms.RichTextBox rtbProducer;
        private System.Windows.Forms.RichTextBox rtbActors;
        private System.Windows.Forms.RichTextBox rtbGenres;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblActors;
        private KalichDSTableAdapters.KQueriesTableAdapter kQueriesTableAdapter1;
    }
}