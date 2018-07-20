using System;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int width = 3 * size;

            int outerDots = width / 2 - 1;
            Console.WriteLine("{0}/\\{0}", new string('.', outerDots));

            int midSpaces = 2;
            for (int row = 0; row <= size - 2; row++)
            {
                Console.WriteLine("{0}/{1}\\{0}",
                    new string('.', outerDots - 1),
                    new string(' ', midSpaces));
                outerDots--;
                midSpaces += 2;
                
            }

            Console.WriteLine("{0}{1}{0}", new string('.', size / 2), new string('*', width - (2 * size / 2)));

            for (int row = 1; row <= size * 2; row++)
            {
                Console.WriteLine("{0}|{1}|{0}",
                    new string('.', size / 2),
                    new string('\\', width - (2 * size / 2) - 2));
            }

            outerDots = size / 2;
            midSpaces = width - (2 * size / 2) - 2;
            for (int row = 1; row <= size / 2; row++)
            {
                Console.WriteLine("{0}/{1}\\{0}",
                    new string('.', outerDots),
                    new string('*', midSpaces));
                outerDots--;
                midSpaces += 2;
            }
        }
    }
}
