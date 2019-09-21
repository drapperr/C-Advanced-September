using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            int value = int.Parse(Console.ReadLine());

            int bulletsCounter = 0;
            while (bullets.Count != 0 && locks.Count != 0)
            {
                if (bullets.Pop() <= locks.Peek())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bulletsCounter++;
                if (bulletsCounter % sizeGunBarrel == 0 && bullets.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            if (locks.Count == 0)
            {
                int earnedMoney = value - bulletsCounter * bulletPrice;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedMoney}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
