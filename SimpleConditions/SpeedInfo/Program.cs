﻿using System;
namespace SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = double.Parse(Console.ReadLine());

            if (num <= 10)
            {
                Console.WriteLine("slow");
            }

            else if (num > 10 && num <= 50)
            {
                Console.WriteLine("average");
            }

            else if (num > 50 && num <= 150)
            {
                Console.WriteLine("fast");
            }

            else if (num > 150 && num <= 1000)
            {
                Console.WriteLine("ultra fast");
            }

            else if (num > 1000)
                    {
                Console.WriteLine("extremely fast");
                    }
        }
    }
}
