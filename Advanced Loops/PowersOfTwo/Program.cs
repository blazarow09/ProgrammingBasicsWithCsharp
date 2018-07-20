using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(sum);
                sum = sum * 2;
            }
        }
    }
}
