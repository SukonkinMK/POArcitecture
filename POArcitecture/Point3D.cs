using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    internal class Point3D
    {
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double getX() { return x; }
        public double getY() { return y; } 
        public double getZ() { return z; }
        public void Add(Point3D other)
        {
            x += other.getX();
            y += other.getY();
            z += other.getZ();
        }
    }
}
