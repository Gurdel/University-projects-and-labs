using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public interface IStrategy
    {
        List<Phone> Algorithm(Phone p, string path);
    }
}
