using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] personInfo = input.Split();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];

                Person person = new Person(name, age, town);

                people.Add(person);
            }

            int positon = int.Parse(Console.ReadLine());
            Person targetPerson = people[positon - 1];
            int matches = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(targetPerson) == 0)
                {
                    matches++;
                }
            }

            if (matches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {people.Count-matches} {people.Count}");
            }
        }
    }
}
