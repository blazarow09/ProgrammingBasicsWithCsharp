using System;
namespace FriendlyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            double fuelPrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double sepatate = 0.0;
            double budgedNeed = 0.0;
            if (budget < sepatate ) 
            {
                double carConsumption = distance * fuelConsumption / 100;
                double fullConsumption = carConsumption * fuelPrice;
                double deficit = fullConsumption - budget;
                double separate = budget / 5;

                Console.WriteLine("Sorry, you cannot take a trip. Each will receive {0:f2} money.", separate);
            }
            else if (budget >= budgetNeed)
            {
                double carConsumption = distance * fuelConsumption / 100;
                double fullConsumption = carConsumption * fuelPrice;
                double budgedNeed = budget - fullConsumption;

                Console.WriteLine("You can take a trip. {0:f2} money left.", budgedNeed);
            }

        }
    }
}
