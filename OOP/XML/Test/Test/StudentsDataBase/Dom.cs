using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


using System.IO;

namespace StudentsDataBase
    {
    class Dom:IStrategy
            {
            List<Student> info = new List<Student>();
        XmlDocument doc = new XmlDocument();
       
       public Dom(string path)
                {

                doc.Load(path);
                }
       public List<Student> Algorithm(Student student,string path)
                {
                info.Clear();
            XmlNode node = doc; 
            if (student.Faculty != null) { info = DomFaculty(student, node); }
            else if (student.Course != null) { info = DomCourse(student, node); }
            else if (student.Spec != null) { info = DomSpec(student, node); }
            else  if (student.Dep != null) { info = DomDep(student, node); }
            else  if (student.Group != null) { info = DomGroup(student,node); }
            else if (student.Name != null) { info = DomStdName(student,node); }
            else if (student.IdCard != null) { info = DomStdIdCard(student,node); }
            for (int i = 0; i < 4; i++)
                {
                if (student.sub[i].Name != "") { info = DomSubName(student,node); }
                if (student.sub[i].Testtype != "") { info = DomSubTesttype(student,node); }
                if (student.sub[i].Mark != "0") { info = DomSubMark(student,node); }
                if (student.sub[i].Typemark != "") { info = DomSubTypemark(student,node); }
                
                }

            return Crossing(info);
                }
       

        public List<Student> DomFaculty(Student student, XmlNode n)
            {
            List<Student> r = new List<Student>();

            if (student.Faculty!= String.Empty)
                {
                string path = "//faculty[@FNAME=\"" + student.Faculty + "\"]";
                XmlNodeList elem = n.SelectNodes("//faculty[@FNAME=\"" + student.Faculty + "\"]");
                try
                    {
                    foreach (XmlNode node in elem)
                        {
                        r = GetDataAboutStudent(student,node, 0);
                       
                        }
                    }
                catch { };
                return r;
                }
            return info;



            }
        public List<Student> DomCourse(Student student, XmlNode n)
            {
            List<Student> r = new List<Student>();

            if (student.Course != String.Empty)
                {
               
                XmlNodeList elem = n.SelectNodes("//course[@COURSE=\"" + student.Course + "\"]");
                try
                    {
                    foreach (XmlNode node in elem)
                        {
                        r = GetDataAboutStudent(student,node, 1);
                        
                        }
                    }
                catch { };
                return r;
                }
            return info;

            }
        public List<Student> DomSpec(Student student, XmlNode n)
            {
            List<Student> r = new List<Student>();

            if (student.Spec != String.Empty)
                {

                XmlNodeList elem = n.SelectNodes("//speciality[@SPEC=\"" + student.Spec + "\"]");
                try
                    {
                    foreach (XmlNode node in elem)
                        {
                        r = GetDataAboutStudent(student,node, 2);
                      
                        }
                    }
                catch { };
                return r;
                }
            return info;

            }
        public List<Student> DomDep(Student student, XmlNode n)
            {
            List<Student> r = new List<Student>();

            if (student.Dep != String.Empty)
                {

                XmlNodeList elem = n.SelectNodes("//department[@DEP=\"" + student.Dep + "\"]");
                try
                    {
                    foreach (XmlNode node in elem)
                        {
                        r = GetDataAboutStudent(student,node, 3);
                        }
                    }
                catch { };
                return r;
                }
            return info;

            }
        public List<Student> DomGroup(Student student, XmlNode n)
            {
            List<Student> r = new List<Student>();

            if (student.Group != String.Empty)
                {

                XmlNodeList elem = n.SelectNodes("//group[@GROUP=\"" + student.Group + "\"]");
                try
                    {
                    foreach (XmlNode node in elem)
                        {
                        r = GetDataAboutStudent(student,node, 4);
                        }
                    }
                catch { };
                return r;
                }
            return info;

            }
        public List<Student> DomStdName(Student student, XmlNode n)
            {
            List<Student> r = new List<Student>();

            if (student.Name != String.Empty)
                {

                XmlNodeList elem = n.SelectNodes("//student[@NAME=\"" + student.Name + "\"]");
                try
                    {
                    foreach (XmlNode node in elem)
                        {
                        r = GetDataAboutStudent(student,node, 5);
                        }
                    }
                catch { };
                return r;
                }
            return info;

            }
        public List<Student> DomStdIdCard(Student student, XmlNode n)
            {
            List<Student> r = new List<Student>();

            if (student.IdCard!= String.Empty)
                {

                XmlNodeList elem = n.SelectNodes("//student[@NAME=\"" + student.IdCard + "\"]");
                try
                    {
                    foreach (XmlNode node in elem)
                        {
                        r = GetDataAboutStudent(student,node, 5);
                        }
                    }
                catch { };
                return r;
                }
            return info;

            }
        public List<Student> DomSubName(Student student, XmlNode n)
            {
                
                List<Student> r = new List<Student>();

            
                    XmlNodeList elem = n.SelectNodes("//student[@NAME]");
                    try
                        {
                        foreach (XmlNode node in elem)
                            {
                            r = GetDataAboutStudent(student, node, 5);
                            }
                        }
                    catch { };
                    return r;
                   

                
            }
        public List<Student> DomSubTesttype(Student student, XmlNode n)
            {
            List<Student> r = new List<Student>();


            XmlNodeList elem = n.SelectNodes("//student[@NAME]");
            try
                {
                foreach (XmlNode node in elem)
                    {
                    r = GetDataAboutStudent(student, node, 5);
                    }
                }
            catch { };
            return r;


            }
        public List<Student> DomSubMark(Student student, XmlNode n)
            {
            List<Student> r = new List<Student>();


            XmlNodeList elem = n.SelectNodes("//student[@NAME]");
            try
                {
                foreach (XmlNode node in elem)
                    {
                    r = GetDataAboutStudent(student, node, 5);
                    }
                }
            catch { };
            return r;


            }
        public List<Student> DomSubTypemark(Student student, XmlNode n)
            {
            List<Student> r = new List<Student>();


            XmlNodeList elem = n.SelectNodes("//student[@NAME]");
            try
                {
                foreach (XmlNode node in elem)
                    {
                    r = GetDataAboutStudent(student, node, 5);
                    }
                }
            catch { };
            return r;


            }



        public List<Student> GetDataAboutStudent(Student student, XmlNode n, int level)
            {
            if (level == 0)//fac
                {
                foreach (XmlNode node in n.ChildNodes)
                    {
                    if (student.Course != null)
                        info = DomCourse(student, node);
                    else
                        {
                        GetDataAboutStudent(student, node, 1);

                        }
                    }
                }
            else if (level == 1)//course
                {
                foreach (XmlNode node in n.ChildNodes)
                    if (student.Spec != null)
                        info = DomSpec(student, node);
                    else

                        { GetDataAboutStudent(student, node, 2); }


                }
            else if (level == 2)//dep
                {
                foreach (XmlNode node in n.ChildNodes)
                    if (student.Dep != null)
                        info = DomDep(student, node);
                    else

                        { GetDataAboutStudent(student, node, 3); }


                }
            else if (level == 3)//group
                {
                foreach (XmlNode node in n.ChildNodes)
                    if (student.Group != null)
                        info = DomGroup(student, node);
                    else

                        { GetDataAboutStudent(student, node, 4); }


                }
            else if (level == 4)//name
                {
                foreach (XmlNode node in n.ChildNodes)
                    if (student.Name != null)
                        info = DomStdName(student, node);
                    else if (student.IdCard != null)
                        info = DomStdIdCard(student, node);

                    else
                        { GetDataAboutStudent(student, node, 5); }



                }
            else if (level == 5)//name
                {
                foreach (XmlNode node in n.ChildNodes)
                    for (int i = 0; i < 4; i++)
                        {
                        if (student.sub[i].Name != "" && student.sub[i].Name != node.Attributes[0].Value)
                            continue;
                        else if (student.sub[i].Mark != "0" && student.sub[i].Mark != node.Attributes[2].Value)
                            continue;
                        else if (student.sub[i].Testtype != "" && student.sub[i].Testtype != node.Attributes[1].Value)
                            continue;
                        else if (student.sub[i].Typemark != "" && student.sub[i].Typemark != node.Attributes[3].Value)
                            continue;
                        else
                            { GetDataAboutStudent(student, node, 6); }
                        }
                            return info;



                        
                }
            if (level == 6)//sub
                {
                int count = 0;
                //bool ok = false;
                n = n.ParentNode;
                foreach (XmlNode node in n.ChildNodes)
                    count++;
                /*
                for (int j = 0; j < count; j++)
                    { if (
                   (student.sub[j].Name == "") || (student.sub[j].Name == n.ChildNodes[j].Attributes[0].Value) &&
                   (student.sub[j].Mark == "0") || (student.sub[j].Mark == n.ChildNodes[j].Attributes[1].Value) &&
                   (student.sub[j].Typemark == "") || (student.sub[j].Typemark == n.ChildNodes[j].Attributes[2].Value) &&
                   (student.sub[j].Testtype == "") || (student.sub[j].Testtype == n.ChildNodes[j].Attributes[3].Value)
                   )
                        { ok = true;}
                    else
                        {
                        ok = false;
                        return info;
                        }
                    }
                    */
                Student inform = new Student(new Dom("std.xml"));
                Student buf = new Student(new Dom("std.xml"));
                for (int j = 0; j < count; j++)
                    {
                    buf.sub[j].Name = n.ChildNodes[j].Attributes[0].Value;
                    buf.sub[j].Mark = n.ChildNodes[j].Attributes[1].Value;
                    buf.sub[j].Typemark = n.ChildNodes[j].Attributes[2].Value;
                    buf.sub[j].Testtype = n.ChildNodes[j].Attributes[3].Value;
                    }
                if (filter(buf, student))
                    {

                    inform = buf;
                    }

                else {
                    return info;
                    }
                    XmlAttributeCollection attr = n.Attributes;
                
                if ((student.Name == attr[0].Value) || (student.Name == null)) inform.Name = attr[0].Value;
                else return info;
                if (student.IdCard == attr[1].Value || (student.IdCard == null)) inform.IdCard = attr[1].Value;
                else return info;
                
                n = n.ParentNode;
                if (student.Group == null || student.Group == n.Attributes[0].Value)
                    inform.Group = n.Attributes[0].Value;
                else return info;
                n = n.ParentNode;
                if (n.Attributes.Count != 0)
                    {
                    if (student.Dep == null || student.Dep == n.Attributes[0].Value)
                        inform.Dep = n.Attributes[0].Value;
                    else return info;
                    }
                n = n.ParentNode;

                if (student.Spec == null || student.Spec == n.Attributes[0].Value)
                     inform.Spec = n.Attributes[0].Value;
                else return info;
                n = n.ParentNode;
                if (student.Course == null || student.Course == n.Attributes[0].Value)
                inform.Course = n.Attributes[0].Value;
                        else return info;
                n = n.ParentNode;
                if (student.Faculty == null || student.Faculty == n.Attributes[0].Value)
                     inform.Faculty = n.Attributes[0].Value;
                else return info;
                 
                info.Add(inform);
                
                }
            info.Distinct();
            return info;
            }

        public List<Student> Crossing(List<Student> list)
            {
            List<Student> result = new List<Student>();
           
            if (list!=null)
                {
                

                    while (list.Count > 0)
                        {
                   
                    for (int i = 1; i < list.Count; i++)
                            {
                            while (list.Count> 1 &&list[0].Eq(list[0], list[i]))
                                list.Remove(list[i]);

                            }
                    result.Add(list[0]);
                    list.Remove(list[0]);


                    }

                }
            return result;
            }
        bool filter(Student file, Student student)
            {
            bool name = true, testtype = true, mark = true, typemark = true, result = true;
            bool[] arr = new bool[student.sub.Count()];
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

               
       


       

            