using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam28August2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double courseUSDToBGN = double.Parse(Console.ReadLine());

            double monthSalary = workingDays * money;
            double yearSalary = (monthSalary * 12) + (monthSalary * 2.5);
            double taxes = yearSalary * 0.25;
            double salaryWithoutTaxesUSD = yearSalary - taxes;
            double salaryWithoutTaxesBGN = salaryWithoutTaxesUSD * courseUSDToBGN;
            double dailyMoney = salaryWithoutTaxesBGN / 365;
            Console.WriteLine($"{dailyMoney:F2}");
            
        }
    }
}
