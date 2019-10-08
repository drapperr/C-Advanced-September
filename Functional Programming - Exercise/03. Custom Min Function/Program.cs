using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string,int> getSmallest = x=>x.Split(' ').Select(int.Parse).Min();
            Console.WriteLine(getSmallest(Console.ReadLine())); ;
        }
    }
}
