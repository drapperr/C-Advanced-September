using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var jaggedArr = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                jaggedArr[i] = line;
            }
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitedInput = input.Split(' ');
                string command = splitedInput[0];
                int row = int.Parse(splitedInput[1]);
                int col = int.Parse(splitedInput[2]);
                int value = int.Parse(splitedInput[3]);

                if (row < 0 || row >= jaggedArr.Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (col < 0 || col >= jaggedArr[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (command== "Add")
                {
                    jaggedArr[row][col] += value;
                }
                else if (command== "Subtract")
                {
                    jaggedArr[row][col] -= value;
                }
            }
            foreach (var arr in jaggedArr)
            {
                foreach (var number in arr)
                {
                    Console.Write(number+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
