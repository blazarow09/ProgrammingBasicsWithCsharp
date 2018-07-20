using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine());
            double br = 0;
            while (coins >= 0.00)
            {
                if (coins >= 2)
                {
                    br += 1;
                    coins -= 2;
                }
                else if(coins >= 1)
                {
                    br += 1;
                    coins -= 1;
                }
                else if (coins >= 0.50)
                {
                    br += 1;
                    coins -= 0.50;
                }
                else if (coins >= 0.20)
                {
                    br += 1;
                    coins -= 0.20;
                }
                else if (coins >= 0.10)
                {
                    br += 1;
                    coins -= 0.10;
                }
                else if (coins >= 0.05)
                {
                    br += 1;
                    coins -= 0.05;
                }
                else if (coins >= 0.02)
                {
                    br += 1;
                    coins -= 0.02;
                }
                else if (coins >= 0.009)
                {
                    br += 1;
                    coins -= 0.01;
                    Console.WriteLine(br);
                    return;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(br);
        }
    }
}
