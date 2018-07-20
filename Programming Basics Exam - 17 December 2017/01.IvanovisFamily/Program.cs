using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam17December2017
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double firstChild = double.Parse(Console.ReadLine());
            double secondChild = double.Parse(Console.ReadLine());
            double thirdChild = double.Parse(Console.ReadLine());
            double amount = firstChild + secondChild + thirdChild;
            double budgetLeft = (budget - amount);
            double dds = budgetLeft * 0.1;
            double donation = budgetLeft - dds;
            

            Console.WriteLine($"{donation:F2}");

        }
    }
}
