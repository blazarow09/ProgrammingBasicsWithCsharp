using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GrandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double total = 0;
            double obshtoLitri = 0;
            for (int i = 1; i <= days; i++)
            {
                double kolichestvo = double.Parse(Console.ReadLine());
                double gradus = double.Parse(Console.ReadLine());

                obshtoLitri += kolichestvo;
                double obshtoKolichestvo = total + gradus * kolichestvo;
                total = obshtoKolichestvo;
                
            }
            double gradusi = total / obshtoLitri;

            Console.WriteLine($"Liter: {obshtoLitri:F2}");
            Console.WriteLine($"Degrees: {gradusi:F2}");
            if (gradusi < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if(gradusi >= 38 && gradusi < 42)
            {
                Console.WriteLine("Super!");
            }
            else if (gradusi > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
