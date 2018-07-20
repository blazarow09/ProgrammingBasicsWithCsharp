using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string stars = new string('*', size - 2);
            string dashes = new string('-', size - 2);
            for (int row = 1; row < 2 * (size - 2) + 1; row++)
            {
                for (int col = 1; row <= size - 2; row++)
                {
                    if (row % 2 == 1)
                    {
                        Console.WriteLine(stars + "\\ " + "/" + stars);
                    }
                    else
                    {
                        Console.WriteLine(dashes + "\\ " + "/" + dashes);
                    }
                }
            }

            Console.WriteLine(new string(' ', size - 1) + "@");

            for (int row = 1; row < 2 * (size - 2) + 1; row++)
            {
                for (int col = 1; row <= size - 2; row++)
                {
                    if (row % 2 == 1)
                    {
                        Console.WriteLine(stars + "/ " + "\\" + stars);
                    }
                    else
                    {
                        Console.WriteLine(dashes + "/ " + "\\" + dashes);
                    }
                }
            }
        }
    }
}


