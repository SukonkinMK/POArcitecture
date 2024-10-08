// See https://aka.ms/new-console-template for more information
using Arcitecture;

Harvester harvester = new("", "", CarType.Truck, 6, FuelType.Diesel);
SportCar sportCar = new("", "", CarType.Sport, 3, FuelType.Gasoline);
Console.WriteLine($"Обслуживание уборщика {CalcMaintandanceCost(harvester)}");
Console.WriteLine($"Обслуживание спорткара {CalcMaintandanceCost(sportCar)}");
IRefueling refuelingStation = new RefuelingStation();
harvester.RefuelingStation = refuelingStation;
harvester.Fuel();
IWiping wipingStation = new WipingStation();
harvester.WipingStation = wipingStation;
harvester.Wipping();



static int CalcMaintandanceCost(Car car)
{
    if (car.WeelCount >= 6)
        return car.WeelCount * 1500;
    else
    {
        return car.WeelCount * 1000;
    }
}