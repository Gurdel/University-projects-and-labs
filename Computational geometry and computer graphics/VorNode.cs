using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGKGlab
{
    public class VorNode
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;

        public int p1_id;
        public int p2_id;

        public VorNode(int _p1_id, int _p2_id, int _x1, int _y1, int _x2, int _y2)
        {
            x1 = _x1;
            y1 = _y1;
            x2 = _x2;
            y2 = _y2;
            p1_id = _p1_id;
            p2_id = _p2_id;
        }
    }
}
