using System;
namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());

            if (secondDigit > firstDigit)
            {
                for (int first = firstDigit; first <= secondDigit; first++)
                {
                    for (int second = firstDigit; second <= secondDigit; second++)
                    {
                        for (int third = firstDigit; third <= secondDigit; third++)
                        {
                            for (int forth = firstDigit; forth <= secondDigit; forth++)
                            {
                                bool oddEven = (first % 2 == 0 && forth % 2 != 0 || first % 2 != 0 && forth % 2 == 0);
                                bool biggerFirst = first > forth;
                                bool evenSum = (second + third) % 2 == 0;

                                if (oddEven && biggerFirst && evenSum)
                                {
                                    Console.Write($"{first}{second}{third}{forth} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
