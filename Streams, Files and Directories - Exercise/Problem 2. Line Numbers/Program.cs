using System;
using System.IO;
using System.Linq;

namespace Problem_2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadLines(@"text.txt");
            int lineNum = 1;
            foreach (string line in text)
            {

                int letters = line.Count(char.IsLetter);
                int puncs = line.Count(char.IsPunctuation);

                File.AppendAllText("output.txt",$"Line {lineNum}: {line} ({letters})({puncs}){Environment.NewLine}");

                lineNum++;
            }
        }
    }
}
