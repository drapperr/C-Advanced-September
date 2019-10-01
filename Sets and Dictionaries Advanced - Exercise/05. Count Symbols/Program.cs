using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var charsCount = new SortedDictionary<char, int>();
            var text = Console.ReadLine();

            foreach (var ch in text)
            {
                if (!charsCount.ContainsKey(ch))
                {
                    charsCount.Add(ch, 0);
                }
                charsCount[ch]++;
            }
            foreach (var kvp in charsCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
