using System;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int width = (2 * size) + 2;

            int outerSpaces = size - 2;
            for (int row = 0; row < size - 1; row++)
            {
                Console.WriteLine("{0}/{1}|  |{1}\\",
                    new string(' ', outerSpaces),
                    new string(' ', row));
                outerSpaces--;
            }

            Console.WriteLine(new string('-', 2 * size + 2));
            int bla = size / 3;
            for (int row = 1; row <= width / 3; row++)
            {

                if (row == 1)
                {
                    Console.WriteLine("|{2}{0}{1}{0}{2}|",
                        new string('_', 1),
                        new string(' ', width - (2 * bla) - 4),
                        new string(' ', bla));
                }
                else if (row == 2)
                {
                    Console.WriteLine("|{2}{0}{1}{0}{2}|",
                       new string('@', 1),
                       new string(' ', width - (2 * bla) - 4),
                       new string(' ', bla));
                }
                else
                {
                    Console.WriteLine("|{0}|", new string(' ', width - 2));
                }

                if (row == width / 3)
                {
                    Console.WriteLine("|{0}OO{0}|", new string(' ', size - 1));
                    Console.WriteLine("|{0}/  \\{0}|", new string(' ', size - 2));
                    Console.WriteLine("|{0}||||{0}|", new string(' ', size - 2));
                }


            }

            int middle = size * 2;
            for (int row = 1; row <= size + 1; row++)
            {
                Console.WriteLine("{0}{1}{2}",
                    new string('\\', row),
                    new string('`', middle),
                    new string('/', row));
                middle -= 2;
            }
        }


    }
}