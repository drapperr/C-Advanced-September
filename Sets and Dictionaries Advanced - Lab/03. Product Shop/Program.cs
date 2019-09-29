using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            while ((input=Console.ReadLine())!= "Revision")
            {
                var shopArgs = input.Split(", ");
                var shop = shopArgs[0];
                var product = shopArgs[1];
                var price = double.Parse(shopArgs[2]);
                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }
                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop][product] = 0;
                }
                shops[shop][product] = price;
            }
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var kvp in shop.Value)
                {
                    Console.WriteLine($"Product: {kvp.Key}, Price: {kvp.Value}");
                }
            }
        }
    }
}
