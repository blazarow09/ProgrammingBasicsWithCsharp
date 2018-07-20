using System;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string secondWord = Console.ReadLine();

            word = word.ToLower();
            secondWord = secondWord.ToLower();

            if (word == secondWord)
            {
                Console.WriteLine("yes");
            }

            else if (word != secondWord)
            {
                Console.WriteLine("no");
            }
        }
    }
}
