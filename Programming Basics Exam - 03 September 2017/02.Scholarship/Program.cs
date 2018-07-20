using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohodBGN = double.Parse(Console.ReadLine());
            double sredenUspeh = double.Parse(Console.ReadLine());
            double minimalnaZaplata = double.Parse(Console.ReadLine());
            
            if (dohodBGN < minimalnaZaplata && sredenUspeh >= 5.50)
            {
                double socStipendiq = minimalnaZaplata * 0.35;
                double uspehStipendiq = sredenUspeh * 25;
                if (socStipendiq > uspehStipendiq)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socStipendiq));
                }
                else
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(uspehStipendiq));
                }
            }
            else if (dohodBGN < minimalnaZaplata && sredenUspeh >= 4.50)
            {
                double socStipendiq = minimalnaZaplata * 0.35;
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socStipendiq));
            }
            else if (sredenUspeh >= 5.50)
            {
                double uspehStipendiq = sredenUspeh * 25;
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(uspehStipendiq));
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
