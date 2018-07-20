using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int height = 4 * size + 4;
            int width = 3 * size + 1;

            int wave = size - 2;
            int dots = width - 2 - wave;

            Console.WriteLine("+{0}+{1}",
                new string('~', wave),
                new string('.', dots));

            int rightDots = size * 2;
            for (int row = 0; row < height / 2 - 1; row++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}",
                    new string('.', row),
                    new string('~', wave),
                    new string('.', rightDots));
                rightDots--;
            }

            int dot = size * 2;
            for (int row = 0; row < height / 2 - 1; row++)
            {
                Console.WriteLine("{0}\\{1}|{2}|",
                    new string('.', row),
                    new string('.', dot),
                    new string('~', wave));
                dot--;
            }

            Console.WriteLine("{0}+{1}+",
                new string('.', dots),
                new string('~', wave));
        }
    }
}


