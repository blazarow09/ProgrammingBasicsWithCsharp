using System;

namespace Hearthstone
{
    class Program
    {
        static void Main(string[] args)
        {
            double restTime = double.Parse(Console.ReadLine());
            double priceCardPack = double.Parse(Console.ReadLine());
            double priceAdventure = double.Parse(Console.ReadLine());
            double coffeePrice = double.Parse(Console.ReadLine());

            double optionalRest = 5.00;

            double afterCOffeeRest = restTime - optionalRest;
            double timeForCardsBuying = 3 * 2;
            double timeForAdventureBuying = 2 * 2;
            double timeForChilling = afterCOffeeRest - (timeForCardsBuying + timeForAdventureBuying);

            double moneySpendForCards = 3 * priceCardPack;
            double moneySpendForAdventures = 2 * priceAdventure;
            double totalMoneySpend = moneySpendForAdventures + moneySpendForCards + coffeePrice;

            Console.WriteLine("{0:f2}", totalMoneySpend);
            Console.WriteLine("{0:f0}", timeForChilling);
            
        }
    }
}
