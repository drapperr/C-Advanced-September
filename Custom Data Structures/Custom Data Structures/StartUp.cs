using System;

namespace Custom_Data_Structures
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new CustomList();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            Console.WriteLine(list);
        }
    }
}
