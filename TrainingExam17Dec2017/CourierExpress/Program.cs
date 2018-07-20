using System;

namespace CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightInKg = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double killometers = double.Parse(Console.ReadLine());
            double priceOnKm = 0.0;
            double price = 0.0;

            if (type == "standard")
            {
                if (weightInKg < 1.000)
                {
                    priceOnKm = 0.03;
                }
                else if (weightInKg >= 1.00 && weightInKg <= 10)
                {
                    priceOnKm = 0.05;
                }
                else if (weightInKg >= 11 && weightInKg < 40)
                {
                    priceOnKm = 0.10;
                }
                else if (weightInKg >= 41 && weightInKg < 90)
                {
                    priceOnKm = 0.15;
                }
                else if (weightInKg >= 91 && weightInKg < 150)
                {
                    priceOnKm = 0.20;
                }
                Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", weightInKg, killometers * priceOnKm);
            }
            else if (type == "express")
            {
                if (weightInKg < 1.000)
                {
                    price = 0.03;
                    priceOnKm = 0.03 * 0.80;
                }
                else if (weightInKg >= 1.00 && weightInKg <= 10)
                {
                    price = 0.05;
                    priceOnKm = 0.05 * 0.40;
                }
                else if (weightInKg >= 11 && weightInKg < 40)
                {
                    price = 0.10;
                    priceOnKm = 0.10 * 0.05;
                }
                else if (weightInKg >= 41 && weightInKg < 90)
                {
                    price = 0.15;
                    priceOnKm = 0.15 * 0.02;
                }
                else if (weightInKg >= 91 && weightInKg < 150)
                {
                    price = 0.20; 
                    priceOnKm = 0.20 * 0.01;
                }
                double delivery1 = killometers * price;
                double deliveryDiscount = weightInKg * priceOnKm;
                double delivery = killometers * deliveryDiscount;
                double total = delivery1 + delivery;

                Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", weightInKg, total);
            }
        }
    }
}
