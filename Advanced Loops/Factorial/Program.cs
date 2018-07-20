using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;       
            }
            Console.WriteLine(sum);
        }
    }
}
