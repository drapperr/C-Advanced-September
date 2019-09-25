﻿using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                double[] line = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();
                jaggedArray[i] = line;
            }

            for (int i = 0; i < jaggedArray.Length-1; i++)
            {
                if (jaggedArray[i].Length==jaggedArray[i+1].Length)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] *= 2;
                        jaggedArray[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] /= 2;
                    }
                    for (int j = 0; j < jaggedArray[i+1].Length; j++)
                    {
                        jaggedArray[i + 1][j] /= 2;
                    }
                }
            }
            string input = string.Empty;

            while ((input=Console.ReadLine())!="End")
            {
                string[] inputArgs = input.Split();
                string command = inputArgs[0];
                int row = int.Parse(inputArgs[1]);
                int col = int.Parse(inputArgs[2]);
                int value = int.Parse(inputArgs[3]);

                if (row >= 0 && row < jaggedArray.Length)
                {
                    if (col >= 0 && col < jaggedArray[row].Length)
                    {
                        if (command=="Add")
                        {
                            jaggedArray[row][col] += value;
                        }
                        else if (command=="Subtract")
                        {
                            jaggedArray[row][col] -= value;
                        }
                    }
                    else continue;
                }
                else continue;
            }

            foreach (var arr in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",arr));
            }
        }
    }
}
