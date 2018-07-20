using System;
namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaSmallestRoom = double.Parse(Console.ReadLine());
            double areaKitchen = double.Parse(Console.ReadLine());
            double pricePerKvM = double.Parse(Console.ReadLine());

            double areaSecondRoom = areaSmallestRoom + (areaSmallestRoom * 0.1);
            double AreaThirdRoom = areaSecondRoom + (areaSecondRoom * 0.1);
            double bathroom = areaSmallestRoom / 2;

            double roomsArea = areaSmallestRoom + areaKitchen + areaSecondRoom + AreaThirdRoom + bathroom;
            double totalArea = roomsArea + (roomsArea * 0.05);

            double price = pricePerKvM * totalArea;
            Console.WriteLine($"{price:f2}");
        }
    }
}
