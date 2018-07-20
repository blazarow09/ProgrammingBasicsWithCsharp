using System;

namespace SumblimeLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int width = 2 * size;
            int stars = 2;
            int spaces = width - 2;
            for (int row = 1; row <= size; row++)
            {
                Console.WriteLine("{0}{1}",
                    new string(' ', spaces),
                    new string('*', stars));
                spaces -= 2;
                stars += 2;

            }

            stars = width - 2;
            spaces = width - stars;
            for (int row = 1; row <= 2; row++)
            {
                Console.WriteLine("{0}{1}",
                    new string('*', stars),
                    new string(' ', spaces));
                spaces += 2;
                stars -= 2;
            }

            stars = width - 2;
            spaces = width - stars;
            for (int row = 1; row <= 2; row++)
            {
                Console.WriteLine("{0}{1}",
                    new string('*', stars),
                    new string(' ', spaces));
                spaces -= 2;
                stars += 2;
            }

            stars = width - 2;
            spaces = width - stars;
            for (int row = 1; row <= 2; row++)
            {
                Console.WriteLine("{0}{1}",
                    new string(' ', spaces),
                    new string('*', stars));
                spaces += 2;
                stars -= 2;   
            }

            stars = width - 2;
            spaces = width- stars;
            for (int row = 1; row <= 2; row++)
            {
                Console.WriteLine("{0}{1}",
                    new string(' ', spaces),
                    new string('*', stars));
                spaces -= 2;
                stars += 2;
            }

            stars = width - 2;
            spaces = width - stars;
            for (int row = 1; row <= size - 1; row++)
            {
                Console.WriteLine("{0}{1}",
                    new string('*', stars),
                    new string(' ', spaces));
                stars -= 2;
                spaces += 2;
            }

        }
    }
}
