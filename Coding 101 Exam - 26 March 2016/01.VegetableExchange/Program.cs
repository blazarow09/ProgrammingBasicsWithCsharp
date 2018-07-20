using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam26March2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double kgVeggies = double.Parse(Console.ReadLine());
            double kgFruits = double.Parse(Console.ReadLine());
            int totalKgVeg = int.Parse(Console.ReadLine());
            int totalKgFru = int.Parse(Console.ReadLine());
            double veggies = kgVeggies * totalKgVeg;
            double fruits = kgFruits * totalKgFru;
            double total = (veggies + fruits) / 1.94;
    
            Console.WriteLine(total);
        }
    }
}
