using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            int wastedWater = 0;

            while (cups.Count>0)
            {
                int currentCup = cups.Peek();
                int currentBottle = 0;

                if (bottles.Count > 0)
                {
                    currentBottle = bottles.Pop();
                }
                else break;

                int currentWastedWater = currentBottle - currentCup;

                while (currentWastedWater<0)
                {
                    if (bottles.Count > 0)
                    {
                        currentWastedWater += bottles.Pop();
                    }
                    else break;
                }
                if (currentWastedWater >= 0)
                {
                    wastedWater += currentWastedWater;
                }
                else break;
                cups.Dequeue();
            }
            if (cups.Count!=0)
            {
                Console.Write("Cups: ");
                Console.WriteLine(string.Join(" ",cups));
            }
            else
            {
                Console.Write("Bottles: ");
                Console.WriteLine(string.Join(" ",bottles));
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
