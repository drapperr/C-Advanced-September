using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirInfo = new Dictionary<string, Dictionary<string, double>>();
            var directoryInfo = new DirectoryInfo(".");
            var allFiles = directoryInfo.GetFiles();

            foreach (var currentFile in allFiles)
            {
                string fileName = currentFile.Name;
                string fileExtension = currentFile.Extension;
                double fileSize = currentFile.Length / 1024.0;

                if (!dirInfo.ContainsKey(fileExtension))
                {
                    dirInfo[fileExtension] = new Dictionary<string, double>();
                }
                dirInfo[fileExtension][fileName] = fileSize;
            }
            dirInfo = dirInfo
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";
            foreach (var (extension, fileInfo) in dirInfo)
            {
                File.AppendAllText(filePath, extension + Environment.NewLine);
                foreach (var (fileName, fileSize) in fileInfo.OrderBy(x => x.Value))
                {
                    File.AppendAllText(filePath, $"--{fileName} - {fileSize:F3}kb{Environment.NewLine}");
                }
            }
        }
    }
}
