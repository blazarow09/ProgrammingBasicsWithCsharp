using System;

namespace AlchoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double vineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double vinePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);
            double moneyForRakia = rakiaLiters * rakiaPrice;
            double moneyForVine = vineLiters * vinePrice;
            double moneyForBeer = beerLiters * beerPrice;
            double moneyForWhiskey = whiskeyLiters * whiskeyPrice;

            double totalMoneyNeed = moneyForBeer + moneyForRakia + moneyForVine + moneyForWhiskey;

            Console.WriteLine("{0:f2}", totalMoneyNeed);
        }
    }
}
