using System;
namespace Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = size + 5;

            Console.WriteLine("{0}^{0}", new string('_', (width - 1) / 2));
            Console.WriteLine("{0}/|\\{0}", new string('_', (width - 1) / 2 - 1));
            Console.WriteLine("{0}/|||\\{0}", new string('_', ((width - 1) / 2 - 1) - 1));

            int outside = size / 2 - 1;
            for (int row = 1; row <= size / 2; row++)
            {
                Console.WriteLine("{0}/{1}|||{1}\\{0}",
                    new string('_', outside),
                    new string('.', row));
                outside--;
            }

            if (size == 4)
            {
                Console.WriteLine("_/.|||.\\_");
            }
            else
            {
                Console.WriteLine("{0}/.|||.\\{0}",
                    
            }

        }
    }
}
