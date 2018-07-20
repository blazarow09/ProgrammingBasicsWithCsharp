using System;

namespace Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            double peopleVoted = double.Parse(Console.ReadLine());
            double votedForFirstLanguage = double.Parse(Console.ReadLine());

            double votedForSecond = votedForFirstLanguage - (votedForFirstLanguage * 0.20);
            double votedForThird = votedForSecond - (votedForSecond * 0.10);
            double total = votedForFirstLanguage + votedForSecond + votedForThird;
            double halfVoted = peopleVoted / 2;
            double diference = total - halfVoted;

            if (total > halfVoted)
            {
                Console.WriteLine("First three languages have {0:f0} votes more", diference);
            }
            else
            {
                Console.WriteLine("First three languages have {0:f0} votes less of half votes", Math.Abs(diference), Math.Ceiling(diference));
            }
        }
    }
}
