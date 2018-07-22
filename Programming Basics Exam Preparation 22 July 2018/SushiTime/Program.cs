using System;

namespace SushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeSushi = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double priceForSushi = 0;
            double moneyForDelivery = 0;
            double totalMoney = 0;

            if (restaurant != "Sushi Zone" &&
             restaurant != "Sushi Time" &&
             restaurant != "Sushi Bar" &&
             restaurant != "Asian Pub")
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
                return;
            }

            switch (restaurant)
            {
                case "Sushi Zone":
                    if (typeSushi == "sashimi")
                    {
                        priceForSushi = 4.99;
                    }
                    else if (typeSushi == "maki")
                    {
                        priceForSushi = 5.29;
                    }
                    else if (typeSushi == "uramaki")
                    {
                        priceForSushi = 5.99;
                    }
                    else if (typeSushi == "temaki")
                    {
                        priceForSushi = 4.29;
                    }
                    break;
                case "Sushi Time":
                    if (typeSushi == "sashimi")
                    {
                        priceForSushi = 5.49;
                    }
                    else if (typeSushi == "maki")
                    {
                        priceForSushi = 4.69;
                    }
                    else if (typeSushi == "uramaki")
                    {
                        priceForSushi = 4.49;
                    }
                    else if (typeSushi == "temaki")
                    {
                        priceForSushi = 5.19;
                    }
                    break;
                case "Sushi Bar":
                    if (typeSushi == "sashimi")
                    {
                        priceForSushi = 5.29;
                    }
                    else if (typeSushi == "maki")
                    {
                        priceForSushi = 5.55;
                    }
                    else if (typeSushi == "uramaki")
                    {
                        priceForSushi = 6.25;
                    }
                    else if (typeSushi == "temaki")
                    {
                        priceForSushi = 4.75;
                    }
                    break;
                case "Asian Pub":
                    if (typeSushi == "sashimi")
                    {
                        priceForSushi = 4.50;
                    }
                    else if (typeSushi == "maki")
                    {
                        priceForSushi = 4.80;
                    }
                    else if (typeSushi == "uramaki")
                    {
                        priceForSushi = 5.50;
                    }
                    else if (typeSushi == "temaki")
                    {
                        priceForSushi = 5.50;
                    }
                    break;
                
            }

            double moneyForOrder = count * priceForSushi;

            if (symbol == "Y")
            {
                moneyForDelivery = moneyForOrder * 0.2;
                totalMoney = moneyForOrder + moneyForDelivery;
            }
            else if (symbol == "N")
            {
                totalMoney = moneyForOrder;
            }

            Console.WriteLine($"Total price: {Math.Ceiling(totalMoney)} lv.");
        }
    }
}
