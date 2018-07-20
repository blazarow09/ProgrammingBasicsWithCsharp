using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = n;
            int width = (2 * n) + 3;
            int tirenca = width - 4;
            int stars = n/2;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($@"{new string('*', i)}\{new string('-',tirenca)}/{new string('*', i)}");
                tirenca -= 2;
            }
            if (n == 7)
            {
                for (int i = 0; i <= n / 3; i++)
                {
                    Console.WriteLine($@"|{new string('*', stars)}\{new string('*', n)}/{new string('*', stars)}|");
                    stars += 1;
                    n -= 2;
                }
            }
            else
            {
                for (int i = 0; i <= (n / 3) + 1; i++)
                {
                    Console.WriteLine($@"|{new string('*', stars)}\{new string('*', n)}/{new string('*', stars)}|");
                    stars += 1;
                    n -= 2;
                }
            }
            tirenca = width - 4;
            for (int i = 1; i <= m; i++)
            {
                Console.WriteLine($@"{new string('-', i)}\{new string('*', tirenca)}/{new string('-', i)}");
                tirenca -= 2;
            }
        }
    }
}
