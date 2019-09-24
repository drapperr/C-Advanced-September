using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixParts = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = matrixParts[0];
            int cols = matrixParts[1];
            var matrix = new int[rows,cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var numbers = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            int maxSum = int.MinValue;
            int topLeftIndexRow = 0;
            int topLeftIndexCol = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;
                        topLeftIndexRow = row;
                        topLeftIndexCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[topLeftIndexRow,topLeftIndexCol]} {matrix[topLeftIndexRow, topLeftIndexCol+1]}");
            Console.WriteLine($"{matrix[topLeftIndexRow+1, topLeftIndexCol]} {matrix[topLeftIndexRow+1, topLeftIndexCol+1]}");
            Console.WriteLine(maxSum);
        }
    }
}
