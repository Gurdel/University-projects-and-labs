using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace MyExcel
{
    public class Calculator
    {
        public string Calc(string str)
        {
            int divByZero = str.Split(new string[] { "/0" }, StringSplitOptions.None).Count();
            int divByNotZero = str.Split(new string[] { "/0." }, StringSplitOptions.None).Count();
            if (divByZero != divByNotZero) return "DIV BY ZERO";


            Expression e = new Expression(str);
            
            return Convert.ToString(e.calculate());
        }
    }
}
