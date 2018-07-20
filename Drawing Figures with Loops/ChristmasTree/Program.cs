using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int row = 1; row <= number+1; row++)
            {
                

                for (int i = 1; i <= (number+1) - row; i++)
                {
                    Console.Write(" ");
                }

                for (int col = 3; col <= row+1; col++)
                {
            
                    Console.Write("*");
          

                }
                // vtora chast
              
                for (int Col = 0; Col <= row ; Col++)
                {
               
                    if (Col == 0)
                        Console.Write(" | ");
                   
                    else if (Col > 1)
                    Console.Write("*");
                }


                Console.WriteLine();
            }

        }
    }
}
