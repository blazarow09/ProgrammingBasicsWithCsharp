using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();
            double noshtuvkiObshto = 0;
            


            switch (room)
            {
                case "room for one person":
                    noshtuvkiObshto = 18 * (days - 1);
                    break;

                case "apartment":
                    if (days <= 10)
                    {
                        noshtuvkiObshto = 25.00 * (days - 1);
                        noshtuvkiObshto *= 0.7;
                    }
                    else if (days >= 11 && days <= 15)
                    {
                        noshtuvkiObshto = 25.00 * (days - 1);
                        noshtuvkiObshto *= 0.65;
                    }
                    else if (days > 15)
                    {
                        noshtuvkiObshto = 25.00 * (days - 1);
                        noshtuvkiObshto *= 0.5;
                    }
                    break;
                case "president apartment":
                    if (days <= 10)
                    {
                        noshtuvkiObshto = 35.00 * (days - 1);
                        noshtuvkiObshto *= 0.9;
                    }
                    else if (days >= 11 && days <= 15)
                    {
                        noshtuvkiObshto = 35.00 * (days - 1);
                        noshtuvkiObshto *= 0.85;
                    }
                    else if (days > 15)
                    {
                        noshtuvkiObshto = 35.00 * (days -1);
                        noshtuvkiObshto *= 0.8;
                    }
                    break;
            }
            switch (grade)
            {
                case "positive":
                    noshtuvkiObshto *= 1.25;
                    break;
                case "negative":
                    noshtuvkiObshto *= 0.9;
                    break;
            }
            Console.WriteLine($"{noshtuvkiObshto:F2}");

        }
    }
}

