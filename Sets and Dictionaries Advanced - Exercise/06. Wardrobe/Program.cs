using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (var clothing in clothes)
                {
                    if (!wardrobe[color].ContainsKey(clothing))
                    {
                        wardrobe[color][clothing] = 0;
                    }
                    wardrobe[color][clothing]++;
                }
            }
            string[] clothingInfo = Console.ReadLine().Split(' ');
            string thisColor = clothingInfo[0];
            string thisClothing = clothingInfo[1];

            foreach (var (color,clothes) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");
                foreach (var (clothing,count) in clothes)
                {
                    string found = string.Empty;
                    if (color==thisColor&&clothing==thisClothing)
                    {
                        found = " (found!)";
                    }
                    Console.WriteLine($"* {clothing} - {count}{found}");
                }
            }
        }
    }
}
