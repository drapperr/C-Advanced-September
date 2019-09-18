using System;
using System.Collections.Generic;

namespace _6._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> kids = new Queue<string>(input);
            int count = int.Parse(Console.ReadLine());

            while (kids.Count > 1)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
