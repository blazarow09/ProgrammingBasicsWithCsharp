using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiTovari = int.Parse(Console.ReadLine());
            double cena = 0;
            double mikrobus = 0;
            double kamion = 0;
            double vlak = 0;
            double sum = 0;
            for (int i = 1; i <= broiTovari; i++)
            {
                int tonaj = int.Parse(Console.ReadLine());
                sum += tonaj;
                if (tonaj <= 3)
                {
                    mikrobus += tonaj;
                }
                else if (tonaj >= 4 && tonaj <= 11)
                {
                    kamion += tonaj;
                }
                else
                {
                    vlak += tonaj;
                }
            }
            cena = (mikrobus * 200 + kamion * 175 + vlak * 120) / sum;
            mikrobus = mikrobus / sum * 100;
            kamion = kamion / sum * 100;
            vlak = vlak / sum * 100;
            Console.WriteLine($"{cena:F2}");
            Console.WriteLine($"{mikrobus:F2}%");
            Console.WriteLine($"{kamion:F2}%");
            Console.WriteLine($"{vlak:F2}%");
        }
    }
}
