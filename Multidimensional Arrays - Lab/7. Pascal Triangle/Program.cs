using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var jaggedArr = new int[num][];
            jaggedArr[0] = new int[]{ 1};

            for (int i = 1; i < num; i++)
            {
                jaggedArr[i] = new int[i + 1];
                jaggedArr[i][0] = 1;
                jaggedArr[i][jaggedArr[i].Length - 1] = 1;

                for (int j = 1; j < jaggedArr[i].Length-1; j++)
                {
                    jaggedArr[i][j] = jaggedArr[i - 1][j] + jaggedArr[i - 1][j - 1];
                }
            }
            foreach (var arr in jaggedArr)
            {
                Console.WriteLine(string.Join(" ",arr));
            }
        }
    }
}
