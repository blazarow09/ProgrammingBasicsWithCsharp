using System;

namespace SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string review = Console.ReadLine();
            double priceForRoom = 0;

            if (typeOfRoom == "room for one person")
            {
                priceForRoom = 18 * (daysCount - 1);
            }
        }
    }
}
