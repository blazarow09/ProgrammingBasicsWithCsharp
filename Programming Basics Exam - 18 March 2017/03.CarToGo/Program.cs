using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                if (season == "Summer")
                {
                    price = budget * 0.35;
                    Console.Write("Cabrio - ");
                }
                else if (season == "Winter")
                {
                    price = budget * 0.65;
                    Console.Write("Jeep - ");
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                if (season == "Summer")
                {
                    price = budget * 0.45;
                    Console.Write("Cabrio - ");
                }
                else if (season == "Winter")
                {
                    price = budget * 0.80;
                    Console.Write("Jeep - ");
                }
            }
            else if (budget > 500)
            {
                Console.WriteLine("Luxury class");
                price = budget * 0.90;
                Console.Write("Jeep - ");
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
