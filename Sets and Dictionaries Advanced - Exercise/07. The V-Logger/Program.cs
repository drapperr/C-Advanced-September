using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vLoggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string input = string.Empty;

            while ((input=Console.ReadLine())!= "Statistics")
            {
                string[] splitedInput = input.Split(' ');
                string command = splitedInput[1];

                if (command=="joined")
                {
                    string userName = splitedInput[0];
                    if (!vLoggers.ContainsKey(userName))
                    {
                        vLoggers.Add(userName, new Dictionary<string, SortedSet<string>>());
                        vLoggers[userName]["followed"] = new SortedSet<string>();
                        vLoggers[userName]["followers"] = new SortedSet<string>();
                    }
                }
                else if (command=="followed")
                {
                    string followerName = splitedInput[0];
                    string userName = splitedInput[2];
                    if (vLoggers.ContainsKey(followerName)
                        &&vLoggers.ContainsKey(userName)
                        &&followerName!=userName)
                    {
                        vLoggers[followerName]["followed"].Add(userName);
                        vLoggers[userName]["followers"].Add(followerName);
                    }
                }
            }
            vLoggers = vLoggers
                    .OrderByDescending(x => x.Value["followers"].Count)
                    .ThenBy(x => x.Value["followed"].Count)
                    .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"The V-Logger has a total of {vLoggers.Count} vloggers in its logs.");

            int counter = 1;

            foreach (var (vLoggerName, vLoggerInfo) in vLoggers)
            {
                int followers = vLoggerInfo["followers"].Count;
                int followings = vLoggerInfo["followed"].Count;

                Console.WriteLine($"{counter}. {vLoggerName} : {followers} followers, {followings} following");

                if (counter == 1)
                {
                    foreach (var follower in vLoggerInfo["followers"])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                counter++;
            }
        }
    }
}
 