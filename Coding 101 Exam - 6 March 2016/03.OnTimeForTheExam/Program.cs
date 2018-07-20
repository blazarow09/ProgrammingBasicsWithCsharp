using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int chas = int.Parse(Console.ReadLine());
            int minuti = int.Parse(Console.ReadLine());
            int chasNaPristigane = int.Parse(Console.ReadLine());
            int minutaNaPristigane = int.Parse(Console.ReadLine());

            int vremeIzpit = (chas * 60) + minuti;
            int vremePristigane = (chasNaPristigane * 60) + minutaNaPristigane;
            int razlika = Math.Abs(vremeIzpit - vremePristigane);
            if (vremeIzpit == vremePristigane)
            {
                Console.WriteLine("On time");
            }
            else if (vremeIzpit < vremePristigane)
            {
                Console.WriteLine("Late");
                if (razlika >= 60)
                {
                    int ch = razlika / 60;
                    int min = razlika % 60;
                    if (min < 10)
                    {
                        Console.WriteLine($"{ch}:0{min} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{ch}:{min} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", razlika);
                }
            }
            else if (vremeIzpit > vremePristigane && razlika <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", razlika);
            }
            else if (vremeIzpit > vremePristigane && razlika > 30 )
            {
                Console.WriteLine("Early");
                if (razlika >= 60)
                {
                    int ch = razlika / 60;
                    int min = razlika % 60;
                    if (min < 10)
                    {
                        Console.WriteLine($"{ch}:0{min} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{ch}:{min} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", razlika);
                }
            }
        }
    }
}
