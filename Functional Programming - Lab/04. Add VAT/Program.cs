using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(x=>x*1.2)
                .ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,prices.Select(x=>$"{x:f2}")));
        }
    }
}
