using System;

namespace GrandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            double times = double.Parse(Console.ReadLine());

            double rakia = 0.0;
            double degrees = 0.0;
            double rakiaTwo = 0.0;
            double degreesTwo = 0.0;
            double degreesThree = 0.0;
            double totalDegrees = 0.0;

            for (int i = 1; i <= times; i++)
            {
                rakia = double.Parse(Console.ReadLine());
                degrees = double.Parse(Console.ReadLine());

                degreesTwo = rakia * degrees;
                rakiaTwo = rakiaTwo + rakia;
                degreesThree = degreesThree + degreesTwo;                    
            }
            totalDegrees = degreesThree / rakiaTwo;
            Console.WriteLine("Liter: {0:f2}", rakiaTwo);
            Console.WriteLine("Degrees: {0:f2}", totalDegrees);
            if (totalDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (totalDegrees >= 38 && totalDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (totalDegrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
    
