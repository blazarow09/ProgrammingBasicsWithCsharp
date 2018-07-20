using System;
namespace PictureInTheWall
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthArea = double.Parse(Console.ReadLine());
            double heightArea = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            double picCount = double.Parse(Console.ReadLine());

            double sHole = widthArea * heightArea;
            double sPic = (side * side) * picCount;
            double rest = sHole - sPic;
            double rest2 = sPic - sHole;
            if (sHole > sPic)
            {
                Console.WriteLine("The pictures fit in the hole. Hole area is {0} bigger than pictures area.", rest);
            }
            else
            {
                Console.WriteLine("The pictures don't fit in the hole. Picture area is {0} bigger than hole area.", rest2);
            }

        }
    }
}
