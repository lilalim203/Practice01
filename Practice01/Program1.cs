// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Lila Lim!");

// 1 - Develop an algorithm that requests 2 numbers and calculates and prints the product.

using System;

namespace ReadLine1
{
    class Program1
    {
        static void Main(string[] args)
        {
            string sinput1, sinput2;
            int input1, input2, sum;

            Console.Write("\nInput the first number: ");
            sinput1 = Console.ReadLine();
            input1 = Convert.ToInt32(sinput1);
            //Console.WriteLine(input1);

            Console.Write("Input the second number: ");
            sinput2 = Console.ReadLine();
            input2 = Convert.ToInt32(sinput2);
            //Console.WriteLine(input2);

            sum = input1 + input2;

            Console.WriteLine("\nThe sum of two inputs is " + sum);
        }
    }
}
            