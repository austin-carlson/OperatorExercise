using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 3;

            int sum = a + b;
            Console.WriteLine(sum);
            int subtract = a - b;
            Console.WriteLine(subtract);
            int product = a * b;
            Console.WriteLine(product);
            int quotient = a / b;
            Console.WriteLine(quotient);
            int remainder = a % b;
            Console.WriteLine(remainder);

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} divided by {b} equals {quotient} with a remainder of {remainder}");
            }
            

          


        }
    }
}
