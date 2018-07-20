using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam6March2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = Math.Floor((double.Parse(Console.ReadLine()) * 100) / 120);
            var h = Math.Floor((double.Parse(Console.ReadLine()) * 100 - 100) / 70);
            Console.WriteLine(w * h - 3);
        }
    }
}
