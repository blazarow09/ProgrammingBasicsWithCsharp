using System;

namespace Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double hoursSpend = double.Parse(Console.ReadLine());
            double peopleCount = double.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            double price = 0.0;

            if  (( month == "january" ||month == "february" || month ==  "march" || month == "april" || month == "may") & dayTime == "day")
            {
                price = 10.50;
            }
             else if ((month == "june" || month == "july" || month == "august" || month == "september" || month == "october" || month == "november" || month == "december") & dayTime == "day")
            {
                price = 12.60;
            }
            else if ((month == "january" || month == "february" || month == "march" || month == "april" || month == "may") & dayTime == "night")
            {
                price = 8.40;
            }
            else if ((month == "june" || month == "july" || month == "august" || month == "september" || month == "october" || month == "november" || month == "december") & dayTime == "night")
            {
                price = 10.20;
            }
            if (peopleCount >= 4)
            {
               price = price * 0.10;
            }
            if (hoursSpend >= 5)
            {
                price = price * 0.5;
            }

            double fullVisit = (price * hoursSpend) * peopleCount;

            Console.WriteLine("Price per person for one hour: {0:f2}", price);
            Console.WriteLine("Total cost of the visit: {0:f2}", fullVisit);
        }
    }
}
