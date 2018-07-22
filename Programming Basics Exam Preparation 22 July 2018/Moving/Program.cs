using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthFreeSpace = double.Parse(Console.ReadLine());
            double lengthFreeSpace = double.Parse(Console.ReadLine());
            double heightFreeSpace = double.Parse(Console.ReadLine());

            double newHouseVolume = newHouseVolume = widthFreeSpace * lengthFreeSpace * heightFreeSpace;
            double boxes = 0;
            double moreSpace = 0;
            double fix = newHouseVolume = widthFreeSpace * lengthFreeSpace * heightFreeSpace;

            var command = Console.ReadLine();

            while (command != "Done" && newHouseVolume > 0)
            {
                double countBoxes = int.Parse(command);
                 
                newHouseVolume -= countBoxes;
                boxes += countBoxes;

                command = Console.ReadLine();
            }

            if (newHouseVolume < 0)
            {
                moreSpace = fix - boxes;
                Console.WriteLine($"No more free space! You need {Math.Abs(moreSpace)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{fix - boxes} Cubic meters left.");
            }
        }
    }
}
