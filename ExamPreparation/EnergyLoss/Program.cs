using System;

namespace EnergyLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingDays = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
          
            double energy = 0.0;
           
            double totalEnergy = 100 * dancers * trainingDays;

            for (int i = 1; i <= trainingDays; i++)
            {


                int hoursTraining = int.Parse(Console.ReadLine());

                if (i % 2 == 0 && hoursTraining % 2 == 0)
                {
                    energy += 68;
                }
                else if (i % 2 == 1 && hoursTraining % 2 == 0)
                {
                    energy +=49;
                }
                else if (i % 2 == 0 && hoursTraining % 2 == 1)
                {
                    energy += 65;
                }
                else if (i % 2 == 1 && hoursTraining % 2 == 1)
                {
                    energy += 30;
                }

               
            }

            double totalSpendEnergy = totalEnergy - (energy * dancers);
           
            double energyPerDancer = totalSpendEnergy / dancers / trainingDays;

            if (energyPerDancer < 50)
            {
                Console.WriteLine($"They are wasted! Energy left: {energyPerDancer:f2}");
            }
            else
            {
                Console.WriteLine($"They feel good! Energy left: {energyPerDancer:f2}");
            }

        }
    }
}