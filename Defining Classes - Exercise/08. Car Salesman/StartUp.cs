using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

            List<Car> cars = new List<Car>();

            AddEngines(engines);
            AddCars(engines, cars);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        private static void AddCars(Dictionary<string, Engine> engines, List<Car> cars)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                string engineModel = carInfo[1];

                Engine engine = engines[engineModel];

                Car car = new Car(model, engine);

                if (carInfo.Length == 3)
                {
                    if (int.TryParse(carInfo[2], out int weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        string color = carInfo[2];
                        car.Color = color;
                    }

                }
                else if (carInfo.Length == 4)
                {
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];
                    car.Weight = weight;
                    car.Color = color;
                }

                cars.Add(car);
            }
        }

        private static void AddEngines(Dictionary<string, Engine> engines)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                Engine engine = new Engine(model, power);

                if (engineInfo.Length == 3)
                {
                    if (int.TryParse(engineInfo[2], out int displacement))
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        string efficiency = engineInfo[2];

                        engine.Efficiency = efficiency;
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];

                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }

                engines.Add(model, engine);
            }
        }
    }
}
