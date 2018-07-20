using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string kategoriq = Console.ReadLine();
            int horaBroi = int.Parse(Console.ReadLine());
            double leftMoney = 0;
            double transport = 0;

            if (horaBroi >= 1 && horaBroi <= 4)
            {
                transport = budget * 0.75;
            }
            else if (horaBroi >= 5 && horaBroi <= 9)
            {
                transport = budget * 0.60;
            }
            else if (horaBroi >= 10 && horaBroi <= 24)
            {
                transport = budget * 0.50;
            }
            else if (horaBroi >= 25 && horaBroi <= 49)
            {
                transport = budget * 0.40;
            }
            else if (horaBroi >= 50)
            {
                transport = budget * 0.25;
            }
            leftMoney = budget - transport;

            if (kategoriq == "Normal")
            {
                double sumaZaBiteli = horaBroi * 249.99;
                if (leftMoney > sumaZaBiteli)
                {
                    double left = leftMoney - sumaZaBiteli;
                    Console.WriteLine($"Yes! You have {left:F2} leva left.");
                }
                else
                {
                    double need = sumaZaBiteli - leftMoney;
                    Console.WriteLine($"Not enough money! You need {need:F2} leva.");
                }
            }
            else if (kategoriq == "VIP")
            {
                double sumaZaBiteli = horaBroi * 499.99;
                if (leftMoney > sumaZaBiteli)
                {
                    double left = leftMoney - sumaZaBiteli;
                    Console.WriteLine($"Yes! You have {left:F2} leva left.");
                }
                else
                {
                    double need = sumaZaBiteli - leftMoney;
                    Console.WriteLine($"Not enough money! You need {need:F2} leva.");
                }
            }

        }
    }
}
