using System;

namespace DeerOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysGone = double.Parse(Console.ReadLine());
            double foodLeftInKg = double.Parse(Console.ReadLine());
            double firstDeerFood = double.Parse(Console.ReadLine());
            double secondDeerFood = double.Parse(Console.ReadLine());
            double thirdDeerFood = double.Parse(Console.ReadLine());

            double totalFirstDeer = daysGone * firstDeerFood;
            double totalSecondDeer = daysGone * secondDeerFood;
            double totalThirdDeer = daysGone * thirdDeerFood;
            double foodNeed = totalFirstDeer + totalSecondDeer + totalThirdDeer;

            if (foodLeftInKg >= foodNeed)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodLeftInKg - foodNeed));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodNeed - foodLeftInKg));
            }
        }
    }
}
