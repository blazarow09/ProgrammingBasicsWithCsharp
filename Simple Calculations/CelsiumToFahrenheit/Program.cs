﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CelsiumToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());
            double F = C * 1.8 + 32;
            Console.WriteLine(Math.Round(F, 2));
        }
    }
}
