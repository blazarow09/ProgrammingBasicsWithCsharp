using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int moves = 0;
            int sum = 0;

            for (int a = 1; a <= N; a++)
            {
                for (int b = M; b >= 1; b--)
                {
                    sum = sum + (a * 2) + (b * 3);
                    moves += 1;
                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{moves} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        return;
                    }
                }
            }           
            if (sum <controlNumber)
            {
                Console.WriteLine($"{moves} moves");
            }
        }
    }
}
