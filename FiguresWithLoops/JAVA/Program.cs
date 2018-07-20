using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = 3 * size + 6;
            int height = 3 * size + 1;

            for (int row = 1; row <= size; row++)
            {
                Console.Write(new string(' ', size));
                Console.WriteLine(new string('s', 3).Replace("s", "~ "));
            }

            Console.WriteLine(new string('=', size * 3 + 5));

            if (size % 2 == 0)
            {
                for (int i = 0; i < size / 2 - 1; i++)
                {
                    Console.WriteLine("|" + new string('~', size * 2 + 4) + "|"
                        + new string(' ', size - 1) + "|");
                }
                Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', size), new string(' ', size - 1));
                for (int i = 0; i < size / 2 - 2; i++)
                {
                    Console.WriteLine("|" + new string('~', size * 2 + 4) + "|"
                        + new string(' ', size - 1) + "|");
                }

            }
            else
            {
                for (int row = 1; row <= (size - 3) / 2; row++)
                {
                    Console.WriteLine("|" + new string('~', size * 2 + 4) + "|"
                        + new string(' ', size - 1) + "|");
                }
                Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', size), new string(' ', size - 1));
                for (int row = 1; row <= (size - 3) / 2; row++)
                {
                    Console.WriteLine("|" + new string('~', size * 2 + 4) + "|"
                        + new string(' ', size - 1) + "|");
                }
            }

            Console.WriteLine(new string('=', size * 3 + 5));

            int padding = size * 2 + 4;
            for (int row = 0; row < size; row++)
            {
                Console.Write(new string(' ', row));
                Console.WriteLine("\\" + new string('@', padding) + "/");
                padding -= 2;
            }

            Console.WriteLine(new string('=', size * 2 + 6));
        }
    }
}