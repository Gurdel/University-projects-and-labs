using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace StudentsDataBase
    {
    class Linq : IStrategy
        {
        List<Student> info = new List<Student>();
        XDocument doc = new XDocument();
        public Linq(string path)
            {

            doc = XDocument.Load(path);
            }

        public List<Student> Algorithm(Student student,string path)
            {
            info.Clear();
            
            var result = (from val in doc.Descendants("student")
                          where
                          (
                         (student.Faculty == null || student.Faculty == ((((val.Parent).Parent).Parent).Parent).Parent.Attribute("FNAME").Value) &&
                         (student.Course == null || student.Course == (((val.Parent).Parent).Parent).Parent.Attribute("COURSE").Value) &&
                         (student.Spec == null || student.Spec == ((val.Parent).Parent).Parent.Attribute("SPEC").Value) &&
                          (student.Dep == null || (Convert.ToInt32(((((val.Parent).Parent).Parent).Parent).Attribute("COURSE").Value) > 2&& student.Dep == (val.Parent).Parent.Attribute("DEP").Value))  &&
                          (student.Group == null || student.Group == val.Parent.Attribute("GROUP").Value) &&
                          (student.Name == null || student.Name == val.Attribute("NAME").Value) &&
                          (student.IdCard == null || student.IdCard == val.Attribute("IDCARD").Value) &&
                          
                          (val.Descendants("subject").Any(element => (
                          (student.sub[0].Name == ""||student.sub[0].Name == element.Attribute("SUB").Value)&&
                          (student.sub[0].Testtype == "" || student.sub[0].Testtype == element.Attribute("TESTTYPE").Value) &&
                          (student.sub[0].Mark == "0" || student.sub[0].Mark == element.Attribute("MARK").Value) &&
                          (student.sub[0].Typemark == "" || student.sub[0].Typemark == element.Attribute("TYPEMARK").Value) 
                         
                          )))&&
                           (val.Descendants("subject").Any(element => (
                          (student.sub[1].Name == "" || student.sub[1].Name == element.Attribute("SUB").Value)&&
                           (student.sub[1].Testtype == "" || student.sub[1].Testtype == element.Attribute("TESTTYPE").Value) &&
                          (student.sub[1].Mark == "0" || student.sub[1].Mark == element.Attribute("MARK").Value) &&
                          (student.sub[1].Typemark == "" || student.sub[1].Typemark == element.Attribute("TYPEMARK").Value) 


                          )))&&
                           (val.Descendants("subject").Any(element => (
                          (student.sub[2].Name == "" || student.sub[2].Name == element.Attribute("SUB").Value)&&
                           (student.sub[2].Testtype == "" || student.sub[2].Testtype == element.Attribute("TESTTYPE").Value) &&
                          (student.sub[2].Mark == "0" || student.sub[2].Mark == element.Attribute("MARK").Value) &&
                          (student.sub[2].Typemark == "" || student.sub[2].Typemark == element.Attribute("TYPEMARK").Value)
                          )))&&
                           (val.Descendants("subject").Any(element => (
                           (student.sub[3].Name == "" || student.sub[3].Name == element.Attribute("SUB").Value) &&
                           (student.sub[3].Testtype == "" || student.sub[3].Testtype == element.Attribute("TESTTYPE").Value) &&
                          (student.sub[3].Mark == "0" || student.sub[3].Mark == element.Attribute("MARK").Value) &&
                          (student.sub[3].Typemark == "" || student.sub[3].Typemark == element.Attribute("TYPEMARK").Value)
                          
                          )))
                          )

                          select val).ToList();
            foreach (var obj in result)
                {
                Student body = new Student(new Linq(path));
                body.Name = obj.Attribute("NAME").Value;
                body.Course = (((obj.Parent).Parent).Parent).Parent.Attribute("COURSE").Value;
                body.Spec = ((obj.Parent).Parent).Parent.Attribute("SPEC").Value;
                body.Faculty = ((((obj.Parent).Parent).Parent).Parent).Parent.Attribute("FNAME").Value;
                if (Convert.ToInt32(body.Course) >= 3)
                    body.Dep = (obj.Parent).Parent.Attribute("DEP").Value;
                body.Group = obj.Parent.Attribute("GROUP").Value;
                body.IdCard = obj.Attribute("IDCARD").Value;
                var ns = obj.Descendants();
                int i = 0;
                foreach (var n in ns)
                 {
               
                    body.sub[i].Name = n.Attribute("SUB").Value;
                    body.sub[i].Testtype = n.Attribute("TESTTYPE").Value;
                    body.sub[i].Mark = n.Attribute("MARK").Value;
                    body.sub[i].Typemark = n.Attribute("TYPEMARK").Value;
                    i++;
                 }
                info.Add(body);
                
                }
            
            return info;
            }


        }
    }
        