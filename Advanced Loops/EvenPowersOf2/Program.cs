using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 1;
            Console.WriteLine(1);
            for (int i = 1; i < number; i += 2)
            {
                sum = sum * 4;
                if (sum % 4 == 0)
                {
                    Console.WriteLine(sum);

                }

            }
        }
    }
}
