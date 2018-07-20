using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesec = Console.ReadLine();
            int broiNoshtuvki = int.Parse(Console.ReadLine());
            double apartmentPrice = 0;
            double studioPrice = 0;

            if (mesec == "May" || mesec == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;
                if (broiNoshtuvki > 7 && broiNoshtuvki <= 14)
                {
                    studioPrice *= 0.95;
                }
                else if (broiNoshtuvki > 14)
                {
                    studioPrice *= 0.70;
                    apartmentPrice *= 0.90;
                }
            }
            else if (mesec == "June" || mesec == "September")
            {
                studioPrice = 75.2;
                apartmentPrice = 68.70;
                if (broiNoshtuvki > 14)
                {
                    studioPrice *= 0.80;
                    apartmentPrice *= 0.90;
                }
            }
            else if (mesec == "July" || mesec == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;
                if (broiNoshtuvki > 14)
                {
                    apartmentPrice *= 0.90;
                }
            }
            studioPrice = studioPrice * broiNoshtuvki;
            apartmentPrice = apartmentPrice * broiNoshtuvki;

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");

        }
    }
}
