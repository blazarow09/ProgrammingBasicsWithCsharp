using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursNeed = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double employeesCount = double.Parse(Console.ReadLine());

            int overtimeHours = 2;

            double schoolDays = days * 0.1;
            double schoolDays2 = days - schoolDays;
            double hours = schoolDays2 * 8;
            double overtimeWork = employeesCount * (overtimeHours * days);
            double totalHours = hours + overtimeWork;

            if (totalHours >= hoursNeed)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(totalHours - hoursNeed));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(hoursNeed - totalHours));
            }

        }
    }
}
