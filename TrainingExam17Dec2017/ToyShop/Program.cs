using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrize = double.Parse(Console.ReadLine());
            double puzzle = double.Parse(Console.ReadLine());
            double dols = double.Parse(Console.ReadLine());
            double bears = double.Parse(Console.ReadLine());
            double minions = double.Parse(Console.ReadLine());
            double miniTrucks = double.Parse(Console.ReadLine());

            double puzzlePrice = 2.60;
            double dollPrize = 3.00;
            double bearPrize = 4.10;
            double minionPrize = 8.20;
            double miniTruckPrize = 2.00;

            double sumToys = puzzle * puzzlePrice + dols * dollPrize + bears * bearPrize + minions * minionPrize + miniTrucks * miniTruckPrize;
            double toysCount = puzzle + dols + bears + minions + miniTrucks;
            
            if (toysCount >= 50)
            {
                double sumToysDiscount = sumToys * 0.25;
                double endSum = sumToys - sumToysDiscount;
                double rent = endSum * 0.10;
                double income = endSum - rent;
                
                if (income > tripPrize)
                {
                    double moneyForTrip = income - tripPrize;
                    Console.WriteLine("Yes! {0:f2} lv left.",moneyForTrip);
                }
                
            }
            else if (toysCount < 50)
            {
                double rent = sumToys * 0.10;
                double income = sumToys - rent;

                if (income < tripPrize)
                {
                    double needMoney = tripPrize - income;
                    Console.WriteLine("Not enough money! {0:f2} lv needed.", needMoney, Math.Abs(needMoney));
                }
            }
        }
    }
}
