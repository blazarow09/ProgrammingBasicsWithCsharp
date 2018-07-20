using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _02.SudokuResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 0;
            int seconds = 0;
            double total = 0;
            double br = 0;
            string star = null;
            while (true)
            {
                string time = Console.ReadLine();
                try
                {
                    minutes = int.Parse(time.Substring(0, 2));
                    seconds = int.Parse(time.Substring(3, 2));
                }
                catch
                {
                    break;
                }
                total = total + minutes * 60 + seconds;
                br += 1;
            
            }
            total = Math.Ceiling(total / br);
            if (total < 720)
            {
                star += "Gold Star";
            }
            else if (total < 1440)
            {
                star += "Silver Star";
            }
            else if (total > 1440)
            {
                star += "Bronze Star";
            }
            Console.WriteLine($"{star}");
            Console.WriteLine($"Games - {br} \\ Average seconds - {total}");
        }
    }
}
