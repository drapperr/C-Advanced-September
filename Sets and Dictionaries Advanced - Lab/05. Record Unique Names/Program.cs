using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var uniNames = new HashSet<string>();
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                uniNames.Add(Console.ReadLine());
            }
            foreach (var name in uniNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
