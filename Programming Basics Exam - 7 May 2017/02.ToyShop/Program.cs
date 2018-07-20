using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaEkskurziq = double.Parse(Console.ReadLine());
            int broiPuzeli = int.Parse(Console.ReadLine());
            int broiKukli = int.Parse(Console.ReadLine());
            int broiMecheta = int.Parse(Console.ReadLine());
            int broiMinioni = int.Parse(Console.ReadLine());
            int broiKamioni = int.Parse(Console.ReadLine());

            double price = broiPuzeli * 2.60 + broiKukli * 3 + broiMecheta * 4.10 + broiMinioni * 8.20 + broiKamioni * 2;
            double broiIgrachki = broiPuzeli + broiKukli + broiMecheta + broiMinioni + broiKamioni;
            if (broiIgrachki >= 50)
            {
                price *= 0.75;
            }
            double ObshtoSNaem = price * 0.9;
            if (ObshtoSNaem >= cenaEkskurziq)
            {
                double result = ObshtoSNaem - cenaEkskurziq;
                Console.WriteLine($"Yes! {result:F2} lv left.");
            }
            else
            {
                double result = cenaEkskurziq - ObshtoSNaem;
                Console.WriteLine($"Not enough money! {result:F2} lv needed.");
            }
        }
    }
}
