using System;
using System.IO;

namespace _4._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                using (StreamReader reader1 = new StreamReader("inputText1.txt"))
                {
                    using (StreamReader reader2 = new StreamReader("inputText2.txt"))
                    {
                        while (!reader1.EndOfStream)
                        {
                            string text1Line = reader1.ReadLine();
                            string text2Line = reader2.ReadLine();
                            writer.WriteLine(text1Line);
                            writer.WriteLine(text2Line);
                        }
                    }
                }
            }
        }
    }
}
