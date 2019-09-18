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
            Stack<char> stack = new Stack<char>();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (char ch in input)
            {
                switch (ch)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(ch);
                        break;
                    default:
                        if ((ch == ')' || ch == '}' || ch == ']') && stack.Count > 0)
                        {
                            if (stack.Peek() == '(' && ch == ')' || stack.Peek() == '{' && ch == '}' || stack.Peek() == '[' && ch == ']')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine("YES");

        }
    }
}
