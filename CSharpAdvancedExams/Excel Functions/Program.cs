using System;
using System.Collections.Generic;
using System.Linq;

namespace Excel_Functions
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());

            string[][] matrix = new string[lines - 1][];

            string[] header = Console.ReadLine().Split(", ");

            for (int i = 0; i < lines - 1; i++)
            {
                string[] currentLine = Console.ReadLine().Split(", ");
                matrix[i] = currentLine;
            }

            string[] commandInfo = Console.ReadLine().Split();

            string command = commandInfo[0];
            string targetHeader = commandInfo[1];
            int indexOfTarget = -1;

            for (int i = 0; i < header.Length; i++)
            {
                if (header[i] == targetHeader)
                {
                    indexOfTarget = i;
                }
            }

            string[][] result = new string[lines - 1][];

            if (command == "hide")
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    List<string> line = new List<string>();

                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (j != indexOfTarget)
                        {
                            line.Add(matrix[i][j]);
                        }
                    }
                    result[i] = line.ToArray();
                }
                header = header.Where(x => x != targetHeader).ToArray();
            }
            else if (command == "sort")
            {
                result=matrix.OrderBy(x=>x[indexOfTarget]).ToArray();
            }
            else if (command == "filter")
            {
                string value = commandInfo[2];
                result = matrix.Where(x => x[indexOfTarget] == value).ToArray();
            }

            Console.WriteLine(string.Join(" | ", header));
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(string.Join(" | ",result[i]));
            }
        }
    }
}
