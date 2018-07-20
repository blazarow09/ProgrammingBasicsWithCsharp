using System;

namespace ANDProccesors
{
    class Program
    {
        static void Main(string[] args)
        {
            double proccesorsCount = double.Parse(Console.ReadLine());
            double employeesCount = double.Parse(Console.ReadLine());
            double workingDays = double.Parse(Console.ReadLine());

            double hours = employeesCount * workingDays * 8;
            double proccesorsMade = Math.Floor(hours / 3);

            if (proccesorsMade < proccesorsCount)
            {
                Console.WriteLine("Losses: -> {0:f2} BGN", (proccesorsCount - proccesorsMade) * 110.10);
            }
            else if (proccesorsMade >= proccesorsCount)
            {
                Console.WriteLine("Profit: -> {0:f2} BGN", (proccesorsMade - proccesorsCount) * 110.10);
            }
        }
    }
}
