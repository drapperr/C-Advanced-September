﻿using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static char[,] matrix;
        static int coals;
        static int startRow;
        static int startCol;

        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var commands = Console.ReadLine().Split(' ');
            matrix = new char[size, size];
            Populate();
            foreach (var command in commands)
            {
                if (command == "up")
                {
                    Move(-1, 0);
                }
                else if (command == "down")
                {
                    Move(1, 0);
                }
                else if (command == "right")
                {
                    Move(0, 1);
                }
                else if (command == "left")
                {
                    Move(0, -1);
                }
            }
            Console.WriteLine($"{coals} coals left. ({startRow}, {startCol})");
        }

        private static void Move(int row, int col)
        {
            int currentRow = startRow + row;
            int currentCol = startCol + col;
            if (IsValid(currentRow, currentCol))
            {
                if (matrix[currentRow, currentCol] == 'c')
                {
                    coals--;
                    if (coals==0)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        Environment.Exit(0);
                    }
                }
                else if (matrix[currentRow, currentCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    Environment.Exit(0);
                }
                matrix[startRow, startCol] = '*';
                matrix[currentRow, currentCol] = 's';
                startRow = currentRow;
                startCol = currentCol;
            }
        }

        private static bool IsValid(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }

        private static void Populate()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine()
                    .Split(' ')
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                    if (line[col] == 'c')
                    {
                        coals++;
                    }
                    else if (line[col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
        }
    }
}
