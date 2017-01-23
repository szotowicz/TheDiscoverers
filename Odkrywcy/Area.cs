using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odkrywcy
{
    class Area
    {
        public int id;
        public int x;
        public int y;
        public int bridge;


        public Area(int id, int x, int y, int bridge)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.bridge = bridge;
        }
    }
}
