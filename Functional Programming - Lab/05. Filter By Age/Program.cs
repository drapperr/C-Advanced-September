using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string currentName = input[0];
                int currentAge = int.Parse(input[1]);

                if (!people.ContainsKey(currentName))
                {
                    people[currentName] = 0;
                }
                people[currentName] = currentAge;
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (condition == "older")
            {
                people = people
                    .Where(x => x.Value >= age)
                    .ToDictionary(x => x.Key, x => x.Value);
            }
            else if (condition == "younger")
            {
                people = people
                    .Where(x => x.Value < age)
                    .ToDictionary(x => x.Key, x => x.Value);
            }
            string format = Console.ReadLine();

            foreach (var (currentName, currentAge) in people)
            {
                if (format == "name")
                {
                    Console.WriteLine(currentName);
                }
                else if (format == "age")
                {
                    Console.WriteLine(currentAge);

                }
                else if (format == "name age")
                {
                    Console.WriteLine($"{currentName} - {currentAge}");

                }
            }
            
        }
    }
}
