using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;

            if(budget <= 1000)
            {
                if (season == "Summer")
                {
                    price = budget - (budget * 0.35);
                    Console.Write("Alaska - ");
                }
                else if (season == "Winter")
                {
                    price = budget - (budget * 0.55);
                    Console.Write("Morocco - ");
                }
                Console.Write("Camp - ");
            }
            else if (budget > 1000 && budget <= 3000)
            {
                if (season == "Summer")
                {
                    price = budget - (budget * 0.20);
                    Console.Write("Alaska - ");
                }
                else if (season == "Winter")
                {
                    price = budget - (budget * 0.40);
                    Console.Write("Morocco - ");
                }
                Console.Write("Hut - ");
            }
            else if (budget > 3000)
            {
                if (season == "Summer")
                {
                    price = budget - (budget * 0.10);
                    Console.Write("Alaska - ");
                }
                else if (season == "Winter")
                {
                    price = budget - (budget * 0.10);
                    Console.Write("Morocco - ");
                }
                Console.Write("Hotel - ");
            }
            Console.WriteLine($"{price:F2}");

        }
    }
}
