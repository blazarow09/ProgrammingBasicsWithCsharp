using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysInMonth = double.Parse(Console.ReadLine());
            double moneyEarnedPerDay = double.Parse(Console.ReadLine());
            double USD = double.Parse(Console.ReadLine());

            double monthSalary = daysInMonth * moneyEarnedPerDay;
            double annualIncome = monthSalary * 12 + monthSalary * 2.5;
            double tax = annualIncome * 0.25;
            double clearAnnualIncome = annualIncome - tax;
            double moneyInBg = clearAnnualIncome * USD;
            double averageIncomePerDay = moneyInBg / 365;

            Console.WriteLine("{0:f2}", averageIncomePerDay);

        }
    }
}
