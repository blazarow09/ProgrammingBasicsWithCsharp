using System;

namespace TicketCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
 
            for (int j = 66; j <= 76; j+=2)
            {
                for (int k = 102; k >= 97; k--)
                {
                    for (int m = 65; m <= 67; m++)
                    {
                        for (int o = 1; o <= 10; o++)
                        {
                            for (int p = 10; p >= 1; p--)
                            {
                                if (comb == num)
                                {
                                    var prize = j + k + m + o + p;
                                    Console.WriteLine($"Ticket combination: {(char)j}{(char)k}{(char)m}{o}{p}");
                                    Console.WriteLine($"Prize: {prize:f0} lv.");
                                    return;
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
