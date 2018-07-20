using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string sezon = Console.ReadLine();
            double kmNaMesec = double.Parse(Console.ReadLine());
            double zaplata = 0;
            if (sezon == "Spring" || sezon == "Autumn")
            {
                if (kmNaMesec <= 5000)
                {
                    zaplata = (kmNaMesec * 0.75) * 4;
                }
                else if (kmNaMesec > 5000 && kmNaMesec <= 10000)
                {
                    zaplata = (kmNaMesec * 0.95) * 4;
                }
                else if (kmNaMesec > 10000 && kmNaMesec <= 20000)
                {
                    zaplata = (kmNaMesec * 1.45) * 4;
                }
            }
            if (sezon == "Summer")
            {
                if (kmNaMesec <= 5000)
                {
                    zaplata = (kmNaMesec * 0.90) * 4;
                }
                else if (kmNaMesec > 5000 && kmNaMesec <= 10000)
                {
                    zaplata = (kmNaMesec * 1.10) * 4;
                }
                else if (kmNaMesec > 10000 && kmNaMesec <= 20000)
                {
                    zaplata = (kmNaMesec * 1.45) * 4;
                }
            }
            if (sezon == "Winter")
            {
                if (kmNaMesec <= 5000)
                {
                    zaplata = (kmNaMesec * 1.05) * 4;
                }
                else if (kmNaMesec > 5000 && kmNaMesec <= 10000)
                {
                    zaplata = (kmNaMesec * 1.25) * 4;
                }
                else if (kmNaMesec > 10000 && kmNaMesec <= 20000)
                {
                    zaplata = (kmNaMesec * 1.45) * 4;                   
                }
            }
            zaplata *= 0.90;
            Console.WriteLine($"{zaplata:F2}");
        }
    }
}
