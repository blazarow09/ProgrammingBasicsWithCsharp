using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int nod = 0;
            while (b != 0)
            {
                nod = b;
                b = a % b;
                a = nod;
            }
            Console.WriteLine(nod);
        }
    }
}
