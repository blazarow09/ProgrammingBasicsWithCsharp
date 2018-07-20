using System;

namespace Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double fuelConsume = double.Parse(Console.ReadLine());

            double distance = 384400 * 2;
            double timeNeed = Math.Ceiling((384400 * 2) / averageSpeed + 3);
            double fuelNeed = (fuelConsume * (384400 * 2) / 100);

            Console.WriteLine("{0:f0}", timeNeed);
            Console.WriteLine("{0}", fuelNeed);
        }
    }
}
