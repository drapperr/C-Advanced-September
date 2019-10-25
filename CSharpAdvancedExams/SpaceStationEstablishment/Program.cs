using System;

namespace SpaceStationEstablishment
{
    class Program
    {
        private static char[,] galaxy;
        private static Coordinates stephen;
        private static Coordinates o1;
        private static Coordinates o2;
        static void Main(string[] args)
        {
            int stars = 0;

            PopulateGalaxy();

            while (stars < 50)
            {
                string direction = Console.ReadLine();

                galaxy[stephen.Row, stephen.Col] = '-';
                Move(direction);

                if (InGalaxy())
                {
                    if (char.IsDigit(galaxy[stephen.Row, stephen.Col]))
                    {
                        stars += int.Parse(galaxy[stephen.Row, stephen.Col].ToString());

                    }
                    else if (galaxy[stephen.Row, stephen.Col] == 'O')
                    {
                        galaxy[stephen.Row, stephen.Col] = '-';

                        if (stephen.Row == o1.Row && stephen.Col == o1.Col)
                        {
                            stephen.Row = o2.Row;
                            stephen.Col = o2.Col;
                        }
                        else
                        {
                            stephen.Row = o1.Row;
                            stephen.Col = o1.Col;
                        }
                    }
                    galaxy[stephen.Row, stephen.Col] = 'S';
                }
                else
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    Console.WriteLine($"Star power collected: {stars}");
                    PrintGalaxy();
                    return;
                }
            }
            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            Console.WriteLine($"Star power collected: {stars}");
            PrintGalaxy();
        }

        private static void PrintGalaxy()
        {
            for (int row = 0; row < galaxy.GetLength(0); row++)
            {
                for (int col = 0; col < galaxy.GetLength(1); col++)
                {
                    Console.Write(galaxy[row,col]);
                }
                Console.WriteLine();
            }
        }

        public static void Move(string direction)
        {
            if (direction == "up")
            {
                stephen.Row--;
            }
            else if (direction == "down")
            {
                stephen.Row++;
            }
            else if (direction == "left")
            {
                stephen.Col--;
            }
            else if (direction == "right")
            {
                stephen.Col++;
            }
        }

        public static bool InGalaxy()
        {
            if (stephen.Row < 0 || stephen.Row >= galaxy.GetLength(0)
                || stephen.Col < 0 || stephen.Col >= galaxy.GetLength(1))
            {
                return false;
            }
            return true;
        }

        public static void PopulateGalaxy()
        {
            int size = int.Parse(Console.ReadLine());

            galaxy = new char[size, size];

            int oCounter = 0;

            for (int row = 0; row < galaxy.GetLength(0); row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < galaxy.GetLength(1); col++)
                {
                    galaxy[row, col] = line[col];

                    if (line[col] == 'S')
                    {
                        stephen = new Coordinates('S', row, col);
                    }
                    else if (line[col] == 'O')
                    {
                        if (oCounter == 0)
                        {
                            o1 = new Coordinates('O', row, col);
                        }
                        else
                        {
                            o2 = new Coordinates('O', row, col);
                        }
                    }
                }
            }
        }
        public class Coordinates
        {
            public Coordinates(char symbol, int row, int col)
            {
                Symbol = symbol;
                Row = row;
                Col = col;
            }

            public char Symbol { get; set; }
            public int Row { get; set; }
            public int Col { get; set; }
        }
    }
}
