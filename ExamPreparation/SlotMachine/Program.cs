using System;

namespace SlotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            char m = char.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            char k = char.Parse(Console.ReadLine());
            int k1 = int.Parse(Console.ReadLine());

            int sum1 = n + n1;
            int sum2 = m + m1;
            int sum3 = k + k1;

            if(sum1 ==(char)'@' && sum2 == (char)'@' && sum3 == (char)'@')
            {
                Console.Write("@@@ \n!!! YOU LOSE EVERYTHING !!!");
            }
            else if (sum1 == (char)'7' && sum2 == (char)'7' && sum3 == (char)'7')
            {
                Console.WriteLine("777 \n *** JACKPOT ***");
            }
            else
            {
                Console.WriteLine($"{(char)sum1}{(char)sum2}{(char)sum3}");
            }   
        }
    }
}

