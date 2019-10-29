namespace GenericBox
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var box = new Box<double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input =double.Parse( Console.ReadLine());

                box.Add(input);
            }

            var targetValue =double.Parse( Console.ReadLine());

            Console.WriteLine(box.CountOfLargerElements(targetValue));
        }
    }
}
