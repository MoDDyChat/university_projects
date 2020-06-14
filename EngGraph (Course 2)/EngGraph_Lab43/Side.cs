using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab43
{
    public class Side
    {
        public Vertex x1, x2, x3, x4;

        public Side(Vertex x1, Vertex x2, Vertex x3, Vertex x4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
        }
    }
}
