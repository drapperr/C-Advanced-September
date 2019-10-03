using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Problem_1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = new char[] { '-', ',', '.', '!', '?' };
            int lineNum = 0;
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split(' ');
                    if (lineNum % 2 == 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(string.Join(" ", line.Reverse()));
                        for (int i = 0; i < sb.Length; i++)
                        {
                            if (symbols.Contains(sb[i]))
                            {
                                sb[i] = '@';
                            }
                        }
                        Console.WriteLine(sb);
                    }
                    lineNum++;
                }
            }
        }
    }
}
