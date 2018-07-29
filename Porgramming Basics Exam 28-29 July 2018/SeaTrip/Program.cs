using System;

namespace SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceForGo = double.Parse(Console.ReadLine());
            var priceForBack = double.Parse(Console.ReadLine());
            var ticketPricePerMatch = double.Parse(Console.ReadLine());
            var countMatches = double.Parse(Console.ReadLine());
            var percentDiscount = double.Parse(Console.ReadLine());

            var discount = percentDiscount / 100;

            var sumForFlightTickets = 6 * (priceForGo + priceForBack);

            var ticketsAfterDiscount = sumForFlightTickets - (sumForFlightTickets * discount) ;

            var totalSumForMatchTickets = 6 * countMatches * ticketPricePerMatch;

            var totalToPay = ticketsAfterDiscount + totalSumForMatchTickets;

            var sumForOnePerson = totalToPay / 6;

            Console.WriteLine($"Total sum: {totalToPay:f2} lv.");
            Console.WriteLine($"Each friend has to pay {sumForOnePerson:f2} lv.");
        }
    }
}
