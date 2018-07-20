using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double taxiStartPrice = 0.70;


            if (km < 20 && time == "day")
            {
                double moneyNeed = taxiStartPrice + km * 0.79;
                Console.WriteLine("{0:f2}", moneyNeed);
            }
            else if (km < 20 && time == "night")
            {
                double moneyNeed = taxiStartPrice + km * 0.90;
                Console.WriteLine("{0:f2}", moneyNeed);
            }
           else if (km >= 20 && km < 100 && time == "day")
            {
                double moneyNeed = km * 0.09;
                Console.WriteLine("{0:f2}", moneyNeed);
            }        
            else if (km >= 20 && km < 100 && time == "night")
            {
                double moneyNeed = km * 0.09;
                Console.WriteLine("{0:f2}", moneyNeed);
            }
            else if (km >= 100 && time == "day")
            {
                double moneyNeed = km * 0.06;
                Console.WriteLine("{0:f2}", moneyNeed);
            }
            else if (km >= 100 && time == "night")
            {
                double moneyNeed = km * 0.06;
                Console.WriteLine("{0:f2}", moneyNeed);
            }


        }
    }
}
