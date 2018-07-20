using System;

namespace ТръбиВБасейн
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLiters = int.Parse(Console.ReadLine());
            int pipeOne = int.Parse(Console.ReadLine());
            int pipeTwo = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double water = pipeOne * hours + pipeTwo * hours;
           

            if (water <= totalLiters)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                Math.Truncate(water / totalLiters * 100),
                Math.Truncate(pipeOne * hours / water * 100),
                Math.Truncate(pipeTwo * hours / water * 100));
                 
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.", hours, water - totalLiters); 
            }

            
        }
    }
}
