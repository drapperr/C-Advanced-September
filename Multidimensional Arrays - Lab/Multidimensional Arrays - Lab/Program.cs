using System;
using System.Linq;

namespace Multidimensional_Arrays___Lab
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
            var matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];

                }
            }
            int sum = 0;
            foreach (var num in matrix)
            {
                sum += num;
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
