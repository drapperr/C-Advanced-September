using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();

            Lake<int> lake = new Lake<int>();
            lake.Add(numbers);

            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
