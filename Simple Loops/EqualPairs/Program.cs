using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int commonValue = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < number; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                
                if ((number1 + number2) < min)
                {
                    min = number1 + number2;
                }
                if ((number1 + number2) > max)
                {
                    max = number1 + number2;
                }
                if((number1 + number2) == sum)
                {
                    commonValue = number1 + number2;
                }

                sum += number1 + number2;
            }
            if (number == 1)
            {
                Console.WriteLine("Yes, value={0}", sum );
            }
          
            else if (commonValue != 0)
            {
                Console.WriteLine("Yes, value={0}", commonValue);
            }
            else
            {
                double maxRazlika = max - min;
                Console.WriteLine("No, maxdiff={0}", maxRazlika );
            }
                
            
        }
    }
}
