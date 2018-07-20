using System;

    class Program
    {
        static void Main(string[] args)
        {
        string gender = (Console.ReadLine());
        double weightInKg = double.Parse(Console.ReadLine());
        double heightInMeters = double.Parse(Console.ReadLine());
        double yearsOld = double.Parse(Console.ReadLine());
        string activity = Console.ReadLine();

            double coeficientsActivity = 0.0;
            double BNM  = 0.0;

            if (gender == "m")
            {
                BNM = 66 + (13.7 * weightInKg) + (5 * (heightInMeters / 0.010000)) - (6.8 * yearsOld);

            if (activity == "sedentary")
            {
                    coeficientsActivity = BNM * 1.2;
                }
                else if (activity == "lightly active")
                {
                    coeficientsActivity = BNM * 1.375;
                }
                else if (activity == "moderately active")
                {
                    coeficientsActivity = BNM * 1.55;
                }
                else if (activity == "very active")
                {
                    coeficientsActivity = BNM * 1.725;
                }
            }
            else if (gender == "f")
            {
                BNM = 655 + (9.6 * weightInKg) + (1.8 * (heightInMeters/ 0.010000)) - (4.7 * yearsOld);

                if (activity == "sedentary")
                {
                    coeficientsActivity = BNM * 1.2;
                }
                else if (activity == "lightly active")
                {
                    coeficientsActivity = BNM * 1.375;
                }
                else if (activity == "moderately active")
                {
                    coeficientsActivity = BNM * 1.55;
                }
                else if (activity == "very active")
                {
                    coeficientsActivity = BNM * 1.725;
                }


            }
         Console.WriteLine("To maintain your current weight you will need {0} calories per day.", Math.Ceiling(coeficientsActivity));
        }
    }

