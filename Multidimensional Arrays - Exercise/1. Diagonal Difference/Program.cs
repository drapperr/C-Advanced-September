using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            int leftDiagonalSum = 0;
            int rightDiagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                leftDiagonalSum += matrix[i, i];
                rightDiagonalSum += matrix[i, matrix.GetLength(0)-1 - i];
            }

            int diff = Math.Abs(leftDiagonalSum - rightDiagonalSum);
            Console.WriteLine(diff);
        }
    }
}
