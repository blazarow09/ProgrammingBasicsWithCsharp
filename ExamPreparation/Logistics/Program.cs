using System;


namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLoad = int.Parse(Console.ReadLine());
           
            var busPrice = 0.0;
            var tirPrice = 0.0;
            var trainPrice = 0.0;

            var totalTonsBus = 0.0;
            var totalTonsTir = 0.0;
            var totalTonsTrain = 0.0;

            for (int i = 0; i < countLoad; i++)
            {
              int tonsOfLoad = int.Parse(Console.ReadLine());

                if (tonsOfLoad <= 3)
                {
                    busPrice = 200.0;
                    totalTonsBus += tonsOfLoad;
                }
                else if (tonsOfLoad > 3 && tonsOfLoad <= 11)
                {
                    tirPrice = 175.0;
                    totalTonsTir += tonsOfLoad;
                }
                else if (tonsOfLoad > 11)
                {
                    trainPrice = 120.0;
                    totalTonsTrain += tonsOfLoad;
                }
                             
            }
            double totalLoads = totalTonsBus + totalTonsTir + totalTonsTrain;
            double average = (totalTonsBus * busPrice + totalTonsTir * tirPrice + totalTonsTrain * trainPrice) / totalLoads;
            Console.WriteLine($"{average:f2}");
            Console.WriteLine($"{totalTonsBus / totalLoads * 100:f2}%");
            Console.WriteLine($"{totalTonsTir / totalLoads * 100:f2}%");
            Console.WriteLine($"{totalTonsTrain / totalLoads * 100:f2}%");
        }
    }
}
