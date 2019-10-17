using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsuptionFor1KM = double.Parse(carInfo[2]);

                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, 
                        new Car()
                    {
                        Model = model,
                        FuealAmount = fuelAmount,
                        FuelConsumptionPerKilometer = fuelConsuptionFor1KM
                    });
                }
            }
            string input = string.Empty;

            while ((input=Console.ReadLine())!="End")
            {
                string[] driveInfo = input.Split();

                string carModel = driveInfo[1];
                double amountOfKM = double.Parse(driveInfo[2]);

                if (cars.ContainsKey(carModel))
                {
                    cars[carModel].Drive(amountOfKM);
                }
            }

            foreach (var (model,car) in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuealAmount:F2} {car.TraveledDistance:F0}");
            }
        }
    }
}
