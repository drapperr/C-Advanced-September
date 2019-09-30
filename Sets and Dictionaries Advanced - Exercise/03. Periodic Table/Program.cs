using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var periodicTable = new SortedSet<string>();

            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine().Split(' ');
                foreach (var element in line)
                {
                    periodicTable.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ",periodicTable));
        }
    }
}
