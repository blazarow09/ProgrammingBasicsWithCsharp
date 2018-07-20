using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double tegloNaPratka = double.Parse(Console.ReadLine());
            string tipPratka = Console.ReadLine();
            int razstoqnie = int.Parse(Console.ReadLine());
            double cena = 0;
            
            if (tipPratka == "standard")
            {
                if (tegloNaPratka < 1.0)
                {
                    cena = razstoqnie * 0.03;
                }
                else if (tegloNaPratka >= 1.0 && tegloNaPratka <= 10)
                {
                    cena = razstoqnie * 0.05;
                }
                else if (tegloNaPratka >= 11 && tegloNaPratka <= 40)
                {
                    cena = razstoqnie * 0.10;
                }
                else if (tegloNaPratka >= 41 && tegloNaPratka <= 90)
                {
                    cena = razstoqnie * 0.15;
                }
                else if (tegloNaPratka >= 91 && tegloNaPratka <= 150)
                {
                    cena = razstoqnie * 0.20;
                }
            }
            else if(tipPratka == "express")
            {
                if (tegloNaPratka < 1.0)
                {
                    double naKM = razstoqnie * 0.03;
                    double expressCena = 0.03 * 0.8;
                    double nadcenka = expressCena * tegloNaPratka;
                    nadcenka *= razstoqnie;

                    cena = naKM + nadcenka; ;                   
                }
                else if (tegloNaPratka >= 1.0 && tegloNaPratka <= 10)
                {
                    double naKM = razstoqnie * 0.05;
                    double expressCena = 0.05 * 0.4;
                    double nadcenka = expressCena * tegloNaPratka;
                    nadcenka *= razstoqnie;

                    cena = naKM + nadcenka;
                }
                else if (tegloNaPratka >= 11 && tegloNaPratka <= 40)
                {
                    double naKM = razstoqnie * 0.10;
                    double expressCena = 0.10 * 0.05;
                    double nadcenka = expressCena * tegloNaPratka;
                    nadcenka *= razstoqnie;

                    cena = naKM + nadcenka;
                }
                else if (tegloNaPratka >= 41 && tegloNaPratka <= 90)
                {
                    double naKM = razstoqnie * 0.15;
                    double expressCena = 0.15 * 0.02;
                    double nadcenka = expressCena * tegloNaPratka;
                    nadcenka *= razstoqnie;

                    cena = naKM + nadcenka;
                }
                else if (tegloNaPratka >= 91 && tegloNaPratka <= 150)
                {
                    double naKM = razstoqnie * 0.20;
                    double expressCena = 0.20 * 0.01;
                    double nadcenka = expressCena * tegloNaPratka;
                    nadcenka *= razstoqnie;

                    cena = naKM + nadcenka;
                }
            }

            Console.WriteLine($"The delivery of your shipment with weight of {tegloNaPratka:F3} kg. would cost {cena:F2} lv.");


        }
    }
}
