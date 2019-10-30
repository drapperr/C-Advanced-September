using System;
using System.Linq;

namespace Workshop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var myList = new DoubleLinkedList<int>();

            for (int i = 0; i < 100; i++)
            {
                myList.AddFirst(i);
            }

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
