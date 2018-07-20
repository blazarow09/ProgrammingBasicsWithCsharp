using System;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = 5 * size;

            int outerSymbols = size * 3;
            for (int row = 0; row < size; row++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', outerSymbols),
                    new string('-', row),
                    new string('-', width - outerSymbols - row  - 2));
            }

            for (int row = 0; row < size / 2; row++)
            {
                Console.WriteLine("{0}*{1}*{1}",
                    new string('*', outerSymbols),
                    new string('-', size - 1));
            }

            int midSymbols = size - 1;
            int rightSymbols = size - 1;
            for (int row = 0; row < size / 2 - 1; row++)
            { 
             Console.WriteLine("{0}*{1}*{2}",
                    new string('-', outerSymbols),
                    new string('-', midSymbols),
                    new string('-', rightSymbols));
                outerSymbols--;
                midSymbols+= 2;
                rightSymbols--;       
            }
            Console.WriteLine("{0}*{1}*{2}",
                    new string('-', outerSymbols),
                    new string('*', midSymbols),
                    new string('-', rightSymbols));
        }
    }
}
