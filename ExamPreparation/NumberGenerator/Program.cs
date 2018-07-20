using System;
class Program
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int L = int.Parse(Console.ReadLine());
        int specialNumber = int.Parse(Console.ReadLine());
        int controlNumber = int.Parse(Console.ReadLine());

        for (int i = M; i >= 1; i--)
        {
            for (int j = N; j >= 1; j--)
            {
                for (int k = L; k >= 1; k--)
                {

                    int number = i * 100 + j * 10 + k;

                    if (number % 3 == 0)
                    {
                        specialNumber += 5;
                    }
                    else if (number % 5 == 0)
                    {
                        specialNumber -= 2;
                    }
                    else if (number % 2 == 0)
                    {
                        specialNumber *= 2;
                    }

                    if (specialNumber >= controlNumber)
                    {
                        Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
                        return;
                    }
                }

            }

        }


        Console.WriteLine("No! {0} is the last reached special number.", specialNumber);

    }
}