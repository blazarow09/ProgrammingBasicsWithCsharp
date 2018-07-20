using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double chocoCount= double.Parse(Console.ReadLine());
            double milkCol = double.Parse(Console.ReadLine());

            double priceChoco = 0.65;
            double priceMilk = 2.70;
            double mandarinPrice = 0.20;

            double moneyForChoco = chocoCount * priceChoco;
            double moneyForMilk = milkCol * priceMilk;
            double moneyForMandarin = Math.Floor((chocoCount - chocoCount * 0.35)) * mandarinPrice;

            double totalMoneyNeed = moneyForChoco + moneyForMandarin + moneyForMilk;

            if (budget >= totalMoneyNeed)
            {
                Console.WriteLine($"You got this, {budget - totalMoneyNeed:f2} money left!");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalMoneyNeed - budget:f2} more!");
            }

        }
    }
}
