using System;

namespace DwarfPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            int dwarfCount = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());
            double moneySpend = 0;

            for (int i = 0; i < dwarfCount; i++)
            {
                string gift = Console.ReadLine();

                switch (gift)
                {
                    case "sandClock":
                        moneySpend += 2.20;
                        break;
                    default:
                }
            }
        }
    }
}
