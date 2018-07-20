using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string TipProjekciq = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (TipProjekciq == "Premiere")
            {
                double result = r * c * 12.00;
                Console.WriteLine("{0:f2} leva", result);
            }
            if (TipProjekciq == "Normal")
            {
                double result = r * c * 7.50;
                Console.WriteLine("{0:f2} leva", result);
            }
            if (TipProjekciq == "Discount")
            {
                double result = r * c * 5.00;
                Console.WriteLine("{0:f2} leva", result);
            }
        }
    }
}
