using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            int pushCount = int.Parse(input[0]);
            int popCount = int.Parse(input[1]);
            int number = int.Parse(input[2]);

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < pushCount; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(number))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count != 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
