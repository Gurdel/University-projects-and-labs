using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDataBase
    {
    interface IStrategy
        {

        List<Student> Algorithm(Student p,string path);
        
         }
    }
