using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string srokNaDogovor = Console.ReadLine();
            string tip = Console.ReadLine();
            string internet = Console.ReadLine();
            int broiMeseci = int.Parse(Console.ReadLine());
            double cena = 0;

            switch (tip)
            {
                case "Small":
                    if (srokNaDogovor == "one")
                        cena = 9.98;
                    else if (srokNaDogovor == "two")
                        cena = 8.58;
                    break;
                case "Middle":
                    if (srokNaDogovor == "one")
                        cena = 18.99;
                    else if (srokNaDogovor == "two")
                        cena = 17.09;
                    break;
                case "Large":
                    if (srokNaDogovor == "one")
                        cena = 25.98;
                    else if (srokNaDogovor == "two")
                        cena = 23.59;
                    break;
                case "ExtraLarge":
                    if (srokNaDogovor == "one")
                        cena = 35.99;
                    else if (srokNaDogovor == "two")
                        cena = 31.79;
                    break;
            }
            if (internet == "yes")
            {
                if (cena <= 10)
                {
                    cena = cena + 5.50;
                }
                else if (cena <= 30)
                {
                    cena = cena + 4.35;
                }
                else if (cena > 30)
                {
                    cena = cena + 3.85;
                }
            }
            if (srokNaDogovor == "two")
            {
                cena = cena - (cena * 3.75 / 100);
            }

            double krainaCena = cena * broiMeseci;
            Console.WriteLine($"{krainaCena:F2} lv.");
        }
    }
}
