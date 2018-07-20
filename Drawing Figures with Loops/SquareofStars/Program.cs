using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SquareofStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int row = 1; row <= number; row++)
            {
                Console.Write("*");
                for (int col = 1; col < number; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
