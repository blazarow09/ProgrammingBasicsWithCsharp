using System;
namespace MaxCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());

            int counter = -1;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    if (counter == maxCombinations)
                    {
                        return;
                    }
                    Console.Write($"<{i}-{j}>");
                }
            }
            Console.WriteLine();
        }
    }
}
