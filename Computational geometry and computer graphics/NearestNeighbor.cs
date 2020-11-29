using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGKGlab
{
    public class NearestNeighbor
    {
        public int p1_id;
        public int p2_id;
        public double size;
        public NearestNeighbor(int _p1_id, int _p2_id, double _size)
        {
            p1_id = _p1_id;
            p2_id = _p2_id;
            size = _size;
        }
    }
}
