using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            string input = string.Empty;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] inputArgs = input.Split();
                string command = inputArgs[0];

                if (command == "add")
                {
                    int firstNum = int.Parse(inputArgs[1]);
                    int secondNum = int.Parse(inputArgs[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (command == "remove")
                {
                    int count = int.Parse(inputArgs[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
