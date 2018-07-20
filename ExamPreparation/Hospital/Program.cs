using System;
namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            int patients;
            double doctors = 7;
            var unTreated = 0.0;
            var treated = 0.0;
            for (double i = 1; i <= days; i++)
            {
                patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if (treated < unTreated)
                    {
                        doctors++;
                    }

                    if (patients >= doctors)
                    {
                        treated = treated + doctors;
                        unTreated = unTreated + (patients - doctors);
                    }

                    else
                    {
                        treated = treated + patients;

                    }
                }
                else
                {
                    if (patients >= doctors)
                    {
                        treated = treated + doctors;
                        unTreated = unTreated + (patients - doctors);
                    }
                    else
                    {
                        treated = treated + patients;
                    }
                }
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {unTreated}.");
        }
    }
}
