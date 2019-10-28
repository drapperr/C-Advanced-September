using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        Dictionary<int, int> coinsCounts = new Dictionary<int, int>();

        coins = coins.OrderByDescending(x => x).ToList();

        while (targetSum != 0)
        {
            int currentSum = targetSum;

            foreach (var coin in coins)
            {
                if (targetSum - coin >= 0)
                {
                    targetSum -= coin;

                    if (!coinsCounts.ContainsKey(coin))
                    {
                        coinsCounts[coin] = 0;
                    }

                    coinsCounts[coin]++;

                    break;
                }
            }

            if (currentSum == targetSum && targetSum != 0)
            {
                Console.WriteLine("Error");
                Environment.Exit(0);
            }
        }

        return coinsCounts;
    }
}