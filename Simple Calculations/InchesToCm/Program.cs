using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches= ");
            const double inch = 2.54;
            double number = double.Parse(Console.ReadLine());
            double convert = number * inch;
            Console.Write("centimeters= ");
            Console.WriteLine(convert);
            
        }
    }
}
