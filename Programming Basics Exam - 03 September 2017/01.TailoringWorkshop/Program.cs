﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam03September2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTables = int.Parse(Console.ReadLine());
            double lenghtOfTables = double.Parse(Console.ReadLine());
            double widthOfTables = double.Parse(Console.ReadLine());

            double totalAreaOfTablecloths = numberOfTables * (lenghtOfTables + 2 * 0.30) * (widthOfTables + 2 * 0.30);
            double totalAreaOfCarriageCover = numberOfTables * (lenghtOfTables / 2) * (lenghtOfTables / 2) ;
            double priceInDollars = (totalAreaOfTablecloths * 7) + (totalAreaOfCarriageCover * 9);
            double priceInLeva = priceInDollars * 1.85;
       
            Console.WriteLine($"{priceInDollars:F2} USD");
            Console.WriteLine($"{priceInLeva:F2} BGN");
        }
    }
}
