using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerName = Console.ReadLine();
            var goals = int.Parse(Console.ReadLine());

            var theBestPlayer = playerName;
            var theMostGoals = goals;
            
            while (true)
            {
                if (theMostGoals < goals)
                {
                    theBestPlayer = playerName;
                    theMostGoals = goals;

                   
                }

                if (theMostGoals >= 10)
                {
                    break;
                }

                playerName = Console.ReadLine();

                if (playerName == "END")
                {
                    break;
                }
                goals = int.Parse(Console.ReadLine());
            }

            if (theMostGoals >= 3)
            {
                Console.WriteLine($"{theBestPlayer} is the best player!");
                Console.WriteLine($"He has scored {theMostGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{theBestPlayer} is the best player!");
                Console.WriteLine($"He has scored {theMostGoals} goals.");
            }
        }
    }
}
