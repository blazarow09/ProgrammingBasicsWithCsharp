using System;


namespace BankNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1 = int.Parse(Console.ReadLine());
            char p2 = char.Parse(Console.ReadLine());
            char p3 = char.Parse(Console.ReadLine());
            char p4 = char.Parse(Console.ReadLine());
            int p5 = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = p1; i <= 99; i++)
            {
                for (char j = p2; j <= 'Z'; j++)
                {
                    for (char k = p3; k <= 'z'; k++)
                    {
                        for (char l = p4; l <= 'Z'; l++)
                        {
                            for (int m = p5; m > 10; m--)
                            {
                                if (i % 10 == 2 && m % 10 == 5)
                                {
                                    counter++;

                                    if (counter == max)
                                    {
                                        Console.WriteLine($"{i}{j}{k}{l}{m}");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
