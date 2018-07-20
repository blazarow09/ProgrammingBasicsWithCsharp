using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var S = a * a; Math.Round(S, 3);
                Console.WriteLine("S = {0:F3}",S, 3);
            }

            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var S2 = Math.PI * r * r; Math.Round(S2, 3);
                Console.WriteLine("S = {0:F3}",S2 ,3);
            }

            else if (figure == "rectangle")
            {
                var a1 = double.Parse(Console.ReadLine());
                var b1 = double.Parse(Console.ReadLine());
                var S3 = a1 * b1; Math.Round(S3, 3);
                Console.WriteLine("S = {0:F3}",S3,3);
            }

            else if (figure == "triangle")
            {
                var a2 = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var S4 = (a2 * h) / 2; Math.Round(S4, 3);
                Console.WriteLine("S = {0:F3}",S4, 3);
            }
        }
    }
}
