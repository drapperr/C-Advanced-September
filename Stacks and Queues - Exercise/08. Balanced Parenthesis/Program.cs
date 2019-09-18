using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> leftSide = new Stack<char>(input);
            Stack<char> rightSide = new Stack<char>();

            for (int i = 0; i < input.Length/2; i++)
            {
                char ch = leftSide.Pop();
                if (ch == '{')
                {
                    rightSide.Push('}');
                }
                else if (ch == '}')
                {
                    rightSide.Push('{');
                }
                else if (ch == '[')
                {
                    rightSide.Push(']');
                }
                else if (ch == ']')
                {
                    rightSide.Push('[');
                }
                else if (ch == '(')
                {
                    rightSide.Push(')');
                }
                else if (ch == ')')
                {
                    rightSide.Push('(');
                }
                else
                {
                    rightSide.Push(leftSide.Pop());
                }
            }
            bool balanced = true;

            for (int i = 0; i < input.Length/2; i++)
            {
                if (leftSide.Pop()!=rightSide.Pop())
                {
                    balanced = false;
                    break;
                }
            }

            if (balanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
