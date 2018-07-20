using System;
namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJuniorBikers = int.Parse(Console.ReadLine());
            int countSeniorBikers = int.Parse(Console.ReadLine());
            string typeRoad = Console.ReadLine();

            var juniorTax = 0.0;
            var seniorTax = 0.0;


            if (typeRoad == "trail")
            {
                juniorTax = 5.50;
                seniorTax = 7;
            }
            else if (typeRoad == "cross-country")
            {
                juniorTax = 8;
                seniorTax = 9.50;
                if (countJuniorBikers + countSeniorBikers >= 50)
                {
                    juniorTax -= juniorTax * 0.25;
                    seniorTax -= seniorTax * 0.25;
                }
            }
            else if (typeRoad == "downhill")
            {
                juniorTax = 12.25;
                seniorTax = 13.75;
            }
            else if (typeRoad == "road")
            {
                juniorTax = 20;
                seniorTax = 21.50;
            }
            double totalTax = countJuniorBikers * juniorTax + countSeniorBikers * seniorTax;
            double razhodi = totalTax -= totalTax * 0.05;

            Console.WriteLine($"{razhodi:f2}");
        }
    }
}
