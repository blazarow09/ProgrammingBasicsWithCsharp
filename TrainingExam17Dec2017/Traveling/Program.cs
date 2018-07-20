using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100 && season == "summer")
            {              
                double moneyNeed = budget * 0.30;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:f2}", moneyNeed);
            }
            else if (budget <= 100 && season == "winter")
            {
                double moneyNeed = budget * 0.70;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:f2}", moneyNeed);
            }
            else if (budget <= 1000 && season == "summer")
            {
                double moneyNeed = budget * 0.40;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:f2}", moneyNeed);
            }
            else if (budget <= 1000 && season == "winter")
            {
                double moneyNeed = budget * 0.80; 
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:f2}", moneyNeed);
            }
            else 
            {
                double moneyNeed = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", moneyNeed);
            }
            
        }

    }
}
