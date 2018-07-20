using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = double.Parse(Console.ReadLine());
            string VhodnaValuta = Console.ReadLine();
            string IzhodnaValuta = Console.ReadLine();

            if (VhodnaValuta == "BGN" && IzhodnaValuta == "USD")
                Console.WriteLine("{0} USD",Math.Round((suma / 1.79549), 2));
            if (VhodnaValuta == "BGN" && IzhodnaValuta == "EUR")
                Console.WriteLine("{0} EUR",Math.Round((suma / 1.95583), 2));
            if (VhodnaValuta == "BGN" && IzhodnaValuta == "GBP")
                Console.WriteLine("{0} GBP", Math.Round((suma / 2.53405), 2));
            if (VhodnaValuta == "USD" && IzhodnaValuta == "BGN")
                Console.WriteLine("{0} BGN", Math.Round((suma * 1.79549), 2));
            if (VhodnaValuta == "USD" && IzhodnaValuta == "EUR")
                Console.WriteLine("{0} EUR", Math.Round(((suma * 1.79549) / 1.95583), 2));
            if (VhodnaValuta == "USD" && IzhodnaValuta == "GBP")
                Console.WriteLine("{0} GBP", Math.Round(((suma * 1.79549) / 2.53405), 2));
            if (VhodnaValuta == "EUR" && IzhodnaValuta == "USD")
                Console.WriteLine("{0} USD", Math.Round(((suma * 1.95583) / 1.79549), 2));
            if (VhodnaValuta == "EUR" && IzhodnaValuta == "BGN")
                Console.WriteLine("{0} BGN", Math.Round((suma * 1.95583), 2));
            if (VhodnaValuta == "EUR" && IzhodnaValuta == "GBP")
                Console.WriteLine("{0} GBP", Math.Round(((suma * 1.95583) / 2.53405), 2));
            if (VhodnaValuta == "GBP" && IzhodnaValuta == "USD")
                Console.WriteLine("{0} USD", Math.Round(((suma * 2.53405) / 1.79549), 2));
            if (VhodnaValuta == "GBP" && IzhodnaValuta == "EUR")
                Console.WriteLine("{0} EUR", Math.Round(((suma * 2.53405) / 1.95583), 2));
            if (VhodnaValuta == "GBP" && IzhodnaValuta == "BGN")
                Console.WriteLine("{0} BGN", Math.Round((suma * 2.53405), 2));





        }
    }
}
