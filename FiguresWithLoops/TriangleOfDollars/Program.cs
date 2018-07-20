using System;
namespace TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("$ ");

                }
                Console.WriteLine("$");
            }
        }
    }
}
