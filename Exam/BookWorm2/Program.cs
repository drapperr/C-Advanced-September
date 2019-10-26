using System;
using System.Text;

namespace BookWorm
{
    class Program
    {
        static StringBuilder myString;
        static char[][] matrix;
        static int playerRow;
        static int playerCol;
        static void Main(string[] args)
        {
            myString = new StringBuilder();
            myString.Append(Console.ReadLine());

            PopulateMatrix();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                matrix[playerRow][playerCol] = '-';

                bool isOutside = false;

                if (command == "down")
                {
                    if (playerRow + 1 >= matrix.Length)
                    {
                        isOutside = true;
                    }
                    else
                    {
                        playerRow++;
                    }
                }
                else if (command == "up")
                {
                    if (playerRow - 1 < 0)
                    {
                        isOutside = true;
                    }
                    else
                    {
                        playerRow--;
                    }
                }
                else if (command == "right")
                {
                    if (playerCol + 1 >= matrix[playerRow].Length)
                    {
                        isOutside = true;
                    }
                    else
                    {
                        playerCol++;
                    }
                }
                else if (command == "left")
                {
                    if (playerCol - 1 < 0)
                    {
                        isOutside = true;
                    }
                    else
                    {
                        playerCol--;
                    }
                }

                if (isOutside&&myString.Length>0)
                {
                    myString.Remove(myString.Length - 1, 1);
                }
                else if(matrix[playerRow][playerCol]!='-')
                {
                    myString.Append(matrix[playerRow][playerCol]);
                }

                matrix[playerRow][playerCol] = 'P';
            }

            Console.WriteLine(myString);

            PrintMatrix();
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join("",matrix[row]));
            }
        }

        private static void PopulateMatrix()
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            for (int row = 0; row < matrix.Length; row++)
            {
                string line = Console.ReadLine();

                matrix[row] = new char[line.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = line[col];

                    if (line[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
