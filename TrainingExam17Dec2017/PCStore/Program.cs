using System;
namespace PCStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double videoCardPrice = double.Parse(Console.ReadLine());
            double ramMemoryPrice = double.Parse(Console.ReadLine());
            int countRamMemory = int.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double cpuInLeva = cpuPrice * 1.57;
            double videoCardInLeva = videoCardPrice * 1.57;
            double ramMemoryInLeva = ramMemoryPrice * 1.57;
            double sumPriceRamMemory = ramMemoryInLeva * countRamMemory ;
            double sumPriceCpu = cpuInLeva - cpuInLeva * percentDiscount;
            double sumPriceVideoCard = videoCardInLeva - videoCardInLeva * percentDiscount;
            double totalPrice = sumPriceCpu + sumPriceVideoCard + sumPriceRamMemory;
            Console.WriteLine("Money needed - {0:f2} leva.", totalPrice);
        }
    }
}
