using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOperations = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < countOfOperations; i++)
            {
                string[] input = Console.ReadLine().Split();

                int command = int.Parse(input[0]);

                if (command == 1)
                {
                    string someString = input[1];
                    text.Append(someString);
                    stack.Push(text.ToString());
                }
                else if (command == 2)
                {
                    int count = int.Parse(input[1]);
                    int startIndex = text.Length - count;
                    int length = count;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex + length > text.Length)
                    {
                        length = text.Length;
                    }
                    text.Remove(startIndex, length);
                    stack.Push(text.ToString());
                }
                else if (command == 3)
                {
                    int index = int.Parse(input[1]) - 1;

                    if (index >= 0 && index < text.Length)
                    {
                        Console.WriteLine(text[index]);
                    }
                }
                else if (command == 4)
                {
                    text.Clear();
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                        if (stack.Count > 0)
                        {
                            text.Append(stack.Peek());
                        }
                    }
                }
            }
        }
    }
}
