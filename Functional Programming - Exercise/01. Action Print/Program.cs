using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printToConsole = x=> 
            {
                foreach (var name in x.Split(' '))
                {
                    Console.WriteLine(name);
                }
            };
            printToConsole(Console.ReadLine());
        }
    }
}
