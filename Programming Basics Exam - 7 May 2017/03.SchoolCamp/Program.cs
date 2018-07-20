using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sezon = Console.ReadLine();
            string vidGrupa = Console.ReadLine();
            int broiUchenici = int.Parse(Console.ReadLine());
            int broiNoshtuvki = int.Parse(Console.ReadLine());
            string sport;
            double cena = 0;

            if (sezon == "Winter")
            {
                if (vidGrupa == "girls")
                {
                    Console.Write("Gymnastics");
                    cena = broiUchenici * 9.60 * broiNoshtuvki;
                }
                else if (vidGrupa == "boys")
                {
                    Console.Write("Judo");
                    cena = broiUchenici * 9.60 * broiNoshtuvki;
                }
                else if (vidGrupa == "mixed")
                {
                    Console.Write("Ski");
                    cena = broiUchenici * 10 * broiNoshtuvki;
                }

            }
            else if (sezon == "Spring")
            {
                if (vidGrupa == "girls")
                {
                    Console.Write("Athletics");
                    cena = broiUchenici * 7.20 * broiNoshtuvki;
                }
                else if (vidGrupa == "boys")
                {
                    Console.Write("Tennis");
                    cena = broiUchenici * 7.20 * broiNoshtuvki;
                }
                else if(vidGrupa == "mixed")
                {
                    Console.Write("Cycling");
                    cena = broiUchenici * 9.50 * broiNoshtuvki;
                }
            }
            else if (sezon == "Summer")
            {
                if (vidGrupa == "girls")
                {
                    Console.Write("Volleyball");
                    cena = broiUchenici * 15 * broiNoshtuvki;
                }
                else if (vidGrupa == "boys")
                {
                    Console.Write("Football");
                    cena = broiUchenici * 15 * broiNoshtuvki;
                }
                else if (vidGrupa == "mixed")
                {
                    Console.Write("Swimming");
                    cena = broiUchenici * 20 * broiNoshtuvki;
                }
            }
            if (broiUchenici >= 50)
            {
                cena *= 0.50;
            }
            else if (broiUchenici >= 20 && broiUchenici < 50)
            {
                cena *= 0.85;
            }
            else if (broiUchenici >= 10 && broiUchenici < 20)
            {
                cena *= 0.95;
            }
            
            Console.WriteLine($" {cena:F2} lv.");

        }
    }
}
