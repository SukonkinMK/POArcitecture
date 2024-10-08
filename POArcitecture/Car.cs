using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public abstract class Car
    {
        protected Car(string make, string model, CarType carType, int weelCount, FuelType fuelType)
        {
            Make = make;
            Model = model;
            CarType = carType;
            WeelCount = weelCount;
            FuelType = fuelType;
            fogLights = false;
        }

        public string Make { get;  } //марка
        public string Model { get;  } //модель
        public Color Color { get; set; }
        public CarType CarType { get; }
        public int WeelCount { get; }
        public FuelType FuelType { get; }
        public GearboxType GearboxType { get; set; }
        public double EngineCapacity { get; set; }
        public IRefueling RefuelingStation { get; set; }
        public IWiping WipingStation { get; set;}
        private bool fogLights;
        public abstract void Move();
        public abstract void Maintendance();
        public abstract bool GearShifting();
        public abstract bool SwitchHeadLights();
        public abstract bool SwitchWipers();
        public bool SwitchFogLights()
        {
            fogLights = !fogLights;
            return fogLights;
        }
        public void Transition()
        {
            Console.WriteLine("Перевозка груза");
        }

        public void Wipping()
        {
            WipingStation.WipHeadLights();
            WipingStation.WipMirrors();
            WipingStation.WipWindshield();
        }

    }
}
