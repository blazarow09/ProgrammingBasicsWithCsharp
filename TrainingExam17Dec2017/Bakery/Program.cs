using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double startDough = double.Parse(Console.ReadLine());
            int gramDough = int.Parse(Console.ReadLine());
            double priceDough = double.Parse(Console.ReadLine());
            int countSoldDough = int.Parse(Console.ReadLine());
            int countSoldPure = int.Parse(Console.ReadLine());

          

            double dailyIncome = countSoldDough * priceDough;
            double doughNeed = countSoldDough * gramDough;
            double pureDoughNeed = gramDough * 0.20 - gramDough;
            double doughUsedForPure = countSoldDough * pureDoughNeed;
            double nightIncome = countSoldPure * 3.125;
            double allDoughUsed = (doughForPure + startDough) * 4;
            double allIncome = (dailyIncome + nightIncome) - allDoughUsed;
            double pureIncome = nightIncome + doughForPure;

            Console.WriteLine("Pure income: {0:f2}", allIncome);
            Console.WriteLine("Dough used: {0:f2}", pureIncome);



        }
    }
}
