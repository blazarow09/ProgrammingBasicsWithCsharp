using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 0.50), 2));
                }
                if (city == "Plovdiv")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 0.40), 2));
                }
                if (city == "Varna")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 0.45), 2));
                }
            }
            if (product == "water")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 0.80), 2));
                }
                if (city == "Plovdiv")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 0.70), 2));
                }
                if (city == "Varna")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 0.70), 2));
                }
            }
            if (product == "beer")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 1.20), 2));
                }
                if (city == "Plovdiv")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 1.15), 2));
                }
                if (city == "Varna")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 1.10), 2));
                }

            }
            if(product == "sweets")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 1.45), 2));
                }
                if (city == "Plovdiv")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 1.30), 2));
                }
                if (city == "Varna")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 1.35), 2));
                }
            }
            if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 1.60), 2));
                }
                if (city == "Plovdiv")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 1.50), 2));
                }
                if (city == "Varna")
                {
                    Console.WriteLine(Math.Round((kolichestvo * 1.55), 2));
                }
            }
        }
    }
}
