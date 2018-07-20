using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            //TOP
            string border = new string('.', size + 1);
            string midBorder = new string('_', 2 * size + 1);
            Console.WriteLine("{0}{1}{0}", border, midBorder);


            int lines = size * 2 - 1;

            for (int row = 0; row <= size; row++)
            {
                if (row < size)
                {
                    Console.Write(new string('.', size - row) + "//");
                    Console.Write(new string('_', lines) + "\\\\");
                    Console.WriteLine(new string('.', size - row));
                    lines += 2;
                }
            }
            string midLines = new string('_', size * 2 - 3);
            Console.WriteLine("//" + midLines + "STOP!7" + midLines + "\\\\");

            for (int row = 0; row <= size; row++)
            {
                if (row < size)
                {
                    Console.Write(new string('.', row) + "\\\\");
                    Console.Write(new string('_', lines) + "//");
                    Console.WriteLine(new string('.', row));
                    lines -= 2;
                }
            }


        }
    }
}


