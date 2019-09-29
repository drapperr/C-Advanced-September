using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static char[,] matrix;
        static int playerRow;
        static int playerCol;
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            matrix = new char[dimensions[0], dimensions[1]];
            PopulateMatrix();
            string commands = Console.ReadLine();
            foreach (var command in commands)
            {
                if (command == 'U')
                {
                    Move(-1, 0);
                }
                else if (command == 'D')
                {
                    Move(1, 0);
                }
                else if (command == 'R')
                {
                    Move(0, 1);
                }
                else if (command == 'L')
                {
                    Move(0, -1);
                }

            }
        }

        private static void Move(int row, int col)
        {
            int currentRow = playerRow + row;
            int currentCol = playerCol + col;
            if (IsValid(currentRow, currentCol))
            {
                matrix[playerRow, playerCol] = '.';
                playerRow = currentRow;
                playerCol = currentCol;
               
                if (matrix[playerRow, playerCol] == 'B')
                {
                    SpreadBunnies();
                    Print();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }
                else
                {
                    matrix[playerRow, playerCol] = 'P';
                    SpreadBunnies();
                }
            }
            else
            {
                matrix[playerRow, playerCol] = '.';
                SpreadBunnies();
                Print();
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
        }

        private static void SpreadBunnies()
        {
            bool playerIsDied = false;
            List<int> bunniesCordinates = new List<int>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunniesCordinates.Add(row);
                        bunniesCordinates.Add(col);
                    }
                }
            }
            for (int i = 0; i < bunniesCordinates.Count; i += 2)
            {
                int bunnyRow = bunniesCordinates[i];
                int bunnyCol = bunniesCordinates[i+1];
                if (IsValid(bunnyRow - 1, bunnyCol))
                {
                    if (matrix[bunnyRow - 1, bunnyCol]=='P')
                    {
                        playerIsDied = true;
                    }
                    matrix[bunnyRow - 1, bunnyCol] = 'B';
                }
                if (IsValid(bunnyRow + 1, bunnyCol))
                {
                    if (matrix[bunnyRow + 1, bunnyCol] == 'P')
                    {
                        playerIsDied = true;
                    }
                    matrix[bunnyRow + 1, bunnyCol] = 'B';
                }
                if (IsValid(bunnyRow, bunnyCol - 1))
                {
                    if (matrix[bunnyRow, bunnyCol - 1] == 'P')
                    {
                        playerIsDied = true;
                    }
                    matrix[bunnyRow, bunnyCol - 1] = 'B';
                }
                if (IsValid(bunnyRow, bunnyCol + 1))
                {
                    if (matrix[bunnyRow, bunnyCol + 1] == 'P')
                    {
                        playerIsDied = true;
                    }
                    matrix[bunnyRow, bunnyCol + 1] = 'B';
                }
            }
            if (playerIsDied)
            {
                Print();
                Console.WriteLine($"dead: {playerRow} {playerCol}");
                Environment.Exit(0);
            }
        }

        private static void Print()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsValid(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }

        private static void PopulateMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                    if (line[col]=='P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
