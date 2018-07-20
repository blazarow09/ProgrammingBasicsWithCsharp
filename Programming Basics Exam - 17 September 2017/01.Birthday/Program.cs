using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam17September2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double volumeOfAquarium = lenght * width * height;
            double totalLiters = volumeOfAquarium * 0.001;
            double percent = p * 0.01;
            double neededLiters = totalLiters * (1 - percent);

            Console.WriteLine($"{neededLiters:F3}");
        }
    }
}
