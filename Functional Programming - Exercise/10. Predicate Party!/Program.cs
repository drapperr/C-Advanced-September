using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, bool> startWithFunc = (x, y) => x.StartsWith(y);
            Func<string, string, bool> endsWithFunc = (x, y) => x.EndsWith(y);
            Func<string, int, bool> lengthFunc = (x, y) => x.Length == y;

            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] inputArgs = input.Split();
                string command = inputArgs[0];
                string condition = inputArgs[1];
                string param = inputArgs[2];

                if (command == "Remove")
                {
                    if (condition == "StartsWith")
                    {
                        names = names.Where(x => !startWithFunc(x, param)).ToList();
                    }
                    else if (condition == "EndsWith")
                    {
                        names = names.Where(x => !endsWithFunc(x, param)).ToList();
                    }
                    else if (condition == "Length")
                    {
                        int length = int.Parse(param);
                        names = names.Where(x => !lengthFunc(x, length)).ToList();
                    }
                }
                else if (command == "Double")
                {
                    List<string> tempNames = new List<string>();

                    if (condition == "StartsWith")
                    {
                        tempNames = names.Where(x => startWithFunc(x, param)).ToList();
                    }
                    else if (condition == "EndsWith")
                    {
                        tempNames = names.Where(x => endsWithFunc(x, param)).ToList();
                    }
                    else if (condition == "Length")
                    {
                        int length = int.Parse(param);
                        tempNames = names.Where(x => lengthFunc(x, length)).ToList();
                    }

                    foreach (var currentName in tempNames)
                    {
                        int index = names.IndexOf(currentName);
                        names.Insert(index,currentName);
                    }
                }
            }
            if (names.Count==0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ",names)} are going to the party!");
            }
        }
    }
}
