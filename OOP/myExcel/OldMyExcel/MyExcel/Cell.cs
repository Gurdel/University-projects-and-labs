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
        public List<string> attach = new List<string>() { };

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
    }
}
