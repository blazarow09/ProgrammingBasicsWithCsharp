using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double PloshtKushta = double.Parse(Console.ReadLine());
            int brProzorci = int.Parse(Console.ReadLine());
            double styrofoam = double.Parse(Console.ReadLine());
            double cena = double.Parse(Console.ReadLine());

            double kushta = PloshtKushta - (brProzorci * 2.4);
            kushta = kushta + (kushta * 0.10);
            double paketi = Math.Ceiling(kushta / styrofoam);
            paketi *= cena;
           
            if(paketi <= budget)
            {
                Console.WriteLine($"Spent: {paketi:F2}");
                double result = budget - paketi;
                Console.WriteLine($"Left: {result:F2}");
            }
            else
            {
                double result = paketi - budget;
                Console.WriteLine($"Need more: {result:F2}");
            }


        }
    }
}
