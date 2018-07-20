using System;

namespace Sword
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int width = (2 * size) + 1;

            Console.WriteLine("{0}/^\\{0}", new string('#', size - 1));

            int outside = size - 2;
            int spaceWidth = 3;
            for (int row = 1; row <= size / 2; row++)
            {
                Console.WriteLine("{0}.{1}.{0}",
                    new string('#', outside),
                    new string(' ', spaceWidth));
                outside--;
                spaceWidth += 2;
            }

            for (int row = 1; row <= 4; row++)
            {
                if (row == 1)
                {
                    Console.WriteLine("{0}|{1}S{1}|{0}",
                        new string('#', (size - 1) / 2),
                        new string(' ', size / 2));
                }
                else if (row == 2)
                {
                    Console.WriteLine("{0}|{1}O{1}|{0}",
                        new string('#', (size - 1) / 2),
                        new string(' ', size / 2));
                }
                else if (row == 3)
                {
                    Console.WriteLine("{0}|{1}F{1}|{0}",
                        new string('#', (size - 1) / 2),
                        new string(' ', size / 2));
                }
                else if (row == 4)
                {
                    Console.WriteLine("{0}|{1}T{1}|{0}",
                        new string('#', (size - 1) / 2),
                        new string(' ', size / 2));
                }
            }

            for (int row = 1; row <= width - (((size + 3) / 2) * 2) - 2; row++)
            {
                Console.WriteLine("{0}|{1} {1}|{0}",
                         new string('#', (size - 1) / 2),
                         new string(' ', size / 2));
            }

            for (int row = 1; row <= 3; row++)
            {
                if (row == 1)
                {
                    Console.WriteLine("{0}|{1}U{1}|{0}",
                        new string('#', (size - 1) / 2),
                        new string(' ', size / 2));
                }
                else if (row == 2)
                {
                    Console.WriteLine("{0}|{1}N{1}|{0}",
                        new string('#', (size - 1) / 2),
                        new string(' ', size / 2));
                }
                else if (row == 3)
                {
                    Console.WriteLine("{0}|{1}I{1}|{0}",
                        new string('#', (size - 1) / 2),
                        new string(' ', size / 2));
                }

            }

            Console.WriteLine("@{0}@", new string('=', width - 2));

            for (int row = 1; row <= size / 2; row++)
            {
                Console.WriteLine("{0}|{1}|{0}",
                    new string('#', (size + 3) /2 ),
                    new string(' ', width - (((size + 3) / 2) * 2) - 2));
            }

            Console.WriteLine("{0}\\{1}/{0}",
                new string('#',(size + 3) / 2),
            new string('.',width - (((size + 3) / 2) * 2) - 2));

        }
    }
}
