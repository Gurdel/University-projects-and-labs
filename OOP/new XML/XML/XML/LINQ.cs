using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML
{
    public class LINQ : IStrategy
    {
        List<Phone> result = new List<Phone>();
        XDocument doc = new XDocument();

        public LINQ(string path)
        {
            doc = XDocument.Load(path);
        }

        public List<Phone> Algorithm(Phone phone, string path)
        {
            List<XElement> match = (from val in doc.Descendants("phone")
                                     where
                                     (phone.Firm == null || phone.Firm == val.Attribute("FIRM").Value) &&
                                     (phone.Model == null || phone.Model == val.Attribute("MODEL").Value) &&
                                     (phone.Ram == null || phone.Ram == val.Attribute("RAM").Value) &&
                                     (phone.Rom == null || phone.Rom == val.Attribute("ROM").Value) &&
                                     (phone.Battery == null || phone.Battery == val.Attribute("BATTERY").Value) &&
                                     (phone.Processor == null || phone.Processor == val.Attribute("PROCESSOR").Value) &&
                                     (phone.Os == null || phone.Os == val.Attribute("OS").Value) &&
                                     (phone.Diagonal == null || phone.Diagonal == val.Attribute("DIAGONAL").Value) &&
                                     (phone.Resolution == null || phone.Resolution == val.Attribute("RESOLUTION").Value) &&
                                     (phone.Matrix == null || phone.Matrix == val.Attribute("MATRIX").Value)
                                     select val).ToList();

            foreach (XElement obj in match)
            {
                Phone ph = new Phone();
                ph.Firm = obj.Attribute("FIRM").Value;
                ph.Model = obj.Attribute("MODEL").Value;
                ph.Ram = obj.Attribute("RAM").Value;
                ph.Rom = obj.Attribute("ROM").Value;
                ph.Battery = obj.Attribute("BATTERY").Value;
                ph.Processor = obj.Attribute("PROCESSOR").Value;
                ph.Os = obj.Attribute("OS").Value;
                ph.Diagonal = obj.Attribute("DIAGONAL").Value;
                ph.Resolution = obj.Attribute("RESOLUTION").Value;
                ph.Matrix = obj.Attribute("MATRIX").Value;
                result.Add(ph);
            }

            return result;
        }
    }
}
