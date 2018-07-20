using System;

namespace ChristmassTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            const string middle = " | ";

            for (int row = 0; row <= size; row++)
            {
                string spaces = new string(' ', size - row);
                string stars = new string('*', row);

                Console.WriteLine("{0}{1}{2}{1}", spaces, stars, middle, stars);
            }
        }
    }
}
