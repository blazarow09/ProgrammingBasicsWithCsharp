using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double gramajTesto = double.Parse(Console.ReadLine());
            double gramajHlebno = double.Parse(Console.ReadLine());
            double cenaEdnoHlebno = double.Parse(Console.ReadLine());
            double prodadeniHlebni = double.Parse(Console.ReadLine());
            double prodadeniSladkishi = double.Parse(Console.ReadLine());

            double dnevenPrihod = prodadeniHlebni * cenaEdnoHlebno;
            double testo = prodadeniHlebni * gramajHlebno;
            double testoSladki = (gramajTesto - testo) + testo;
            double cenaSladki = cenaEdnoHlebno + (cenaEdnoHlebno * 0.25);
            double gramajSladki = gramajHlebno * 0.80;
            double izpolzvanoTestoSladki = prodadeniSladkishi * gramajSladki;
            double prihodiNosht = prodadeniSladkishi * cenaSladki;
            double razhodi = ((gramajTesto - (gramajTesto - testo) + testoSladki) / 1000) * 4;
            double zaplata = (dnevenPrihod + prihodiNosht) - razhodi;
            double izpolzvanoTesto = Math.Round(testo + izpolzvanoTestoSladki);
            Console.WriteLine($"Pure income: {zaplata:F2} lv.");
            Console.WriteLine($"Dough used: {izpolzvanoTesto} g.");
        }
    }
}
