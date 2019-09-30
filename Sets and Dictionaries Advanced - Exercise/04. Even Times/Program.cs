using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var countsOfNumbers = new Dictionary<int,int>();

            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (!countsOfNumbers.ContainsKey(number))
                {
                    countsOfNumbers.Add(number, 0);
                }
                countsOfNumbers[number]++;
            }
            foreach (var kvp in countsOfNumbers)
            {
                if (kvp.Value%2==0)
                {
                    Console.WriteLine(kvp.Key);
                    return;
                }
            }
        }
    }
}
