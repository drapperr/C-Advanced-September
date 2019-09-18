using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "1")
                {
                    int number = int.Parse(input[1]);
                    stack.Push(number);
                }
                else if (input[0] == "2" && stack.Count != 0)
                {
                    stack.Pop();
                }
                else if (input[0] == "3" && stack.Count != 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (input[0] == "4" && stack.Count != 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
