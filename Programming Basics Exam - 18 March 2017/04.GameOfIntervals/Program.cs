using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int players = int.Parse(Console.ReadLine());
            double result = 0;
            double from0to9 = 0;
            double from10to19 = 0;
            double from20to29 = 0;
            double from30to39 = 0;
            double from40to50 = 0;
            double invalidNumbers = 0;
            double points = 0;
            for (int i = 1; i <= players; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    double sum = number * 0.20;
                    points += sum;
                    from0to9 += 1;
                }
                else if (number >= 10 && number <= 19)
                {
                    double sum = number * 0.30;
                    points += sum;
                    from10to19 += 1;
                }
                else if (number >= 20 && number <= 29)
                {
                    double sum = number * 0.40;
                    points += sum;
                    from20to29 += 1;
                }
                else if (number >= 30 && number <= 39)
                {
                    points += 50;
                    from30to39 += 1;
                }
                else if (number >= 40 && number <= 50)
                {
                    points += 100;
                    from40to50 += 1;
                }
                else
                {
                    points /= 2;
                    invalidNumbers += 1;
                }
            }
            from0to9 = from0to9 / players * 100;
            from10to19 = from10to19 / players * 100;
            from20to29 = from20to29 / players * 100;
            from30to39 = from30to39 / players * 100;
            from40to50 = from40to50 / players * 100;
            invalidNumbers = invalidNumbers / players * 100;
            Console.WriteLine($"{points:F2}");
            Console.WriteLine($"From 0 to 9: {from0to9:F2}%");
            Console.WriteLine($"From 10 to 19: {from10to19:F2}%");
            Console.WriteLine($"From 20 to 29: {from20to29:F2}%");
            Console.WriteLine($"From 30 to 39: {from30to39:F2}%");
            Console.WriteLine($"From 40 to 50: {from40to50:F2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers:F2}%");
        }
    }
}
