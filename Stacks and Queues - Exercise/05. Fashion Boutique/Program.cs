using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(numbers);

            int counter = 1;

            while (stack.Count != 0)
            {
                int currentSum = stack.Pop();
                while (stack.Count != 0)
                {
                    if (currentSum + stack.Peek() <= capacity)
                    {
                        currentSum += stack.Pop();
                    }
                    else
                    {
                        counter++;
                        break;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
