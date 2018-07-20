using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var star = 1;
            if (size % 2 == 0) star++;
            {
                for (int row = 1; row <= (size + 1) / 2; row++)
                {
                    int padding = ((size - star) / 2);
                    Console.Write(new string('-', padding));
                    Console.Write(new string('*', star));
                    Console.WriteLine(new string('-', padding));
                    star += 2;
                }
            }
            for (int row = 1; row < size / 2 + 1; row++)
            {
                Console.WriteLine("|" + new string('*', size - 2) + "|");
            }
        }
    }
}


