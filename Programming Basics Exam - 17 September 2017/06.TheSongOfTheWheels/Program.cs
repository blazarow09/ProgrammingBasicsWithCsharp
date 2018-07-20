using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int sum = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if((a * b) + (c * d) == n && a < b && c > d)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                sum += 1;
                                if (sum == 4)
                                {
                                    num1 = a;
                                    num2 = b;
                                    num3 = c;
                                    num4 = d;
                                }
                                
                            }
                        }
                    }
                    
                }                
            }
            
            if (num1 != 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {num1}{num2}{num3}{num4}");
            }
            else
            {
                if (sum == 0)
                {
                    Console.WriteLine("No!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("No!");
                }
            }
        }
    }
}
