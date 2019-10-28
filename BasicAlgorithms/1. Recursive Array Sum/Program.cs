using System;
using System.Linq;

namespace _1._Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = SumArray(numbers);

            Console.WriteLine(sum);
        }

        private static int SumArray(int[] numbers,int i=0)
        {
            if (i==numbers.Length)
            {
                return 0;
            }
            int currentSum = numbers[i];
            return currentSum + SumArray(numbers,++i);
        }
    }
}
