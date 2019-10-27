using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> func = (x, y) => x % y != 0;

            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            List<int> resultNumbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                resultNumbers.Add(i);
            }

            foreach (var divider in dividers)
            {
                resultNumbers.RemoveAll(x => func(x, divider));
            }

            Console.WriteLine(string.Join(" ",resultNumbers));
        }
    }
}
