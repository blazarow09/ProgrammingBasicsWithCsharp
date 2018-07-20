using System;


class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int left = n;
        int rev = 0;
        int rev1 = 0;
        int rev2 = 0;

        int r = left % 10;
        rev = rev + r;
        left = left / 10;

        r = left % 10;
        rev1 = rev1 + r;
        left = left / 10;
        r = left % 10;
        rev2 = rev2 + r;

        for (int i = 1; i <= rev; i++)
        {
            for (int j = 1; j <= rev1; j++)
            {
                for (int k = 1; k <= rev2; k++)
                {
                    Console.WriteLine(i + " " + "*" + " " + j + " " + "*" + " " + k + " " + "=" + " " + i * j * k + ";");
                }
            }
        }

    }
    
}