using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalPrice = magnolii * 3.25 + zumbuli * 4 + rozi * 3.5 + kaktusi * 8;
            double earn = totalPrice * 0.95;
            
            if(earn < giftPrice)
            {
                double needed = Math.Ceiling(giftPrice - earn);
                Console.WriteLine("She will have to borrow {0} leva.", needed);
            }
            else
            {
                double left = Math.Floor(earn - giftPrice);
                Console.WriteLine("She is left with {0} leva.", left);
            }
        }
    }
}
