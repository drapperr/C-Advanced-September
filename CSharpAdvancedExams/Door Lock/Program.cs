using System;
using System.Collections.Generic;

namespace Door_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());

            Stack<string> input = new Stack<string>(Console.ReadLine().Split());

            Queue<string> halls = new Queue<string>();
            Queue<int> people = new Queue<int>();

            int sumOfPeople = 0;

            while (input.Count > 0)
            {
                string currentValue = input.Pop();

                if (int.TryParse(currentValue, out int currentPeople))
                {
                    if (sumOfPeople + currentPeople <= maxCapacity)
                    {
                        sumOfPeople += currentPeople;
                        people.Enqueue(currentPeople);
                    }
                    else if (people.Count != 0 && halls.Count != 0)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", people)}");

                        people.Clear();

                        sumOfPeople = currentPeople;
                        people.Enqueue(currentPeople);
                    }
                }
                else
                {
                    if (halls.Count==0)
                    {
                        people.Clear();
                        sumOfPeople = 0;
                    }
                    halls.Enqueue(currentValue);
                }
            }
        }
    }
}
