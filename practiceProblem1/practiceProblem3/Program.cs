using System;
namespace practiceProblem3
{
    class Program
    {
        static void main(string[] args)
        {
            string str, str1 = "";
            int i, l;
            Console.Write("Input A String: ");
            str = Console.ReadLine();
            l = str.Length - 1;
            for(i = 1; i >= 0; i--)
            {
                str1 = str1 + str[i];
            }
            Console.WriteLine("The string in Reverse order Is:{0}", str1);
            Console.Write("\n");
        }
    }
}
