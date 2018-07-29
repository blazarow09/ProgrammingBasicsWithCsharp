using System;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceForTshirt = double.Parse(Console.ReadLine());
            var sumToWinBall = double.Parse(Console.ReadLine());

            var priceForPants = priceForTshirt - (priceForTshirt - (priceForTshirt * 0.75));

            var priceForSocks = (priceForPants * 0.2);

            var priceForBoots = (priceForPants + priceForTshirt) * 2;

            var totalSum = priceForTshirt + priceForSocks + priceForPants + priceForBoots;

            var totalSumDiscount = totalSum - (totalSum * 0.15);

            if (totalSumDiscount >= sumToWinBall)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalSumDiscount:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {sumToWinBall - totalSumDiscount:f2} lv. more.");
            }
        }
    }
}
