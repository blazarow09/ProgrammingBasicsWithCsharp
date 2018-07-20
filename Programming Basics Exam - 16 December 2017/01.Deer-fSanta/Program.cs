using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DeerОfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double firstDeer = double.Parse(Console.ReadLine());
            double secondDeer = double.Parse(Console.ReadLine());
            double thirdDeer = double.Parse(Console.ReadLine());

            double firstDeerFood = firstDeer * days;
            double secondDeerFood = secondDeer * days;
            double thirdDeerFood = thirdDeer * days;
            double totalFood = firstDeerFood + secondDeerFood + thirdDeerFood;

            if (totalFood <= food)
            {
                double result = food - totalFood;
                Console.WriteLine("{0} kilos of food left.", Math.Floor(result));
            }
            else
            {
                double result = totalFood - food;
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(result));
            }
        }
    }
}
