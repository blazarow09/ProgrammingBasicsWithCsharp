using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiTanciori = int.Parse(Console.ReadLine());
            double broiTochki = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            string mqsto = Console.ReadLine();
            
            double charity = 0;
            double moneyPerDancer = 0;

            if(mqsto == "Bulgaria")
            {
                double money = broiTanciori * broiTochki;
                if (sezon == "winter")
                {
                    money *= 0.92;
                }
                else if (sezon == "summer")
                {
                    money *= 0.95;
                }
                charity = money * 0.75;
                double leftMoney = money - charity;
                moneyPerDancer = leftMoney / broiTanciori;
            }
            else if (mqsto == "Abroad")
            {
                double money = broiTanciori * broiTochki;
                money = money + (money * 0.5);
                if (sezon == "winter")
                {
                    money *= 0.85;
                }
                else if (sezon == "summer")
                {
                    money *= 0.90;
                }
                charity = money * 0.75;
                double leftMoney = money - charity;
                moneyPerDancer = leftMoney / broiTanciori;
            }
            Console.WriteLine($"Charity - {charity:F2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:F2}");
        }
    }
}
