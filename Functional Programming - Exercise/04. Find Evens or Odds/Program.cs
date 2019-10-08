using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{

    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> predicate = x => x % 2 == 0;

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int startNum = input[0];
            int endNum = input[1];

            List<int> numbers = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                numbers.Add(i);
            }

            string command = Console.ReadLine();

            if (command == "even")
            {
                numbers.RemoveAll(x=>!predicate(x));
            }
            else if (command == "odd")
            {
                numbers.RemoveAll(predicate);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
