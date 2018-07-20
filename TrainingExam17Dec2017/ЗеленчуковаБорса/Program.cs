using System;

namespace ЗеленчуковаБорса
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKgVegetables = double.Parse(Console.ReadLine());
            double priceKgFruits = double.Parse(Console.ReadLine());
            double kgVegetables = double.Parse(Console.ReadLine());
            double kgFruits = double.Parse(Console.ReadLine());

            double priceVegetables = priceKgVegetables * kgVegetables;
            double priceFruits = priceKgFruits * kgFruits;
            double total = priceFruits + priceVegetables;
            Console.WriteLine("{0}", total / 1.94 );
        }
    }
}
