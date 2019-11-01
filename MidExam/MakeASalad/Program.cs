using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> vegetablesCalories = new Dictionary<string, int>()
            {
                {"tomato",80 },
                {"carrot",136 },
                {"lettuce",109 },
                {"potato",215 },
            };

            Queue<string> vegetables = new Queue<string>(Console.ReadLine().Split());
            Stack<int> calories = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            List<int> salads = new List<int>();

            while (calories.Count > 0 && vegetables.Count > 0)
            {
                int currentCalories = calories.Pop();
                salads.Add(currentCalories);

                while (currentCalories > 0 && vegetables.Count > 0)
                {
                    string currentVegetable = vegetables.Dequeue();
                    if (vegetablesCalories.ContainsKey(currentVegetable))
                    {
                        int vegetableCalorie = vegetablesCalories[currentVegetable];

                        currentCalories -= vegetableCalorie;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", salads));

            if (calories.Count > 0)
            {
                Console.WriteLine(string.Join(" ", calories));
            }
            else if (vegetables.Count > 0)
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }
        }
    }
}
