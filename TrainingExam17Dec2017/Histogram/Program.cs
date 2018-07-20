using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());

            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;

            for (int i = 1; i <= lenght; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                    
                }
                else if (num >= 200 && num <= 399)
                {
                    p2++;
                    
                }
                else if (num >= 400 && num <= 599)
                {
                    p3++;
                   
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                    
                }
                else if (num >= 800)
                {
                    p5++;
                    
                }
            }
            Console.WriteLine("{0:f2}%", p1 / lenght * 100);
            Console.WriteLine("{0:f2}%", p2 / lenght * 100);
            Console.WriteLine("{0:f2}%", p3 / lenght * 100);
            Console.WriteLine("{0:f2}%", p4 / lenght * 100);            
            Console.WriteLine("{0:f2}%", p5 / lenght * 100);
        }
    }
}
