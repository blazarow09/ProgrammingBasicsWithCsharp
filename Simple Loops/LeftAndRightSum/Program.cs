using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int rsum = 0;
            int lsum = 0;
            for (int i = 0; i < number; i++)
            {
                leftSum = int.Parse(Console.ReadLine());
                lsum += leftSum;

            }
            for (int i = 0; i < number; i++)
            {
                rightSum = int.Parse(Console.ReadLine());
                rsum += rightSum;
            }
            if (lsum == rsum)
            {
                Console.WriteLine("Yes, sum = "+ lsum);
            }
            else
            {
                Console.WriteLine("No, diff = "+ Math.Abs(lsum - rsum));
            }
        }
    }
}
