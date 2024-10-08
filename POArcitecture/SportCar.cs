using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class SportCar : Car
    {
        public SportCar(string make, string model, CarType carType, int weelCount, FuelType fuelType) : base(make, model, carType, weelCount, fuelType)
        {
        }

        public override bool GearShifting()
        {
            throw new NotImplementedException();
        }

        public override void Maintendance()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override bool SwitchHeadLights()
        {
            throw new NotImplementedException();
        }

        public override bool SwitchWipers()
        {
            throw new NotImplementedException();
        }
    }
}
