using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine()
                .Split(new char[] {',',' ' },StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = firstLine.Skip(1).Select(int.Parse).ToArray();

            CustamStack<int> myStack = new CustamStack<int>(numbers.ToList());

            string input = string.Empty;

            while ((input = Console.ReadLine())!= "END")
            {
                string[] inputArgs = input.Split();
                string command = inputArgs[0];

                switch (command)
                {
                    case "Push":
                        int item = int.Parse(inputArgs[1]);
                        myStack.Push(item);
                        break;
                    case "Pop":
                        try
                        {
                            myStack.Pop();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
            }
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }   
        }
    }
}
