using System;
using System.Linq;

namespace _4._Matrix_Shuffling
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
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] chars = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(chars[col]);
                }
            }
            string input = string.Empty;

            while ((input=Console.ReadLine())!="END")
            {
                string[] inputArgs = input.Split();
                string command = inputArgs[0];
                bool isValid = command == "swap" && inputArgs.Length == 5;
                if (isValid)
                {
                    int row1 =int.Parse(inputArgs[1]);
                    int col1 =int.Parse(inputArgs[2]);
                    int row2 =int.Parse(inputArgs[3]);
                    int col2 =int.Parse(inputArgs[4]);

                    bool inRange = row1 >= 0 && row1 < matrix.GetLength(0)
                        && row2 >= 0 && row2 < matrix.GetLength(0)
                        && col1 >= 0 && col1 < matrix.GetLength(1)
                        && col2 >= 0 && col2 < matrix.GetLength(1);
                    if (inRange)
                    {
                        int currentNum = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = currentNum;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row,col]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
