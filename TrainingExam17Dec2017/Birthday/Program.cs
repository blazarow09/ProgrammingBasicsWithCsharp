using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtInCm = double.Parse(Console.ReadLine());
            double widthInCm = double.Parse(Console.ReadLine());
            double heightInCm = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double S = lenghtInCm * widthInCm * heightInCm;
            double totalLiters = S * 0.001;
            double percents = percent * 0.01;
            double Liters = totalLiters * (1 - percents);
                Console.WriteLine("{0:f3}", Liters);

        }
    }
}
