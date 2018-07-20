using System;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeight = double.Parse(Console.ReadLine());

            double rocketS = width * lenght * height;
            double roomS = (averageHeight + 0.40) * 2 * 2;
            double area = Math.Truncate(rocketS / roomS);

            if(area >= 3 && area <= 10)
            {
                Console.WriteLine("The spacecraft holds {0} astronauts.", area);
            }
            else if (area < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (area > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
