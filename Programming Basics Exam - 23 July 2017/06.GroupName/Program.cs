using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GroupName
{
    class Program
    {
        static void Main(string[] args)
        {
            string AA = Console.ReadLine();
            string aa = Console.ReadLine();
            string bb = Console.ReadLine();
            string cc = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            char A = AA.ToCharArray()[0];
            char a = aa.ToCharArray()[0];
            char b = bb.ToCharArray()[0];
            char c = cc.ToCharArray()[0];
            int sum = 0;


            for (char i = 'A'; i <= A; i++)
            {
                for (char j = 'a'; j <= a; j++)
                {
                    for (char k = 'a'; k <= b; k++)
                    {
                        for (char o = 'a'; o <= c; o++)
                        {
                            for (int number = 0; number <= num; number++)
                            {
                                sum += 1;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(sum - 1);
        }
    }
}
