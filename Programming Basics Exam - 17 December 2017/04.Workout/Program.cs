using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiDni = int.Parse(Console.ReadLine());
            double kmProbqganiPurviDen = double.Parse(Console.ReadLine());
            double obshto = kmProbqganiPurviDen;
            double km = obshto;
            double probqganiKm = km;
            for (int i = 1; i <= broiDni; i++)
            {
                double procentUvelichenie = double.Parse(Console.ReadLine());
                probqganiKm = km + (km * (procentUvelichenie / 100)) ;
                km = probqganiKm;
                obshto += probqganiKm;
            }
            if (obshto >= 1000)
            {
                double result = Math.Ceiling(obshto - 1000);
                Console.WriteLine("You've done a great job running {0} more kilometers!", result);
            }
            else
            {
                double result = Math.Ceiling(1000 - obshto);
                Console.WriteLine("Sorry Mrs. Ivanova, you need to run {0} more kilometers", result);
            }
        }
    }
}
