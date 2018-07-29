using System;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            var concat = "";
            var concat2 = "";

            var count = 0;

            while (true)
            {
                for (int i = K; i <= 8; i++)
                {
                    for (int j = 9; j >= L; j--)
                    {
                        for (int p = M; p <= 8; p++)
                        {
                            for (int q = 9; q >= N; q--)
                            {
                                if (i % 2 == 0 && j % 2 != 0 &&
                                    p % 2 == 0 && q % 2 != 0)
                                {
                                    

                                    if (i == p && j == q)
                                    {
                                        Console.WriteLine("Cannot change the same player");
                                    }
                                    else
                                    {
                                        concat = i + "" + j;
                                        concat2 = p + "" + q;
                                        count++;
                                        Console.WriteLine($"{concat + "-" + concat2}");

                                        if (count == 6)
                                        {
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
}
