using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                }

            }
            Console.WriteLine(max);

        }
    }
}
