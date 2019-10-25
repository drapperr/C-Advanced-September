using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> pairs = new List<int>();

            var leftSocks = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            var rightSocks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            while (leftSocks.Count != 0 & rightSocks.Count != 0)
            {
                int leftSock = leftSocks.Peek();
                int rightSock = rightSocks.Peek();

                if (leftSock > rightSock)
                {
                    int pair = leftSocks.Pop() + rightSocks.Dequeue();

                    pairs.Add(pair);
                }
                else if (rightSock > leftSock)
                {
                    leftSocks.Pop();
                }
                else if (rightSock==leftSock)
                {
                    rightSocks.Dequeue();
                    leftSocks.Push(leftSocks.Pop() + 1);
                }
            }
            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ",pairs));
        }
    }
}
