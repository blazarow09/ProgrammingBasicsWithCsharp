using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double broiStupki = double.Parse(Console.ReadLine());
            double tanciori = double.Parse(Console.ReadLine());
            double Dni = double.Parse(Console.ReadLine());

            double stupkiNaDen = Math.Ceiling(((broiStupki / Dni) / broiStupki) * 100);
            double procentStupki = stupkiNaDen / tanciori;
            
            if (stupkiNaDen <= 13)
            {
                Console.Write("Yes, they will succeed in that goal! ");
                Console.Write($"{procentStupki:F2}");
                Console.WriteLine("%.");
                
            }
            else
            {
                Console.Write("No, They will not succeed in that goal! Required ");
                Console.Write($"{procentStupki:F2}");
                Console.WriteLine("% steps to be learned per day.");
            }
        }
    }
}
