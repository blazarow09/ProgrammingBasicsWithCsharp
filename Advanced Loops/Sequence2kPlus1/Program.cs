using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 1; 
            Console.WriteLine(1);
            for (int i = 1; i < number; i += 3)
            {
                sum = (sum * 2) + 1;
                if (sum <= number)
                {
                    Console.WriteLine(sum);
                }
                if (sum > number)
                {
                    break;
                }
            }
        }
    }
}
