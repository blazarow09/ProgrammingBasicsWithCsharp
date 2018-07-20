using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ImpressTheGirlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            uint r = uint.Parse(Console.ReadLine());
            uint d = uint.Parse(Console.ReadLine());
            uint e = uint.Parse(Console.ReadLine());
            uint b = uint.Parse(Console.ReadLine());
            uint m = uint.Parse(Console.ReadLine());

            double fromRUBToBGN = Math.Ceiling((r / 100) * 3.5);
            double fromUSDToBGN = Math.Ceiling(d * 1.5);
            double fromEURToBGN = Math.Ceiling(e * 1.95);
            double BperGame = b / 2;
            double MperGame = m;

            double maximum = Math.Max(fromRUBToBGN,Math.Max(fromUSDToBGN, Math.Max(fromEURToBGN, Math.Max(BperGame, MperGame))));
            Console.WriteLine($"{maximum:F2}");
        }
    }
}
