using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POArcitecture
{
    internal class Flash
    {
        public Point3D Location {  get; }
        public Angle3D Angle { get; }
        public Color Color { get; }
        public float Power {  get; }

        public Flash(Point3D location, Angle3D angle, Color color, float power)
        {
            Location = location;
            Angle = angle;
            Color = color;
            Power = power;
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
