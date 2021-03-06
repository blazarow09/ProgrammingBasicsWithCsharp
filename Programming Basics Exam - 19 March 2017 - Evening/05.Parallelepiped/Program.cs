﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = (2 * n) + 1;
            int dots = (n * 2) + 1;
            Console.WriteLine($@"+{new string('~', n - 2)}+{new string('.', dots)}");
            dots -= 1;
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine($@"|{new string('.', i)}\{new string('~', n - 2)}\{new string('.', dots)}");
                dots -= 1;
            }
            dots = n * 2;
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine($@"{new string('.', i)}\{new string('.',dots )}|{new string('~', n - 2)}|");
                dots -= 1;
            }
            dots = (n * 2) + 1;
            Console.WriteLine($@"{new string('.', dots)}+{new string('~', n - 2)}+");
        }
    }
}
