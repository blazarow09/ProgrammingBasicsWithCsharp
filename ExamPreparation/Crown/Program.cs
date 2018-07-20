using System;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = (2 * size) - 1;
            int height = (size / 2) + 4;

            Console.WriteLine("@{0}@{0}@", new string(' ', size - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ',size -3));
            int spaces = (width - 9) / 2;
            int midDots = 1;
       
                for (int row = 0; row < size / 2; row++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                    new string('.', row),
                    new string(' ', spaces),
                    new string('.', midDots));
                spaces -= 2;
                midDots += 2;
            }
        }
    }
}
