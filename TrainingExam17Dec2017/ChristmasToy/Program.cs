using System;
namespace ChristmasToy
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = 5 * size;
            int height = 2 * size + 3;

            Console.WriteLine("{0}{1}{0}",
                new string('-', size * 2),
                new string('*', size));

            int middle = size + 2;
            int star = 1;
            int dash = width / 3; 
            for (int row = 1; row <= size / 2; row++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                   new string('-', dash),
                    new string('*', star),
                    new string('&', middle));
                dash -= 2;
                star++;
                middle += 2;
            }

            int dashSecond = size - 1;
            int wave = width - 2 * dashSecond - 4;  
            for (int row = 1; row <= size / 2; row++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('-', dashSecond),
                    new string('*', 2),
                    new string('~', wave));
                dashSecond--;
                wave += 2;
            }

            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('-', size /2),
                new string('*', 1),
                new string('|', size * 4 - 2));

            int dashSecond2 = size - 1;
            int wave2 = width - 2 * dashSecond - 4;
            for (int row = size / 2; row >= 1; row--)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('-', dashSecond2),
                    new string('*', 2),
                    new string('~', wave2));
                dashSecond--;
                wave += 2;
            }
        }
    }
}
