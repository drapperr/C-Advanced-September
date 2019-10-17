using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {
        public string Model { get; set; }
        public double FuealAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TraveledDistance { get; set; }

        public void Drive(double distance)
        {
            bool fuelIsEnough = distance * this.FuelConsumptionPerKilometer <= FuealAmount;
            if (fuelIsEnough)
            {
                this.FuealAmount -= distance * this.FuelConsumptionPerKilometer;
                this.TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
