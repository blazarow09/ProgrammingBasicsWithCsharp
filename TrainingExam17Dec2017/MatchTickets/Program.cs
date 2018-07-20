using System;


namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double countPeople = double.Parse(Console.ReadLine());

            var ticketPrice = 0.0; 
            var transport = 0.0;

            if (type == "VIP")
            {
                if (countPeople <= 4)
                {
                    ticketPrice = 499.99;
                    transport = budged * 0.75;
                }
                else if (countPeople >= 5 && countPeople <= 9)
                {
                    ticketPrice = 499.99;
                    transport = budged * 0.60;
                }
                else if (countPeople >= 10 && countPeople <=24)
                {
                    ticketPrice = 499.99;
                    transport = budged * 0.50;
                }
                else if (countPeople >= 25 && countPeople <= 49)
                {
                    ticketPrice = 499.99;
                    transport = budged * 0.40;
                }
                else if (countPeople >= 50)
                {
                    ticketPrice = 499.99;
                    transport = budged * 0.25;
                }

                double moneyLeft = budged - transport;
                double tickets = countPeople * ticketPrice;

                if (tickets <= moneyLeft)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - tickets);
                }
                else if (tickets > moneyLeft)
                {                 
                    Console.WriteLine("Not enough money! You need {0:f2} leva.",
                      Math.Abs(moneyLeft - tickets)); 
                }

            }
            if (type == "Normal")
            {
                if (countPeople <= 4)
                {
                    ticketPrice = 249.99;
                    transport = budged * 0.75;
                }
                else if (countPeople >= 5 && countPeople <= 9)
                {
                    ticketPrice = 249.99;
                    transport = budged * 0.60;
                }
                else if (countPeople >= 10 && countPeople <= 24)
                {
                    ticketPrice = 249.99;
                    transport = budged * 0.50;
                }
                else if (countPeople >= 25 && countPeople <= 49)
                {
                    ticketPrice = 249.99;
                    transport = budged * 0.40;
                }
                else if (countPeople >= 50)
                {
                    ticketPrice = 249.99;
                    transport = budged * 0.25;
                }

                double moneyLeft = budged - transport;
                double tickets = countPeople * ticketPrice;

                if (tickets <= moneyLeft)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - tickets);
                }
                else if (tickets > moneyLeft)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.",
                      Math.Abs(moneyLeft - tickets));
                }
            }
        }
    }
}
