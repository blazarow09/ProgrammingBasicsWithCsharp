using System;

namespace SumTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationCounter = 0;
            bool isNumberMagic = false;

            for (int i = start; i >= end; i--)
            {
                if (isNumberMagic == true)
                {
                    break;
                }
                for (int j = start; j >= end; j--)
                {
                    combinationCounter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", combinationCounter, i, j, magicNumber);
                        isNumberMagic = true;
                        break;
                    }
                }
                
            }
            if (isNumberMagic == false)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combinationCounter, magicNumber);

            }

        }
    }
}
