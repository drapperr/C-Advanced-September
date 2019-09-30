using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var setsCounts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var firstSetCount = setsCounts[0];
            var secondSetCount = setsCounts[1];
            var firstSet = new HashSet<int>();
            var repeatSet = new HashSet<int>();
            for (int i = 0; i < firstSetCount; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < secondSetCount; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (firstSet.Contains(number))
                {
                    repeatSet.Add(number);
                }
            }
            foreach (var number in firstSet)
            {
                if (repeatSet.Contains(number))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
