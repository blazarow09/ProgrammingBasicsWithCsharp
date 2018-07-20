using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int dots = (12 * size - 6) / 2;
            int sharps = 1;

            for (int row = 0; row < 2 * size; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', sharps));
                dots -= 3;
                sharps += 6;
            }
            dots = 3;
            sharps -= 12;
            for (int i = 0; i < size - 2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', dots - 1), new string('#', sharps), new string('.', dots));
                dots += 3;
                sharps -= 6;
            }
            dots = 3;
            sharps = 12;

            for (int row = 0; row < size; row++)
            {
                if (size == size - 1)
                {
                    Console.WriteLine("@" + new string('-', dots - 1) + new string('#', sharps) + new string('-', sharps));
                }
                else
                    Console.WriteLine("|" + new string('-', dots + 2) + new string('#', sharps - 3));
            }


        }
    }
}


