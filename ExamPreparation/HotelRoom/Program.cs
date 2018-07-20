using System;
namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int overnightsCount = int.Parse(Console.ReadLine());

            var priceStudio = 0.0;
            var priceApart = 0.0;
            var discount = 0.0;
            var discountApart = 0.0;
            
            if (month == "may" || month == "october")
            {
                priceStudio = 50.0;
                priceApart = 65;

                if (overnightsCount > 7 && overnightsCount < 14)
                {
                     priceStudio -= (priceStudio * 0.05);
                }
                else if (overnightsCount > 14)
                {
                   priceStudio -= (priceStudio * 0.30); 
                   priceApart -= (priceApart * 0.10);                   
                }
            }
            else if (month == "june" || month == "september")
            {
                priceStudio = 75.20;
                priceApart = 68.70;

                if (overnightsCount > 14)
                {
                    priceStudio -= (priceStudio * 0.20);
                    priceApart -= (priceApart * 0.10);
                }
            }
            else if (month == "july" || month == "august")
            {
                priceStudio = 76;
                priceApart = 77;

                if (overnightsCount > 14)
                {
                    priceApart -= (priceApart * 0.10);
                }
            }

            Console.WriteLine($"Apartment: {priceApart * overnightsCount:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio * overnightsCount:f2} lv.");


        }
    }
}
