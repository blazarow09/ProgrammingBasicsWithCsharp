using System;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            double countPassengers = double.Parse(Console.ReadLine());
            double countStops = double.Parse(Console.ReadLine());


            for (int i = 1; i <= countStops; i++)
            {
                double passengersLeft = double.Parse(Console.ReadLine());
                double passengersIn = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    countPassengers -= passengersLeft + 2;
                    countPassengers += passengersIn;
                }
                else if (i % 2 == 1)
                {
                    countPassengers -= passengersLeft;
                    countPassengers += passengersIn + 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {countPassengers}");
        }
    }
}
