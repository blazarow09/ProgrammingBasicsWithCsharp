using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FruityCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            string plod = Console.ReadLine();
            string razmer = Console.ReadLine();
            int broiPitieta = int.Parse(Console.ReadLine());
            double cena = 0;
            double smallPrice = 0;
            double bigPrice = 0;

            switch (plod)
            {
                case "Watermelon":
                    if(razmer == "small")
                    {
                        smallPrice = 2 * 56;
                        cena = smallPrice * broiPitieta;
                    }
                    else if (razmer == "big")
                    {
                        bigPrice = 5 * 28.70;
                        cena = bigPrice * broiPitieta;
                    }
                    break;
                case "Mango":
                    if (razmer == "small")
                    {
                        smallPrice = 2 * 36.66;
                        cena = smallPrice * broiPitieta;
                    }
                    else if (razmer == "big")
                    {
                        bigPrice = 5 * 19.60;
                        cena = bigPrice * broiPitieta;
                    }
                    break;
                case "Pineapple":
                    if (razmer == "small")
                    {
                        smallPrice = 2 * 42.10;
                        cena = smallPrice * broiPitieta;
                    }
                    else if (razmer == "big")
                    {
                        bigPrice = 5 * 24.80;
                        cena = bigPrice * broiPitieta;
                    }                  
                    break;
                case "Raspberry":
                    if (razmer == "small")
                    {
                        smallPrice = 2 * 20;
                        cena = smallPrice * broiPitieta;
                    }
                    else if (razmer == "big")
                    {
                        bigPrice = 5 * 15.20;
                        cena = bigPrice * broiPitieta;
                    }                  
                    break;
            }
            
            if (cena > 1000)
            {
                cena *= 0.50;
            }
            else if (cena >= 400 && cena <= 1000)
            {
                cena *= 0.85;
            }
            Console.WriteLine($"{cena:F2} lv.");
        }
    }
}
