using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string lens = new string('/', 2 * n - 2);
            string bridge = new string('|', n);
            string emptySpace = new string(' ', n);
            string lensAndFrame = string.Format("{0}{1}{0}", '*', lens);
            string frame = new string('*', 2 * n);

            for (int row = 0; row < n; row++)
            {
                if (row == 0 || row == n - 1)
                {
                    Console.WriteLine("{0}{1}{0}", frame, emptySpace);
                }
                else if (row == (n -1 )/ 2  )
                {
                    Console.WriteLine("{0}{1}{0}", lensAndFrame, bridge);
                }
                else  
                {
                    Console.WriteLine("{0}{1}{0}", lensAndFrame, emptySpace);
                }
            }
        }
    }
}
