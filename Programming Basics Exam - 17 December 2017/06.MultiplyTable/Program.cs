using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num1 = n % 10;
            n /= 10;
            int num2 = n % 10;
            n /= 10;
            int num3 = n % 10;
            for (int a = 1; a <= num1; a++)
            {
                for (int b = 1; b <= num2; b++)
                {
                    for (int c = 1; c <= num3; c++)
                    {
                        Console.WriteLine("{0} * {1} * {2} = {3};", a, b, c, (a * b * c));
                    }
                }
            }
        }
    }
}
