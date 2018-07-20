using System;
namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int midDots = size;

            for (int row = 0; row < size -1; row++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.', row),
                    new string('.', midDots));
                midDots--;
            }

            Console.WriteLine("{0}{1}{0}",new string('.', size - 1), new string('*', 5));
            Console.WriteLine(new string('*', 2 * size + 3));
            Console.WriteLine("{0}{1}{0}", new string('.', size - 1), new string('*', 5));

            int leftRightDots = size - 2;
            midDots = 2;
            for (int row = 0; row < size - 1; row++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.', leftRightDots),
                    new string('.', midDots));
                leftRightDots--;
                midDots++;
            }
        }
    }
}
