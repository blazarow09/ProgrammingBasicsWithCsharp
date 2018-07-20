using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int cups = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double madeCups = workers * days * 8;
            madeCups /= 5;
            
            if(madeCups >= cups)
            {
                double extraMoney = Math.Floor(madeCups - cups);
                extraMoney *= 4.2;
                Console.WriteLine($"{extraMoney:F2} extra money");
            }
            else
            {
                double losses = cups - madeCups;
                losses *= 4.2;
                Console.WriteLine($"Losses: {losses:F2}");
            }

        }
    }
}
