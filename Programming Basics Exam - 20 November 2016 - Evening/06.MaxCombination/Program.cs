using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxNumbers = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {                 
                    Console.Write($"<{a}-{b}>");
                    sum += 1;
                    if (sum == maxNumbers)
                    {
                        return;
                    }
                }
            }
        }
    }
}
