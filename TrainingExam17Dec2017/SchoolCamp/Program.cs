using System;


class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupGender = Console.ReadLine();
            double studentsCount = double.Parse(Console.ReadLine());
            double overnightsCount = double.Parse(Console.ReadLine());

            double price = 0.0;
            string sport = "";


        if (season == "Winter")
        {
            price = 9.60;

            if (groupGender == "boys")
            {
                sport = "Judo";
            }
            else if (groupGender == "girls")
            {
                sport = "Gymnastics";
            }
            else if (groupGender == "mixed")
            {
                sport = "Ski";
                price = 10.00;
            }
        }
        else if (season == "Spring")
        {
            price = 7.20;

            if (groupGender == "boys")
            {
                sport = "Tennis";
            }
            else if (groupGender == "girls")
            {
                sport = "Athletics";

            }
            else if (groupGender == "mixed")
            {
                sport = "Cycling";
                price = 9.50;
            }
        }
        else if (season == "Summer")
        {
            price = 15;

            if (groupGender == "boys")
            {
                sport = "Football";
            }
            else if (groupGender == "girls")
            {
                sport = "Volleyball";
            }
            else if (groupGender == "mixed")
            {
                sport = "Swimming";
                price = 20;
            }
        }
                double total = studentsCount * price * overnightsCount;

                if (studentsCount >= 50)
                {
            total = total * 0.5;
                }
                else if (studentsCount >= 20 && studentsCount < 50)
                {
            total = total * 0.85; // -15% otstupka
                }
                else if (studentsCount >= 10 && studentsCount < 20)
                {
            total = total * 0.95; // -05% otstupka
                }
            
            Console.WriteLine("{0} {0:f2} lv.", sport, total);
        }
    }

