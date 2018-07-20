using System;

namespace PCStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double CPUpriceInUSD = double.Parse(Console.ReadLine());
            double VideoCardPriceInUSD = double.Parse(Console.ReadLine());
            double RAMpriceInUSD = double.Parse(Console.ReadLine());
            double countRAM = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double USD = 1.57;

            double priceCPUinBGN = CPUpriceInUSD * USD;
            double priceVideoCardInBGN = VideoCardPriceInUSD * USD;
            double priceRAMinBGN = RAMpriceInUSD * USD;

            double totalMoneyRAM = priceRAMinBGN * countRAM;

            double CPUdiscount = Math.Abs(priceCPUinBGN * discount - priceCPUinBGN);
            double VideoCardDiscount = Math.Abs(priceVideoCardInBGN * discount - priceVideoCardInBGN);
            double priceAfterDiscount = CPUdiscount + VideoCardDiscount + totalMoneyRAM;

            Console.WriteLine($"Money needed - {priceAfterDiscount:f2} leva.");
            
        }
    }
}
