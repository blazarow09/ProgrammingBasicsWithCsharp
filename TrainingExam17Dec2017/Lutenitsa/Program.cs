using System;

namespace Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatoesInKg = double.Parse(Console.ReadLine());
            double boxes = double.Parse(Console.ReadLine());
            double jars = double.Parse(Console.ReadLine());

            double totalLutenitsa = tomatoesInKg / 5;
            double jarsFilled = totalLutenitsa / 0.535;
            double boxesFilled = jarsFilled / jars;


            if (boxesFilled > boxes)
            {
                Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(totalLutenitsa), totalLutenitsa);
                Console.WriteLine("{0} boxes left.", Math.Floor(boxesFilled - boxes), boxesFilled - boxes);
                Console.WriteLine("{0} jars left.", Math.Floor(jarsFilled - boxes * jars), jarsFilled - (boxes * jars));
            }
            else if (boxesFilled < boxes)
            {
                Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(totalLutenitsa), totalLutenitsa);
                Console.WriteLine("{0} more boxes needed.", Math.Floor(boxes - boxesFilled), boxes - boxesFilled);
                Console.WriteLine("{0} more jars needed.", Math.Floor(boxes * jars - jarsFilled), boxes * jars - jarsFilled);
            }
        }
    }
}
