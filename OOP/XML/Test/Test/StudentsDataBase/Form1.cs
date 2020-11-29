using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace StudentsDataBase
    {
    public partial class Form1 : Form
        {
        string path = "std.xml";
        XmlDocument doc = new XmlDocument();
        
        
        string new_file = "std2.xml";

        public Form1()
            {
            InitializeComponent();
            start();
            visible_start();
            }
        public void visible_start()
            {
            html_btn.Visible = false;

            sub2_sub.Visible = false;
            sub2_combo.Visible = false;
            sub2_comboType.Visible = false;
            sub2_numeric.Visible = false;

            sub3_sub.Visible = false;
            sub3_combo.Visible = false;
            sub3_comboType.Visible = false;
            sub3_numeric.Visible = false;

            sub4_sub.Visible = false;
            sub4_combo.Visible = false;
            sub4_comboType.Visible = false;
            sub4_numeric.Visible = false;
            }
        public void start()
            {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            foreach (XmlNode Name in doc.SelectNodes("//faculty[@FNAME]"))
                {
                faculty_combo.Items.Add(Name.Attributes["FNAME"].Value);

                }

            foreach (XmlNode Name in doc.SelectNodes("//speciality[@SPEC]"))
                {

                bool check = true;
                foreach (var Item in speciality_combo.Items)
                    {
                    if (Convert.ToString(Item) == Convert.ToString(Name.Attributes["SPEC"].Value))
                        check = false;
                    }
                if (check) speciality_combo.Items.Add(Name.Attributes["SPEC"].Value);

                }
            foreach (XmlNode Name in doc.SelectNodes("//course[@COURSE]"))
                {

                bool check = true;
                foreach (var Item in course_combo.Items)
                    {
                    if (Convert.ToString(Item) == Convert.ToString(Name.Attributes["COURSE"].Value))
                        check = false;
                    }
                if (check) course_combo.Items.Add(Name.Attributes["COURSE"].Value);
                }
            foreach (XmlNode Name in doc.SelectNodes("//department[@DEP]"))
                {
                bool check = true;
                foreach (var Item in department_combo.Items)
                    {
                    if (Convert.ToString(Item) == Convert.ToString(Name.Attributes["DEP"].Value))
                        check = false;
                    }
                if (check) department_combo.Items.Add(Name.Attributes["DEP"].Value);


                }
            foreach (XmlNode Name in doc.SelectNodes("//group[@GROUP]"))
                {
                bool check = true;
                foreach (var Item in group_combo.Items)
                    {
                    if (Convert.ToString(Item) == Convert.ToString(Name.Attributes["GROUP"].Value))
                        check = false;
                    }
                if (check) group_combo.Items.Add(Name.Attributes["GROUP"].Value);


                }
            foreach (XmlNode Name in doc.SelectNodes("//student[@NAME]"))
                {
                name_combo.Items.Add(Name.Attributes["NAME"].Value);

                }
            foreach (XmlNode Name in doc.SelectNodes("//student[@IDCARD]"))
                {
                id_card_combo.Items.Add(Name.Attributes["IDCARD"].Value);

                }
            foreach (XmlNode Name in doc.SelectNodes(".//subject[@SUB]"))
                {
                bool check = true;
                foreach (var Item in sub1_sub.Items)
                    {
                    if (Convert.ToString(Item) == Convert.ToString(Name.Attributes["SUB"].Value))
                        check = false;
                    }
                if (check)
                    {
                    sub1_sub.Items.Add(Name.Attributes["SUB"].Value);
                    sub2_sub.Items.Add(Name.Attributes["SUB"].Value);
                    sub3_sub.Items.Add(Name.Attributes["SUB"].Value);
                    sub4_sub.Items.Add(Name.Attributes["SUB"].Value);
                    }
                }
            string text = "відмінно, добре,задовільно,зараховано";
            string[] marks = text.Split(',');
            for (int i = 0; i < marks.Count(); i++)
                {
                sub1_combo.Items.Add(marks[i]);
                sub2_combo.Items.Add(marks[i]);
                sub3_combo.Items.Add(marks[i]);
                sub4_combo.Items.Add(marks[i]);
                }
            text = "екзамен,залік";
            string[] types = text.Split(',');
            for (int i = 0; i < types.Count(); i++)
                {
                sub1_comboType.Items.Add(types[i]);
                sub2_comboType.Items.Add(types[i]);
                sub3_comboType.Items.Add(types[i]);
                sub4_comboType.Items.Add(types[i]);
                }




            }

        private void faculty_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
            string index = Convert.ToString(faculty_combo.SelectedItem);
            
            faculty_cb.Checked = true;
            course_cb.Checked = false;
            speciality_cb.Checked = false;
            department_cb.Checked = false;
            group_cb.Checked = false;
            name_cb.Checked = false;
            id_card_combo.Visible = true;
            id_card_cb.Visible = true;
            id_card_cb.Checked = false;
            name_combo.Visible = true;
            name_cb.Visible = true;
            doc.Load("std.xml");



            
                    speciality_combo.Items.Clear();
                    department_combo.Items.Clear();
                    course_combo.Items.Clear();
                    group_combo.Items.Clear();
                    name_combo.Items.Clear();
                    id_card_combo.Items.Clear();
                    sub1_sub.Items.Clear();
                    sub2_sub.Items.Clear();
                    sub3_sub.Items.Clear();
                    sub4_sub.Items.Clear();
            string road="//faculty[@FNAME=\"" + Convert.ToString(faculty_combo.SelectedItem) 
            +"\" ]/course";

            foreach (XmlNode val in doc.SelectNodes(road))
                {

                bool check = true;
                foreach (var Item in course_combo.Items)
                    {
                    
                    if (Convert.ToString(Item) == Convert.ToString(val.Attributes["COURSE"].Value))
                        check = false;
                    }
                if (check) course_combo.Items.Add(val.Attributes["COURSE"].Value);

                foreach (XmlNode al in val.SelectNodes(".//speciality[@SPEC]"))
                    {
                    check = true;
                    foreach (var Item in speciality_combo.Items)
                        {
                        
                        if (Convert.ToString(Item) == Convert.ToString(al.Attributes["SPEC"].Value))
                            check = false;
                        }
                    if (check) speciality_combo.Items.Add(al.Attributes["SPEC"].Value);
                    }


                foreach (XmlNode al in val.SelectNodes(".//department[@DEP]"))
                    {
                    check = true;
                    foreach (var Item in department_combo.Items)
                        {
                        if (Convert.ToString(Item) == Convert.ToString(al.Attributes["DEP"].Value))
                            check = false;
                        }
                    if (check) 
                    department_combo.Items.Add(al.Attributes["DEP"].Value);
                    }
                foreach (XmlNode al in val.SelectNodes(".//group[@GROUP]"))
                    {
                    check = true;
                    foreach (var Item in group_combo.Items)
                        {
                        if (Convert.ToString(Item) == Convert.ToString(al.Attributes["GROUP"].Value))
                            check = false;
                        }
                    if (check)
                        group_combo.Items.Add(al.Attributes["GROUP"].Value);
                    }
                foreach (XmlNode al in val.SelectNodes(".//student"))
                    {
                    name_combo.Items.Add(al.Attributes["NAME"].Value);
                    id_card_combo.Items.Add(al.Attributes["IDCARD"].Value);
                    }
                foreach (XmlNode al in val.SelectNodes(".//subject[@SUB]"))
                    {
                    check = true;
                    foreach (var Item in sub1_sub.Items)
                        {
                        if (Convert.ToString(Item) == Convert.ToString(al.Attributes["SUB"].Value))
                            check = false;
                        }
                    if (check)
                        {
                        sub1_sub.Items.Add(al.Attributes["SUB"].Value);
                        sub2_sub.Items.Add(al.Attributes["SUB"].Value);
                        sub3_sub.Items.Add(al.Attributes["SUB"].Value);
                        sub4_sub.Items.Add(al.Attributes["SUB"].Value);
                        }
                    }

                }
            }
        private void course_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
            int index = Convert.ToInt32(course_combo.SelectedItem);
            doc.Load(path);


            course_cb.Checked = true;
            speciality_cb.Checked = false;
            department_cb.Checked = false;
            group_cb.Checked = false;
            name_cb.Checked = false;
            id_card_combo.Visible = true;
            id_card_cb.Visible = true;
            id_card_cb.Checked = false;
            name_combo.Visible = true;
            name_cb.Visible = true;


            if (index < 3)
                {
                department_combo.Visible = false;
                department_cb.Visible = false;
                }
            speciality_combo.Items.Clear();
            department_combo.Items.Clear();
            group_combo.Items.Clear();
            name_combo.Items.Clear();
            id_card_combo.Items.Clear();
            sub1_sub.Items.Clear();
            sub2_sub.Items.Clear();
            sub3_sub.Items.Clear();
            sub4_sub.Items.Clear();
            string faculty = Convert.ToString(faculty_combo.SelectedItem);
            string road;
            if (Convert.ToString(faculty_combo.SelectedItem) != "")
                {
                road = "//faculty[@FNAME=\"" + Convert.ToString(faculty_combo.SelectedItem) + 
				"\" ]/course[@COURSE=\"" + Convert.ToString(course_combo.SelectedItem) + 
				"\" ]/speciality";
                }
            else
                {
                road = "//course[@COURSE=\"" + Convert.ToString(course_combo.SelectedItem) + 
				"\" ]/speciality";
                }

            foreach (XmlNode val in doc.SelectNodes(road))
                {

                bool check = true;
                foreach (var Item in speciality_combo.Items)
                    {
                    if (Convert.ToString(Item) == Convert.ToString(val.Attributes["SPEC"].Value))
                        check = false;
                    }
                if (check) speciality_combo.Items.Add(val.Attributes["SPEC"].Value);




                foreach (XmlNode al in val.SelectNodes(".//department[@DEP]"))
                    {
                    department_combo.Items.Add(al.Attributes["DEP"].Value);
                    }
                foreach (XmlNode al in val.SelectNodes(".//group[@GROUP]"))
                    {
                    group_combo.Items.Add(al.Attributes["GROUP"].Value);
                    }
                foreach (XmlNode al in val.SelectNodes(".//student"))
                    {
                    name_combo.Items.Add(al.Attributes["NAME"].Value);
                    id_card_combo.Items.Add(al.Attributes["IDCARD"].Value);
                    }
                foreach (XmlNode al in val.SelectNodes(".//subject[@SUB]"))
                    {
                    check = true;
                    foreach (var Item in sub1_sub.Items)
                        {
                        if (Convert.ToString(Item) == Convert.ToString(al.Attributes["SUB"].Value))
                            check = false;
                        }
                    if (check)
                        {
                        sub1_sub.Items.Add(al.Attributes["SUB"].Value);
                        sub2_sub.Items.Add(al.Attributes["SUB"].Value);
                        sub3_sub.Items.Add(al.Attributes["SUB"].Value);
                        sub4_sub.Items.Add(al.Attributes["SUB"].Value);
                        }
                    }

                }
            }

        private void speciality_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
            string index = Convert.ToString(speciality_combo.SelectedItem);
            doc.Load(path);

            speciality_cb.Checked = true;
            department_cb.Checked = false;
            group_cb.Checked = false;
            name_cb.Checked = false;
            id_card_combo.Visible = true;
            id_card_cb.Visible = true;
            id_card_cb.Checked = false;
            name_combo.Visible = true;
            name_cb.Visible = true;




            department_combo.Items.Clear();
            group_combo.Items.Clear();
            name_combo.Items.Clear();
            id_card_combo.Items.Clear();
            string faculty = Convert.ToString(faculty_combo.SelectedItem);
            string road;
            if (Convert.ToString(faculty_combo.SelectedItem) != ""&& Convert.ToString(course_combo.SelectedItem) != "")
                {
                road = "//faculty[@FNAME=\"" + Convert.ToString(faculty_combo.SelectedItem) + "\" ]/course[@COURSE=\"" + Convert.ToString(course_combo.SelectedItem) + "\" ]/speciality[@SPEC=\"" + Convert.ToString(speciality_combo.SelectedItem)+"\" ]";
                }
            else if (Convert.ToString(faculty_combo.SelectedItem) != "" && Convert.ToString(course_combo.SelectedItem) == "")
                {
                road = "//faculty[@FNAME=\"" + Convert.ToString(faculty_combo.SelectedItem) + "\" ]/*/speciality[@SPEC=\"" + Convert.ToString(speciality_combo.SelectedItem) + "\" ]/";
                }
            else if (Convert.ToString(faculty_combo.SelectedItem) == "" && Convert.ToString(course_combo.SelectedItem) != "")
                {
                road = "//course[@COURSE=\"" + Convert.ToString(course_combo.SelectedItem) + "\" ]/speciality[@SPEC=\"" + Convert.ToString(speciality_combo.SelectedItem) + "\" ]/";
                }
            else
                {
                road="//speciality[@SPEC=\"" + Convert.ToString(speciality_combo.SelectedItem) + "\" ]";
                }
            bool check = true;
            foreach (XmlNode val in doc.SelectNodes(road))
                {
                foreach (XmlNode al in val.SelectNodes(".//department[@DEP]"))
                    {
                    check = true;
                    foreach (var Item in department_combo.Items)
                        {
                        if (Convert.ToString(Item) == Convert.ToString(al.Attributes["DEP"].Value))
                            check = false;
                        }
                    if (check) department_combo.Items.Add(al.Attributes["DEP"].Value);

                    }

                foreach (XmlNode al in val.SelectNodes(".//group"))
                        {
                        check = true;
                        foreach (var Item in group_combo.Items)
                            {
                            if (Convert.ToString(Item) == Convert.ToString(al.Attributes["GROUP"].Value))
                                check = false;
                            }
                        if (check) group_combo.Items.Add(al.Attributes["GROUP"].Value);
                        }
                    foreach (XmlNode al in val.SelectNodes(".//student"))
                        {
                        name_combo.Items.Add(al.Attributes["NAME"].Value);
                        id_card_combo.Items.Add(al.Attributes["IDCARD"].Value);
                        }
                    foreach (XmlNode al in val.SelectNodes(".//subject"))
                        {
                        check = true;
                        foreach (var Item in sub1_sub.Items)
                            {
                            if (Convert.ToString(Item) == Convert.ToString(al.Attributes["SUB"].Value))
                                check = false;
                            }
                        if (check)
                            {
                            sub1_sub.Items.Add(al.Attributes["SUB"].Value);
                            sub2_sub.Items.Add(al.Attributes["SUB"].Value);
                            sub3_sub.Items.Add(al.Attributes["SUB"].Value);
                            sub4_sub.Items.Add(al.Attributes["SUB"].Value);
                            }
                        }

                    
                }
        


        }
        private void department_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
            string index = Convert.ToString(department_combo.SelectedItem);
            doc.Load(path);
            department_cb.Checked = true;
            group_cb.Checked = false;
            name_cb.Checked = false;
            id_card_combo.Visible = true;
            id_card_cb.Visible = true;
            id_card_cb.Checked = false;
            name_combo.Visible = true;
            name_cb.Visible = true;


            group_combo.Items.Clear();
            name_combo.Items.Clear();
            id_card_combo.Items.Clear();
            sub1_sub.Items.Clear();
            sub2_sub.Items.Clear();
            sub3_sub.Items.Clear();
            sub4_sub.Items.Clear();
            string road;
            if (Convert.ToString(faculty_combo.SelectedItem) != "" && Convert.ToString(course_combo.SelectedItem) != "" && Convert.ToString(speciality_combo.SelectedItem) != "")
                {
                road = "//faculty[@FNAME=\"" + Convert.ToString(faculty_combo.SelectedItem) +
                    "\" ]/course[@COURSE=\"" + Convert.ToString(course_combo.SelectedItem) +
                    "\" ]/speciality[@SPEC=\"" + Convert.ToString(speciality_combo.SelectedItem) +
                    "\" ]/department[@DEP=\"" + Convert.ToString(department_combo.SelectedItem) +
                    "\" ]/group";
                }
            else if (Convert.ToString(faculty_combo.SelectedItem) == "" && Convert.ToString(course_combo.SelectedItem) != "" && Convert.ToString(speciality_combo.SelectedItem) != "")
                {
                road = "//course[@COURSE=\"" + Convert.ToString(course_combo.SelectedItem) +
                    "\" ]/speciality[@SPEC=\"" + Convert.ToString(speciality_combo.SelectedItem) +
                    "\" ]/department[@DEP=\"" + Convert.ToString(department_combo.SelectedItem) +
                    "\" ]/group";
                }
            else if (Convert.ToString(faculty_combo.SelectedItem) != "" && Convert.ToString(course_combo.SelectedItem) == "" && Convert.ToString(speciality_combo.SelectedItem) != "")
                {
                road = "//faculty[@FNAME=\"" + Convert.ToString(faculty_combo.SelectedItem) +

                    "\" ]/*/speciality[@SPEC=\"" + Convert.ToString(speciality_combo.SelectedItem) +
                    "\" ]/department[@DEP=\"" + Convert.ToString(department_combo.SelectedItem) +
                    "\" ]/group";
                }
            else if (Convert.ToString(faculty_combo.SelectedItem) != "" && Convert.ToString(course_combo.SelectedItem) != "" && Convert.ToString(speciality_combo.SelectedItem) == "")
                {
                road = "//faculty[@FNAME=\"" + Convert.ToString(faculty_combo.SelectedItem) +
                    "\" ]/course[@COURSE=\"" + Convert.ToString(course_combo.SelectedItem) +

                    "\" ]/*/department[@DEP=\"" + Convert.ToString(department_combo.SelectedItem) +
                    "\" ]/group";
                }
            else if (Convert.ToString(faculty_combo.SelectedItem) == "" && Convert.ToString(course_combo.SelectedItem) == "" && Convert.ToString(speciality_combo.SelectedItem) != "")
                {
                road =
                    "//speciality[@SPEC=\"" + Convert.ToString(speciality_combo.SelectedItem) +
                    "\" ]/department[@DEP=\"" + Convert.ToString(department_combo.SelectedItem) +
                    "\" ]/group";
                }
            else if (Convert.ToString(faculty_combo.SelectedItem) == "" && Convert.ToString(course_combo.SelectedItem) != "" && Convert.ToString(speciality_combo.SelectedItem) == "")
                {
                road =
                    "\" ]/course[@COURSE=\"" + Convert.ToString(course_combo.SelectedItem) +

                    "\" ]/*/department[@DEP=\"" + Convert.ToString(department_combo.SelectedItem) +
                    "\" ]/group";
                }
            else if (Convert.ToString(faculty_combo.SelectedItem) != "" && Convert.ToString(course_combo.SelectedItem) == "" && Convert.ToString(speciality_combo.SelectedItem) == "")
                {
                road = "//faculty[@FNAME=\"" + Convert.ToString(faculty_combo.SelectedItem) +


                    "\" ]//department[@DEP=\"" + Convert.ToString(department_combo.SelectedItem) +
                    "\" ]/group";
                }
            else
                {
                road = "//department[@DEP=\"" + Convert.ToString(department_combo.SelectedItem) +
                    "\" ]/group";
                }
            bool check = true;
            foreach (XmlNode val in doc.SelectNodes(road))
                {



                check = true;
                foreach (var Item in group_combo.Items)
                    {
                    if (Convert.ToString(Item) == Convert.ToString(val.Attributes["GROUP"].Value))
                        check = false;
                    }
                if (check) group_combo.Items.Add(val.Attributes["GROUP"].Value);

                foreach (XmlNode al in val.SelectNodes(".//student"))
                    {
                    name_combo.Items.Add(al.Attributes["NAME"].Value);
                    id_card_combo.Items.Add(al.Attributes["IDCARD"].Value);
                    }
                foreach (XmlNode al in val.SelectNodes(".//subject"))
                    {
                    check = true;
                    foreach (var Item in sub1_sub.Items)
                        {
                        if (Convert.ToString(Item) == Convert.ToString(al.Attributes["SUB"].Value))
                            check = false;
                        }
                    if (check)
                        {
                        sub1_sub.Items.Add(al.Attributes["SUB"].Value);
                        sub2_sub.Items.Add(al.Attributes["SUB"].Value);
                        sub3_sub.Items.Add(al.Attributes["SUB"].Value);
                        sub4_sub.Items.Add(al.Attributes["SUB"].Value);
                        }
                    }
                
            

                }

            }
        private void group_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
            string index = Convert.ToString(group_combo.SelectedItem);

            
            group_cb.Checked = true;
            name_cb.Checked = false;
            id_card_combo.Visible = true;
            id_card_cb.Visible = true;
            id_card_cb.Checked = false;
            name_combo.Visible = true;
            name_cb.Visible = true;

           
            }
        private void name_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
            

           
            name_cb.Checked = true;
            id_card_combo.Visible = false;
            id_card_cb.Visible = false;
           


            }
        private void id_card_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
            id_card_cb.Checked = true;
            name_combo.Visible = false;
            name_cb.Visible = false;
            }
        public void problem()
            {
            result_listView.Text = "Кто-то накосячил!Интересно кто же это"+"\n"+"Мне подсунули битый xml("; }
        
        
        private void search_btn_Click(object sender, EventArgs e)
            {
           
            result_listView.Clear();
            if (LINQ_cb.Checked && SAX_cb.Checked || LINQ_cb.Checked &&DOM_cb.Checked|| DOM_cb.Checked&& SAX_cb.Checked || DOM_cb.Checked&& SAX_cb.Checked&& LINQ_cb.Checked)
                {
                LINQ_cb.Checked = false;
                SAX_cb.Checked = false;
                DOM_cb.Checked = false;
                result_listView.Text = "Оберіть тип пошуку";
                return;

                }
            html_btn.Visible = true;
            List<Student> inf = new List<Student>();
            if (SAX_cb.Checked)
                {
                Student inform = new Student(new Sax(path));

                inf = inform.Algorithm(ReadParametrs(), path);
                }
          
           
           
           else if (LINQ_cb.Checked)
                {
                  Student inform = new Student(new Linq(path));
                inf = inform.Algorithm(ReadParametrs(), path);
              
               
                }
            
            else
                {
                if (!DOM_cb.Checked)
                        {
                        DOM_cb.Checked = true;
                        }
                Student inform = new Student(new Dom(path));
                inf = inform.Algorithm(ReadParametrs(), path);
              
                
                    }
            int i = 1;
            foreach (Student n in inf)
                {
                result_listView.Text += i++ + "\n";
                Show(n);

                SaveFile(inf,new_file);

                }
            }
        private void SaveFile(List<Student> inform,string path)
            {
            XDocument xdoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));

            
            
            

            XElement studentsDataBase = new XElement("studentsDataBase");
            
            foreach (Student inf in inform)
                {
                XElement faculty = new XElement("faculty");
                
                 XAttribute facultyAttr = new XAttribute("FNAME", inf.Faculty);
                    XElement course = new XElement("course");
                         XAttribute courseAttr = new XAttribute("COURSE", inf.Course);
                         XElement speciality = new XElement("speciality");
                              XAttribute specialityAttr = new XAttribute("SPEC", inf.Spec);
                               XElement department = new XElement("department");
                                    XAttribute departmentAttr = new XAttribute("DEP", "пусто"); 
                                    if (inf.Dep != "")
                                     { departmentAttr = new XAttribute("DEP", inf.Dep); }
                                     XElement group = new XElement("group");
                                             XAttribute groupAttr = new XAttribute("GROUP", inf.Group);
                                             XElement student = new XElement("student");
                                                    XAttribute studentName = new XAttribute("NAME", inf.Name);
                                                    XAttribute studentIdCard = new XAttribute("IDCARD", inf.IdCard);

                XElement[] subject = new XElement[4];
                XAttribute[] subjectName = new XAttribute[4];
                XAttribute[] subjectTesttype = new XAttribute[4];
                XAttribute[] subjectMark = new XAttribute[4];
                XAttribute[] subjectTypemark = new XAttribute[4];
                for (int i = 0; i < subject.Count(); i++)
                    {
                    if (inf.sub[i].Name == "") break;
                    subject[i] = new XElement("subject");
                    subjectName[i] = new XAttribute("SUB", inf.sub[i].Name);
                    subjectTesttype[i] = new XAttribute("TESTTYPE", inf.sub[i].Testtype);
                    subjectMark[i] = new XAttribute("MARK", inf.sub[i].Mark);
                    subjectTypemark[i] = new XAttribute("TYPEMARK", inf.sub[i].Typemark);
                    }
                for (int i = 0; i < subject.Count(); i++)
                    {
                    if (inf.sub[i].Name == "") break;
                   
                    subject[i].Add(subjectTesttype[i]);
                    subject[i].Add(subjectMark[i]);
                    subject[i].Add(subjectTypemark[i]);

                    }
                for (int i = 0; i < subject.Count(); i++)
                    {
                    if (inf.sub[i].Name == "") break;

                    student.Add(subject[i]);

                    }
                student.Add(studentName);
                student.Add(studentIdCard);


                group.Add(student);
                group.Add(groupAttr);
                department.Add(group);
                if (inf.Dep != "")
                    department.Add(departmentAttr);
                speciality.Add(department);
                speciality.Add(specialityAttr);
                course.Add(speciality);
                course.Add(courseAttr);
                faculty.Add(course);
                faculty.Add(facultyAttr);
                studentsDataBase.Add(faculty);
                }
           
            xdoc.Add(studentsDataBase);
            
           
            xdoc.Save(path);

            }
        private Student ReadParametrs()
            {
            string[] read = new string[24];
            if (faculty_cb.Checked && faculty_combo.Visible) read[0] = Convert.ToString(faculty_combo.SelectedItem);
            if (course_cb.Checked) read[1] = Convert.ToString(course_combo.SelectedItem);
            if (speciality_cb.Checked) read[2] = Convert.ToString(speciality_combo.SelectedItem);
            if (department_cb.Checked && department_combo.Visible) read[3] = Convert.ToString(department_combo.SelectedItem);
            if (group_cb.Checked) read[4] = Convert.ToString(group_combo.SelectedItem);
            if (name_cb.Checked && name_combo.Visible) read[5] = Convert.ToString(name_combo.SelectedItem);
            if (id_card_cb.Checked && id_card_combo.Visible) read[6] = Convert.ToString(id_card_combo.SelectedItem);

            read[7] = Convert.ToString(sub1_sub.SelectedItem);
            read[8] = Convert.ToString(sub1_comboType.SelectedItem);
            read[9] = Convert.ToString(sub1_numeric.Value);
            read[10] = Convert.ToString(sub1_combo.SelectedItem);
            if (sub2_sub.Visible)
                {
                read[11] = Convert.ToString(sub2_sub.SelectedItem);
                read[12] = Convert.ToString(sub2_comboType.SelectedItem);
                read[13] = Convert.ToString(sub2_numeric.Value);
                read[14] = Convert.ToString(sub2_combo.SelectedItem);
                }
            else
                {
                read[11] = "";
                read[12] = "";
                read[13] = "0";
                read[14] = "";
                }
            if (sub3_sub.Visible)
                {
                read[15] = Convert.ToString(sub3_sub.SelectedItem);
                read[16] = Convert.ToString(sub3_comboType.SelectedItem);
                read[17] = Convert.ToString(sub3_numeric.Value);
                read[18] = Convert.ToString(sub3_combo.SelectedItem);
                }
            else
                {
                read[15] = "";
                read[16] = "";
                read[17] = "0";
                read[18] = "";
                }
            if (sub4_sub.Visible)
                {
                read[19] = Convert.ToString(sub4_sub.SelectedItem);
                read[20] = Convert.ToString(sub4_comboType.SelectedItem);
                read[21] = Convert.ToString(sub4_numeric.Value);
                read[22] = Convert.ToString(sub4_combo.SelectedItem);
                }
            else
                {
                read[19] = "";
                read[20] = "";
                read[21] = "0";
                read[22] = "";
                }


            Student std = new Student(read);
            return std;
            }

        private void Show(Student s)
            {
            result_listView.Text+="Факультет: "+s.Faculty+"\n";
            result_listView.Text += "Курс: " + s.Course + "\n";
            result_listView.Text += "Спеціальність: " + s.Spec + "\n";
            if (Convert.ToInt32(s.Course) > 2)
                result_listView.Text += "Кафедра: " + s.Dep + "\n";
            result_listView.Text += "Група: " + s.Group + "\n";
            result_listView.Text +="П.І.П: " + s.Name + "\n";
            result_listView.Text += "Студентський квиток: " + s.IdCard + "\n";
            for (int i=0;i<4;i++)
                {
                if (s.sub[i].Name == "") break;
                result_listView.Text += "Предмет " + i + ": " + "  " + s.sub[i].Name + "  " + s.sub[i].Mark +
                                        "  " + s.sub[i].Testtype + "  " + s.sub[i].Typemark + "\n";                
                }
            result_listView.Text += "\n_________________________________________________________________________________\n";
            }

        private void html_btn_Click(object sender, EventArgs e)
            {
            Transform();
            }
        private void Transform()
            {
            //Ініціалізуе новий екземпляр класу XslCompiledTransform,
            //що перетворює дані XML за допомогою таблиці стилів XSLT
            XslCompiledTransform transform = new XslCompiledTransform();
            //Завантажує і компілюють таблицю стилів
            //розташовану в зазначеному файлі.
            transform.Load(@"std.xsl");
            //Виконує перетворення за допомогою вхідного документа (new_file)
            // виводить результати на XmlWriter (index.html).
            transform.Transform(@new_file, @"index.html");
            System.Diagnostics.Process.Start(@"index.html");
            
            }

        private void faculty_cb_CheckedChanged(object sender, EventArgs e)
            {
           // faculty_cb.Checked =false;


            }
        private void course_cb_CheckedChanged(object sender, EventArgs e)
            {
            //  course_cb.Checked = false;
            }
        private void speciality_cb_CheckedChanged(object sender, EventArgs e)
            {
            //speciality_cb.Checked = false;
           
            }
        private void department_cb_CheckedChanged(object sender, EventArgs e)
            {
           // department_cb.Checked = false;
            

            }
        private void group_cb_CheckedChanged(object sender, EventArgs e)
            {
            //group_cb.Checked = false;
            }
        private void name_cb_CheckedChanged(object sender, EventArgs e)
            {
          //  name_cb.Checked = false;
            }
        private void id_card_cb_CheckedChanged(object sender, EventArgs e)
            {
            //id_card_cb.Checked = false;
            }

        private void sub1_sub_SelectedIndexChanged(object sender, EventArgs e)
            {
            sub2_sub.Visible = true;
            sub2_combo.Visible = true;
            sub2_comboType.Visible = true;
            sub2_numeric.Visible = true;
            sub2_sub.Items.Remove(Convert.ToString(sub1_sub.SelectedItem));
            sub3_sub.Items.Remove(Convert.ToString(sub1_sub.SelectedItem));
            sub4_sub.Items.Remove(Convert.ToString(sub1_sub.SelectedItem));
            }
        private void sub1_numeric_ValueChanged(object sender, EventArgs e)
            {
            sub2_sub.Visible = true;
            sub2_combo.Visible = true;
            sub2_comboType.Visible = true;
            sub2_numeric.Visible = true;
            }
        private void sub1_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
            sub2_sub.Visible = true;
            sub2_combo.Visible = true;
            sub2_comboType.Visible = true;
            sub2_numeric.Visible = true;
            }
        private void sub1_comboType_SelectedIndexChanged(object sender, EventArgs e)
            {
            sub2_sub.Visible = true;
            sub2_combo.Visible = true;
            sub2_comboType.Visible = true;
            sub2_numeric.Visible = true;
            }

        private void sub2_sub_SelectedIndexChanged(object sender, EventArgs e)
            {
            sub3_sub.Visible = true;
            sub3_combo.Visible = true;
            sub3_comboType.Visible = true;
            sub3_numeric.Visible = true;
    
            sub3_sub.Items.Remove(Convert.ToString(sub2_sub.SelectedItem));
            sub4_sub.Items.Remove(Convert.ToString(sub2_sub.SelectedItem));
            }
        private void sub2_numeric_ValueChanged(object sender, EventArgs e)
            {
            sub3_sub.Visible = true;
            sub3_combo.Visible = true;
            sub3_comboType.Visible = true;
            sub3_numeric.Visible = true;
            }
        private void sub2_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
            sub3_sub.Visible = true;
            sub3_combo.Visible = true;
            sub3_comboType.Visible = true;
            sub3_numeric.Visible = true;

            }
        private void sub2_comboType_SelectedIndexChanged(object sender, EventArgs e)
            {
            sub3_sub.Visible = true;
            sub3_combo.Visible = true;
            sub3_comboType.Visible = true;
            sub3_numeric.Visible = true;
            }

        private void sub3_sub_SelectedIndexChanged(object sender, EventArgs e)
            {
            sub4_sub.Visible = true;
            sub4_combo.Visible = true;
            sub4_comboType.Visible = true;
            sub4_numeric.Visible = true;
            
            sub4_sub.Items.Remove(Convert.ToString(sub3_sub.SelectedItem));
            }
        private void sub3_numeric_ValueChanged(object sender, EventArgs e)
            {
            sub4_sub.Visible = true;
            sub4_combo.Visible = true;
            sub4_comboType.Visible = true;
            sub4_numeric.Visible = true;
            }
        private void sub3_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
            sub4_sub.Visible = true;
            sub4_combo.Visible = true;
            sub4_comboType.Visible = true;
            sub4_numeric.Visible = true;
            }
        private void sub3_comboType_SelectedIndexChanged(object sender, EventArgs e)
            {
            sub4_sub.Visible = true;
            sub4_combo.Visible = true;
            sub4_comboType.Visible = true;
            sub4_numeric.Visible = true;
            }

      







        }
        }
    
