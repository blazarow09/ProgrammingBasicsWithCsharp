using System;
namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string num = number.ToString();

            int firtDigit = int.Parse(num[0].ToString());
            int secondDigit = int.Parse(num[1].ToString());
            int thirdDigit = int.Parse(num[2].ToString());
                             
            int rows = firtDigit + secondDigit;
            int cols = firtDigit + thirdDigit;

            for (int row = 1; row <= rows; row++)
            {
                for (int col = 1; col <= cols; col++)
                {
                    if (number % 5 == 0)
                    {
                        number -= firtDigit;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= secondDigit;
                    }
                    else
                    {
                        number += thirdDigit;
                    }
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
