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

            using (StreamReader reader = new StreamReader("text.txt"))
            {
                int lineNum = 0;
                while (!reader.EndOfStream)
                {
                    StringBuilder line = new StringBuilder(reader.ReadLine());

                    if (lineNum % 2 == 0)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (symbols.Contains(line[i]))
                            {
                                line[i] = '@';
                            }
                        }
                        Console.WriteLine(string.Join(" ", line.ToString().Split(' ').Reverse()));
                    }
                    lineNum++;
                }
            }
        }
    }
}
