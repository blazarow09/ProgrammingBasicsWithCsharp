using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam16December2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollsWrappingPaper = int.Parse(Console.ReadLine());
            int rollsTextile = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double wrappingPaperPrice = rollsWrappingPaper * 5.80;
            double textilePrice = rollsTextile * 7.20;
            double gluePrice = glue * 1.20;
            double allPrice = wrappingPaperPrice + textilePrice + gluePrice;
            double allPriceWithDiscount = allPrice - ((allPrice * discount) / 100);

            Console.WriteLine($"{allPriceWithDiscount:F3}");

        }
    }
}
