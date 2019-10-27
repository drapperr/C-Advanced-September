using System;
using System.Collections.Generic;
using System.Linq;

namespace Trojan_Invasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int wavesCount = int.Parse(Console.ReadLine());

            List<int> plates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList(); ;

            for (int i = 1; i <= wavesCount; i++)
            {
                int[] warriorsLine = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                Stack<int> warriors = new Stack<int>(warriorsLine);

                if (i % 3 == 0)
                {
                    plates.Add(int.Parse(Console.ReadLine()));
                }

                while (warriors.Count > 0 && plates.Count > 0)
                {
                    int currentWarrior = warriors.Pop();
                    int currentPlate = plates[0];

                    if (currentWarrior > currentPlate)
                    {
                        plates.RemoveAt(0);
                        warriors.Push(currentWarrior - currentPlate);
                    }
                    else if (currentWarrior < currentPlate)
                    {
                        plates[0] = currentPlate - currentWarrior;
                    }
                    else
                    {
                        plates.RemoveAt(0);
                    }
                }

                if (plates.Count==0)
                {
                    Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                    Console.WriteLine($"Warriors left: {string.Join(", ",warriors)}");
                    return;
                }
            }
            Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
            Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
        }
    }
}
