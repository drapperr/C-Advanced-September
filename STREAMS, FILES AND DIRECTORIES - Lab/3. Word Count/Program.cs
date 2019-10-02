using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsCounts = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader("words.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string word = reader.ReadLine().ToLower();
                    if (!wordsCounts.ContainsKey(word))
                    {
                        wordsCounts.Add(word, 0);
                    }
                }
            }
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().ToLower().Split(new char[] { ' ','-', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in line)
                    {
                        if (wordsCounts.ContainsKey(word))
                        {
                            wordsCounts[word]++;
                        }
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (var (word, count) in wordsCounts.OrderByDescending(x=>x.Value))
                {
                    writer.WriteLine($"{word} - {count}");
                }
            }
        }
    }
}
