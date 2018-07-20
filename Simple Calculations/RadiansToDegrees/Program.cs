using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = (rad / (Math.PI / 180.0) + 0.5);
            Console.WriteLine(Math.Floor(deg));

        }
    }
}
