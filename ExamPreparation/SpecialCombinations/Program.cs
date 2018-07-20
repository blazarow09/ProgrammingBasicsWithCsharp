using System;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {


            int hundredsLimit = int.Parse(Console.ReadLine());
            int tensLimit = int.Parse(Console.ReadLine());
            int unitsLimit = int.Parse(Console.ReadLine());



            for (int i = 1; i <= hundredsLimit; i++)
            {
                for (int j = 1; j <= tensLimit; j++)
                {
                    for (int k = 1; k <= unitsLimit; k++)
                    {
                        if (i % 2 == 0)
                        {
                            if (j == 2 || j == 3 || j == 5 || j == 7)
                            {

                                if (k % 2 == 0)
                                {
                                    Console.WriteLine("{0} {1} {2}", i, j, k);
                                }
                            }
                        }

                    }
                }
            }
        }
    }
}