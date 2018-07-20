using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = n;
            int tochka = (n - 1) / 2;
            Console.Write(new string('.', ((n * 3) - 1) / 2));
            Console.Write(new string('x', 1));
            Console.Write(new string('.', ((n * 3) - 1) / 2));
            Console.WriteLine();
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.Write(@"/x\");
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.WriteLine();
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.Write("x|x");
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.WriteLine();
            for (int row = 1; row <= (n / 2) + 1; row++)
            {
                for (int col = 0; col < 1; col++)
                {
                    Console.Write(new string('.', tochka));
                    Console.Write(new string('x', x));
                    Console.Write(new string('|', 1));
                    Console.Write(new string('x', x));
                    Console.Write(new string('.', tochka));
                    tochka -= 1;
                    x += 1;
                }
                Console.WriteLine();

            }
            tochka += 1;
            x -= 1;
            for (int row = 1; row <= n / 2; row++)
            {
                for (int col = 0; col < 1; col++)
                {
                    tochka += 1;
                    x -= 1;
                    Console.Write(new string('.', tochka));
                    Console.Write(new string('x', x));
                    Console.Write(new string('|', 1));
                    Console.Write(new string('x', x));
                    Console.Write(new string('.', tochka));                  
                }
                Console.WriteLine();
            }
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.Write(@"/x\");
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.WriteLine();
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.Write(@"\x/");
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.WriteLine();
            for (int row = 1; row <= (n / 2) + 1; row++)
            {
                for (int col = 0; col < 1; col++)
                {
                    Console.Write(new string('.', tochka));
                    Console.Write(new string('x', x));
                    Console.Write(new string('|', 1));
                    Console.Write(new string('x', x));
                    Console.Write(new string('.', tochka));
                    tochka -= 1;
                    x += 1;
                }
                Console.WriteLine();

            }
            tochka += 1;
            x -= 1;
            for (int row = 1; row <= n / 2; row++)
            {
                for (int col = 0; col < 1; col++)
                {
                    tochka += 1;
                    x -= 1;
                    Console.Write(new string('.', tochka));
                    Console.Write(new string('x', x));
                    Console.Write(new string('|', 1));
                    Console.Write(new string('x', x));
                    Console.Write(new string('.', tochka));
                }
                Console.WriteLine();
            }
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.Write("x|x");
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.WriteLine();
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.Write(@"\x/");
            Console.Write(new string('.', ((n * 3) - 3) / 2));
            Console.WriteLine();
            Console.Write(new string('.', ((n * 3) - 1) / 2));
            Console.Write(new string('x', 1));
            Console.Write(new string('.', ((n * 3) - 1) / 2));
            Console.WriteLine();

        }
    }
}
