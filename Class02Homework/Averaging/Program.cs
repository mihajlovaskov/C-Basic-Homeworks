using System;

namespace Averaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
            double num4;
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
            Console.WriteLine("Enter third number and click enter:");
            for (; ; )
            {
                bool thirdSuccess = double.TryParse(Console.ReadLine(), out num3);
                if (!thirdSuccess)
                {
                    Console.WriteLine("CAUTION!!! You've entered an invalid number! Please try again!");
                }
                else if (thirdSuccess)
                {
                    break;
                }
            }
            Console.WriteLine("Enter fourth number and click enter:");
            for (; ; )
            {
                bool fourthSuccess = double.TryParse(Console.ReadLine(), out num4);
                if (!fourthSuccess)
                {
                    Console.WriteLine("CAUTION!!! You've entered an invalid number! Please try again!");
                }
                else if (fourthSuccess)
                {
                    break;
                }
            }
            double averageNum = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is: {averageNum}");
        }
    }
}
