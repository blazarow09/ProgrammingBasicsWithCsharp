using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string plod = Console.ReadLine();
            string den = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());

            if (den == "Monday" || den == "Tuesday" || den == "Wednesday" || den == "Thursday" || den == "Friday")

            {
                if (plod == "banana")
                {
                    Console.WriteLine(kolichestvo * 2.50);
                }
                else if (plod == "apple")
                {
                    Console.WriteLine(kolichestvo * 1.20);
                }
                else if (plod == "orange")
                {
                    Console.WriteLine(kolichestvo * 0.85);
                }
                else if (plod == "grapefruit")
                {
                    Console.WriteLine(kolichestvo * 1.45);
                }
                else if (plod == "kiwi")
                {
                    Console.WriteLine(kolichestvo * 2.70);
                }
                else if (plod == "pineapple")
                {
                    Console.WriteLine(kolichestvo * 5.50);
                }
                else if (plod == "grapes")
                {
                    Console.WriteLine(kolichestvo * 3.85);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (den == "Saturday" || den == "Sunday")
            {
                if (plod == "banana")
                {
                    Console.WriteLine(kolichestvo * 2.70);
                }
                else if (plod == "apple")
                {
                    Console.WriteLine(kolichestvo * 1.25);
                }
                else if (plod == "orange")
                {
                    Console.WriteLine(kolichestvo * 0.90);
                }
                else if (plod == "grapefruit")
                {
                    Console.WriteLine(kolichestvo * 1.60);
                }
                else if (plod == "kiwi")
                {
                    Console.WriteLine(kolichestvo * 3.00);
                }
                else if (plod == "pineapple")
                {
                    Console.WriteLine(kolichestvo * 5.60);
                }
                else if (plod == "grapes")
                {
                    Console.WriteLine(kolichestvo * 4.20);
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
