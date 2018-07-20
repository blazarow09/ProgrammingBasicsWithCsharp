using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tirenca = (2 * n) - 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($@"{new string('-', 3 * n)}*{new string('-', i)}*{new string('-', tirenca)}");
                tirenca -= 1;
            }
            tirenca += 1;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine($@"{new string('*', 3 * n)}*{new string('-', n - 1)}*{new string('-', tirenca)}");
            }
            for (int i = 0; i < n / 2; i++)
            {
                if (i == (n / 2) - 1)
                {
                    Console.WriteLine($@"{new string('-', (3 * n) - i)}*{new string('*', (n - 1) + i * 2)}*{new string('-', tirenca - i)}");
                }
                else
                {
                    Console.WriteLine($@"{new string('-', (3 * n) - i)}*{new string('-', (n - 1) + i * 2)}*{new string('-', tirenca - i)}");
                }
            }
        }
    }
}
