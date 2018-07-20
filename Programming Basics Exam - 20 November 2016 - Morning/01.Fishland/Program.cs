using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam20November2016Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPrice = double.Parse(Console.ReadLine());
            double tsatsaPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double midiKg = double.Parse(Console.ReadLine());

            double palamudPrice = skumriaPrice + (skumriaPrice * 0.60);
            double palamudAmount = palamudKg * palamudPrice;
            double safridPrice = tsatsaPrice + (tsatsaPrice * 0.80);
            double safridAmount = safridKg * safridPrice;
            double midiAmount = midiKg * 7.50;
            double allAmount = palamudAmount + safridAmount + midiAmount;
            
            Console.WriteLine($"{allAmount:F2}");

        }
    }
}
