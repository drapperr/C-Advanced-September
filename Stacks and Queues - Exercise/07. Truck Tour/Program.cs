using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Queue<int> petrolQueue = new Queue<int>();
            Queue<int> distanceQueue = new Queue<int>();

            for (int i = 0; i < count; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int petrolAmount = input[0];
                int distance = input[1];
                petrolQueue.Enqueue(petrolAmount);
                distanceQueue.Enqueue(distance);
            }

            int index = -1;

            for (int i = 0; i < count; i++)
            {
                bool possibleQueue = true;
                int currentPetrol = 0;

                for (int j = 0; j < count; j++)
                {
                    int petrolAmount = petrolQueue.Dequeue();
                    int distance = distanceQueue.Dequeue();

                    currentPetrol += petrolAmount;
                    currentPetrol -= distance;
                    petrolQueue.Enqueue(petrolAmount);
                    distanceQueue.Enqueue(distance);

                    if (currentPetrol<0)
                    {
                        possibleQueue = false;
                    }
                }
                petrolQueue.Enqueue(petrolQueue.Dequeue());
                distanceQueue.Enqueue(distanceQueue.Dequeue());

                if (possibleQueue)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
