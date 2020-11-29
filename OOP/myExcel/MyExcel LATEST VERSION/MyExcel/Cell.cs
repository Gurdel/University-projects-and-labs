using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExcel
{
    public class Cell
    {
        private double value = 0.0;
        private string expression = "";
        private string error = "";

        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public string Expression
        {
            get { return expression; }
            set { expression = value; }
        }

        public string Error
        {
            get { return error; }
            set { error = value; }
        }
    }
}
