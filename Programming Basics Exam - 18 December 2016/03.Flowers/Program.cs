using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiHrizantemi = int.Parse(Console.ReadLine());
            int broiRozi = int.Parse(Console.ReadLine());
            int broiLaleta = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            string daliEPraznik = Console.ReadLine();
            double obshtBroi = broiHrizantemi + broiLaleta + broiRozi;
            double cena = 0;

            if (sezon == "Spring" || sezon == "Summer")
            {
                double cenaHrizantemi = 2;
                double cenaRozi = 4.10;
                double cenaLaleta = 2.50;
                cena = broiHrizantemi * cenaHrizantemi + broiLaleta * cenaLaleta + broiRozi * cenaRozi;
                if (daliEPraznik == "Y")
                {
                    cena = cena + (cena * 0.15);
                }
                if (sezon == "Spring" && broiLaleta > 7)
                {
                    cena *= 0.95;
                }
            }
            else if (sezon == "Autumn" || sezon == "Winter")
            {
                double cenaHrizantemi = 3.75;
                double cenaRozi = 4.50;
                double cenaLaleta = 4.15;
                cena = broiHrizantemi * cenaHrizantemi + broiLaleta * cenaLaleta + broiRozi * cenaRozi;
                if (daliEPraznik == "Y")
                {
                    cena = cena + (cena * 0.15);
                }
                if (sezon == "Winter" && broiRozi >= 10)
                {
                    cena *= 0.90;
                }
            }
            if (obshtBroi > 20)
            {
                cena *= 0.80;
            }
            cena += 2;
            Console.WriteLine($"{cena:F2}");
        }
    }
}
