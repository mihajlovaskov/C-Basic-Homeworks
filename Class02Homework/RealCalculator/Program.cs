using System;

namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double parsedResult;
            double secondParsedResult;
            char operators;
            Console.WriteLine("Enter first number and click enter:");
            for (; ; ) {
                bool success = double.TryParse(Console.ReadLine(), out parsedResult);
                if (!success)
                {
                    Console.WriteLine("CAUTION!!! You've entered an invalid number, please try again");
                }
                else if (success)
                {
                    break;
                }
            }
            Console.WriteLine("Enter second number and click enter:");
            for (; ; ){
                bool secondSuccess = double.TryParse(Console.ReadLine(), out secondParsedResult);
                if (!secondSuccess)
                {
                Console.WriteLine("CAUTION!!! You've entered an invalid number, please try again");
                }
                   else if (secondSuccess)
                {
                    break;
                }
            }
            Console.WriteLine("Enter operator (+, -, * or /) and click enter:");
            for ( ; ; )
            {
                bool thirdSuccess = char.TryParse(Console.ReadLine(), out operators);
                if (operators == '+' || operators == '-' || operators == '*' || operators == '/')
                {
                    switch (operators)
                    {
                        case '+':
                            double finalResult = parsedResult + secondParsedResult;
                            Console.WriteLine($"The final result is: {finalResult}");
                            break;
                        case '-':
                            finalResult = parsedResult - secondParsedResult;
                            Console.WriteLine($"The final result is: {finalResult}");
                            break;
                        case '*':
                            finalResult = parsedResult * secondParsedResult;
                            Console.WriteLine($"The final result is: {finalResult}");
                            break;
                        case '/':
                            finalResult = parsedResult / secondParsedResult;
                            Console.WriteLine($"The final result is: {finalResult}");
                            break;
                    }
                    break;
                }
                else { Console.WriteLine("CAUTION!!! You've entered an invalid operator! Please try again"); 
                }
            }
        }
    }
}
