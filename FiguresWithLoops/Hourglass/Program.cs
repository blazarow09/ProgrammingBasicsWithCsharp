using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int heightWeight = 2 * size + 1;

            Console.WriteLine("{0}", new string('*', heightWeight));
            Console.WriteLine(".*{0}*.", new string(' ', heightWeight - 4));

            int dot = 2;
            int A = heightWeight - 6;
            for (int row = 0; row <= heightWeight / 2 - 3; row++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', dot),
                    new string('@', A));
                dot++;
                A -= 2;
            }

            Console.WriteLine("{0}*{0}", new string('.', size));

            int dots = size - 1;
            for (int row = 0; row <= heightWeight / 2 - 3; row++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}",
                    new string('.', dots),
                    new string(' ', row));
                dots--;
            }

            Console.WriteLine(".*{0}*.", new string('@', heightWeight - 4));
            Console.WriteLine("{0}", new string('*', heightWeight));


        }
    }
}