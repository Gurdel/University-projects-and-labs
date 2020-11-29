using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace StudentsDataBase
    {
    class Sax : IStrategy
        {
        List<Student> info = new List<Student>();
        XmlTextReader xmlReader;
        
        public Sax(string path)
            {

            xmlReader = new XmlTextReader(path);
            }

        public List<Student> Algorithm(Student student, string path)
            {
            info.Clear();
            List<Student> results = new List<Student>();
           
            XmlTextReader xmlReader = new XmlTextReader(path);
            Student std = new Student(new Sax(path));
          
            while (xmlReader.Read())
                {
                if (xmlReader.Name == "faculty")
                    {

                    while (xmlReader.Name == "faculty")
                        {
                        xmlReader.MoveToAttribute("FNAME");
                        if (student.Faculty == xmlReader.Value || student.Faculty == null)
                            {
                            std.Faculty = xmlReader.Value;
                            while (xmlReader.Read() && xmlReader.Name != "course")
                                { }

                            ////////////////////////////////////////////////
                            while (xmlReader.Name == "course")
                                {
                                xmlReader.MoveToAttribute("COURSE");
                                if (student.Course == xmlReader.Value || student.Course == null)
                                    {
                                    std.Course = xmlReader.Value;
                                    while (xmlReader.Read() && xmlReader.Name != "speciality")
                                        { }
                                    ///////////////////////////////////////////////
                                    while (xmlReader.Name == "speciality")
                                        {
                                        xmlReader.MoveToAttribute("SPEC");
                                        if (student.Spec == xmlReader.Value || student.Spec == null)
                                            {
                                            std.Spec = xmlReader.Value;
                                            while (xmlReader.Read() && xmlReader.Name != "department")
                                                { }
                                            ///////////////////////////////////////////////////
                                            while (xmlReader.Name == "department")
                                                {
                                                if (xmlReader.HasAttributes)
                                                    {
                                                    xmlReader.MoveToAttribute("DEP");
                                                    }
                                                if (student.Dep == xmlReader.Value || student.Dep == null)
                                                    {
                                                    std.Dep = xmlReader.Value;
                                                    if (std.Dep == "department") std.Dep = "";
                                                    while (xmlReader.Read() && xmlReader.Name != "group")
                                                        { }




                                                    //////////////////////////////////////////////////////
                                                    while (xmlReader.Name == "group")
                                                        {
                                                        xmlReader.MoveToAttribute("GROUP");
                                                        if (student.Group == xmlReader.Value || student.Group == null)
                                                            {
                                                            std.Group = xmlReader.Value;

                                                            while (xmlReader.Read() && xmlReader.Name != "student")
                                                                { }


                                                            ////////////////////////////////////////////////////
                                                            while (xmlReader.Name == "student")
                                                                {
                                                                xmlReader.MoveToAttribute("NAME");
                                                                // if (student.Name == null&& student.IdCard == null)
                                                                if (student.Name == xmlReader.Value || student.Name == null)
                                                                    {
                                                                    std.Name = xmlReader.Value;
                                                                    xmlReader.MoveToAttribute("IDCARD");
                                                                    if (student.IdCard == xmlReader.Value || student.IdCard == null)
                                                                        {
                                                                        std.IdCard = xmlReader.Value;
                                                                        
                                                                         while (xmlReader.Read() && xmlReader.Name != "subject")
                                                                             { }

                                                                         ////////////////////////////////////////////
                                                                         for (int i = 0; i < 4 && xmlReader.Name == "subject"; i++)
                                                                             {
                                                                             xmlReader.MoveToAttribute("SUB");

                                                                             std.sub[i].Name = xmlReader.Value;

                                                                             xmlReader.MoveToAttribute("TESTTYPE");

                                                                             std.sub[i].Testtype = xmlReader.Value;
                                                                             xmlReader.MoveToAttribute("MARK");

                                                                             std.sub[i].Mark = xmlReader.Value;
                                                                             xmlReader.MoveToAttribute("TYPEMARK");

                                                                             std.sub[i].Typemark = xmlReader.Value;
                                                                             xmlReader.ReadToNextSibling("subject");
                                                                             }
                                                                        if ( filter(std,student))
                                                                             {
                                                                             
                                                                        Student dep = new Student(new Sax(path));
                                                                        dep.Course = std.Course;
                                                                        dep.Faculty = std.Faculty;
                                                                        dep.Spec = std.Spec;
                                                                        dep.Dep = std.Dep;
                                                                        dep.Group = std.Group;
                                                                        dep.Name = std.Name;
                                                                        dep.IdCard = std.IdCard;
                                                                        for (int i = 0; i < std.sub.Count(); i++)
                                                                            {
                                                                            dep.sub[i].Name = std.sub[i].Name;
                                                                            dep.sub[i].Testtype = std.sub[i].Testtype;
                                                                            dep.sub[i].Mark = std.sub[i].Mark;
                                                                            dep.sub[i].Typemark = std.sub[i].Typemark;
                                                                            }

                                                                        results.Add(dep);
                                                                            for (int i = 0; i < std.sub.Count(); i++)
                                                                                {
                                                                                 std.sub[i].Name="";
                                                                                std.sub[i].Testtype="";
                                                                                std.sub[i].Mark="0";
                                                                                std.sub[i].Typemark="";
                                                                                }

                                                                            }

                                                                    else {

                                                                            do
                                                                                {
                                                                                if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                                                                else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                                                                else if (xmlReader.Name == "speciality" && xmlReader.HasAttributes) break;
                                                                                else if (xmlReader.Name == "department" && xmlReader.HasAttributes) break;
                                                                                else if (xmlReader.Name == "group" && xmlReader.HasAttributes) break;
                                                                                else if (xmlReader.Name == "student" && xmlReader.HasAttributes) break;
                                                                                }
                                                                            while (xmlReader.Read());
                                                                     }
                                                                     

                                                                    ////////////////////////////////////////////
                                                                     }
                                                                    else
                                                                        {
                                                                        do
                                                                            {
                                                                            if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                                                            else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                                                            else if (xmlReader.Name == "speciality" && xmlReader.HasAttributes) break;
                                                                            else if (xmlReader.Name == "department" && xmlReader.HasAttributes) break;
                                                                            else if (xmlReader.Name == "group" && xmlReader.HasAttributes) break;
                                                                            else if (xmlReader.Name == "student" && xmlReader.HasAttributes) break;
                                                                            }
                                                                        while (xmlReader.Read());
                                                                        }



                                                                   
                                                                    do
                                                                        {
                                                                        if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                                                        else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                                                        else if (xmlReader.Name == "speciality" && xmlReader.HasAttributes) break;
                                                                        else if (xmlReader.Name == "department" && xmlReader.HasAttributes) break;
                                                                        else if (xmlReader.Name == "group" && xmlReader.HasAttributes) break;
                                                                        else if (xmlReader.Name == "student" && xmlReader.HasAttributes) break;
                                                                        }
                                                                    while (xmlReader.Read());

                                                                    }
                                                                else
                                                                    {
                                                                    do
                                                                        {
                                                                        if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                                                        else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                                                        else if (xmlReader.Name == "speciality" && xmlReader.HasAttributes) break;
                                                                        else if (xmlReader.Name == "department" && xmlReader.HasAttributes) break;
                                                                        else if (xmlReader.Name == "group" && xmlReader.HasAttributes) break;
                                                                        else if (xmlReader.Name == "student" && xmlReader.HasAttributes) break;
                                                                        }
                                                                    while (xmlReader.Read());
                                                                    }
                                                                }
                                                            /////////////////////////////////////////////////////
                                                            if (xmlReader.Name == "group") continue;

                                                            do
                                                                {

                                                                if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                                                else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                                                else if (xmlReader.Name == "speciality" && xmlReader.HasAttributes) break;
                                                                else if (xmlReader.Name == "department" && xmlReader.HasAttributes) break;
                                                                else if (xmlReader.Name == "group" && xmlReader.HasAttributes) break;
                                                                }
                                                            while (xmlReader.Read());
                                                            }
                                                        else
                                                            {

                                                            do
                                                                {

                                                                if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                                                else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                                                else if (xmlReader.Name == "speciality" && xmlReader.HasAttributes) break;
                                                                else if (xmlReader.Name == "department" && xmlReader.HasAttributes) break;
                                                                else if (xmlReader.Name == "group" && xmlReader.HasAttributes) break;
                                                                } while (xmlReader.Read());
                                                            }
                                                        }
                                                    ///////////////////////////////////////////////////////////////////////////


                                                    do
                                                        {
                                                        if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                                        else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                                        else if (xmlReader.Name == "speciality" && xmlReader.HasAttributes) break;
                                                        else if (xmlReader.Name == "department" && xmlReader.HasAttributes) break;
                                                        }
                                                    while (xmlReader.Read());
                                                    }
                                                else
                                                    {
                                                   
                                                        do
                                                            {
                                                            if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                                            else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                                            else if (xmlReader.Name == "speciality" && xmlReader.HasAttributes) break;
                                                            else if (xmlReader.Name == "department" && xmlReader.HasAttributes) break;
                                                            } while (xmlReader.Read());
                                                    }
                                                }
                                            /////////////////////////////////////////////////////////




                                            do
                                                {
                                                if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                                else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                                else if (xmlReader.Name == "speciality" && xmlReader.HasAttributes) break;
                                                }
                                            while (xmlReader.Read());
                                            }
                                        else
                                            {

                                            do
                                                {
                                                if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                                else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                                else if (xmlReader.Name == "speciality" && xmlReader.HasAttributes) break;

                                                }
                                            while (xmlReader.Read());
                                            }
                                        }


                                    do
                                        {
                                        if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                        else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                        }
                                    while (xmlReader.Read());
                                    }
                                else
                                    {
                                    do
                                        {

                                        if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                        else if (xmlReader.Name == "course" && xmlReader.HasAttributes) break;
                                        } while (xmlReader.Read());
                                    }
                                }

                            if (xmlReader.Name == "faculty") continue;
                            do
                                {
                                if (xmlReader.Name == "faculty" && xmlReader.HasAttributes) break;
                                }
                            while (xmlReader.Read());
                            }
                        else
                            {
                            xmlReader.ReadToNextSibling("faculty");
                            }
                        }
                    }



                

                }
                return results;
            }



        bool filter (Student file,Student student)
            {
            bool name = true, testtype = true, mark = true, typemark = true, result = true;
            bool [] arr=new bool [student.sub.Count()];
            bool[] b = new bool[student.sub.Count()];
            for (int j = 0; j < student.sub.Count(); j++)
                {
                arr[j] = true;
                }

                for (int j = 0; j < student.sub.Count(); j++)
                {
                for (int i = 0; i < file.sub.Count(); i++)
                    {
                    if (student.sub[j].Name == file.sub[i].Name || student.sub[j].Name == "") name = true; else name = false;
                    if (student.sub[j].Testtype == file.sub[i].Testtype || student.sub[j].Testtype == "") testtype = true; else testtype = false;
                    if (student.sub[j].Mark == file.sub[i].Mark || student.sub[j].Mark == "0") mark = true; else mark = false;
                    if (student.sub[j].Typemark == file.sub[i].Typemark || student.sub[j].Typemark == "") typemark = true; else typemark = false;
                    if ((name && testtype) && (mark && typemark)) arr[i] = true;
                    else arr[i] = false;
                    }
                for (int i = 0; i < student.sub.Count(); i++)
                    {
                    if (arr[i] == true) { result = true; break; }
                    else result = false;
                    }
                b[j] = result;

                }

            for (int j = 0; j < student.sub.Count(); j++)
                {
                if (b[j] != true) { result = false; break; }
                else result = true;
                }
            return result;
            
            }
        }
    }


