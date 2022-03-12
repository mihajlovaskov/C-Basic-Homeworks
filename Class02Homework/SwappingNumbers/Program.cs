using System;

namespace SwappingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            Console.WriteLine("Enter first number and click enter:");
            for (; ; )
            {
                bool success = double.TryParse(Console.ReadLine(), out num1);
                if (!success)
                {
                    Console.WriteLine("CAUTION!!! You've entered an invalid number! Please try again!");
                }
                else if (success)
                {
                    break;
                }
            }
            Console.WriteLine("Enter second number and click enter:");
            for (; ; )
            {
                bool secondSuccess = double.TryParse(Console.ReadLine(), out num2);
                if (!secondSuccess)
                {
                    Console.WriteLine("CAUTION!!! You've entered an invalid number! Please try again!");
                }
                else if (secondSuccess)
                {
                    break;
                }
            }
            Console.WriteLine($"Before swapping, first number is: {num1}, whereas second number is: {num2}");
            double num3 = num1;
            double num4 = num2;
            num1 = num4;
            num2 = num3;
            Console.WriteLine($"After swapping, first number is: {num1}, whereas second number is: {num2}");
        }
    }
}
