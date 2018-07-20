using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double prizeFor1Point = double.Parse(Console.ReadLine());
            double prize = 0;
            double money = 0;
            for (int i = 1; i <= parts; i++)
            {
                double points = double.Parse(Console.ReadLine());
                if (i % 2 == 0 && i != 1)
                {
                    double sum = points * 2;
                    prize += sum;
                }
                else
                {
                    prize += points;
                }
            }
            money = prizeFor1Point * prize;
            Console.WriteLine($"The project prize was {money:F2} lv.");
        }
    }
}
