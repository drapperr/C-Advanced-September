using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string opr = stack.Pop();
                int secondNum = int.Parse(stack.Pop());

                if (opr == "+")
                {
                    stack.Push($"{firstNum + secondNum}");
                }
                else if (opr == "-")
                {
                    stack.Push($"{firstNum - secondNum}");
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
