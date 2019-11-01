using System;
using System.Collections.Generic;

namespace The_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> countOfVegetables = new Dictionary<string, int>()
            {
                { "Carrots",0},
                {"Potatoes",0 },
                { "Lettuce",0},
            };

            int harmedVegetables = 0;

            int rows = int.Parse(Console.ReadLine());

            string[][] garden = new string[rows][];

            for (int row = 0; row < garden.Length; row++)
            {
                string[] line = Console.ReadLine().Split();
                garden[row] = new string[line.Length];

                for (int col = 0; col < garden[row].Length; col++)
                {
                    garden[row][col] = line[col];
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End of Harvest")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];
                int row = int.Parse(inputArgs[1]);
                int col = int.Parse(inputArgs[2]);

                if (command == "Harvest" && InGarden(row, col, garden))
                {
                    switch (garden[row][col])
                    {
                        case "L":
                            countOfVegetables["Lettuce"]++;
                            break;
                        case "P":
                            countOfVegetables["Potatoes"]++;
                            break;
                        case "C":
                            countOfVegetables["Carrots"]++;
                            break;
                    }

                    garden[row][col] = " ";
                }
                else if (command == "Mole")
                {
                    string direction = inputArgs[3];

                    while (InGarden(row, col, garden))
                    {
                        if (garden[row][col]!=" ")
                        {
                            harmedVegetables++;
                            garden[row][col] = " ";
                        }
                        switch (direction)
                        {
                            case "up":
                                row -= 2;
                                break;
                            case "down":
                                row += 2;
                                break;
                            case "left":
                                col -= 2;
                                break;
                            case "right":
                                col += 2;
                                break;
                        }
                    }
                }
            }

            for (int row = 0; row < garden.Length; row++)
            {
                Console.WriteLine(string.Join(" ",garden[row]));
            }

            foreach (var (vegetable,count) in countOfVegetables)
            {
                Console.WriteLine($"{vegetable}: {count}");
            }
            Console.WriteLine($"Harmed vegetables: {harmedVegetables}");
        }

        private static bool InGarden(int row, int col, string[][] garden)
        {
            return row >= 0 && row < garden.Length && col >= 0 && col < garden[row].Length;
        }
    }
}
