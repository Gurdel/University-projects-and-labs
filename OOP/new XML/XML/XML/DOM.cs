using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    public class DOM : IStrategy
    {
        XmlDocument doc = new XmlDocument();

        public DOM(string path)
        {
            doc.Load(path);
        }

        public List<Phone> Algorithm (Phone phone, string path)
        {
            List<List<Phone>> info = new List<List<Phone>>();

            if (phone.Firm != null) info.Add(SearchByParam("phone", "FIRM", phone.Firm, doc));
            if (phone.Model != null) info.Add(SearchByParam("phone", "MODEL", phone.Model, doc));
            if (phone.Ram != null) info.Add(SearchByParam("phone", "RAM", phone.Ram, doc));
            if (phone.Rom != null) info.Add(SearchByParam("phone", "ROM", phone.Rom, doc));
            if (phone.Battery != null) info.Add(SearchByParam("phone", "BATTERY", phone.Battery, doc));
            if (phone.Processor != null) info.Add(SearchByParam("phone", "PROCESSOR", phone.Processor, doc));
            if (phone.Os != null) info.Add(SearchByParam("phone", "OS", phone.Os, doc));
            if (phone.Diagonal != null) info.Add(SearchByParam("phone", "DIAGONAL", phone.Diagonal, doc));
            if (phone.Resolution != null) info.Add(SearchByParam("phone", "RESOLUTION", phone.Resolution, doc));
            if (phone.Matrix != null) info.Add(SearchByParam("phone", "MATRIX", phone.Matrix, doc));


            if (phone.Firm == null &&
                phone.Model == null &&
                phone.Ram == null &&
                phone.Rom == null &&
                phone.Battery == null &&
                phone.Processor == null &&
                phone.Os == null &&
                phone.Diagonal == null &&
                phone.Resolution == null &&
                phone.Matrix == null)
            {
                List<Phone> phones = new List<Phone>();
                XmlNodeList elem = doc.SelectNodes("//phone");
                foreach (XmlNode n in elem)
                {
                    phones.Add(Info(n));
                }
                return phones;
            }

                return Cross(info);
        }

        private List<Phone> SearchByParam(string node, string val, string param, XmlDocument doc)
        {
            List<Phone> phones = new List<Phone>();

            if (param != String.Empty && param != null)
            {
                XmlNodeList elem = doc.SelectNodes("//" + node + "[@" + val + "=\"" + param + "\"]");
                foreach (XmlNode n in elem)
                {
                    phones.Add(Info(n));
                }
            }

            return phones;
        }

        private Phone Info(XmlNode node)
        {
            Phone p = new Phone();

            p.Firm = node.Attributes.GetNamedItem("FIRM").Value;
            p.Model = node.Attributes.GetNamedItem("MODEL").Value;
            p.Ram = node.Attributes.GetNamedItem("RAM").Value;
            p.Rom = node.Attributes.GetNamedItem("ROM").Value;
            p.Battery = node.Attributes.GetNamedItem("BATTERY").Value;
            p.Processor = node.Attributes.GetNamedItem("PROCESSOR").Value;
            p.Os = node.Attributes.GetNamedItem("OS").Value;
            p.Diagonal = node.Attributes.GetNamedItem("DIAGONAL").Value;
            p.Resolution = node.Attributes.GetNamedItem("RESOLUTION").Value;
            p.Matrix = node.Attributes.GetNamedItem("MATRIX").Value;

            return p;
        }

        private List<Phone> Cross(List<List<Phone>> list)
        {
            List<Phone> res = new List<Phone>();

            if (list.Count != 0 && list != null)
            {
                Phone[] p = list[0].ToArray();
                if (p != null)
                {
                    foreach (Phone elem in p)
                    {
                        bool exists = true;
                        foreach (List<Phone> _p in list)
                        {
                            if (_p.Count <= 0) return new List<Phone>();

                            foreach (Phone phon in _p)
                            {
                                exists = false;
                                if (elem.Comparing(phon))
                                {
                                    exists = true;
                                    break;
                                }
                            }
                            if (!exists) break;
                        }
                        if (exists) res.Add(elem);
                    }
                }
            }

            return res;
        }
    }
}
