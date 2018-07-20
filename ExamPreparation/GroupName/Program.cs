using System;

namespace GroupName
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            char forthLetter = char.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int counter = -1;

            for (char i = 'A'; i <= firstLetter; i++)
            {
                for (char j = 'a'; j <= secondLetter; j++)
                {
                    for (char k = 'a'; k <= thirdLetter; k++)
                    {
                        for (char l = 'a'; l <= forthLetter; l++)
                        {
                            for (int m = 0; m <= max; m++)
                            {
                                counter++;
                                
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter); ;


        }
    }
}
