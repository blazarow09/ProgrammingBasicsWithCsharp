using System;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double fishingTime = double.Parse(Console.ReadLine());

            double sumTime = 1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother);
            double timeWithRest = sumTime * 0.15 + sumTime;
            double leftTime = fishingTime - timeWithRest;

            if (timeWithRest < fishingTime)
            {
                Console.WriteLine("Cleaning time: {0:f2}", timeWithRest);
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(leftTime), leftTime);
            }
            else if (timeWithRest > fishingTime)
            {
                Console.WriteLine("Cleaning time: {0:f2}", timeWithRest);
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(timeWithRest - fishingTime), timeWithRest - fishingTime);
            }
        }
    }
}
