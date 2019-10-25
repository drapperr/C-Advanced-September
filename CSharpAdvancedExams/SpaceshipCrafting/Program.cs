using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> advancedMaterial = new Dictionary<string, int>()
            {
                { "Aluminium" , 50 },
                {"Carbon fiber",100},
                {"Glass",25 },
                {"Lithium",75 },
            };

            Dictionary<string, int> myMaterials = new Dictionary<string, int>()
                {
                { "Aluminium" , 0 },
                {"Carbon fiber",0},
                {"Glass",0 },
                {"Lithium",0 },
            };

            Queue<int> chemicalLiquids = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Stack<int> physicalItems = new Stack<int>(Console.ReadLine()
                 .Split()
                 .Select(int.Parse));

            while (chemicalLiquids.Count > 0 && physicalItems.Count > 0)
            {
                int currentLiquid = chemicalLiquids.Peek();
                int currentItem = physicalItems.Peek();

                int sum = currentLiquid + currentItem;

                bool foundItem = false;

                foreach (var (name,value) in advancedMaterial)
                {
                    if (sum==value)
                    {
                        myMaterials[name]++;

                        chemicalLiquids.Dequeue();
                        physicalItems.Pop();

                        foundItem = true;
                        break;
                    }
                }
                if (!foundItem)
                {
                    chemicalLiquids.Dequeue();
                    physicalItems.Push(physicalItems.Pop() + 3);
                }
            }

            if (myMaterials.Any(x=>x.Value==0))
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }
            else
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }

            if (chemicalLiquids.Count==0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",chemicalLiquids)}");
            }

            if (physicalItems.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
            }

            foreach (var item in myMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
