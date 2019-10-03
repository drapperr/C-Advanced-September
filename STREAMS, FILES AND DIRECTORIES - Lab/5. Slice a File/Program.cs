using System;
using System.IO;

namespace _5._Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo("text.txt");
            long lenghtOfOnePart = fileInfo.Length / 4;
            long lenghtOfLastPart = lenghtOfOnePart + fileInfo.Length % 4;

            int counter = 1;

            using (StreamReader reader = new StreamReader("text.txt"))
            {
                while (!reader.EndOfStream)
                {
                    long bufferLength = lenghtOfOnePart;
                    if (counter == 4)
                    {
                        bufferLength = lenghtOfLastPart;
                    }
                    char[] buffer = new char[bufferLength];
                    reader.Read(buffer);
                    using (StreamWriter writer = new StreamWriter($"Part-{counter}.txt"))
                    {
                        writer.Write(buffer);
                    }
                    counter++;
                }
            }
        }
    }
}
