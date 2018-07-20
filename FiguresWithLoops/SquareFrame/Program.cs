using System; 

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            
           //Top
                string border = new string('*', size * 2);
                string spaces = new string(' ', size);
                Console.WriteLine("{0}{1}{0}", border, spaces);

            //Middle                 
            for (int row = 0; row < size - 2; row++)
            {
                Console.Write("*" + new string('/', 2 * (size -1)) + "*");

                if (row == (size - 1) / 2 - 1)
                {
                    Console.Write(new string('|', size));
                }
                else
                {
                    Console.Write(spaces);
                }
                Console.Write("*" + new string('/', 2 * (size - 1)) +"*");
                Console.WriteLine();
            }
            

            //Bottom
            Console.WriteLine("{0}{1}{0}", border, spaces);

        }
    }
}

