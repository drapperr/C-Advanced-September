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

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < pushCount; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < popCount; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(number))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count != 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
