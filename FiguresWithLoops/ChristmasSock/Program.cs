using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("|" + new string('-', size * 2) + "|");
            Console.WriteLine("|" + new string('*', size * 2) + "|");
            Console.WriteLine("|" + new string('-', size * 2) + "|");

            int wave = 2;
            int dash = size - 1;
            int dashBottom = 2;
            int waveBottom = size * 2 - 4;

            if (size % 2 == 0)
            {
                for (int row = 1; row <= size - 1; row++)
                {
                    Console.WriteLine("|{0}{1}{0}|", new string('-', dash),
                        new string('~', wave));
                    dash--;
                    wave += 2;
                }
                for (int row = 1; row <= size - 2; row++)
                {
                    Console.WriteLine("|{0}{1}{0}|", new string('-', dashBottom),
                        new string('~', waveBottom));
                    dashBottom++;
                    waveBottom -= 2;
                }
            }
            else
            {
                int waves = size * 2 - 4;
                for (int row = 1; row <= size - 1; row++)
                {
                    Console.WriteLine("|{0}{1}{0}|", new string('-', dash), new string('~', wave));
                    dash--;
                    wave += 2;
                }
                for (int row = 1; row <= size - 2; row++)
                {
                    Console.WriteLine("|{0}{1}{0}|", new string('-', dashBottom), new string('~', waves));
                    dashBottom++;
                    waves -= 2;
                }
            }
       
            var dotsCount = size * 2 + 1;
            var tireLeftCount = 0;

            for (int i = 0; i < size + 2; i++)
            {
                if (i == size / 2)
                {
                    Console.WriteLine(new string('-', tireLeftCount) + "\\" +
                        new string('.', size - 2) + "MERRY" + new string('.', size - 2) + "\\");
                }
                else if (i == size / 2 + 2)
                {
                    Console.WriteLine(new string('-', tireLeftCount) + "\\" +
                        new string('.', size - 2) + "X-MAS" + new string('.', size - 2) + "\\");
                }
                else
                {

                    Console.WriteLine(new string('-', tireLeftCount) + "\\" + new string('.', dotsCount) +
                        "\\");
                }
                tireLeftCount++;

            }
            Console.WriteLine(new string('-', size + 2) + "\\" + new string('_', size * 2 + 1) + ")");
        }
    }
}


