using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printToConsole = x =>
            {
                foreach (var name in x.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                {
                    Console.WriteLine("Sir " + name);
                }
            };
            printToConsole(Console.ReadLine());
        }
    }
}
