using System;
namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double grapePerM = double.Parse(Console.ReadLine());
            double needVine = double.Parse(Console.ReadLine());
            double employees = double.Parse(Console.ReadLine());

            double totalGrape = V * grapePerM;
            double vine = 0.40 * totalGrape / 2.5;

            if (vine >= needVine)
            {
                double leftVine = vine - needVine;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",
                    Math.Floor(vine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(leftVine),
                    Math.Ceiling(leftVine / employees));
            }
            else if (vine < needVine)
            {
                double needed = needVine - vine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                    Math.Floor(needed));
            }
        }
    }
}
