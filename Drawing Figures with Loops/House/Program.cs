using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int stars = 1;
            if (number % 2 == 0)
            {
                stars = 2;
            }
            if (number >= 2 && number < 100)
            {

                for (int row = 1; row <= (number+1) / 2 ; row++)
                {
                    int tirenca = (number - stars) / 2;
                    Console.Write(new string('-', tirenca));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', tirenca));
                    Console.WriteLine();
                    stars = stars + 2;
                }
                int houseBase = number / 2;
                for (int row = 0; row < houseBase; row++)
                {
                    int s = number - 2;
                    Console.Write("|");
                    Console.Write(new string('*', s));
                    Console.Write("|");
                    Console.WriteLine();
                }
             

            }
        }
    }
}
