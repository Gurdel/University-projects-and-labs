using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGKGlab
{
    public class Result
    {
        public List<MyPoint> res_p = new List<MyPoint>();
        public List<NearestNeighbor> res_nn = new List<NearestNeighbor>();
        public List<VorNode> res_vor = new List<VorNode>();

        public Result(List<MyPoint> _p, List<NearestNeighbor> _nn, List<VorNode> _vor)
        {
            res_p.AddRange(_p);
            res_nn.AddRange(_nn);
            res_vor.AddRange(_vor);
        }
    }
}
