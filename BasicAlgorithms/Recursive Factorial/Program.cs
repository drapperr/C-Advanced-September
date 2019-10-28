using System;

namespace Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            long factorial = GetFactorial(number);
            Console.WriteLine(factorial);
        }

        private static long GetFactorial(int number)
        {
            if (number==1)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }
    }
}
