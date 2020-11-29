using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    public class SAX : IStrategy
    {
        List<Phone> info = new List<Phone>();
        XmlReader reader;

        public SAX(string path)
        {
            reader = new XmlTextReader(path);
        }

        public List<Phone> Algorithm(Phone phone, string path)
        {
            info.Clear();

            List<Phone> result = new List<Phone>();
            Phone p = null;

            while (reader.Read())
            {
                if (reader.Name == "phone")
                {
                    p = new Phone();

                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name == "FIRM") p.Firm = reader.Value;
                            if (reader.Name == "MODEL") p.Model = reader.Value;
                            if (reader.Name == "RAM") p.Ram = reader.Value;
                            if (reader.Name == "ROM") p.Rom = reader.Value;
                            if (reader.Name == "BATTERY") p.Battery = reader.Value;
                            if (reader.Name == "PROCESSOR") p.Processor = reader.Value;
                            if (reader.Name == "OS") p.Os = reader.Value;
                            if (reader.Name == "DIAGONAL") p.Diagonal = reader.Value;
                            if (reader.Name == "RESOLUTION") p.Resolution = reader.Value;
                            if (reader.Name == "MATRIX") p.Matrix = reader.Value;
                        }
                        result.Add(p);
                    }
                }
            }

            info = Filtr(result, phone);
            return info;
        }

        private List<Phone> Filtr(List<Phone> phones, Phone phon)
        {
            List<Phone> result = new List<Phone>();

            if (phones != null && phones.Count != 0)
            {
                foreach (Phone p in phones)
                {
                    if (
                        (p.Firm == phon.Firm || phon.Firm == null) &&
                        (p.Model == phon.Model || phon.Model == null) &&
                        (p.Ram == phon.Ram || phon.Ram == null) &&
                        (p.Rom == phon.Rom || phon.Rom == null) &&
                        (p.Battery == phon.Battery || phon.Battery == null) &&
                        (p.Processor == phon.Processor || phon.Processor == null) &&
                        (p.Os == phon.Os || phon.Os == null) &&
                        (p.Diagonal == phon.Diagonal || phon.Diagonal == null) &&
                        (p.Resolution == phon.Resolution || phon.Resolution == null) &&
                        (p.Matrix == phon.Matrix || phon.Matrix == null)
                        )
                    {
                        result.Add(p);
                    }
                }
            }

            return result;
        }
    }
}
