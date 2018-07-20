using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double firstPipe = P1 * H;
            double secondPipe = P2 * H;
            double total = firstPipe + secondPipe;

            if (total <= V)
            {
                double fullPercent = Math.Truncate(total / V * 100);
                double firstPipePercent = Math.Truncate(firstPipe / total * 100);
                double secondPipePercent = Math.Truncate(secondPipe / total * 100);

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", fullPercent, firstPipePercent, secondPipePercent);

            }
            else
            {
                double overflows = total - V;
                Console.WriteLine($"For {H} hours the pool overflows with {overflows:F1} liters.");
            }
        }
    }
}
