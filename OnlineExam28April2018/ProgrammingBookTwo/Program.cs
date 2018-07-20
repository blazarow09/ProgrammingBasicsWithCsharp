using System;

namespace ProgrammingBookTwo
{
    class Program
    {
        static void Main(string[] args)
        {                 double pricePerPage = double.Parse(Console.ReadLine());            double pricePerCover = double.Parse(Console.ReadLine());            double percentDiscount = double.Parse(Console.ReadLine());            double priceForDesigner = double.Parse(Console.ReadLine());            double percentForTeam = double.Parse(Console.ReadLine());


            double firstSum = pricePerPage * 899 + pricePerCover * 2;            double discount = firstSum - (firstSum * percentDiscount) / 100;            double forDesigner = discount + priceForDesigner;
           double endSum = forDesigner - (forDesigner * percentForTeam) / 100;
        


            Console.WriteLine("Avtonom should pay {0:f2} BGN.", endSum);
        }
    }
}
