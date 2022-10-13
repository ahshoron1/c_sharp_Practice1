using System;

namespace practiceProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            
            for(int i=0; i <= number; i++)
            {
                if(number %i == 0)
                {
                    count++;
                }
            }
                if(count == 2)
                {
                    Console.WriteLine("Prime Number");
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }
                Console.ReadLine();
            
        }
    }
}
