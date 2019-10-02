using System;
using System.IO;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    int counter = 1;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        writer.WriteLine($"{counter}. {line}");
                        counter++;
                    }
                }
            }
        }
    }
}
