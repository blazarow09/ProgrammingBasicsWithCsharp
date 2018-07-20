using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthCake = int.Parse(Console.ReadLine());
            int lenghtCake = int.Parse(Console.ReadLine());
            int S = widthCake * lenghtCake;
            int left = S;

            while (left >= 0)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    left -= n;
                }
                catch 
                {                    
                    Console.WriteLine("{0} pieces are left.", left);
                    break;
                }
                
            }
            if (left < 0)
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(left));
            }
        }
    }
}
