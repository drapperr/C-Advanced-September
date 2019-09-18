using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            List<string> passedCars = new List<string>();

            int count = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    int currentCount = Math.Min(queue.Count, count);
                    for (int i = 0; i < currentCount; i++)
                    {
                        passedCars.Add(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, passedCars.Select(x => $"{x} passed!")));
            Console.WriteLine($"{passedCars.Count} cars passed the crossroads.");
        }
    }
}
