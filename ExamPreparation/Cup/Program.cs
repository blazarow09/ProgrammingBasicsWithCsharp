using System;

class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int width = 5 * size;

        var outerDots = size;
        int middleSymbols = size * 3;
        for (int row = 1; row <= size / 2; row++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', outerDots),
                new string('#', middleSymbols));
            outerDots++;
            middleSymbols -= 2;
        }

        outerDots = width / 3 - 1;
        middleSymbols = size * 2 - 2;
        for (int row = 1; row <= size / 2 + 1; row++)
        {
            Console.WriteLine("{0}#{1}#{0}",
                new string('.', outerDots),
                new string('.', middleSymbols));
            outerDots++;
            middleSymbols -= 2;

            if (row == size / 2 + 1)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', size * 2),
                    new string('#', size));
            }
        }

        outerDots = size * 2 - 2;
        middleSymbols = size + 4;
        for (int row = 1; row <= size / 2; row++)
        {
            Console.WriteLine("{0}{1}{0}",
                   new string('.', outerDots),
                   new string('#', middleSymbols));

            if (row == size / 2)
            {
                Console.WriteLine("{0}D^A^N^C^E^{1}",
                    new string('.', (width - 10) / 2),
                    new string('.', (width - 10) / 2));

            }
        }

        for (int row = 1; row <= size / 2 + 1; row++)
        {
            Console.WriteLine("{0}{1}{0}",
                    new string('.', outerDots),
                    new string('#', middleSymbols));
        }

    }
}
