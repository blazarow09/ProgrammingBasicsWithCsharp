using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }

            else if (grade <= 5.49)
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
