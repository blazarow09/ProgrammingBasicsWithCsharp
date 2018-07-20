using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam25June2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int chefs = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double cakes = c * 45;
            double waffles = w * 5.80;
            double pancakes = p * 3.20;
            double totalAmountOneDay = (cakes + waffles + pancakes) * chefs;
            double totalAmount = totalAmountOneDay * days;
            double afterSpending = totalAmount * 0.125;
            double amountAfterSpending = totalAmount - afterSpending;

            Console.WriteLine($"{amountAfterSpending:F2}");
        }
    }
}
