using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int height = 7 * size + 3;
            int width = 8 * size + 2;

            Console.WriteLine("&${0}", new string('\'', width - 2));

            int leftDash = 2;
            int rightDash = width - 3;
            for (int row = 0; row < height / 8; row++)
            {
                Console.WriteLine("{0}\\{1}",
                    new string('\'', leftDash),
                    new string('\'', rightDash));
                leftDash++;
                rightDash--;
            }

            Console.WriteLine("{0}^'", new string('s', width / 2 - 1).Replace("s", "^*"));

            int spaces = width - size - 6;
            for (int row = 0; row < height / 8; row++)
            {
                Console.WriteLine("{0}\\\\{1}\\{2}//{0}'",
                    new string('\'', row),
                    new string(' ', size),
                    new string(' ', spaces));
                spaces -= 2;
            }

            Console.WriteLine("{0}\\{1}/{0}\'",
                new string('\'', size - 1),
                new string('~', size * 6 + 1));

            int dot = size;
            int space = size * 6 - 1;
            for (int row = 0; row < height / 8; row++)
            {
                Console.WriteLine("{0}\\{1}/{0}\'",
                    new string('\'', dot),
                    new string(' ', space));
                dot++;
                space -= 2;
            }
            int left = width - 6 * size - 3;
            Console.WriteLine("{0}\\{1}/{0}\'",
                new string('\'', left),
                new string('_', width - 2 * left - 3));
            int left2 = width - 6 * size - 2;
            Console.WriteLine("{0}\\{1}/{0}\'",
                new string('\'', left2),
                new string('.', width - 2 * left - 5));

            int left3 = width - 6 * size - 2;
            int slash = width - 6 * size - 1;
            int spacess = width - 2 * left3 - 5;
            for (int row = 0; row < height / 4 - 1; row++)
            {
                Console.WriteLine("{0}\\{1}/{0}\'",
                    new string('\'', slash),
                    new string(' ', spacess));
                slash++;
                spacess -= 2;
            }
            int left4 = 4 * size - 3;
            Console.WriteLine("{0}\\{1}/{0}\'",
                new string('\'', left4),
                new string('_', width - 2 * left4 - 3));
        }




    }
}