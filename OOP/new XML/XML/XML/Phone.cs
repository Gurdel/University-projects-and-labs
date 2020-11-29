using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class Phone
    {
        public string Firm = null;
        public string Model = null;
        public string Ram = null;
        public string Rom = null;
        public string Battery = null;
        public string Processor = null;
        public string Os = null;
        public string Diagonal = null;
        public string Resolution = null;
        public string Matrix = null;

        public Phone() { }

        public Phone(string[] data)
        {
            Firm = data[0];
            Model = data[1];
            Ram = data[2];
            Rom = data[3];
            Battery = data[4];
            Processor = data[5];
            Os = data[6];
            Diagonal = data[7];
            Resolution = data[8];
            Matrix = data[9];
        }

        public bool Comparing(Phone _phone)
        {
            if ((this.Firm == _phone.Firm) &&
                (this.Model == _phone.Model) &&
                (this.Ram == _phone.Ram) &&
                (this.Rom == _phone.Rom) &&
                (this.Battery == _phone.Battery) &&
                (this.Processor == _phone.Processor) &&
                (this.Os == _phone.Os) &&
                (this.Diagonal == _phone.Diagonal) &&
                (this.Resolution == _phone.Resolution) &&
                (this.Matrix == _phone.Matrix))
                return true;
            else return false;
        }
    }
}
