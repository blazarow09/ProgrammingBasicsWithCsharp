﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            int br = 0;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (n == a * b + c * d)
                            {
                                if (a < b && c > d)
                                {
                                    Console.Write($"{a}{b}{c}{d} ");
                                    br++;
                                    if (br == 4)
                                    {
                                        A = a;
                                        B = b;
                                        C = c;
                                        D = d;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (br >= 4)
            {
                Console.WriteLine($"Password: {A}{B}{C}{D}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}