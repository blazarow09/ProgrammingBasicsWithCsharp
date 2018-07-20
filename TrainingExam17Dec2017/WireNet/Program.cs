using System;

namespace WireNet
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtInMeters = double.Parse(Console.ReadLine());
            double widthInMeters = double.Parse(Console.ReadLine());
            double heightWireInMeters = double.Parse(Console.ReadLine());
            double priceMeterWireInLv = double.Parse(Console.ReadLine());
            double weightMeterInKg = double.Parse(Console.ReadLine());

            double wireHeight = 2 * lenghtInMeters + 2 * widthInMeters;
            double totalPrice = wireHeight * priceMeterWireInLv;
            double sWire = wireHeight * heightWireInMeters;
            double wireKg = sWire * weightMeterInKg;

            Console.WriteLine("{0:f0}", wireHeight);
            Console.WriteLine("{0:f2}", totalPrice);
            Console.WriteLine("{0:f3}", wireKg);
        }
    }
}
