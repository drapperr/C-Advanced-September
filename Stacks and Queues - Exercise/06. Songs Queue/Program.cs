using System;
using System.Collections.Generic;
using System.Linq;


namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songsQueue = new Queue<string>(input);

            while (true)
            {
                string command = Console.ReadLine();

                if (command=="Play")
                {
                    if (songsQueue.Count==1)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                    songsQueue.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    string songName = command.Substring(4);

                    if (!songsQueue.Contains(songName))
                    {
                        songsQueue.Enqueue(songName);
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    List<string> songsInList = new List<string>(songsQueue);
                    Console.WriteLine(string.Join(", ",songsInList));
                }
            }
        }
    }
}
