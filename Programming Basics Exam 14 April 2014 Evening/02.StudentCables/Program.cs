using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentCables
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCables = int.Parse(Console.ReadLine());
            int totalLenght = 0;
            int br = numberOfCables;
            for (int i = 1; i <= numberOfCables ; i++)
            {
                int cableLenght = int.Parse(Console.ReadLine());
                string measure = Console.ReadLine();
                if (measure == "meters")
                {
                    cableLenght *= 100;
                }
                if (cableLenght < 20)
                {
                    cableLenght = 0;
                    br--; 
                }
                totalLenght += cableLenght;
            }
            totalLenght = totalLenght - (br - 1) * 3;        
            Console.WriteLine(totalLenght / 504);
            Console.WriteLine(totalLenght % 504);
        }
    }
}
