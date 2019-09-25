using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixArgs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = matrixArgs[0];
            int cols = matrixArgs[1];
            char[,] matrix = new char[rows, cols];
            Queue<char> snake = new Queue<char>(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row%2==0)
                    {
                        matrix[row, col] = snake.Peek();
                    }
                    else
                    {
                        matrix[row, matrix.GetLength(1) - 1 - col] = snake.Peek();
                    }
                    snake.Enqueue(snake.Dequeue());
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
