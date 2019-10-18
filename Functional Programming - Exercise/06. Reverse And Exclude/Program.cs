using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> noDevisible = (x, y) => x % y != 0;

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToList();
            int divider = int.Parse(Console.ReadLine());

            numbers = numbers.Where(x=>noDevisible(x,divider)).ToList();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
