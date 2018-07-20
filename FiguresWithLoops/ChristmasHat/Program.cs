using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = 4 * size + 1;
            int height = 2 * size + 5;
            Console.WriteLine("{0}/|\\{0}",new string('.', size * 2 - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', size * 2 - 1));
            //Console.WriteLine(new string('.', size * 2 - 1) + "/|\\" +
            //    new string('.', size * 2 - 1));
            //Console.WriteLine(new string('.', size * 2 - 1) + "\\|/" +
            //   new string('.', size * 2 - 1));

            int padding = size * 2 - 1;
            int shading = size * 2 - 1;
            if (size % 2 == 0)
            {
                for (int row = 0; row <= height - 6; row++)
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', padding), new string('-', row));
                    //Console.WriteLine(new string('.', padding) + "*"
                    //    + new string('-', row) + "*"
                    //    + new string('-', row) + "*"
                    //    + new string('.', padding));
                    padding--;
                }
            }
            else
            {
                for (int row = 0; row <= height - 6; row++)
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', shading), new string('-', row));
                    //Console.WriteLine(new string('.', shading) + "*"
                    //   + new string('-', row) + "*"
                    //   + new string('-', row) + "*"
                    //   + new string('.', shading));
                    shading--;
                }
            }

            Console.WriteLine(new string('*', width));
            Console.WriteLine(new string('s', width / 2).Replace("s", "*.") + "*");
            Console.WriteLine(new string('*', width));

        }
    }
}


