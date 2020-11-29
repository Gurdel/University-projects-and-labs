using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDataBase
    {
    class Student
        {
        public Subject [] sub ;
       
           
        public string Faculty { get; set; }
            public string Course { get; set; }
            public string Spec { get; set; }
            public string Dep{ get; set; }
            public string Group { get; set; }
            public string Name { get; set; }
            public string IdCard { get; set; }
       
        public Student(string[] param)
            {
            Faculty = param[0];
            Course = param[1];
            Spec = param[2];
            Dep = param[3];
            Group = param[4];
            Name = param[5];
            IdCard = param[6];

            sub = new Subject[4];
            for (int i = 0; i < 4; i++)
                {
                sub[i] = new Subject();
                }
            int j = 7; 
                
                for (int i = 0; i < 4; i++)
                {
                sub[i].Name = param[j++];
                sub[i].Testtype = param[j++];
                sub[i].Mark = param[j++];
                sub[i].Typemark = param[j++];
                }
            

          
           

            }
       public Student(IStrategy algo)
                {
            Faculty = String.Empty;
            Course = String.Empty;
            Spec = String.Empty;
            Dep = String.Empty;
            Group = String.Empty;
            Name = String.Empty;
            IdCard = String.Empty;
          sub = new Subject[4];
            for (int i = 0; i < 4; i++)
                {
                sub[i] = new Subject();
                }
            Algo = algo;
                }

    
            public IStrategy Algo { get; set; }
            public List<Student> Algorithm(Student parametrs,string path)
                {
                return Algo.Algorithm(parametrs,path);
                }
        public bool Eq(Student f,Student s)
            { bool ok=false;
            if
                (

            s.Faculty == f.Faculty &&
            s.Course == f.Course &&
            s.Spec == f.Spec &&
            s.Dep == f.Dep &&
            s.Group == f.Group &&
            s.Name == f.Name &&
            s.IdCard == f.IdCard
            )
                ok = true;
            else { ok = false; return ok; }
            for (int i=0;i<4; i++)
                {
                if ((s.sub[i].Name == f.sub[i].Name) &&
                    s.sub[i].Mark == f.sub[i].Mark &&
                    s.sub[i].Testtype == f.sub[i].Testtype &&
                    s.sub[i].Typemark == f.sub[i].Typemark)
                    ok = true;
                else ok = false;

                }
            return ok;
            }
       
        }
        class Subject
        {
        public string Name { get; set; }
        public string Testtype { get; set; }
        public string Mark { get; set; }
        public string Typemark { get; set; }


        public Subject()
            {
            Name = String.Empty;
            Testtype = String.Empty;
            Mark = String.Empty;
            Typemark = String.Empty;
            
            }

        }
    }
    
