using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int row = 1; row <= number; row++)
            {
                for (int i = 0; i < number-row; i++)
                {
                    Console.Write(" ");
                }
               
                for (int col = 0; col < row; col++)
                {
                    Console.Write("* ");
            

                }

               
                Console.WriteLine();
            }
            for (int row = 1; row <= number; row++)
            {
                for (int col = 0; col < row - 1; col++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < number - row ; i++)
                {
                    Console.Write(" *");
                }

      
                Console.WriteLine();
            }
        }
    }
}
