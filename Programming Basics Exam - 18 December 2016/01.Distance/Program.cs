using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PBExam18December2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());
            double firstHour = firstTime / 60;
            double secondHour = secondTime / 60;
            double thirdHour = thirdTime / 60;
            double distanceWithFirstTime = speed * firstHour;
            double percentIncrease = (speed + (speed * 0.10));
            double afterIncrease = percentIncrease * secondHour;
            double percentReduction = percentIncrease - (percentIncrease * 0.05);
            double afterReduction = percentReduction * thirdHour;
            double all = distanceWithFirstTime + afterIncrease + afterReduction;
           
            Console.WriteLine($"{all:F2}");

        }
    }
}
