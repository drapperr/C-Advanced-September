using System;
using System.IO;

namespace _6.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"..\..\..\TestFolder");
            var files =directoryInfo.GetFiles();
            long sum = 0;
            foreach (var file in files)
            {
                sum+=file.Length;
            }
            Console.WriteLine(sum/1024.0/1024.0);
        }
    }
}
