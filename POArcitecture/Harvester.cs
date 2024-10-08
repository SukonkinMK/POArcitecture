using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class Harvester : Car, IFueling
    {
        public Harvester(string make, string model, CarType carType, int weelCount, FuelType fuelType) : base(make, model, carType, weelCount, fuelType)
        {
        }

        public override bool GearShifting()
        {
            Console.WriteLine("Переключение передач");
            return true;
        }

        public override void Maintendance()
        {
            Console.WriteLine("Обслуживание");
        }

        public override void Move()
        {
            Console.WriteLine("Движение");
        }

        public override bool SwitchHeadLights()
        {
            Console.WriteLine("Включение фар");
            return true;
        }

        public override bool SwitchWipers()
        {
            Console.WriteLine("Включение дворников");
            return true;
        }
        public void Sweeping()
        {
            Console.WriteLine("Подметать улицу");
        }

        public void Fuel()
        {
            Console.WriteLine("Заправка");
            if(RefuelingStation is not null)
            {
                RefuelingStation.Fuel(FuelType);
            }
        }
    }
}
