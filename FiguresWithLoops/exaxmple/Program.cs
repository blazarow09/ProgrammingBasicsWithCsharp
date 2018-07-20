using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int tochki = 2 * n + 1;
        Console.WriteLine("{0}{1}{0}{2}", '+', new string('~', n - 2), new string('.', tochki));
        tochki--;
        Console.WriteLine("{0}{1}{2}{1}{3}", '|', '\\', new string('~', n - 2), new string('.', tochki));
        tochki--;
        for (int i = 1; i <= (2 * n); i++)
        {
            Console.Write("|");
            Console.Write(new string('.', i));
            Console.Write("\\");
            Console.Write(new string('~', n - 2));
            Console.Write("\\");
            Console.Write(new string('.', tochki));
            Console.WriteLine();
            tochki--;
        }
        tochki = 2 * n; ;
        for (int i = 0; i < (2 * n) + 1; i++)
        {

            Console.Write(new string('.', i));
            Console.Write("\\");
            Console.Write(new string('.', tochki));
            tochki--;
            Console.Write("{0}{1}{0}", '|', new string('~', n - 2));
            Console.WriteLine();
        }
        Console.Write(new string('.', 2 * n + 1));
        Console.Write("{0}{1}{0}", '+', new string('~', n - 2));
    }
}