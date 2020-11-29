using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mini_excel_lab2
{
    public class Cell : DataGridViewTextBoxCell
    {
        string val;
        string name;
        string exp;


        public Cell()
        {
            name = "A" + "1";
            val = "";
            exp = "";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        new public string Value
        {
            get { return val; }
            set { val = value; }
        }

        public string Exp
        {
            get { return exp; }
            set { exp = value; }
        }


    }
}
