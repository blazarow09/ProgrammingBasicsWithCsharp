using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Swimming
{
    class Program
    {
        static void Main(string[] args)
        {
            double rekordSekundi = double.Parse(Console.ReadLine());
            double razstoqnie = double.Parse(Console.ReadLine());
            double vremeZa1Metur = double.Parse(Console.ReadLine());

            double prepluva = razstoqnie * vremeZa1Metur;
            double bonusVreme = Math.Floor(razstoqnie / 15) * 12.5;
            double obshtoVreme = prepluva + bonusVreme;
            
            if(rekordSekundi <= obshtoVreme)
            {
                double nedostigashtiSek = obshtoVreme - rekordSekundi;
                Console.WriteLine($"No, he failed! He was {nedostigashtiSek:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {obshtoVreme:F2} seconds.");
            }
        }
    }
}
