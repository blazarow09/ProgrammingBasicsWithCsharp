using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var firstNum = int.Parse(input[2].ToString());
            var secondNum = int.Parse(input[1].ToString());
            var thirdNum = int.Parse(input[0].ToString());

            for (int i = 1; i <= firstNum; i++)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    for (int k = 1; k <= thirdNum; k++)
                    {
                        var res = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {res};");
                    }
                }
            }
        }
    }
}
