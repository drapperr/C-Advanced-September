using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> carsCollection = new Dictionary<string, Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];

                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire[] tires = new Tire[4];

                for (int j = 5; j < carInfo.Length; j += 2)
                {
                    double tirePressure =double.Parse( carInfo[j]);
                    int tireAge=int.Parse(carInfo[j+1]);
                    tires[(j - 5) / 2] = new Tire(tirePressure, tireAge);
                }

                Car car = new Car(model, engine, cargo, tires);

                carsCollection.Add(model, car);
            }

            string command = Console.ReadLine();

            if (command== "fragile")
            {
                carsCollection = carsCollection
                    .Where(x => x.Value.Cargo.Type == "fragile"
                    && x.Value.Tires.Any(t => t.Pressure < 1))
                    .ToDictionary(x => x.Key, y => y.Value);
            }
            else if (command== "flamable")
            {
                carsCollection = carsCollection
                    .Where(x => x.Value.Cargo.Type == "flamable"
                    && x.Value.Engine.Power>250)
                    .ToDictionary(x => x.Key, y => y.Value);
            }

            foreach (var car in carsCollection)
            {
                Console.WriteLine(car.Key);
            }
        }
    }
}
