﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else {
                Console.WriteLine(number2);
            }
        }
    }
}
