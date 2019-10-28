using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> stratsWithFilter = new HashSet<string>();
            HashSet<string> endsWithFilter = new HashSet<string>();
            HashSet<string> lengthFilter = new HashSet<string>();
            HashSet<string> containsFilter = new HashSet<string>();

            List<string> names = Console.ReadLine()
                .Split()
                .ToList();
            string input = string.Empty;

            while ((input=Console.ReadLine())!="Print")
            {
                string[] inputArgs = input.Split(';');
                string command = inputArgs[0];
                string condition = inputArgs[1];
                string param = inputArgs[2];

                if (command== "Add filter")
                {
                    if (condition== "Starts with")
                    {
                        stratsWithFilter.Add(param);
                    }
                    else if (condition == "Ends with")
                    {
                        endsWithFilter.Add(param);
                    }
                    else if (condition == "Length")
                    {
                        lengthFilter.Add(param);
                    }
                    else if (condition == "Contains")
                    {
                        containsFilter.Add(param);
                    }
                }
                else if (command== "Remove filter")
                {
                    if (condition == "Starts with")
                    {
                        stratsWithFilter.Remove(param);
                    }
                    else if (condition == "Ends with")
                    {
                        endsWithFilter.Remove(param);
                    }
                    else if (condition == "Length")
                    {
                        lengthFilter.Remove(param);
                    }
                    else if (condition == "Contains")
                    {
                        containsFilter.Remove(param);
                    }
                }
            }
            foreach (var item in stratsWithFilter)
            {
                names = names.Where(x => !x.StartsWith(item)).ToList();
            }
            foreach (var item in endsWithFilter)
            {
                names = names.Where(x => !x.EndsWith(item)).ToList();
            }
            foreach (var item in lengthFilter)
            {
                names = names.Where(x => x.Length!=int.Parse(item)).ToList();
            }
            foreach (var item in containsFilter)
            {
                names = names.Where(x => !x.Contains(item)).ToList();
            }
            Console.WriteLine(string.Join(" ",names));
        }
    }
}
