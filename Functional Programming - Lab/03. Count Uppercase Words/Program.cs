using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            var sortedWords = words.Where(x => char.IsUpper(x[0]));
            Console.WriteLine(string.Join(Environment.NewLine,sortedWords));
        }
    }
}
