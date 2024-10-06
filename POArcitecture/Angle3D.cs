namespace POArcitecture
{
    public class Angle3D
    {
        private double angleX;
        private double angleY;
        private double angleZ;

        public Angle3D(double angleX, double angleY, double angleZ)
        {
            this.angleX = angleX;
            this.angleY = angleY;
            this.angleZ = angleZ;
        }

        public double getXAngle() { return angleX; }
        public double getYAngle() {  return angleY; }
        public double getZAngle() {  return angleZ; }

        public void Rotate(Angle3D angle)
        {
            angleX += angle.getXAngle();
            angleY += angle.getYAngle();
            angleZ += angle.getZAngle();
        }
    }
}