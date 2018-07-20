using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChristmasToy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = (2 * n + 3) / 2;
            int width = 5 * n;
            int tirenca = width - n;
            int zvezdichki = 1;
            int ampersand = n+ 2;
            int vulnichka = (3 * n) - 2;
            Console.Write(new string('-', tirenca / 2));
            Console.Write(new string('*', n));
            Console.Write(new string('-', tirenca / 2));
            Console.WriteLine();
            tirenca -= 4;          
            for (int row = 1; row <= height - 1 ; row++)
            {
                for (int col = 0; col < 1; col++)
                {
                    if (row >= 1 && row <= n / 2)
                    {
                        Console.Write(new string('-', tirenca / 2));
                        Console.Write(new string('*', zvezdichki));
                        Console.Write(new string('&', ampersand));
                        Console.Write(new string('*', zvezdichki));
                        Console.Write(new string('-', tirenca / 2));
                        ampersand += 2;
                        zvezdichki += 1;
                        tirenca -= 4;
                    }
                    
                    else
                    {
                        
                        
                        Console.Write(new string('-', (tirenca / 2) + 1));
                        Console.Write(new string('*', 2));
                        Console.Write(new string('~', vulnichka));
                        Console.Write(new string('*', 2));
                        Console.Write(new string('-', (tirenca / 2) + 1));
                        tirenca -= 2;
                        vulnichka += 2;
                    }       
                }
                Console.WriteLine();
            }
            Console.Write(new string('-', n/ 2));
            Console.Write(new string('*', 1));
            Console.Write(new string('|', (width - 2) - n));
            Console.Write(new string('*', 1));
            Console.Write(new string('-', n / 2));
            Console.WriteLine();
            tirenca = n / 2;
            vulnichka = (4 * n) - 4;
            ampersand = n * 2;
            zvezdichki = n / 2;
            for (int row = 1; row <= height -1; row++)
            {
                for (int col = 0; col < 1; col++)
                {
                    
                    if (row >= 1 && row <= n / 2)
                    {
                        Console.Write(new string('-', tirenca));
                        Console.Write(new string('*', 2));
                        Console.Write(new string('~', vulnichka));
                        Console.Write(new string('*', 2));
                        Console.Write(new string('-', tirenca));
                        tirenca += 1;
                        vulnichka -= 2;
                    }
                    else
                    {
                        Console.Write(new string('-', tirenca));
                        Console.Write(new string('*', zvezdichki));
                        Console.Write(new string('&', ampersand));
                        Console.Write(new string('*', zvezdichki));
                        Console.Write(new string('-', tirenca));
                        zvezdichki -= 1;
                        ampersand -= 2;
                        tirenca += 2;
                    }
                }
                Console.WriteLine();
            }
            Console.Write(new string('-', tirenca ));
            Console.Write(new string('*', n));
            Console.Write(new string('-', tirenca ));
            Console.WriteLine();

        }
    }
}
