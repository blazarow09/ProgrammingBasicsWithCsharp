using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = double.Parse(Console.ReadLine());
            double chineese = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double bitcoinPrice = bitcoin * 1168.0;
            double chineesePrice = chineese * 0.15; //dollars
            double leva = chineesePrice * 1.76;

            double total = bitcoinPrice + leva;
            double totalEUR = total / 1.95;
            double asd = totalEUR  * comission * 0.01;
            double finish = totalEUR - asd;
            Console.WriteLine("{0:f2}", finish);
        }
    }
}
