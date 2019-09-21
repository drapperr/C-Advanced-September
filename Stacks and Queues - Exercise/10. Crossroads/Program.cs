using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;

            string carName = string.Empty;

            while ((carName = Console.ReadLine()) != "END")
            {
                if (carName == "green" && cars.Count > 0)
                {
                    string currentCar = cars.Dequeue();
                    Queue<char> carLenght = new Queue<char>(currentCar);
                    passedCars++;

                    for (int i = 0; i < greenLight; i++)
                    {
                        if (carLenght.Count == 0)
                        {
                            if (cars.Count > 0)
                            {
                                currentCar = cars.Dequeue();
                                carLenght = new Queue<char>(currentCar);
                                passedCars++;
                            }
                            else break;
                        }
                        carLenght.Dequeue();
                    }
                    if (carLenght.Count > 0)
                    {
                        for (int i = 0; i < freeWindow; i++)
                        {
                            if (carLenght.Count > 0)
                            {
                                carLenght.Dequeue();
                            }
                        }
                    }
                    if (carLenght.Count > 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currentCar} was hit at {carLenght.Dequeue()}.");
                        return;
                    }
                }
                else
                {
                    cars.Enqueue(carName);
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
