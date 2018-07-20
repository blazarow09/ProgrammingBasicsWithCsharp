using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            if(inputUnit == "mm")
            {
                number = number / 1000;
            }
            if (inputUnit == "cm")
            {
                number = number / 100;
            }
            if (inputUnit == "mi")
            {
                number = number / 0.000621371192;
            }
            if (inputUnit == "in")
            {
                number = number / 39.3700787;
            }
            if (inputUnit == "km")
            {
                number = number / 0.001;
            }
            if (inputUnit == "ft")
            {
                number = number / 3.2808399;
            }
            if (inputUnit == "yd")
            {
                number = number / 1.0936133;
            }
            if (outputUnit == "mm")
            {
                number = number * 1000;
            }
            if (outputUnit == "cm")
            {
                number = number * 100;
            }
            if (outputUnit == "mi")
            {
                number = number * 0.000621371192;
            }
            if (outputUnit == "in")
            {
                number = number * 39.3700787;
            }
            if (outputUnit == "km")
            {
                number = number * 0.001;
            }
            if (outputUnit == "ft")
            {
                number = number * 3.2808399;
            }
            if (outputUnit == "yd")
            {
                number = number * 1.0936133;
            }
            Console.WriteLine(Math.Round(number, 8));


        }
    }
}
