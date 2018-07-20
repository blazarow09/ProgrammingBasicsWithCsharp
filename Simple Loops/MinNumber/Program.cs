using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            for (int i = 0; i < number - 1; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n < min)
                {
                    min = n;
                }

            }
            Console.WriteLine(min);
        }
    }
}
