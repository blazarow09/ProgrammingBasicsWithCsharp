using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgedIvo = double.Parse(Console.ReadLine());
            double chocoCount = double.Parse(Console.ReadLine());
            double milkLiters = double.Parse(Console.ReadLine());

            double chocoPrice = 0.65;
            double milkPrice = 2.70;


            double moneyForChoco = chocoCount * chocoPrice;
            double moneyForMilk = milkLiters * milkPrice;
            double mandariniCount = Math.Floor(chocoCount * 0.65); 
            double moneyForMandarini = mandariniCount * 0.20;
            double totalMoneyNeedd = moneyForChoco + moneyForMilk + moneyForMandarini;

            double moneyLeft = budgedIvo - totalMoneyNeedd;
            double moneyNeed = totalMoneyNeedd - budgedIvo;

            if (budgedIvo >= totalMoneyNeedd)
            {
                Console.WriteLine("You got this, {0:f2} money left!", moneyLeft);
            }
            else if (budgedIvo < totalMoneyNeedd)
            {
                Console.WriteLine("Not enough money, you need {0:f2} more!", moneyNeed);
                            
            }
        }
    }
}
