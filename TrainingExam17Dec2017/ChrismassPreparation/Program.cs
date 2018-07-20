using System;

namespace ChrismassPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double paperPrice = 5.80;
            double textilePrice = 7.20;
            double gluePrice = 1.20;

            double paperCount = double.Parse(Console.ReadLine());
            double textileRols = double.Parse(Console.ReadLine());
            double glueLiters = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double paperTotalPrice = paperPrice * paperCount;
            double textileTotalPrice = textilePrice * textileRols;
            double glueTotalPrice = gluePrice * glueLiters;
            double totalMoneyNeed = paperTotalPrice + textileTotalPrice + glueTotalPrice;

            Console.WriteLine("{0:f3}", totalMoneyNeed - ((totalMoneyNeed * percentDiscount) / 100));

        }
    }
}
