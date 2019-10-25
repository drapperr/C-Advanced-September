using System;
using System.Collections.Generic;
using System.Linq;

namespace SeashellTreasure
{
    class Program
    {
        static char[][] beach;
        static void Main(string[] args)
        {
            PopulateBeach();

            List<char> colectedSeashells = new List<char>();
            int stolenSeashells = 0;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Sunset")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];
                int row = int.Parse(inputArgs[1]);
                int col = int.Parse(inputArgs[2]);

                if (InBeach(row, col))
                {
                    if (command == "Collect")
                    {
                        if (beach[row][col] != '-')
                        {
                            colectedSeashells.Add(beach[row][col]);
                            beach[row][col] = '-';
                        }
                    }
                    else if (command == "Steal")
                    {
                        if (beach[row][col] != '-')
                        {
                            stolenSeashells++;
                            beach[row][col] = '-';
                        }

                        string direction = inputArgs[3];


                        for (int i = 0; i < 3; i++)
                        {
                            switch (direction)
                            {
                                case "up":
                                    row--;
                                    break;
                                case "down":
                                    row++;
                                    break;
                                case "left":
                                    col--;
                                    break;
                                case "right":
                                    col++;
                                    break;
                            }

                            if (InBeach(row, col))
                            {
                                if (beach[row][col] != '-')
                                {
                                    stolenSeashells++;
                                    beach[row][col] = '-';
                                }
                            }
                            else break;
                        }
                    }
                }
            }

            PrintBeach();
            Console.Write($"Collected seashells: {colectedSeashells.Count}");
            if (colectedSeashells.Count != 0)
            {
                Console.WriteLine($" -> {string.Join(", ", colectedSeashells)}");
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine($"Stolen seashells: {stolenSeashells}");
        }

        private static void PrintBeach()
        {
            for (int row = 0; row < beach.Length; row++)
            {
                Console.WriteLine(string.Join(" ", beach[row]));
            }
        }

        private static bool InBeach(int row, int col)
        {
            return row >= 0 && row < beach.Length && col >= 0 && col < beach[row].Length;
        }

        private static void PopulateBeach()
        {
            int rows = int.Parse(Console.ReadLine());

            beach = new char[rows][];

            for (int row = 0; row < beach.Length; row++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                beach[row] = new char[line.Length];

                if (line.Any())
                {
                    for (int col = 0; col < line.Length; col++)
                    {
                        beach[row][col] = char.Parse(line[col]);
                    }
                }

            }
        }
    }
}
