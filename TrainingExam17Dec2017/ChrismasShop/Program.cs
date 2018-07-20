using System;
namespace ChrismasShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int startFirstNum = start / 1000;
            int startSecondNum = start / 100 % 10;
            int startThirdNum = start / 10 % 10;
            int startForthNum = start % 10;

            int endFirstNum = end / 1000;
            int endSecondNum =end  / 100 % 10;
            int endThirdNum = end / 10 % 10;
            int endForthNum = end % 10;

            for (int i = startFirstNum; i <= endFirstNum; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = startSecondNum; j <= endSecondNum; j++)
                    {

                    }
                }
            }
        }
    }
}
