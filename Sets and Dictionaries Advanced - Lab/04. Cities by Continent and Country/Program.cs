﻿using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, Dictionary<string,List<string>>>();
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var cityArgs = Console.ReadLine().Split(" ");
                var continent = cityArgs[0];
                var country = cityArgs[1];
                var city = cityArgs[2];
                if (!cities.ContainsKey(continent))
                {
                    cities[continent] = new Dictionary<string,List<string>>();
                }
                if (!cities[continent].ContainsKey(country))
                {
                    cities[continent][country] = new List<string>();
                }
                cities[continent][country].Add(city);
            }
            foreach (var continent in cities)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
