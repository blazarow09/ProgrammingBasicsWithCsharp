using System;
namespace ДелениеБезОстатък
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());

            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;

            for (int i = 1; i <= lenght; i++)
            {
                double num = double.Parse(Console.ReadLine());
               
                if (num % 2 == 0)
                {
                    p2++;
                    
                }
                if (num % 3 == 0)
                {
                    p3++;
                }
                if (num % 4 == 0)
                {
                    p4++;
                }
            }
            Console.WriteLine("{0:f2}%", p2 / lenght * 100);
            Console.WriteLine("{0:f2}%", p3 / lenght * 100);
            Console.WriteLine("{0:f2}%", p4 / lenght * 100);

        }
    }
}
