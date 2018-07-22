using System;

namespace SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodMoneyPerDay = double.Parse(Console.ReadLine());
            double souvenirMoneyPerDay = double.Parse(Console.ReadLine());
            double hotelMoney = double.Parse(Console.ReadLine());

            double moneyForPetrol = 54.39;

            double moneyForFoodAndSouvenirs = 3 * foodMoneyPerDay + 3 * souvenirMoneyPerDay;

            double firstDayDiscount = hotelMoney * 0.9;
            double secondDayDiscount = hotelMoney * 0.85;
            double thirdDayDiscount = hotelMoney * 0.8;

            double total = moneyForPetrol + moneyForFoodAndSouvenirs + firstDayDiscount + secondDayDiscount + thirdDayDiscount;

            Console.WriteLine($"Money needed: {total:f2}");
        }
    }
}
