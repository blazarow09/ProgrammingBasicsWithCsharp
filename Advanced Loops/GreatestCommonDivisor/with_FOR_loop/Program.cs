using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NOD_withFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());

            for (int i = N2; i >= 0;)
            {
                i = N2;
                N2 = N1 % N2;
                N1 = i;
                if (N1 % i == 0 && N2 % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
