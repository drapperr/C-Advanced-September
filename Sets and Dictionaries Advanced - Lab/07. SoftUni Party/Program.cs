using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var reservNumbers = new HashSet<string>();
            var vipNumbers = new HashSet<string>();

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipNumbers.Add(input);
                }
                else
                {
                    reservNumbers.Add(input);
                }
            }
            input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                reservNumbers.Remove(input);
                vipNumbers.Remove(input);
            }
            Console.WriteLine(vipNumbers.Count+reservNumbers.Count);
            foreach (var number in vipNumbers)
            {
                Console.WriteLine(number);
            }
            foreach (var number in reservNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
