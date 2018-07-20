using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string VidGodina = Console.ReadLine();
            int BroiPraznici = int.Parse(Console.ReadLine());
            int BroiUikendiVRodniqGrad = int.Parse(Console.ReadLine());
            
            double SofiaWeekend = (48 - BroiUikendiVRodniqGrad) * 3.0 / 4;
            double IgriPraznichenDen = BroiPraznici * 2.0 / 3;
            double ObshtoIgri = SofiaWeekend + BroiUikendiVRodniqGrad + IgriPraznichenDen;

            if (VidGodina == "normal")
            {
                Console.WriteLine(Math.Truncate(ObshtoIgri));
            }
            else if (VidGodina == "leap")
            {
                double LeapYear = ObshtoIgri * 15 / 100;
                Console.WriteLine(Math.Truncate(ObshtoIgri + LeapYear));

            }
        }
    }
}
