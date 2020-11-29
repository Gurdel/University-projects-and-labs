namespace OGKGlab
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FindNN = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.nupdCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // FindNN
            // 
            this.FindNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FindNN.Location = new System.Drawing.Point(618, 229);
            this.FindNN.Name = "FindNN";
            this.FindNN.Size = new System.Drawing.Size(200, 48);
            this.FindNN.TabIndex = 1;
            this.FindNN.Text = "Find NN";
            this.FindNN.UseVisualStyleBackColor = true;
            this.FindNN.Click += new System.EventHandler(this.FindNN_Click);
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Generate.Location = new System.Drawing.Point(618, 283);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(200, 48);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Clear.Location = new System.Drawing.Point(618, 364);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(200, 48);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // nupdCount
            // 
            this.nupdCount.Location = new System.Drawing.Point(619, 338);
            this.nupdCount.Name = "nupdCount";
            this.nupdCount.Size = new System.Drawing.Size(199, 20);
            this.nupdCount.TabIndex = 4;
            this.nupdCount.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 423);
            this.Controls.Add(this.nupdCount);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.FindNN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "OGKG Shevchenko MI-3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FindNN;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.NumericUpDown nupdCount;
    }
}

