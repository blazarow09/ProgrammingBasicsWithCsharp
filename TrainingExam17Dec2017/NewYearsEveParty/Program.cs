using System;

namespace NewYearsEveParty
{
    using System;

    namespace NewYearsEveParty
    {
        class Program
        {
            static void Main(string[] args)
            {
                double countGuests = double.Parse(Console.ReadLine());
                double IvanoviBudged = double.Parse(Console.ReadLine());


                double couvertPrice = 20;
                double sumCouvert = couvertPrice * countGuests;

                if (sumCouvert < IvanoviBudged)
                {

                    double moneyLeft = IvanoviBudged - sumCouvert;
                    double moneyForFireworks = moneyLeft * 0.40;
                    double moneyForDonations = moneyLeft - moneyForFireworks;
                    Console.WriteLine("Yes! {0:f0} lv are for fireworks and {1:f0} lv are for donation.", moneyForFireworks, moneyForDonations);
                }
                else if (sumCouvert > IvanoviBudged)
                {
                    double notEnoughMoney = sumCouvert - IvanoviBudged;
                    Console.WriteLine("They won't have enough money to pay the covert. They will need {0:f0} lv more.", notEnoughMoney);
                }

            }
        }
    }
}