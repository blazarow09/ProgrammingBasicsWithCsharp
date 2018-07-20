using System;

namespace Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupCount = double.Parse(Console.ReadLine());
            double personPower = double.Parse(Console.ReadLine());
            double illidanPower = double.Parse(Console.ReadLine());

            double sumPower = groupCount * personPower;
            double slain = sumPower - illidanPower;
            double prepared = illidanPower - sumPower;

            if (sumPower > illidanPower)
            {
                Console.WriteLine("Illidan has been slain! You defeated him with {0} points.", slain);
            }
            else if (sumPower < illidanPower)
            {
                Console.WriteLine("You are not prepared! You need {0} more points.", prepared);
            }
        }

    }
}
