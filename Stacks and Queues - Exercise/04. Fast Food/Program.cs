using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(input);
            int biggestOrder = orders.Max();

            while (orders.Count != 0)
            {
                if (quantity - orders.Peek() >= 0)
                {
                    quantity -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (biggestOrder != -1)
            {
                Console.WriteLine(biggestOrder);
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(" ", orders));
            }
        }
    }
}
