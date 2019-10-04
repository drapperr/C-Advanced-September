using System;
using System.IO.Compression;

namespace Problem_6._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(Environment.CurrentDirectory, @"..\..\..\zipFile.zip");
            ZipFile.ExtractToDirectory(@"..\..\..\zipFile.zip", @"..\..\..\unzipped");
        }
    }
}
