using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());            
            while (number % 2 != 0)
            {
                Console.WriteLine("The number is not even.");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Even number entered: " + number);
        }
    }
}
