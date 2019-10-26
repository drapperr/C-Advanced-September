using System;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> females = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int matches = 0;

            while (males.Count > 0 && females.Count > 0)
            {
                int currentMale = males.Peek();
                int currentFemale = females.Peek();

                if (currentMale <= 0)
                {
                    males.Pop();
                    continue;
                }

                if (currentFemale <= 0)
                {
                    females.Dequeue();
                    continue;
                }

                if (currentMale % 25 == 0)
                {
                    males.Pop();
                    if (males.Count > 0)
                    {
                        males.Pop();
                    }
                    continue;
                }

                if (currentFemale % 25 == 0)
                {
                    females.Dequeue();
                    if (females.Count > 0)
                    {
                        females.Dequeue();
                    }
                    continue;
                }

                if (currentMale == currentFemale)
                {
                    males.Pop();
                    females.Dequeue();
                    matches++;
                    continue;
                }
                else
                {
                    males.Pop();
                    females.Dequeue();
                    males.Push(currentMale - 2);
                }
            }
            Console.WriteLine($"Matches: {matches}");

            Console.Write("Males left: ");
            if (males.Count == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                Console.WriteLine(string.Join(", ", males));
            }

            Console.Write("Females left: ");
            if (females.Count == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                Console.WriteLine(string.Join(", ", females));
            }
        }
    }
}
