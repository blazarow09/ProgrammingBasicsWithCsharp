using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int wing = n - 2;
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0 && i != 1)
                {
                    Console.WriteLine($@"{new string('*', wing)}\ /{new string('*', wing)}");
                }
                else
                {
                    Console.WriteLine($@"{new string('-', wing)}\ /{new string('-', wing)}");
                }
            }
            Console.WriteLine($@"{new string(' ', wing + 1)}@{new string(' ', wing + 1)}");
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0 && i != 1)
                {
                    Console.WriteLine($@"{new string('*', wing)}/ \{new string('*', wing)}");
                }
                else
                {
                    Console.WriteLine($@"{new string('-', wing)}/ \{new string('-', wing)}");
                }
            }
        }
    }
}
