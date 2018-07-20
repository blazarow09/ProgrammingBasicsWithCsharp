using System;

namespace MinningRig
{
    class Program
    {
        static void Main(string[] args)
        {
            double videoCardPrice = double.Parse(Console.ReadLine());
            double adapterPrice = double.Parse(Console.ReadLine());
            double electricityPerDay = double.Parse(Console.ReadLine());
            double incomePerCardADay = double.Parse(Console.ReadLine());

            double videCardTotal = videoCardPrice * 13;
            double adapterTotal = adapterPrice * 13;
            double total = videCardTotal + adapterTotal + 1000;
            double incomePerDayForCard = incomePerCardADay - electricityPerDay;
            double totalIncome = 13 * incomePerDayForCard;
            double timeNeed = total / totalIncome;

            Console.WriteLine("{0:f0}", total);
            Console.WriteLine(Math.Ceiling(timeNeed));
        }
    }
    
}
