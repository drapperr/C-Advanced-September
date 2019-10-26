using System;
using System.Collections.Generic;
using System.Linq;

namespace SummerCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mixes = new Dictionary<string, int>()
            {
                { "Mimosa" , 150 },
                {"Daiquiri",250},
                {"Sunshine",300 },
                {"Mojito",400 },
            };

            Dictionary<string, int> coctails = new Dictionary<string, int>()
                {
                { "Mimosa" , 0 },
                {"Daiquiri",0},
                {"Sunshine",0 },
                {"Mojito",0 },
            };

            Queue<int> ingredients = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Stack<int> freshness = new Stack<int>(Console.ReadLine()
                 .Split()
                 .Select(int.Parse));

            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                int currentIngrediend = ingredients.Dequeue();

                if (currentIngrediend == 0)
                {
                    continue;
                }

                int currentFreshness = freshness.Pop();

                int total = currentIngrediend * currentFreshness;

                bool foundMix = false;

                foreach (var (name, value) in mixes)
                {
                    if (total == value)
                    {
                        coctails[name]++;

                        foundMix = true;
                        break;
                    }
                }
                if (!foundMix)
                {
                    ingredients.Enqueue(currentIngrediend + 5);
                }
            }

            if (coctails.Any(x => x.Value == 0))
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }
            else
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }

            if (ingredients.Count != 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var (name, value) in coctails.Where(x => x.Value != 0).OrderBy(x => x.Key))
            {
                Console.WriteLine($" # {name} --> {value}");
            }
        }
    }
}
