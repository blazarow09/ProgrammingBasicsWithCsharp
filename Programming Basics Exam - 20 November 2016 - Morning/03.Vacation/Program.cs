using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiVuzrastni = int.Parse(Console.ReadLine());
            int broiUchenici = int.Parse(Console.ReadLine());
            int broiNoshtuvki = int.Parse(Console.ReadLine());
            string vidTransport = Console.ReadLine();
            double obshtaSuma = 0;

            switch (vidTransport)
            {
                case "train":
                    double cenaVuzrasten = 24.99;
                    double cenaUchenici = 14.99;
                    if ((broiVuzrastni + broiUchenici) >= 50)
                    {
                        cenaVuzrasten *= 0.5;
                        cenaUchenici *= 0.5;
                    }
                    double razhodTransport = (broiVuzrastni * cenaVuzrasten + broiUchenici * cenaUchenici) * 2;
                    double hotel = broiNoshtuvki * 82.99;
                    obshtaSuma = razhodTransport + hotel;
                    obshtaSuma = obshtaSuma + (obshtaSuma * 0.10);
                    break;
                case "bus":
                    cenaVuzrasten = 32.5;
                    cenaUchenici = 28.5;
                    razhodTransport = (broiVuzrastni * cenaVuzrasten + broiUchenici * cenaUchenici) * 2;
                    hotel = broiNoshtuvki * 82.99;
                    obshtaSuma = razhodTransport + hotel;
                    obshtaSuma = obshtaSuma + (obshtaSuma * 0.10);
                    break;
                case "boat":
                    cenaVuzrasten = 42.99;
                    cenaUchenici = 39.99;
                    razhodTransport = (broiVuzrastni * cenaVuzrasten + broiUchenici * cenaUchenici) * 2;
                    hotel = broiNoshtuvki * 82.99;
                    obshtaSuma = razhodTransport + hotel;
                    obshtaSuma = obshtaSuma + (obshtaSuma * 0.10);
                    break;
                case "airplane":
                    cenaVuzrasten = 70.0;
                    cenaUchenici = 50.0;
                    razhodTransport = (broiVuzrastni * cenaVuzrasten + broiUchenici * cenaUchenici) * 2;
                    hotel = broiNoshtuvki * 82.99;
                    obshtaSuma = razhodTransport + hotel;
                    obshtaSuma = obshtaSuma + (obshtaSuma * 0.10);
                    break;
            }
          
            Console.WriteLine($"{obshtaSuma:F2}");
        }
    }
}
