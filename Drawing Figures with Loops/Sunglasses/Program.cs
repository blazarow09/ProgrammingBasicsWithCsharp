using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            if (number >= 3 && number <= 100)
            {
                for (int row = 1; row <= number; row++)
                {
                    //lqva chast
                    for (int col = 1; col <= number * 2; col++)
                    {
                        if ((row > 1 && row < number) && (col > 1 && col < (number * 2)))
                            Console.Write("/");
                        else
                        Console.Write("*");
                    }
                    // sredna chast
                    for (int col = 1; col <= number; col++)
                    {
                        if (number % 2 == 0)
                        {
                            if (row == number / 2)
                                Console.Write("|");
                            else
                                Console.Write(" ");
                        }
                        else
                        {
                            if (row == (number / 2) +1)
                                Console.Write("|");
                            else
                                Console.Write(" ");
                        }

                    }
                    // dqsna chast
                    for (int col = 1; col <= number * 2; col++)
                    {
                        if ((row > 1 && row < number) && (col > 1 && col < (number * 2)))
                            Console.Write("/");
                        else
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
