using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tiresInfo = input.Split();
                Tire[] currentTires = new Tire[4];
                for (int i = 0; i < tiresInfo.Length; i += 2)
                {
                    int tierYear = int.Parse(tiresInfo[i]);
                    double tierPressure = double.Parse(tiresInfo[i + 1]);
                    currentTires[i / 2] = new Tire(tierYear, tierPressure);
                }
                tires.Add(currentTires);
            }

            List<Engine> engines = new List<Engine>();

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = input.Split();

                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);

                engines.Add(new Engine(horsePower, cubicCapacity));
            }

            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input.Split();
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));
            }
            var specialCars = new List<Car>();

            foreach (var car in cars)
            {
                if (car.Year >= 2017
                    && car.Engine.HorsePower >= 330
                    && car.Tires.Sum(t => t.Pressure) >= 9
                    && car.Tires.Sum(t => t.Pressure) <= 10)
                {
                    specialCars.Add(car);
                }
            }

            foreach (var car in specialCars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
