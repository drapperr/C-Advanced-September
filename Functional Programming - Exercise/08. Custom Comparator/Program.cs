using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> evenNumbers = number.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            List<int> oddNumbers = number.Where(x => x % 2 != 0).OrderBy(x => x).ToList();

            evenNumbers.AddRange(oddNumbers);

            Console.WriteLine(string.Join(" ",evenNumbers));
        }
    }
}
