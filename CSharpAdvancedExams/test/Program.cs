using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> input = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Console.WriteLine(string.Join(" ",input));
            Console.WriteLine();
            Console.WriteLine(string.Join(" ",input));
            Console.WriteLine();
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
