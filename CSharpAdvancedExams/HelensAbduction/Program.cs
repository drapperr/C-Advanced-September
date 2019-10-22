using System;

namespace HelensAbduction
{
    class Program
    {
        static int energy;
        static char[][] matrix;
        static PlayerCoordinates paris;
        static PlayerCoordinates helen;
        static void Main(string[] args)
        {
            energy = int.Parse(Console.ReadLine());

            paris = new PlayerCoordinates('P');
            helen = new PlayerCoordinates('H');

            PopulateMatrix();

            while (energy>0)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                int spartanRow = int.Parse(input[1]);
                int spartanCol = int.Parse(input[2]);

                matrix[spartanRow][spartanCol] = 'S';
                matrix[paris.Row][paris.Col] = '-';

                Move(command);
            }

            matrix[paris.Row][paris.Col] = 'X';

            Console.WriteLine($"Paris died at {paris.Row};{paris.Col}.");
            Print();
        }

        private static void Move(string command)
        {
            if (command == "up")
            {
                paris.Row--;

                if (paris.Row == -1)
                {
                    paris.Row = 0;
                }
            }
            else if (command == "down")
            {
                paris.Row++;

                if (paris.Row == matrix.Length)
                {
                    paris.Row = matrix.Length - 1;
                }
            }
            else if (command == "right")
            {
                paris.Col++;

                if (paris.Col == matrix[paris.Row].Length)
                {
                    paris.Col = matrix[paris.Row].Length - 1;
                }
            }
            else if (command == "left")
            {
                paris.Col--;

                if (paris.Col == -1)
                {
                    paris.Col = 0;
                }
            }

            energy--;

            if (matrix[paris.Row][paris.Col] == 'S')
            {
                energy -= 2;

                if (energy <= 0)
                {
                    matrix[paris.Row][paris.Col] = 'X';

                    Console.WriteLine($"Paris died at {paris.Row};{paris.Col}.");
                    Print();
                    Environment.Exit(0);
                }
                else
                {
                    matrix[paris.Row][paris.Col] = 'P';
                }
            }
            else if (matrix[paris.Row][paris.Col] == 'H')
            {
                matrix[paris.Row][paris.Col] = '-';
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
                Print();
                Environment.Exit(0);
            }
        }

        private static void Print()
        {
            foreach (var line in matrix)
            {
                Console.WriteLine(string.Join("",line));
            }
        }

        private static void PopulateMatrix()
        {
            int n = int.Parse(Console.ReadLine());

            matrix = new char[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                string line = Console.ReadLine();
                matrix[row] = new char[line.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = line[col];

                    if (line[col] == 'P')
                    {
                        paris.Row = row;
                        paris.Col = col;
                    }

                    if (line[col] == 'H')
                    {
                        helen.Row = row;
                        helen.Col = col;
                    }
                }
            }
        }
    }
    class PlayerCoordinates
    {
        public PlayerCoordinates(char symbol)
        {
            Symbol = symbol;
        }

        public char Symbol { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
