using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var End = double.Parse(Console.ReadLine());

            if (End % 2 == 0)
            {
                Console.WriteLine("Even");
            }

            else if (End % 2 == 1)
            {
                Console.WriteLine("Odd");
            }

             
        }
    }
}
