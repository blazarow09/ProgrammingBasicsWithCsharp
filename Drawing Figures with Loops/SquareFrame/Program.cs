using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 2)
            {
                Console.WriteLine("+ +");
            }
            else
            for (int row = 1; row <= number; row++)
            {
                
                if (row == 1)
                {
                    Console.Write("+");
                }
                if (row > 1 && row < number )
                {
                    Console.Write("|");
                }
                if (row == number)
                {
                    Console.Write("+");
                }
                
                for (int col = 1; col < number-1 ; col++)
                {
                    Console.Write(" -");

                    if (col == (number - 2) && row == 1)
                    {
                        Console.Write(" +");
                    }

                    if (col == (number - 2) && row == number)
                    {
                        Console.Write(" +");
                    }
                    if (col == (number - 2) && row != number && row != 1)
                    {
                        Console.Write(" |");
                    }


                   
                    
                    
                }
                Console.WriteLine();

            }
        }
    }
}
