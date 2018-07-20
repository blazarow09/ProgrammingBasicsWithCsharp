using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int row = 0; row < number; row++)
            {
                for (int col = 1 + row; col <= number + row; col++)
                {
                    
                    if (col > number)
                    {
                        Console.Write(2 * number - col + " ");
                    }
                    else
                    {
                        Console.Write(col + " ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
