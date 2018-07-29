using System;

namespace FootbalSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            var team = Console.ReadLine();
            var typeSouvenirs = Console.ReadLine();
            var countBought = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (team != "Argentina" && team != "Croatia" && team != "Brazil" && team != "Denmark")
            {
                Console.WriteLine("Invalid country!");
                return;
            }

            if (typeSouvenirs != "flags" && typeSouvenirs != "stickers" && typeSouvenirs != "caps" && typeSouvenirs != "posters" ) 
            {
                Console.WriteLine("Invalid stock!");
                return;
            }

            switch (team)
            {
                case "Argentina":
                    if (typeSouvenirs == "stickers")
                    {
                        price = 1.25;
                    }
                    else if (typeSouvenirs == "posters")
                    {
                        price = 5.10;
                    }
                    else if (typeSouvenirs == "caps")
                    {
                        price = 7.20;
                    }
                    else if (typeSouvenirs == "flags")
                    {
                        price = 3.25;
                    }
                    break;
                case "Brazil":
                    if (typeSouvenirs == "stickers")
                    {
                        price = 1.20;
                    }
                    else if (typeSouvenirs == "posters")
                    {
                        price = 5.35;
                    }
                    else if (typeSouvenirs == "caps")
                    {
                        price = 8.50;
                    }
                    else if (typeSouvenirs == "flags")
                    {
                        price = 4.20;
                    }
                    break;
                case "Croatia":
                    if (typeSouvenirs == "stickers")
                    {
                        price = 1.10;
                    }
                    else if (typeSouvenirs == "posters")
                    {
                        price = 4.95;
                    }
                    else if (typeSouvenirs == "caps")
                    {
                        price = 6.90;
                    }
                    else if (typeSouvenirs == "flags")
                    {
                        price = 2.75;
                    }
                    break;
                case "Denmark":
                    if (typeSouvenirs == "stickers")
                    {
                        price = 0.90;
                    }
                    else if (typeSouvenirs == "posters")
                    {
                        price = 4.80;
                    }
                    else if (typeSouvenirs == "caps")
                    {
                        price = 6.50;
                    }
                    else if (typeSouvenirs == "flags")
                    {
                        price = 3.10;
                    }
                    break;
            }

            double totalSumToPay = countBought * price;

            Console.WriteLine($"Pepi bought {countBought} {typeSouvenirs} of {team} for {totalSumToPay:f2} lv.");
        }
    }
}
