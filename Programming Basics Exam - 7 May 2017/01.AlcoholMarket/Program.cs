using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam7May2017
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskey = double.Parse(Console.ReadLine());
            double beerLeters = double.Parse(Console.ReadLine());
            double wineLeters = double.Parse(Console.ReadLine());
            double rakiaLeters = double.Parse(Console.ReadLine());
            double whiskeyLeters = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskey / 2;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);
            double rakiaTotalPrice = rakiaLeters * rakiaPrice;
            double wineTotalPrice = wineLeters * winePrice;
            double beerTotalPrice = beerLeters * beerPrice;
            double whiskeyTotalPrice = whiskey * whiskeyLeters;
            double totalPriceAll = rakiaTotalPrice + wineTotalPrice + beerTotalPrice + whiskeyTotalPrice;

            Console.WriteLine($"{totalPriceAll:F2}");

        }
    }
}
