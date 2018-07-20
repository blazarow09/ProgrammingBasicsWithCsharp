using System;

namespace Ivanovi_SFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            var budged = double.Parse(Console.ReadLine());
            var budgedFirstChild = double.Parse(Console.ReadLine());
            var budgedSecondChild = double.Parse(Console.ReadLine());
            var budgedThirdrdChild = double.Parse(Console.ReadLine());

            double totalGiftPrice = budgedFirstChild + budgedSecondChild + budgedThirdrdChild;
            double budgedLeft = budged - totalGiftPrice;
            double total = budgedLeft - budgedLeft * 10 / 100; // -10% от сумата!
            Console.WriteLine("{0:f2}", total);
       }
    }
}
