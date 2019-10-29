using System;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string personName = personInfo[0] + " " + personInfo[1];
            string adress = personInfo[2];
            string town = personInfo[3];

            string[] beerInfo = Console.ReadLine().Split();
            string beerName = beerInfo[0];
            int amountOfBeer = int.Parse(beerInfo[1]);
            bool conditon = beerInfo[2] == "drunk" ? true : false;

            string[] bankInfo = Console.ReadLine().Split();
            string name = bankInfo[0];
            double balance = double.Parse(bankInfo[1]);
            string bankName = bankInfo[2];


            var threeuplePerson = new Threeuple<string, string,string>(personName, adress,town);
            var threeupleBeer = new Threeuple<string, int,bool>(beerName, amountOfBeer,conditon);
            var threeupleBank = new Threeuple<string, double,string>(name, balance,bankName);

            Console.WriteLine(threeuplePerson);
            Console.WriteLine(threeupleBeer);
            Console.WriteLine(threeupleBank);
        }
    }
}
