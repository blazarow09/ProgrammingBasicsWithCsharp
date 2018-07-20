using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string right = Console.ReadLine();

            if (right == "s3cr3t!P@ssw0rd")
            
            {
                Console.WriteLine("Welcome");
            }

            else if (right == "qwerty")
            {
                Console.WriteLine("Wrong password!");
            }
            else if (right == "s3cr3t!p@ss")
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
