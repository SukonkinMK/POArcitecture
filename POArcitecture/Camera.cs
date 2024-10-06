using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    internal class Camera
    {
        public Point3D Location { get; }
        public Angle3D Angle { get; }


        public Camera(Point3D location, Angle3D angle)
        {
            Location = location;
            Angle = angle;
        }

        public void Rotate(Angle3D angle)
        {
            Angle.Rotate(angle);
        }
        public void Move(Point3D point)
        {
            Location.Add(point);
        }
    }
}
