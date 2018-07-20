using System;

namespace CherryJar
{
    class Program
    {
        static void Main(string[] args)
        {
            double jarsWithCompot = double.Parse(Console.ReadLine());
            double jarsWithSladko = double.Parse(Console.ReadLine());

            double jarsC = jarsWithCompot + 1;
            double jarsS = jarsWithSladko + 1;

            double cherriesForCompot = (jarsC * 0.300);
            double percentC = cherriesForCompot * 0.05 + cherriesForCompot;
            double cherriesForSladko = (jarsS * 0.650);
            double percentS = cherriesForSladko * 0.10 + cherriesForSladko;
            double totalAmount = percentC + percentS;
            Console.WriteLine("{0:f2}", totalAmount * 3.20);
        }
    }
}
