using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam19March2017Evening
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaOfTheVineyard = double.Parse(Console.ReadLine());
            double kg = double.Parse(Console.ReadLine());
            double brak = double.Parse(Console.ReadLine());

            double grapeKg = (areaOfTheVineyard * kg) - brak;
            double forRakia =grapeKg * 45 / 100;
            double rakiaLeters = forRakia / 7.5;
            double rakiaBGN = rakiaLeters * 9.80;
            double forSell = grapeKg * 55 / 100;
            double prihod = forSell * 1.50;
            Console.WriteLine($"{rakiaBGN:F2}");
            Console.WriteLine($"{prihod:F2}");
            
        }
    }
}
