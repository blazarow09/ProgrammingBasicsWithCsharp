using System;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 10;

            for (int i = 1; i < max; i++)
            {
                for (int j = 1; j < max; j++)
                {
                    for (int k = 1; k < max; k++)
                    {
                        for (int l = 1; l < max; l++)
                        {
                            if ((n % i == 0) && (n % j == 0) && (n % k == 0) && (n % l == 0))
                            {
                                Console.Write("{0}{1}{2}{3} ", i, j, k, l);
                            }
                        }
                    }
                }
            }

        }
    }
}