using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    internal class Poligon
    {
        private List<Point3D> points;
        public Poligon()
        {
            
        }

        public Poligon(List<Point3D> points)
        {
            this.points = points;
        }
    }
}
