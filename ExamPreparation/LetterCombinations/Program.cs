﻿using System;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            for (char i = firstChar; i <= secondChar; i++)
            {
                for (char j = firstChar; j <= secondChar; j++)
                {
                    for (char k = firstChar; k <= secondChar; k++)
                    {
                        if (i != thirdChar && j != thirdChar && k != thirdChar)
                        {
                            Console.Write($"{i}{j}{k} ");
                            sum++;
                        }

                    }
                }

            }
            Console.WriteLine(sum);

        }
    }
}