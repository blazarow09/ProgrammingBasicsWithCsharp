using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam19March2017Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //steni
            double sideWall = x * y;
            double window = 1.5 * 1.5;
            double bothWalls = (sideWall * 2) - (window * 2);
            double backWall = x * x;
            double door = 1.2 * 2;
            double FrontAndBackWall = (backWall * 2) - door;
            double totalArea = bothWalls + FrontAndBackWall;
            double greenPaint = totalArea / 3.4;
            Console.WriteLine($"{greenPaint:F2}");
            //pokriv
            double roofRectWalls = 2 * (x * y);
            double roofTriangleWalls = 2 * (x * h / 2);
            double totalRoofArea = roofRectWalls + roofTriangleWalls;
            double redPaint = totalRoofArea / 4.3;
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
