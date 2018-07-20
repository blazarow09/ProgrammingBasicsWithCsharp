using System;

namespace FlowersShop
{
    class Program
    {
        static void Main(string[] args)
        {                                  
            int magnolii = int.Parse(Console.ReadLine());
            int ziumbiuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double presentGift = double.Parse(Console.ReadLine());

            var priceMagnolii = 3.25;
            var priceZiumbiuli = 4;
            var priceRozi = 3.50;
            var priceKaktusi = 8.0;

            double sum = (magnolii * priceMagnolii) + (ziumbiuli * priceZiumbiuli) + (rozi * priceRozi) + (kaktusi * priceKaktusi);
            double tax = sum - (sum * 0.05);

            if (tax < presentGift)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentGift - tax)} leva.");
            }
            else if (tax >= presentGift)
            {
                Console.WriteLine($"She is left with {Math.Floor(tax - presentGift)} leva. ");
            }
        }
    }
}
