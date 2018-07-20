using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IvanovisHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string transport = Console.ReadLine();

            if (destination == "Miami")
            {
                if (numberOfNights >= 1 && numberOfNights <= 10)
                {
                    double adultPrice = 24.99;
                    double kidsPrice = 14.99;
                    double priceDestination = numberOfNights * ((2 * adultPrice) + (3 * kidsPrice));
                    double priceDestWithdog = priceDestination * 0.25;
                    double allPriceDest = priceDestination + priceDestWithdog;

                    if (transport == "train")
                    {
                        double trainAdult = 22.30;
                        double trainKids = 12.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    else if (transport == "bus")
                    {
                        double trainAdult = 45.00;
                        double trainKids = 37.00;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    else if (transport == "airplane")
                    {
                        double trainAdult = 90.00;
                        double trainKids = 68.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }

                }
                else if (numberOfNights >= 11 && numberOfNights <= 15)
                {
                    double adultPrice = 22.99;
                    double kidsPrice = 11.99;
                    double priceDestination = numberOfNights * ((2 * adultPrice) + (3 * kidsPrice));
                    double priceDestWithdog = priceDestination * 0.25;
                    double allPriceDest = priceDestination + priceDestWithdog;

                    if (transport == "train")
                    {
                        double trainAdult = 22.30;
                        double trainKids = 12.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    else if (transport == "bus")
                    {
                        double trainAdult = 45.00;
                        double trainKids = 37.00;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    else if (transport == "airplane")
                    {
                        double trainAdult = 90.00;
                        double trainKids = 68.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                }
                else if (numberOfNights > 15)
                {
                    double adultPrice = 20.00;
                    double kidsPrice = 10.00;
                    double priceDestination = numberOfNights * ((2 * adultPrice) + (3 * kidsPrice));
                    double priceDestWithdog = priceDestination * 0.25;
                    double allPriceDest = priceDestination + priceDestWithdog;

                    if (transport == "train")
                    {
                        double trainAdult = 22.30;
                        double trainKids = 12.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    else if (transport == "bus")
                    {
                        double trainAdult = 45.00;
                        double trainKids = 37.00;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    else if (transport == "airplane")
                    {
                        double trainAdult = 90.00;
                        double trainKids = 68.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                }
            }
            else if (destination == "Canary Islands")
            {
                if (numberOfNights >= 1 && numberOfNights <= 10)
                {
                    double adultPrice = 32.50;
                    double kidsPrice = 28.50;
                    double priceDestination = numberOfNights * ((2 * adultPrice) + (3 * kidsPrice));
                    double priceDestWithdog = priceDestination * 0.25;
                    double allPriceDest = priceDestination + priceDestWithdog;

                    if (transport == "train")
                    {
                        double trainAdult = 22.30;
                        double trainKids = 12.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "bus")
                    {
                        double trainAdult = 45.00;
                        double trainKids = 37.00;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "airplane")
                    {
                        double trainAdult = 90.00;
                        double trainKids = 68.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }

                }
                else if (numberOfNights >= 11 && numberOfNights <= 15)
                {
                    double adultPrice = 30.50;
                    double kidsPrice = 25.60;
                    double priceDestination = numberOfNights * ((2 * adultPrice) + (3 * kidsPrice));
                    double priceDestWithdog = priceDestination * 0.25;
                    double allPriceDest = priceDestination + priceDestWithdog;


                    if (transport == "train")
                    {
                        double trainAdult = 22.30;
                        double trainKids = 12.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "bus")
                    {
                        double trainAdult = 45.00;
                        double trainKids = 37.00;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "airplane")
                    {
                        double trainAdult = 90.00;
                        double trainKids = 68.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                }
                else if (numberOfNights > 15)
                {
                    double adultPrice = 28.00;
                    double kidsPrice = 22.00;
                    double priceDestination = numberOfNights * ((2 * adultPrice) + (3 * kidsPrice));
                    double priceDestWithdog = priceDestination * 0.25;
                    double allPriceDest = priceDestination + priceDestWithdog;
                }

                    if (transport == "train")
                    {
                        double trainAdult = 22.30;
                        double trainKids = 12.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "bus")
                    {
                        double trainAdult = 45.00;
                        double trainKids = 37.00;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "airplane")
                    {
                        double trainAdult = 90.00;
                        double trainKids = 68.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                }
            }
            ////////////////////////////////////////////
            else if (destination == "Phillipines")
            {
                if (numberOfNights >= 1 && numberOfNights <= 10)
                {
                    double adultPrice = 42.99;
                    double kidsPrice = 39.99;
                    double priceDestination = numberOfNights * ((2 * adultPrice) + (3 * kidsPrice));
                    double priceDestWithdog = priceDestination * 0.25;
                    double allPriceDest = priceDestination + priceDestWithdog;

                    if (transport == "train")
                    {
                        double trainAdult = 22.30;
                        double trainKids = 12.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "bus")
                    {
                        double trainAdult = 45.00;
                        double trainKids = 37.00;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "airplane")
                    {
                        double trainAdult = 90.00;
                        double trainKids = 68.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }

                }
                else if (numberOfNights >= 11 && numberOfNights <= 15)
                {
                    double adultPrice = 41.00;
                    double kidsPrice = 36.00;
                    double priceDestination = numberOfNights * ((2 * adultPrice) + (3 * kidsPrice));
                    double priceDestWithdog = priceDestination * 0.25;
                    double allPriceDest = priceDestination + priceDestWithdog;

                    if (transport == "train")
                    {
                        double trainAdult = 22.30;
                        double trainKids = 12.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "bus")
                    {
                        double trainAdult = 45.00;
                        double trainKids = 37.00;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "airplane")
                    {
                        double trainAdult = 90.00;
                        double trainKids = 68.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                }
                else if (numberOfNights > 15)
                {
                    double adultPrice = 38.50;
                    double kidsPrice = 32.40;
                    double priceDestination = numberOfNights * ((2 * adultPrice) + (3 * kidsPrice));
                    double priceDestWithdog = priceDestination * 0.25;
                    double allPriceDest = priceDestination + priceDestWithdog;

                    if (transport == "train")
                    {
                        double trainAdult = 22.30;
                        double trainKids = 12.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "bus")
                    {
                        double trainAdult = 45.00;
                        double trainKids = 37.00;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                    if (transport == "airplane")
                    {
                        double trainAdult = 90.00;
                        double trainKids = 68.50;
                        double priceTransport = (trainAdult * 2) + (trainKids * 3);
                        Console.WriteLine(allPriceDest + priceTransport);
                    }
                }
            }
        }
    }
}
