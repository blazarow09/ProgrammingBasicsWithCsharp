using System;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string session = Console.ReadLine();
            string type = Console.ReadLine();
            string internet = Console.ReadLine();
            double months = double.Parse(Console.ReadLine());

            double price = 0.0;
           

            if (session == "one")
            {
                if (type == "Small")
                {
                    price = 9.98;
                }
                else if (type == "Middle")
                {
                    price = 18.99;
                }
                else if (type == "Large")
                {
                    price = 25.98;
                }
                else if (type == "ExtraLarge")
                {
                    price = 35.99;
                }
               
            }         
            else if (session == "two")
            {
                if (type == "Small")
                {
                    price = 8.58;
                }
                else if (type == "Middle")
                {
                    price = 17.09;
                }
                else if (type == "Large")
                {
                    price = 23.59;
                }
                else if (type == "ExtraLarge")
                {
                    price = 31.79;
                }
            }
            if (internet == "yes")
            {
                price +=
                     price <= 10 ? 5.50 :
                     price <= 30 ? 4.35 :
                     3.85;
            }

            if (session == "two")
            {
                price *= (1 - 0.0375);
            }

            Console.WriteLine("{0:f2} lv.",price * months);



        }
    }
}
