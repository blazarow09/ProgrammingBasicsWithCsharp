using System;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double firstDay = double.Parse(Console.ReadLine());

            double allKg = firstDay;
            for (int i = 0; i < n; i++)
            {
                double nextDay = double.Parse(Console.ReadLine());
                firstDay = firstDay + firstDay * (nextDay / 100);
                allKg += firstDay;
            }

            if (allKg >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(allKg - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - allKg)} more kilometers");
            }
        }
    }
}
