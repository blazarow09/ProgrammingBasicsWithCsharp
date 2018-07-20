using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = 2 * size + 3;

            int padding = width - 4;
            for (int row = 1; row <= size; row++)
            {

                Console.WriteLine(new string('*', row) + "\\" +
                    new string('-', padding) + "/" +
                    new string('*', row));
                padding -= 2;

            }

            int midStars = size;
            int leftRightStars = size / 2;

            for (int row = 1; row < size / 3 + 1; row++)
            {
                Console.WriteLine("|" + new string('*', leftRightStars) + "\\" +
                    new string('*', midStars) + "/" +
                    new string('*', leftRightStars) + "|"
                    );
                leftRightStars += 1;
                midStars -= 2;
            }

            int shading = width - 4;
            for (int row = 1; row <= size; row++)
            {

                Console.WriteLine(new string('-', row) + "\\" +
                    new string('*', shading) + "/" +
                    new string('-', row));
                shading -= 2;

            }
        }
    }
}


