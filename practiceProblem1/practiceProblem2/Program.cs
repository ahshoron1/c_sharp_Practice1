using System;
namespace practiceProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, num1, num2;
            int count = 0;
            firstNumber = Convert.ToInt32(Console.ReadLine());
            secondNumber = Convert.ToInt32(Console.ReadLine());
            int i = firstNumber;
            for(i = 1; i<= secondNumber; i++)
            {
                num1 = secondNumber;
                if(num1 %i ==0)
                {
                    count++;
                }

            }
            if(count == 2)
            {
                Console.WriteLine(count);
            }

        }
    }
}
