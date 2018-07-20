using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double fuelNeed = double.Parse(Console.ReadLine());

            double totalDistance = 384400 * 2;
            double timeNeed = Math.Ceiling(totalDistance / averageSpeed);
            double totalTime = Math.Ceiling(timeNeed + 3);
            double fuel = (fuelNeed * totalDistance) / 100;

            Console.WriteLine(totalTime);
            Console.WriteLine(fuel);
        }
    }
}
