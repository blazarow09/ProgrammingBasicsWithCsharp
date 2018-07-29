using System;

namespace GameInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int countMatches = int.Parse(Console.ReadLine());
            int minutesPlayed = int.Parse(Console.ReadLine());

            var totalMins = 0.0;
            int additionalTime = 0;
            int penalties = 0;

            int count = 0;

            while (true)
            {

                totalMins += minutesPlayed;

                if (minutesPlayed > 90 && minutesPlayed <= 120)
                {
                    additionalTime++;
                }

                if (minutesPlayed > 120 && minutesPlayed <= 130)
                {
                    penalties++;
                }

                count++;
                if (count == countMatches && count <= 10)
                {
                    break;
                }

                minutesPlayed = int.Parse(Console.ReadLine());

            }

            double avgMins = totalMins / countMatches;

            Console.WriteLine($"{teamName} has played {totalMins} minutes. Average minutes per game: {avgMins:f2}");
            Console.WriteLine($"Games with penalties: {penalties}");
            Console.WriteLine($"Games with additional time: {additionalTime}");
        }
    }
}
