using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string personName = personInfo[0] + " " + personInfo[1];
            string adress = personInfo[2];

            string[] beerInfo = Console.ReadLine().Split();
            string name = beerInfo[0];
            int amountOfBeer = int.Parse(beerInfo[1]);

            string[] nums = Console.ReadLine().Split();
            int intNum = int.Parse(nums[0]);
            double doubleNum = double.Parse(nums[1]);

            var tuplePerson = new Tuple<string,string>(personName, adress);
            var tupleBeer = new Tuple<string,int>(name, amountOfBeer);
            var tupleNums = new Tuple<int,double>(intNum, doubleNum);

            Console.WriteLine(tuplePerson);
            Console.WriteLine(tupleBeer);
            Console.WriteLine(tupleNums);
        }
    }
}
