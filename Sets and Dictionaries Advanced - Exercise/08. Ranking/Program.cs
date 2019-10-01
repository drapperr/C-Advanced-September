using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var contestsPasswords = new Dictionary<string, string>();
            var candidatesPoints = new Dictionary<string, Dictionary<string, int>>();

            while ((input=Console.ReadLine())!= "end of contests")
            {
                string[] contestInfo = input.Split(':');
                string contestName = contestInfo[0];
                string contestPassword = contestInfo[1];
                if (!contestsPasswords.ContainsKey(contestName))
                {
                    contestsPasswords[contestName] = contestPassword;
                }
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] contestInfo = input.Split("=>");
                string contestName = contestInfo[0];
                string contestPass = contestInfo[1];
                string userName = contestInfo[2];
                int points = int.Parse(contestInfo[3]);

                if (contestsPasswords.ContainsKey(contestName))
                {
                    if (contestsPasswords[contestName]==contestPass)
                    {
                        if (!candidatesPoints.ContainsKey(userName))
                        {
                            candidatesPoints[userName] = new Dictionary<string, int>();
                        }
                        if (!candidatesPoints[userName].ContainsKey(contestName))
                        {
                            candidatesPoints[userName][contestName] = points;
                        }
                        if (points> candidatesPoints[userName][contestName])
                        {
                            candidatesPoints[userName][contestName] = points;
                        }
                    }
                }
            }
            var bestUser = candidatesPoints
                .OrderByDescending(x => x.Value.Sum(s => s.Value))
                .FirstOrDefault();
            Console.WriteLine($"Best candidate is {bestUser.Key} with total {bestUser.Value.Sum(s => s.Value)} points.");

            Console.WriteLine("Ranking: ");

            foreach (var (userName,contestInfo) in candidatesPoints.OrderBy(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine(userName);
                foreach (var (contest,points) in contestInfo.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }

        }
    }
}
