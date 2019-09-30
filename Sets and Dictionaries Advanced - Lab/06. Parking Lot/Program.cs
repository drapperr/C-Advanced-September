using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var cars = new HashSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                var inputArgs = input.Split(", ");
                var direction = inputArgs[0];
                var carNumber = inputArgs[1];
                if (direction == "IN")
                {
                    cars.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }
            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
