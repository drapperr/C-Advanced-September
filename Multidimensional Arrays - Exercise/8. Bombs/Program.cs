﻿using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static int[,] matrix;
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            matrix = new int[size, size];
            Populate();
            var coordinates = Console.ReadLine().Split(' ');
            foreach (var coordinate in coordinates)
            {
                var coordinatParts = coordinate
                    .Split(',')
                    .Select(int.Parse)
                    .ToArray();
                int row = coordinatParts[0];
                int col = coordinatParts[1];
                if (IsValid(row, col) && matrix[row, col] > 0)
                {
                    Explode(row, col);
                }
            }
            Print();
        }

        private static void Print()
        {
            Console.WriteLine($"Alive cells: {matrix.Cast<int>().Where(x => x > 0).Count()}");
            Console.WriteLine($"Sum: {matrix.Cast<int>().Where(x => x > 0).Sum()}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Explode(int row, int col)
        {
            int bombValue = matrix[row, col];

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int currentRow = row + i;
                    int currenCol = col + j;
                    if (IsValid(currentRow, currenCol) && matrix[currentRow, currenCol] > 0)
                    {
                        matrix[currentRow, currenCol] -= bombValue;
                    }
                }
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
                var input = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
