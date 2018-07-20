using System;

namespace ExternalEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());

            var point1 = 0.0;
            var point2 = 0.0;
            var point3 = 0.0;
            var point4 = 0.0;
            var point5 = 0.0;
            for (int i = 1; i <= studentsCount; i++)
            {
                double points = double.Parse(Console.ReadLine());

                if (points >= 0 && points <= 22.5)
                {
                    point1++;
                }
                else if (points > 22.5 && points <= 40.5)
                {
                    point2++;
                }
                else if (points > 40.5 && points <= 58.5)
                {
                    point3++;
                }
                else if (points > 58.5 && points <= 76.5)
                {
                    point4++;
                }
                else if (points > 76.5 && points <= 100)
                {
                    point5++;
                }
            }

            var poorMark = (point1 / studentsCount) * 100;
            var satisfactoryMark = (point2 / studentsCount) * 100;
            var goodMark = (point3 / studentsCount) * 100;
            var veryGoodMark = (point4 / studentsCount) * 100;
            var excellentMark = (point5 / studentsCount) * 100;

            Console.WriteLine("{0:f2}% poor marks", poorMark);
            Console.WriteLine("{0:f2}% satisfactory marks", satisfactoryMark);
            Console.WriteLine("{0:f2}% good marks", goodMark);
            Console.WriteLine("{0:f2}% very good marks", veryGoodMark);
            Console.WriteLine("{0:f2}% excellent marks", excellentMark);


        }
    }
}
