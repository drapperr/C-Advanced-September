using System;

namespace Tron_Racers
{
    class Program
    {
        private static char[,] matrix;
        static void Main(string[] args)
        {
            PlayerCoordinates firstPlayer = new PlayerCoordinates('f');
            PlayerCoordinates secondPlayer = new PlayerCoordinates('s');

            int sizeOfMatrix = int.Parse(Console.ReadLine());

            matrix = new char[sizeOfMatrix, sizeOfMatrix];
            PopulateMatrix(firstPlayer, secondPlayer);

            while (true)
            {
                string[] inputCommands = Console.ReadLine().Split();
                string firstPlayerCommand = inputCommands[0];
                string secondPlayerCommand = inputCommands[1];

                Move(firstPlayerCommand, firstPlayer);
                Move(secondPlayerCommand, secondPlayer);
            }
        }

        private static void Move(string command, PlayerCoordinates player)
        {
            if (command == "up")
            {
                player.Row--;

                if (player.Row < 0)
                {
                    player.Row = matrix.GetLength(0) - 1;
                }
            }
            else if (command == "down")
            {
                player.Row++;

                if (player.Row > matrix.GetLength(0) - 1)
                {
                    player.Row = 0;
                }
            }
            else if (command == "left")
            {
                player.Col--;

                if (player.Col < 0)
                {
                    player.Col = matrix.GetLength(1) - 1;
                }
            }
            else if (command == "right")
            {
                player.Col++;

                if (player.Col > matrix.GetLength(1) - 1)
                {
                    player.Col = 0;
                }
            }

            if (matrix[player.Row, player.Col] == '*')
            {
                matrix[player.Row, player.Col] = player.symbol;
            }
            else
            {
                matrix[player.Row, player.Col] = 'x';
                Print();
                Environment.Exit(0);
            }
        }

        private static void Print()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void PopulateMatrix(PlayerCoordinates firstPlayer, PlayerCoordinates secondPlayer)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string inputLine = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputLine[col];

                    if (inputLine[col] == 'f')
                    {
                        firstPlayer.Row = row;
                        firstPlayer.Col = col;
                    }
                    else if (inputLine[col] == 's')
                    {
                        secondPlayer.Row = row;
                        secondPlayer.Col = col;
                    }
                }
            }
        }
    }
    public class PlayerCoordinates
    {
        public PlayerCoordinates(char symbol)
        {
            this.symbol = symbol;
        }

        public int Row { get; set; }
        public int Col { get; set; }
        public char symbol { get; set; }
    }
}
