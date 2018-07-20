using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int diff = 0;
            int MAX = 0;

            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n;
 
                if (n > MAX)
                {
                    MAX = n;
                }
                diff = Math.Abs((MAX * 2) - sum);
    
            }
            if (MAX == (sum - MAX))
            {
                Console.WriteLine("Yes sum = " + MAX);
            }
            else
            {
                
                Console.WriteLine("No diff = " + diff);

            }
        }
    }
}
