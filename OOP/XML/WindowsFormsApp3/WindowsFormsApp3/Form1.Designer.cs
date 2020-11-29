namespace WindowsFormsApp3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.faculty_cb = new System.Windows.Forms.CheckBox();
            this.faculty_combo = new System.Windows.Forms.ComboBox();
            this.course_cb = new System.Windows.Forms.CheckBox();
            this.course_combo = new System.Windows.Forms.ComboBox();
            this.speciality_cb = new System.Windows.Forms.CheckBox();
            this.speciality_combo = new System.Windows.Forms.ComboBox();
            this.department_cb = new System.Windows.Forms.CheckBox();
            this.department_combo = new System.Windows.Forms.ComboBox();
            this.group_cb = new System.Windows.Forms.CheckBox();
            this.group_combo = new System.Windows.Forms.ComboBox();
            this.name_cb = new System.Windows.Forms.CheckBox();
            this.name_combo = new System.Windows.Forms.ComboBox();
            this.id_card_cb = new System.Windows.Forms.CheckBox();
            this.id_card_combo = new System.Windows.Forms.ComboBox();
            this.sub1_sub = new System.Windows.Forms.ComboBox();
            this.sub1_numeric = new System.Windows.Forms.NumericUpDown();
            this.sub1_combo = new System.Windows.Forms.ComboBox();
            this.sub1_comboType = new System.Windows.Forms.ComboBox();
            this.sub2_sub = new System.Windows.Forms.ComboBox();
            this.sub2_numeric = new System.Windows.Forms.NumericUpDown();
            this.sub2_combo = new System.Windows.Forms.ComboBox();
            this.sub2_comboType = new System.Windows.Forms.ComboBox();
            this.sub3_sub = new System.Windows.Forms.ComboBox();
            this.sub3_numeric = new System.Windows.Forms.NumericUpDown();
            this.sub3_combo = new System.Windows.Forms.ComboBox();
            this.sub3_comboType = new System.Windows.Forms.ComboBox();
            this.sub4_sub = new System.Windows.Forms.ComboBox();
            this.sub4_numeric = new System.Windows.Forms.NumericUpDown();
            this.sub4_combo = new System.Windows.Forms.ComboBox();
            this.sub4_comboType = new System.Windows.Forms.ComboBox();
            this.result_listView = new System.Windows.Forms.RichTextBox();
            this.SAX_cb = new System.Windows.Forms.CheckBox();
            this.LINQ_cb = new System.Windows.Forms.CheckBox();
            this.DOM_cb = new System.Windows.Forms.CheckBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.html_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sub1_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub2_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub3_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub4_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.faculty_cb);
            this.flowLayoutPanel1.Controls.Add(this.faculty_combo);
            this.flowLayoutPanel1.Controls.Add(this.course_cb);
            this.flowLayoutPanel1.Controls.Add(this.course_combo);
            this.flowLayoutPanel1.Controls.Add(this.speciality_cb);
            this.flowLayoutPanel1.Controls.Add(this.speciality_combo);
            this.flowLayoutPanel1.Controls.Add(this.department_cb);
            this.flowLayoutPanel1.Controls.Add(this.department_combo);
            this.flowLayoutPanel1.Controls.Add(this.group_cb);
            this.flowLayoutPanel1.Controls.Add(this.group_combo);
            this.flowLayoutPanel1.Controls.Add(this.name_cb);
            this.flowLayoutPanel1.Controls.Add(this.name_combo);
            this.flowLayoutPanel1.Controls.Add(this.id_card_cb);
            this.flowLayoutPanel1.Controls.Add(this.id_card_combo);
            this.flowLayoutPanel1.Controls.Add(this.sub1_sub);
            this.flowLayoutPanel1.Controls.Add(this.sub1_numeric);
            this.flowLayoutPanel1.Controls.Add(this.sub1_combo);
            this.flowLayoutPanel1.Controls.Add(this.sub1_comboType);
            this.flowLayoutPanel1.Controls.Add(this.sub2_sub);
            this.flowLayoutPanel1.Controls.Add(this.sub2_numeric);
            this.flowLayoutPanel1.Controls.Add(this.sub2_combo);
            this.flowLayoutPanel1.Controls.Add(this.sub2_comboType);
            this.flowLayoutPanel1.Controls.Add(this.sub3_sub);
            this.flowLayoutPanel1.Controls.Add(this.sub3_numeric);
            this.flowLayoutPanel1.Controls.Add(this.sub3_combo);
            this.flowLayoutPanel1.Controls.Add(this.sub3_comboType);
            this.flowLayoutPanel1.Controls.Add(this.sub4_sub);
            this.flowLayoutPanel1.Controls.Add(this.sub4_numeric);
            this.flowLayoutPanel1.Controls.Add(this.sub4_combo);
            this.flowLayoutPanel1.Controls.Add(this.sub4_comboType);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(308, 418);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // faculty_cb
            // 
            this.faculty_cb.Location = new System.Drawing.Point(2, 4);
            this.faculty_cb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.faculty_cb.Name = "faculty_cb";
            this.faculty_cb.Size = new System.Drawing.Size(92, 20);
            this.faculty_cb.TabIndex = 1;
            this.faculty_cb.Text = "Факультет";
            this.faculty_cb.UseVisualStyleBackColor = true;
            // 
            // faculty_combo
            // 
            this.faculty_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faculty_combo.FormattingEnabled = true;
            this.faculty_combo.Location = new System.Drawing.Point(98, 4);
            this.faculty_combo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.faculty_combo.Name = "faculty_combo";
            this.faculty_combo.Size = new System.Drawing.Size(181, 21);
            this.faculty_combo.TabIndex = 14;
            // 
            // course_cb
            // 
            this.course_cb.Location = new System.Drawing.Point(2, 31);
            this.course_cb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.course_cb.Name = "course_cb";
            this.course_cb.Size = new System.Drawing.Size(92, 20);
            this.course_cb.TabIndex = 3;
            this.course_cb.Text = "Курс";
            this.course_cb.UseVisualStyleBackColor = true;
            // 
            // course_combo
            // 
            this.course_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course_combo.FormattingEnabled = true;
            this.course_combo.Location = new System.Drawing.Point(98, 31);
            this.course_combo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.course_combo.Name = "course_combo";
            this.course_combo.Size = new System.Drawing.Size(181, 21);
            this.course_combo.Sorted = true;
            this.course_combo.TabIndex = 17;
            // 
            // speciality_cb
            // 
            this.speciality_cb.AutoSize = true;
            this.speciality_cb.Location = new System.Drawing.Point(2, 58);
            this.speciality_cb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.speciality_cb.Name = "speciality_cb";
            this.speciality_cb.Size = new System.Drawing.Size(93, 17);
            this.speciality_cb.TabIndex = 2;
            this.speciality_cb.Text = "Спеціальніст ";
            this.speciality_cb.UseVisualStyleBackColor = true;
            // 
            // speciality_combo
            // 
            this.speciality_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciality_combo.FormattingEnabled = true;
            this.speciality_combo.Location = new System.Drawing.Point(99, 58);
            this.speciality_combo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.speciality_combo.Name = "speciality_combo";
            this.speciality_combo.Size = new System.Drawing.Size(181, 21);
            this.speciality_combo.Sorted = true;
            this.speciality_combo.TabIndex = 16;
            // 
            // department_cb
            // 
            this.department_cb.Location = new System.Drawing.Point(2, 85);
            this.department_cb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.department_cb.Name = "department_cb";
            this.department_cb.Size = new System.Drawing.Size(92, 20);
            this.department_cb.TabIndex = 4;
            this.department_cb.Text = "Кафедра";
            this.department_cb.UseVisualStyleBackColor = true;
            // 
            // department_combo
            // 
            this.department_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department_combo.FormattingEnabled = true;
            this.department_combo.Location = new System.Drawing.Point(98, 85);
            this.department_combo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.department_combo.Name = "department_combo";
            this.department_combo.Size = new System.Drawing.Size(181, 21);
            this.department_combo.Sorted = true;
            this.department_combo.TabIndex = 18;
            // 
            // group_cb
            // 
            this.group_cb.Location = new System.Drawing.Point(2, 112);
            this.group_cb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.group_cb.Name = "group_cb";
            this.group_cb.Size = new System.Drawing.Size(92, 20);
            this.group_cb.TabIndex = 38;
            this.group_cb.Text = "Група";
            this.group_cb.UseVisualStyleBackColor = true;
            // 
            // group_combo
            // 
            this.group_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_combo.FormattingEnabled = true;
            this.group_combo.Location = new System.Drawing.Point(98, 112);
            this.group_combo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.group_combo.Name = "group_combo";
            this.group_combo.Size = new System.Drawing.Size(181, 21);
            this.group_combo.Sorted = true;
            this.group_combo.TabIndex = 39;
            // 
            // name_cb
            // 
            this.name_cb.Location = new System.Drawing.Point(2, 139);
            this.name_cb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.name_cb.Name = "name_cb";
            this.name_cb.Size = new System.Drawing.Size(92, 18);
            this.name_cb.TabIndex = 5;
            this.name_cb.Text = "П.І.П";
            this.name_cb.UseVisualStyleBackColor = true;
            // 
            // name_combo
            // 
            this.name_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_combo.FormattingEnabled = true;
            this.name_combo.Location = new System.Drawing.Point(98, 139);
            this.name_combo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.name_combo.Name = "name_combo";
            this.name_combo.Size = new System.Drawing.Size(181, 21);
            this.name_combo.Sorted = true;
            this.name_combo.TabIndex = 40;
            // 
            // id_card_cb
            // 
            this.id_card_cb.Location = new System.Drawing.Point(2, 166);
            this.id_card_cb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.id_card_cb.Name = "id_card_cb";
            this.id_card_cb.Size = new System.Drawing.Size(92, 18);
            this.id_card_cb.TabIndex = 6;
            this.id_card_cb.Text = "Студентський";
            this.id_card_cb.UseVisualStyleBackColor = true;
            // 
            // id_card_combo
            // 
            this.id_card_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_card_combo.FormattingEnabled = true;
            this.id_card_combo.Location = new System.Drawing.Point(98, 166);
            this.id_card_combo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.id_card_combo.Name = "id_card_combo";
            this.id_card_combo.Size = new System.Drawing.Size(181, 21);
            this.id_card_combo.Sorted = true;
            this.id_card_combo.TabIndex = 44;
            // 
            // sub1_sub
            // 
            this.sub1_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub1_sub.FormattingEnabled = true;
            this.sub1_sub.Location = new System.Drawing.Point(2, 193);
            this.sub1_sub.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.sub1_sub.Name = "sub1_sub";
            this.sub1_sub.Size = new System.Drawing.Size(276, 21);
            this.sub1_sub.Sorted = true;
            this.sub1_sub.TabIndex = 41;
            this.sub1_sub.Text = "Предмет";
            // 
            // sub1_numeric
            // 
            this.sub1_numeric.Location = new System.Drawing.Point(2, 222);
            this.sub1_numeric.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.sub1_numeric.Name = "sub1_numeric";
            this.sub1_numeric.Size = new System.Drawing.Size(92, 20);
            this.sub1_numeric.TabIndex = 22;
            // 
            // sub1_combo
            // 
            this.sub1_combo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sub1_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub1_combo.FormattingEnabled = true;
            this.sub1_combo.Location = new System.Drawing.Point(98, 220);
            this.sub1_combo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.sub1_combo.Name = "sub1_combo";
            this.sub1_combo.Size = new System.Drawing.Size(97, 21);
            this.sub1_combo.TabIndex = 23;
            this.sub1_combo.Text = "Оцінка";
            // 
            // sub1_comboType
            // 
            this.sub1_comboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub1_comboType.FormattingEnabled = true;
            this.sub1_comboType.Location = new System.Drawing.Point(5, 248);
            this.sub1_comboType.Margin = new System.Windows.Forms.Padding(5, 4, 2, 2);
            this.sub1_comboType.Name = "sub1_comboType";
            this.sub1_comboType.Size = new System.Drawing.Size(114, 21);
            this.sub1_comboType.TabIndex = 35;
            this.sub1_comboType.Text = "Тип Контролю";
            // 
            // sub2_sub
            // 
            this.sub2_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub2_sub.FormattingEnabled = true;
            this.sub2_sub.Location = new System.Drawing.Point(2, 275);
            this.sub2_sub.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.sub2_sub.Name = "sub2_sub";
            this.sub2_sub.Size = new System.Drawing.Size(276, 21);
            this.sub2_sub.Sorted = true;
            this.sub2_sub.TabIndex = 42;
            this.sub2_sub.Text = "Предмет";
            // 
            // sub2_numeric
            // 
            this.sub2_numeric.Location = new System.Drawing.Point(2, 304);
            this.sub2_numeric.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.sub2_numeric.Name = "sub2_numeric";
            this.sub2_numeric.Size = new System.Drawing.Size(92, 20);
            this.sub2_numeric.TabIndex = 28;
            // 
            // sub2_combo
            // 
            this.sub2_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub2_combo.FormattingEnabled = true;
            this.sub2_combo.Location = new System.Drawing.Point(98, 302);
            this.sub2_combo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.sub2_combo.Name = "sub2_combo";
            this.sub2_combo.Size = new System.Drawing.Size(84, 21);
            this.sub2_combo.TabIndex = 29;
            this.sub2_combo.Text = "Оцінка ";
            // 
            // sub2_comboType
            // 
            this.sub2_comboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub2_comboType.FormattingEnabled = true;
            this.sub2_comboType.Location = new System.Drawing.Point(5, 330);
            this.sub2_comboType.Margin = new System.Windows.Forms.Padding(5, 4, 2, 2);
            this.sub2_comboType.Name = "sub2_comboType";
            this.sub2_comboType.Size = new System.Drawing.Size(127, 21);
            this.sub2_comboType.TabIndex = 34;
            this.sub2_comboType.Text = "Тип Контролю";
            // 
            // sub3_sub
            // 
            this.sub3_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub3_sub.FormattingEnabled = true;
            this.sub3_sub.Location = new System.Drawing.Point(2, 357);
            this.sub3_sub.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.sub3_sub.Name = "sub3_sub";
            this.sub3_sub.Size = new System.Drawing.Size(276, 21);
            this.sub3_sub.Sorted = true;
            this.sub3_sub.TabIndex = 43;
            this.sub3_sub.Text = "Предмет";
            // 
            // sub3_numeric
            // 
            this.sub3_numeric.Location = new System.Drawing.Point(2, 386);
            this.sub3_numeric.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.sub3_numeric.Name = "sub3_numeric";
            this.sub3_numeric.Size = new System.Drawing.Size(92, 20);
            this.sub3_numeric.TabIndex = 31;
            // 
            // sub3_combo
            // 
            this.sub3_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub3_combo.FormattingEnabled = true;
            this.sub3_combo.Location = new System.Drawing.Point(98, 384);
            this.sub3_combo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.sub3_combo.Name = "sub3_combo";
            this.sub3_combo.Size = new System.Drawing.Size(84, 21);
            this.sub3_combo.TabIndex = 32;
            this.sub3_combo.Text = "Оцінка";
            // 
            // sub3_comboType
            // 
            this.sub3_comboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub3_comboType.FormattingEnabled = true;
            this.sub3_comboType.Location = new System.Drawing.Point(5, 412);
            this.sub3_comboType.Margin = new System.Windows.Forms.Padding(5, 4, 2, 2);
            this.sub3_comboType.Name = "sub3_comboType";
            this.sub3_comboType.Size = new System.Drawing.Size(127, 21);
            this.sub3_comboType.TabIndex = 27;
            this.sub3_comboType.Text = "Тип Контролю";
            // 
            // sub4_sub
            // 
            this.sub4_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub4_sub.FormattingEnabled = true;
            this.sub4_sub.Location = new System.Drawing.Point(2, 439);
            this.sub4_sub.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.sub4_sub.Name = "sub4_sub";
            this.sub4_sub.Size = new System.Drawing.Size(277, 21);
            this.sub4_sub.Sorted = true;
            this.sub4_sub.TabIndex = 48;
            this.sub4_sub.Text = "Предмет";
            // 
            // sub4_numeric
            // 
            this.sub4_numeric.Location = new System.Drawing.Point(2, 468);
            this.sub4_numeric.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.sub4_numeric.Name = "sub4_numeric";
            this.sub4_numeric.Size = new System.Drawing.Size(92, 20);
            this.sub4_numeric.TabIndex = 46;
            // 
            // sub4_combo
            // 
            this.sub4_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub4_combo.FormattingEnabled = true;
            this.sub4_combo.Location = new System.Drawing.Point(98, 466);
            this.sub4_combo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.sub4_combo.Name = "sub4_combo";
            this.sub4_combo.Size = new System.Drawing.Size(84, 21);
            this.sub4_combo.TabIndex = 47;
            this.sub4_combo.Text = "Оцінка";
            // 
            // sub4_comboType
            // 
            this.sub4_comboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub4_comboType.FormattingEnabled = true;
            this.sub4_comboType.Location = new System.Drawing.Point(5, 494);
            this.sub4_comboType.Margin = new System.Windows.Forms.Padding(5, 4, 2, 2);
            this.sub4_comboType.Name = "sub4_comboType";
            this.sub4_comboType.Size = new System.Drawing.Size(127, 21);
            this.sub4_comboType.TabIndex = 45;
            this.sub4_comboType.Text = "Тип Контролю";
            // 
            // result_listView
            // 
            this.result_listView.Location = new System.Drawing.Point(312, 0);
            this.result_listView.Margin = new System.Windows.Forms.Padding(2);
            this.result_listView.Name = "result_listView";
            this.result_listView.Size = new System.Drawing.Size(485, 335);
            this.result_listView.TabIndex = 29;
            this.result_listView.Text = "";
            // 
            // SAX_cb
            // 
            this.SAX_cb.AutoSize = true;
            this.SAX_cb.Location = new System.Drawing.Point(750, 335);
            this.SAX_cb.Margin = new System.Windows.Forms.Padding(2);
            this.SAX_cb.Name = "SAX_cb";
            this.SAX_cb.Size = new System.Drawing.Size(47, 17);
            this.SAX_cb.TabIndex = 30;
            this.SAX_cb.Text = "SAX";
            this.SAX_cb.UseVisualStyleBackColor = true;
            // 
            // LINQ_cb
            // 
            this.LINQ_cb.AutoSize = true;
            this.LINQ_cb.Location = new System.Drawing.Point(750, 356);
            this.LINQ_cb.Margin = new System.Windows.Forms.Padding(2);
            this.LINQ_cb.Name = "LINQ_cb";
            this.LINQ_cb.Size = new System.Drawing.Size(51, 17);
            this.LINQ_cb.TabIndex = 31;
            this.LINQ_cb.Text = "LINQ";
            this.LINQ_cb.UseVisualStyleBackColor = true;
            // 
            // DOM_cb
            // 
            this.DOM_cb.AutoSize = true;
            this.DOM_cb.Location = new System.Drawing.Point(750, 377);
            this.DOM_cb.Margin = new System.Windows.Forms.Padding(2);
            this.DOM_cb.Name = "DOM_cb";
            this.DOM_cb.Size = new System.Drawing.Size(51, 17);
            this.DOM_cb.TabIndex = 32;
            this.DOM_cb.Text = "DOM";
            this.DOM_cb.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(348, 376);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(398, 37);
            this.search_btn.TabIndex = 33;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // html_btn
            // 
            this.html_btn.Location = new System.Drawing.Point(637, 351);
            this.html_btn.Margin = new System.Windows.Forms.Padding(2);
            this.html_btn.Name = "html_btn";
            this.html_btn.Size = new System.Drawing.Size(109, 21);
            this.html_btn.TabIndex = 34;
            this.html_btn.Text = "HTML";
            this.html_btn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.html_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.DOM_cb);
            this.Controls.Add(this.LINQ_cb);
            this.Controls.Add(this.SAX_cb);
            this.Controls.Add(this.result_listView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "XML";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sub1_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub2_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub3_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub4_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox faculty_cb;
        private System.Windows.Forms.ComboBox faculty_combo;
        private System.Windows.Forms.CheckBox course_cb;
        private System.Windows.Forms.ComboBox course_combo;
        private System.Windows.Forms.CheckBox speciality_cb;
        private System.Windows.Forms.ComboBox speciality_combo;
        private System.Windows.Forms.CheckBox department_cb;
        private System.Windows.Forms.ComboBox department_combo;
        private System.Windows.Forms.CheckBox group_cb;
        private System.Windows.Forms.ComboBox group_combo;
        private System.Windows.Forms.CheckBox name_cb;
        private System.Windows.Forms.ComboBox name_combo;
        private System.Windows.Forms.CheckBox id_card_cb;
        private System.Windows.Forms.ComboBox id_card_combo;
        private System.Windows.Forms.ComboBox sub1_sub;
        private System.Windows.Forms.NumericUpDown sub1_numeric;
        private System.Windows.Forms.ComboBox sub1_combo;
        private System.Windows.Forms.ComboBox sub1_comboType;
        private System.Windows.Forms.ComboBox sub2_sub;
        private System.Windows.Forms.NumericUpDown sub2_numeric;
        private System.Windows.Forms.ComboBox sub2_combo;
        private System.Windows.Forms.ComboBox sub2_comboType;
        private System.Windows.Forms.ComboBox sub3_sub;
        private System.Windows.Forms.NumericUpDown sub3_numeric;
        private System.Windows.Forms.ComboBox sub3_combo;
        private System.Windows.Forms.ComboBox sub3_comboType;
        private System.Windows.Forms.ComboBox sub4_sub;
        private System.Windows.Forms.NumericUpDown sub4_numeric;
        private System.Windows.Forms.ComboBox sub4_combo;
        private System.Windows.Forms.ComboBox sub4_comboType;
        private System.Windows.Forms.RichTextBox result_listView;
        private System.Windows.Forms.CheckBox SAX_cb;
        private System.Windows.Forms.CheckBox LINQ_cb;
        private System.Windows.Forms.CheckBox DOM_cb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button html_btn;
    }
}

