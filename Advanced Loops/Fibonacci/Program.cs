using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
           
            for (int i = 0; i < number - 1; i++)
            {
                int sum = f0 + f1;
                f0 = f1;
                f1 = sum;
            }
                Console.WriteLine(f1);           
        }
    }
}
