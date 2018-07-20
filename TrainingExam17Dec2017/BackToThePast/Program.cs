using System;
namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double year = double.Parse(Console.ReadLine());

            double oddMoney = 12000.0;
            double evenMoney = 12000.0;
            double yearsOld = 18;
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                   
                    money -= oddMoney;
                }
                else
                { 
                   
                    money -= (evenMoney + 50 * yearsOld);                                                        
                }
                    yearsOld++;


            }

            if (money < 0)
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(money));
            }
            else
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money);
            }
        }
    }
}
