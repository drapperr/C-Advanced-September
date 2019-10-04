using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textLines = File.ReadAllLines("text.txt");
            string[] words = File.ReadAllLines("words.txt");

            var wordsCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordsCounts.ContainsKey(word.ToLower()))
                {
                    wordsCounts.Add(word.ToLower(), 0);
                }
            }

            foreach (var currentLine in textLines)
            {
                string[] line = currentLine.ToLower().Split(new char[] { ' ', '-', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in line)
                {
                    if (wordsCounts.ContainsKey(word))
                    {
                        wordsCounts[word]++;
                    }
                }
            }

            foreach (var (word, count) in wordsCounts)
            {
                File.AppendAllText("actualResult.txt", $"{word} - {count}{Environment.NewLine}");
            }

            foreach (var (word, count) in wordsCounts.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText("expectedResult.txt", $"{word} - {count}{Environment.NewLine}");
            }
        }
    }
}
