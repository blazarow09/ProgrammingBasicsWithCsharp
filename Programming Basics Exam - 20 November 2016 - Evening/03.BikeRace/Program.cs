using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiJunior = int.Parse(Console.ReadLine());
            int broiSenior = int.Parse(Console.ReadLine());
            string vidTrase = Console.ReadLine();
            double obshtaSuma = 0;

            switch (vidTrase)
            {
               
                case "trail":
                    double juniorTax = 5.5;
                    double seniorTax = 7;
                    obshtaSuma = broiJunior * juniorTax + broiSenior * seniorTax;
                    obshtaSuma *= 0.95;
                    break;
                case "cross-country":
                    juniorTax = 8;
                    seniorTax = 9.5;
                    obshtaSuma = broiJunior * juniorTax + broiSenior * seniorTax;
                    obshtaSuma *= 0.95;
                    if ((broiJunior + broiSenior) >= 50)
                    {
                        obshtaSuma *= 0.75;
                    }
                    break;
                case "downhill":
                    juniorTax = 12.25;
                    seniorTax = 13.75;
                    obshtaSuma = broiJunior * juniorTax + broiSenior * seniorTax;
                    obshtaSuma *= 0.95;
                    break;
                case "road":
                    juniorTax = 20;
                    seniorTax = 21.5;
                    obshtaSuma = broiJunior * juniorTax + broiSenior * seniorTax;
                    obshtaSuma *= 0.95;
                    break;
            }
            Console.WriteLine($"{obshtaSuma:F2}");
        }
    }
}
