using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PhotoPictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiSnimki = int.Parse(Console.ReadLine());
            string vidSnimki = Console.ReadLine();
            string vidPoruchka = Console.ReadLine();
            double edinichnaCena = 0;
            double obshto = 0;

            switch (vidSnimki)
            {
                case "9X13":
                    edinichnaCena = 0.16;
                    obshto = edinichnaCena * broiSnimki;
                    if (broiSnimki >= 50)
                    {
                        obshto *= 0.95;
                    }
                    break;
                case "10X15":
                    edinichnaCena = 0.16;
                    obshto = edinichnaCena * broiSnimki;
                    if (broiSnimki >= 80)
                    {
                        obshto *= 0.97;
                    }
                    break;
                case "13X18":
                    edinichnaCena = 0.38;
                    obshto = edinichnaCena * broiSnimki;
                    if (broiSnimki >= 50 && broiSnimki <= 100)
                    {
                        obshto *= 0.97;
                    }
                    else if (broiSnimki > 100)
                    {
                        obshto *= 0.95;
                    }
                    break;
                case "20X30":
                    edinichnaCena = 2.90;
                    obshto = edinichnaCena * broiSnimki;
                    if (broiSnimki >= 10 && broiSnimki <= 50)
                    {
                        obshto *= 0.93;
                    }
                    else if (broiSnimki > 50)
                    {
                        obshto *= 0.91;
                    }
                    break;
            }
            if (vidPoruchka == "online")
            {
                obshto *= 0.98;
            }
            Console.WriteLine($"{obshto:F2}BGN");
        }
    }
}
