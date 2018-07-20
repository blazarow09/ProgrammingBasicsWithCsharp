using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int total = int.Parse(Console.ReadLine());
            
            for (int a = 0; a <= one; a++)
            {
                for (int b = 0; b <= two; b++)
                {
                    for (int c = 0; c <= five; c++)
                    {
                        int br1lv = a * 1;
                        int br2lv = b * 2;
                        int br5lv = c * 5;
                        if (a <= one && b <= two && c <= five)
                        {
                            if (br1lv + br2lv + br5lv == total)
                            {
                                Console.WriteLine($"{a} * 1 lv. + {b} * 2 lv. + {c} * 5 lv. = {total} lv.");
                            }
                        }
                    }
                }
            }


        }
    }
}
