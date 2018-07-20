using System;


class Program
{
    static void Main(string[] args)
    {
        double stationCapacity = double.Parse(Console.ReadLine());
        double fansCount = double.Parse(Console.ReadLine());
        var fansInSectorA = 0;
        var fansInSectorB = 0;
        var fansInSectorC = 0;
        var fansInSectorD = 0;
        for (int i = 1; i <= fansCount; i++)
        {
            string sector = Console.ReadLine();

            if (sector == "A")
            {
                fansInSectorA++;
            }
            else if (sector == "B")
            {
                fansInSectorB++;
            }
            else if (sector == "V")
            {
                fansInSectorC++;
            }
            else if (sector == "G")
            {
                fansInSectorD++;
            }
        }
        var percenteA = fansInSectorA / fansCount * 100;
        var percenteB = fansInSectorB / fansCount * 100;
        var percenteC = fansInSectorC / fansCount * 100;
        var percenteD = fansInSectorD / fansCount * 100;
        var percenteTotal = fansCount / stationCapacity * 100;

        Console.WriteLine("{0:f2}%", percenteA);
        Console.WriteLine("{0:f2}%", percenteB);
        Console.WriteLine("{0:f2}%", percenteC);
        Console.WriteLine("{0:f2}%", percenteD);
        Console.WriteLine("{0:f2}%", percenteTotal);
    }
}
