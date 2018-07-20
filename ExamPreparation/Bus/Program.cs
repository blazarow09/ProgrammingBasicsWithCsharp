using System;
namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengersCount = int.Parse(Console.ReadLine());
            int busStopsCount = int.Parse(Console.ReadLine());

            int totalPassengers = 0;
            int checkers = 0;

            for (int i = 1; i <= busStopsCount ; i++)
            {
                int countPassengersMinus = int.Parse(Console.ReadLine());
                int countPassengersPlus = int.Parse(Console.ReadLine());

                totalPassengers = passengersCount - countPassengersMinus;
                if (busStopsCount % 2 == 1)
                {
                    checkers += 2;
                }

                if (busStopsCount % 2 == 0)
                {
                    checkers -= 2;
                }


            }
        }
    }
}
