using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string grad = Console.ReadLine();
            double S = double.Parse(Console.ReadLine());

            if (grad == "Sofia")
            {
                if ( S >= 0 && S <= 500)
                {
                    Console.WriteLine(S * 5 / 100);
                }
                else if (S > 500 && S <= 1000)
                {
                    Console.WriteLine(S * 7 / 100);
                }
                else if (S > 1000 && S <= 10000)
                {
                    Console.WriteLine(S * 8 / 100);
                }
                else if (S > 10000)
                {
                    Console.WriteLine(S * 12 / 100);
                }
            }
            else if (grad == "Varna")
            {
                if (S >= 0 && S <= 500)
                {
                    Console.WriteLine(S * 4.5 / 100);
                }
                else if (S > 500 && S <= 1000)
                {
                    Console.WriteLine(S * 7.5 / 100);
                }
                else if (S > 1000 && S <= 10000)
                {
                    Console.WriteLine(S * 10 / 100);
                }
                else if (S > 10000)
                {
                    Console.WriteLine(S * 13 / 100);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (grad == "Plovdiv")
            {
                if (S >= 0 && S <= 500)
                {
                    Console.WriteLine(S * 5.5 / 100);
                }
                else if (S > 500 && S <= 1000)
                {
                    Console.WriteLine(S * 8 / 100);
                }
                else if (S > 1000 && S <= 10000)
                {
                    Console.WriteLine(S * 12 / 100);
                }
                else if (S > 10000)
                {
                    Console.WriteLine(S * 14.5 / 100);
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
