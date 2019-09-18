using System;
using System.Collections.Generic;

namespace _5._Supermarket_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            List<string> names = new List<string>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        names.Add(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
