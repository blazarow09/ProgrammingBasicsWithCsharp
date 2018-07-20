using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FootbalLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadion = double.Parse(Console.ReadLine());
            double fenove = double.Parse(Console.ReadLine());
            double total = fenove / stadion * 100;
            double A = 0;
            double B = 0;
            double V = 0;
            double G = 0;
            

            for (int i = 1; i <= fenove; i++)
            {
                string sektor = Console.ReadLine();

                if (sektor == "A")
                {
                    A += 1;
                }
                else if (sektor == "B")
                {
                    B += 1;
                }
                else if (sektor == "V")
                {
                    V += 1;
                }
                else if (sektor == "G")
                {
                    G += 1;
                }
            }
            A = A / fenove * 100;
            B = B / fenove * 100;
            V = V / fenove * 100;
            G = G / fenove * 100;
            

            Console.WriteLine($"{A:F2}%");
            Console.WriteLine($"{B:F2}%");
            Console.WriteLine($"{V:F2}%");
            Console.WriteLine($"{G:F2}%");
            Console.WriteLine($"{total:F2}%");

        }
    }
}
