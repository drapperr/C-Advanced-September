using System;
using System.Collections.Generic;

namespace _7._Knight_Game
{
    class Program
    {
        static char[,] matrix;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            matrix = new char[n, n];
            PopulateMatrix();
            int maxAttacks = -1;
            int knightrow = 0;
            int knightcol = 0;
            int counter = 0;
            while (true)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int currenAttacks = 0;
                        if (matrix[row, col] == 'K')
                        {
                            if (IsValid(row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
                            {
                                currenAttacks++;
                            }
                            if (IsValid(row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
                            {
                                currenAttacks++;
                            }
                            if (IsValid(row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
                            {
                                currenAttacks++;
                            }
                            if (IsValid(row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
                            {
                                currenAttacks++;
                            }
                            if (IsValid(row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
                            {
                                currenAttacks++;
                            }
                            if (IsValid(row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
                            {
                                currenAttacks++;
                            }
                            if (IsValid(row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
                            {
                                currenAttacks++;
                            }
                            if (IsValid(row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
                            {
                                currenAttacks++;
                            }
                        }
                        if (currenAttacks>maxAttacks)
                        {
                            maxAttacks=currenAttacks;
                            knightrow = row;
                            knightcol = col;
                        }
                    }
                }
                if (maxAttacks!=0)
                {
                    matrix[knightrow, knightcol] = 'O';
                    counter++;
                    maxAttacks = 0;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
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
                string line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }
}
