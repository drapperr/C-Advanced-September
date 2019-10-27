using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string,int, bool> func = (x,y) => x.Length <= y;

            int maxLenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            List<string> filtredNames = names.Where(x => func(x, maxLenght)).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,filtredNames));
        }
    }
}
