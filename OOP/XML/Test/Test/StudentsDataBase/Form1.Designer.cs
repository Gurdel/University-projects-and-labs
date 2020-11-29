namespace StudentsDataBase
    {
    partial class Form1
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
            this.speciality_cb = new System.Windows.Forms.CheckBox();
            this.course_cb = new System.Windows.Forms.CheckBox();
            this.department_cb = new System.Windows.Forms.CheckBox();
            this.name_cb = new System.Windows.Forms.CheckBox();
            this.id_card_cb = new System.Windows.Forms.CheckBox();
            this.LINQ_cb = new System.Windows.Forms.CheckBox();
            this.SAX_cb = new System.Windows.Forms.CheckBox();
            this.DOM_cb = new System.Windows.Forms.CheckBox();
            this.faculty_combo = new System.Windows.Forms.ComboBox();
            this.speciality_combo = new System.Windows.Forms.ComboBox();
            this.course_combo = new System.Windows.Forms.ComboBox();
            this.department_combo = new System.Windows.Forms.ComboBox();
            this.sub1_numeric = new System.Windows.Forms.NumericUpDown();
            this.sub1_combo = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.faculty_cb = new System.Windows.Forms.CheckBox();
            this.group_cb = new System.Windows.Forms.CheckBox();
            this.group_combo = new System.Windows.Forms.ComboBox();
            this.name_combo = new System.Windows.Forms.ComboBox();
            this.id_card_combo = new System.Windows.Forms.ComboBox();
            this.sub1_sub = new System.Windows.Forms.ComboBox();
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
            this.search_btn = new System.Windows.Forms.Button();
            this.result_listView = new System.Windows.Forms.RichTextBox();
            this.html_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sub1_numeric)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sub2_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub3_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub4_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // speciality_cb
            // 
            this.speciality_cb.AutoSize = true;
            this.speciality_cb.Location = new System.Drawing.Point(3, 69);
            this.speciality_cb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.speciality_cb.Name = "speciality_cb";
            this.speciality_cb.Size = new System.Drawing.Size(121, 21);
            this.speciality_cb.TabIndex = 2;
            this.speciality_cb.Text = "Спеціальність";
            this.speciality_cb.UseVisualStyleBackColor = true;
            this.speciality_cb.CheckedChanged += new System.EventHandler(this.speciality_cb_CheckedChanged);
            // 
            // course_cb
            // 
            this.course_cb.Location = new System.Drawing.Point(3, 37);
            this.course_cb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.course_cb.Name = "course_cb";
            this.course_cb.Size = new System.Drawing.Size(122, 24);
            this.course_cb.TabIndex = 3;
            this.course_cb.Text = "Курс";
            this.course_cb.UseVisualStyleBackColor = true;
            this.course_cb.CheckedChanged += new System.EventHandler(this.course_cb_CheckedChanged);
            // 
            // department_cb
            // 
            this.department_cb.Location = new System.Drawing.Point(3, 101);
            this.department_cb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.department_cb.Name = "department_cb";
            this.department_cb.Size = new System.Drawing.Size(122, 24);
            this.department_cb.TabIndex = 4;
            this.department_cb.Text = "Кафедра";
            this.department_cb.UseVisualStyleBackColor = true;
            this.department_cb.CheckedChanged += new System.EventHandler(this.department_cb_CheckedChanged);
            // 
            // name_cb
            // 
            this.name_cb.Location = new System.Drawing.Point(3, 165);
            this.name_cb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.name_cb.Name = "name_cb";
            this.name_cb.Size = new System.Drawing.Size(122, 22);
            this.name_cb.TabIndex = 5;
            this.name_cb.Text = "П.І.П";
            this.name_cb.UseVisualStyleBackColor = true;
            this.name_cb.CheckedChanged += new System.EventHandler(this.name_cb_CheckedChanged);
            // 
            // id_card_cb
            // 
            this.id_card_cb.Location = new System.Drawing.Point(3, 197);
            this.id_card_cb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.id_card_cb.Name = "id_card_cb";
            this.id_card_cb.Size = new System.Drawing.Size(122, 22);
            this.id_card_cb.TabIndex = 6;
            this.id_card_cb.Text = "Студентський";
            this.id_card_cb.UseVisualStyleBackColor = true;
            this.id_card_cb.CheckedChanged += new System.EventHandler(this.id_card_cb_CheckedChanged);
            // 
            // LINQ_cb
            // 
            this.LINQ_cb.AutoSize = true;
            this.LINQ_cb.Location = new System.Drawing.Point(529, 424);
            this.LINQ_cb.Name = "LINQ_cb";
            this.LINQ_cb.Size = new System.Drawing.Size(62, 21);
            this.LINQ_cb.TabIndex = 11;
            this.LINQ_cb.Text = "LINQ";
            this.LINQ_cb.UseVisualStyleBackColor = true;
            // 
            // SAX_cb
            // 
            this.SAX_cb.AutoSize = true;
            this.SAX_cb.Location = new System.Drawing.Point(413, 424);
            this.SAX_cb.Name = "SAX_cb";
            this.SAX_cb.Size = new System.Drawing.Size(57, 21);
            this.SAX_cb.TabIndex = 12;
            this.SAX_cb.Text = "SAX";
            this.SAX_cb.UseVisualStyleBackColor = true;
            // 
            // DOM_cb
            // 
            this.DOM_cb.AutoSize = true;
            this.DOM_cb.Location = new System.Drawing.Point(653, 424);
            this.DOM_cb.Name = "DOM_cb";
            this.DOM_cb.Size = new System.Drawing.Size(62, 21);
            this.DOM_cb.TabIndex = 13;
            this.DOM_cb.Text = "DOM";
            this.DOM_cb.UseVisualStyleBackColor = true;
            // 
            // faculty_combo
            // 
            this.faculty_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faculty_combo.FormattingEnabled = true;
            this.faculty_combo.Location = new System.Drawing.Point(131, 5);
            this.faculty_combo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.faculty_combo.Name = "faculty_combo";
            this.faculty_combo.Size = new System.Drawing.Size(240, 24);
            this.faculty_combo.TabIndex = 14;
            this.faculty_combo.SelectedIndexChanged += new System.EventHandler(this.faculty_combo_SelectedIndexChanged);
            // 
            // speciality_combo
            // 
            this.speciality_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciality_combo.FormattingEnabled = true;
            this.speciality_combo.Location = new System.Drawing.Point(130, 69);
            this.speciality_combo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.speciality_combo.Name = "speciality_combo";
            this.speciality_combo.Size = new System.Drawing.Size(240, 24);
            this.speciality_combo.Sorted = true;
            this.speciality_combo.TabIndex = 16;
            this.speciality_combo.SelectedIndexChanged += new System.EventHandler(this.speciality_combo_SelectedIndexChanged);
            // 
            // course_combo
            // 
            this.course_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course_combo.FormattingEnabled = true;
            this.course_combo.Location = new System.Drawing.Point(131, 37);
            this.course_combo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.course_combo.Name = "course_combo";
            this.course_combo.Size = new System.Drawing.Size(240, 24);
            this.course_combo.Sorted = true;
            this.course_combo.TabIndex = 17;
            this.course_combo.SelectedIndexChanged += new System.EventHandler(this.course_combo_SelectedIndexChanged);
            // 
            // department_combo
            // 
            this.department_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department_combo.FormattingEnabled = true;
            this.department_combo.Location = new System.Drawing.Point(131, 101);
            this.department_combo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.department_combo.Name = "department_combo";
            this.department_combo.Size = new System.Drawing.Size(240, 24);
            this.department_combo.Sorted = true;
            this.department_combo.TabIndex = 18;
            this.department_combo.SelectedIndexChanged += new System.EventHandler(this.department_combo_SelectedIndexChanged);
            // 
            // sub1_numeric
            // 
            this.sub1_numeric.Location = new System.Drawing.Point(3, 263);
            this.sub1_numeric.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.sub1_numeric.Name = "sub1_numeric";
            this.sub1_numeric.Size = new System.Drawing.Size(122, 22);
            this.sub1_numeric.TabIndex = 22;
            this.sub1_numeric.ValueChanged += new System.EventHandler(this.sub1_numeric_ValueChanged);
            // 
            // sub1_combo
            // 
            this.sub1_combo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sub1_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub1_combo.FormattingEnabled = true;
            this.sub1_combo.Location = new System.Drawing.Point(131, 261);
            this.sub1_combo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.sub1_combo.Name = "sub1_combo";
            this.sub1_combo.Size = new System.Drawing.Size(128, 24);
            this.sub1_combo.TabIndex = 23;
            this.sub1_combo.Text = "Оцінка";
            this.sub1_combo.SelectedIndexChanged += new System.EventHandler(this.sub1_combo_SelectedIndexChanged);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(395, 490);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // faculty_cb
            // 
            this.faculty_cb.Location = new System.Drawing.Point(3, 5);
            this.faculty_cb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.faculty_cb.Name = "faculty_cb";
            this.faculty_cb.Size = new System.Drawing.Size(122, 24);
            this.faculty_cb.TabIndex = 1;
            this.faculty_cb.Text = "Факультет";
            this.faculty_cb.UseVisualStyleBackColor = true;
            this.faculty_cb.CheckedChanged += new System.EventHandler(this.faculty_cb_CheckedChanged);
            // 
            // group_cb
            // 
            this.group_cb.Location = new System.Drawing.Point(3, 133);
            this.group_cb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.group_cb.Name = "group_cb";
            this.group_cb.Size = new System.Drawing.Size(122, 24);
            this.group_cb.TabIndex = 38;
            this.group_cb.Text = "Група";
            this.group_cb.UseVisualStyleBackColor = true;
            this.group_cb.CheckedChanged += new System.EventHandler(this.group_cb_CheckedChanged);
            // 
            // group_combo
            // 
            this.group_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_combo.FormattingEnabled = true;
            this.group_combo.Location = new System.Drawing.Point(131, 133);
            this.group_combo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.group_combo.Name = "group_combo";
            this.group_combo.Size = new System.Drawing.Size(240, 24);
            this.group_combo.Sorted = true;
            this.group_combo.TabIndex = 39;
            this.group_combo.SelectedIndexChanged += new System.EventHandler(this.group_combo_SelectedIndexChanged);
            // 
            // name_combo
            // 
            this.name_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_combo.FormattingEnabled = true;
            this.name_combo.Location = new System.Drawing.Point(131, 165);
            this.name_combo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.name_combo.Name = "name_combo";
            this.name_combo.Size = new System.Drawing.Size(240, 24);
            this.name_combo.Sorted = true;
            this.name_combo.TabIndex = 40;
            this.name_combo.SelectedIndexChanged += new System.EventHandler(this.name_combo_SelectedIndexChanged);
            // 
            // id_card_combo
            // 
            this.id_card_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_card_combo.FormattingEnabled = true;
            this.id_card_combo.Location = new System.Drawing.Point(131, 197);
            this.id_card_combo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.id_card_combo.Name = "id_card_combo";
            this.id_card_combo.Size = new System.Drawing.Size(240, 24);
            this.id_card_combo.Sorted = true;
            this.id_card_combo.TabIndex = 44;
            this.id_card_combo.SelectedIndexChanged += new System.EventHandler(this.id_card_combo_SelectedIndexChanged);
            // 
            // sub1_sub
            // 
            this.sub1_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub1_sub.FormattingEnabled = true;
            this.sub1_sub.Location = new System.Drawing.Point(3, 229);
            this.sub1_sub.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.sub1_sub.Name = "sub1_sub";
            this.sub1_sub.Size = new System.Drawing.Size(367, 24);
            this.sub1_sub.Sorted = true;
            this.sub1_sub.TabIndex = 41;
            this.sub1_sub.Text = "Предмет";
            this.sub1_sub.SelectedIndexChanged += new System.EventHandler(this.sub1_sub_SelectedIndexChanged);
            // 
            // sub1_comboType
            // 
            this.sub1_comboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub1_comboType.FormattingEnabled = true;
            this.sub1_comboType.Location = new System.Drawing.Point(269, 261);
            this.sub1_comboType.Margin = new System.Windows.Forms.Padding(7, 5, 3, 3);
            this.sub1_comboType.Name = "sub1_comboType";
            this.sub1_comboType.Size = new System.Drawing.Size(102, 24);
            this.sub1_comboType.TabIndex = 35;
            this.sub1_comboType.Text = "Тип Контролю";
            this.sub1_comboType.SelectedIndexChanged += new System.EventHandler(this.sub1_comboType_SelectedIndexChanged);
            // 
            // sub2_sub
            // 
            this.sub2_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub2_sub.FormattingEnabled = true;
            this.sub2_sub.Location = new System.Drawing.Point(3, 293);
            this.sub2_sub.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.sub2_sub.Name = "sub2_sub";
            this.sub2_sub.Size = new System.Drawing.Size(367, 24);
            this.sub2_sub.Sorted = true;
            this.sub2_sub.TabIndex = 42;
            this.sub2_sub.Text = "Предмет";
            this.sub2_sub.SelectedIndexChanged += new System.EventHandler(this.sub2_sub_SelectedIndexChanged);
            // 
            // sub2_numeric
            // 
            this.sub2_numeric.Location = new System.Drawing.Point(3, 327);
            this.sub2_numeric.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.sub2_numeric.Name = "sub2_numeric";
            this.sub2_numeric.Size = new System.Drawing.Size(122, 22);
            this.sub2_numeric.TabIndex = 28;
            this.sub2_numeric.ValueChanged += new System.EventHandler(this.sub2_numeric_ValueChanged);
            // 
            // sub2_combo
            // 
            this.sub2_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub2_combo.FormattingEnabled = true;
            this.sub2_combo.Location = new System.Drawing.Point(131, 325);
            this.sub2_combo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.sub2_combo.Name = "sub2_combo";
            this.sub2_combo.Size = new System.Drawing.Size(110, 24);
            this.sub2_combo.TabIndex = 29;
            this.sub2_combo.Text = "Оцінка ";
            this.sub2_combo.SelectedIndexChanged += new System.EventHandler(this.sub2_combo_SelectedIndexChanged);
            // 
            // sub2_comboType
            // 
            this.sub2_comboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub2_comboType.FormattingEnabled = true;
            this.sub2_comboType.Location = new System.Drawing.Point(251, 325);
            this.sub2_comboType.Margin = new System.Windows.Forms.Padding(7, 5, 3, 3);
            this.sub2_comboType.Name = "sub2_comboType";
            this.sub2_comboType.Size = new System.Drawing.Size(120, 24);
            this.sub2_comboType.TabIndex = 34;
            this.sub2_comboType.Text = "Тип Контролю";
            this.sub2_comboType.SelectedIndexChanged += new System.EventHandler(this.sub2_comboType_SelectedIndexChanged);
            // 
            // sub3_sub
            // 
            this.sub3_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub3_sub.FormattingEnabled = true;
            this.sub3_sub.Location = new System.Drawing.Point(3, 357);
            this.sub3_sub.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.sub3_sub.Name = "sub3_sub";
            this.sub3_sub.Size = new System.Drawing.Size(367, 24);
            this.sub3_sub.Sorted = true;
            this.sub3_sub.TabIndex = 43;
            this.sub3_sub.Text = "Предмет";
            this.sub3_sub.SelectedIndexChanged += new System.EventHandler(this.sub3_sub_SelectedIndexChanged);
            // 
            // sub3_numeric
            // 
            this.sub3_numeric.Location = new System.Drawing.Point(3, 391);
            this.sub3_numeric.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.sub3_numeric.Name = "sub3_numeric";
            this.sub3_numeric.Size = new System.Drawing.Size(122, 22);
            this.sub3_numeric.TabIndex = 31;
            this.sub3_numeric.ValueChanged += new System.EventHandler(this.sub3_numeric_ValueChanged);
            // 
            // sub3_combo
            // 
            this.sub3_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub3_combo.FormattingEnabled = true;
            this.sub3_combo.Location = new System.Drawing.Point(131, 389);
            this.sub3_combo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.sub3_combo.Name = "sub3_combo";
            this.sub3_combo.Size = new System.Drawing.Size(110, 24);
            this.sub3_combo.TabIndex = 32;
            this.sub3_combo.Text = "Оцінка";
            this.sub3_combo.SelectedIndexChanged += new System.EventHandler(this.sub3_combo_SelectedIndexChanged);
            // 
            // sub3_comboType
            // 
            this.sub3_comboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub3_comboType.FormattingEnabled = true;
            this.sub3_comboType.Location = new System.Drawing.Point(251, 389);
            this.sub3_comboType.Margin = new System.Windows.Forms.Padding(7, 5, 3, 3);
            this.sub3_comboType.Name = "sub3_comboType";
            this.sub3_comboType.Size = new System.Drawing.Size(120, 24);
            this.sub3_comboType.TabIndex = 27;
            this.sub3_comboType.Text = "Тип Контролю";
            this.sub3_comboType.SelectedIndexChanged += new System.EventHandler(this.sub3_comboType_SelectedIndexChanged);
            // 
            // sub4_sub
            // 
            this.sub4_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub4_sub.FormattingEnabled = true;
            this.sub4_sub.Location = new System.Drawing.Point(3, 421);
            this.sub4_sub.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.sub4_sub.Name = "sub4_sub";
            this.sub4_sub.Size = new System.Drawing.Size(368, 24);
            this.sub4_sub.Sorted = true;
            this.sub4_sub.TabIndex = 48;
            this.sub4_sub.Text = "Предмет";
            // 
            // sub4_numeric
            // 
            this.sub4_numeric.Location = new System.Drawing.Point(3, 455);
            this.sub4_numeric.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.sub4_numeric.Name = "sub4_numeric";
            this.sub4_numeric.Size = new System.Drawing.Size(122, 22);
            this.sub4_numeric.TabIndex = 46;
            // 
            // sub4_combo
            // 
            this.sub4_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub4_combo.FormattingEnabled = true;
            this.sub4_combo.Location = new System.Drawing.Point(131, 453);
            this.sub4_combo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.sub4_combo.Name = "sub4_combo";
            this.sub4_combo.Size = new System.Drawing.Size(110, 24);
            this.sub4_combo.TabIndex = 47;
            this.sub4_combo.Text = "Оцінка";
            // 
            // sub4_comboType
            // 
            this.sub4_comboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub4_comboType.FormattingEnabled = true;
            this.sub4_comboType.Location = new System.Drawing.Point(251, 453);
            this.sub4_comboType.Margin = new System.Windows.Forms.Padding(7, 5, 3, 3);
            this.sub4_comboType.Name = "sub4_comboType";
            this.sub4_comboType.Size = new System.Drawing.Size(120, 24);
            this.sub4_comboType.TabIndex = 45;
            this.sub4_comboType.Text = "Тип Контролю";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(413, 451);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(131, 46);
            this.search_btn.TabIndex = 27;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // result_listView
            // 
            this.result_listView.Location = new System.Drawing.Point(413, 7);
            this.result_listView.Name = "result_listView";
            this.result_listView.Size = new System.Drawing.Size(597, 411);
            this.result_listView.TabIndex = 28;
            this.result_listView.Text = "";
            // 
            // html_btn
            // 
            this.html_btn.Location = new System.Drawing.Point(584, 450);
            this.html_btn.Name = "html_btn";
            this.html_btn.Size = new System.Drawing.Size(131, 47);
            this.html_btn.TabIndex = 29;
            this.html_btn.Text = "HTML";
            this.html_btn.UseVisualStyleBackColor = true;
            this.html_btn.Click += new System.EventHandler(this.html_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 514);
            this.Controls.Add(this.html_btn);
            this.Controls.Add(this.result_listView);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.DOM_cb);
            this.Controls.Add(this.SAX_cb);
            this.Controls.Add(this.LINQ_cb);
            this.Name = "Form1";
            this.Text = "Lab3";
            ((System.ComponentModel.ISupportInitialize)(this.sub1_numeric)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sub2_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub3_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub4_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.CheckBox speciality_cb;
        private System.Windows.Forms.CheckBox course_cb;
        private System.Windows.Forms.CheckBox department_cb;
        private System.Windows.Forms.CheckBox name_cb;
        private System.Windows.Forms.CheckBox id_card_cb;
        private System.Windows.Forms.CheckBox LINQ_cb;
        private System.Windows.Forms.CheckBox SAX_cb;
        private System.Windows.Forms.CheckBox DOM_cb;
        private System.Windows.Forms.ComboBox faculty_combo;
        private System.Windows.Forms.ComboBox speciality_combo;
        private System.Windows.Forms.ComboBox course_combo;
        private System.Windows.Forms.ComboBox department_combo;
        private System.Windows.Forms.NumericUpDown sub1_numeric;
        private System.Windows.Forms.ComboBox sub1_combo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox sub3_comboType;
        private System.Windows.Forms.NumericUpDown sub2_numeric;
        private System.Windows.Forms.ComboBox sub2_combo;
        private System.Windows.Forms.NumericUpDown sub3_numeric;
        private System.Windows.Forms.ComboBox sub3_combo;
        private System.Windows.Forms.ComboBox sub1_comboType;
        private System.Windows.Forms.ComboBox sub2_comboType;
        private System.Windows.Forms.CheckBox group_cb;
        private System.Windows.Forms.ComboBox group_combo;
        private System.Windows.Forms.ComboBox name_combo;
        private System.Windows.Forms.CheckBox faculty_cb;
        private System.Windows.Forms.ComboBox sub1_sub;
        private System.Windows.Forms.ComboBox sub2_sub;
        private System.Windows.Forms.ComboBox sub3_sub;
        private System.Windows.Forms.ComboBox id_card_combo;
        private System.Windows.Forms.ComboBox sub4_sub;
        private System.Windows.Forms.NumericUpDown sub4_numeric;
        private System.Windows.Forms.ComboBox sub4_combo;
        private System.Windows.Forms.ComboBox sub4_comboType;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.RichTextBox result_listView;
        private System.Windows.Forms.Button html_btn;
        }
    }

