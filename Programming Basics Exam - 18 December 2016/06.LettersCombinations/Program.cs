using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string no = Console.ReadLine();
            char letter1 = first.ToCharArray()[0];
            char letter2 = second.ToCharArray()[0];
            char noLetter = no.ToCharArray()[0];
            int sum = 0;
            for (char a = letter1; a <= letter2; a++)
            {
                for (char b = letter1; b <= letter2; b++)
                {
                    for (char c = letter1; c <= letter2; c++)
                    {
                        if (a != noLetter && b != noLetter && c != noLetter)
                        {
                            sum += 1;
                            Console.Write($"{a}{b}{c} ");                           
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
