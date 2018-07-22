using System;

namespace SpaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthShip = double.Parse(Console.ReadLine());
            double lengthShip = double.Parse(Console.ReadLine());
            double heightShip = double.Parse(Console.ReadLine());
            double avgHeight = double.Parse(Console.ReadLine());

            double volumeRocket = Math.Floor(widthShip * lengthShip * heightShip);
            double volumeRoom = (avgHeight + 0.40) * 2 * 2;

            double willHavePlaceFor = Math.Floor(volumeRocket / volumeRoom);

            if (willHavePlaceFor >= 3 && willHavePlaceFor <= 10)
            {
                Console.WriteLine($"The spacecraft holds {willHavePlaceFor:f0} astronauts.");
            }
            else if (willHavePlaceFor < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (willHavePlaceFor > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
