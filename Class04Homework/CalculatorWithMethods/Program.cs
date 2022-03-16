using System;

namespace CalculatorWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            char anyOperators;
            Console.WriteLine("Enter first number and click enter:");
            for (; ; )
            {
                bool success = double.TryParse(Console.ReadLine(), out number1);
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
            for (; ; )
            {
                bool secondSuccess = double.TryParse(Console.ReadLine(), out number2);
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
            for (; ; )
            {
                bool thirdSuccess = char.TryParse(Console.ReadLine(), out anyOperators);
                if (anyOperators == '+' || anyOperators == '-' || anyOperators == '*' || anyOperators == '/')
                {
                    switch (anyOperators)
                    {
                        case '+':
                            Sum(number1, number2);
                            break;
                        case '-':
                            Substract(number1, number2);
                            break;
                        case '*':
                            Multiplication(number1, number2);
                            break;
                        case '/':
                            Division(number1, number2);
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("CAUTION!!! You've entered an invalid operator! Please try again");
                }
            }
            Calculator(anyOperators, number1, number2);//Malce mi e nejasna zadacata. Ne e navedeno za sto
             // se koristi ovaa funkcija/metod? Dali se povikuva ili ne? Kako i da e, presmetkite gi pravam
            // i so ovoj metod, iako vekje pogore povikani se i drugite soodvetni metodi.
            // Eve neka bide nekoj vid na proverka, dali se dobiva istiot rezultat...
        }
        static void Sum(double num1, double num2)
        {
            double num3 = num1 + num2;
            Console.WriteLine($"The result of the sum with Sum() method is: {num3}");
        }
        static void Substract(double num1, double num2)
        {
            double num3 = num1 - num2;
            Console.WriteLine($"The result of the substraction with Substract() method is: {num3}");
        }
        static void Multiplication(double num1, double num2)
        {
            double num3 = num1 * num2;
            Console.WriteLine($"The result of the multiplication with Multiplication() method is: {num3}");
        }
        static void Division(double num1, double num2)
        {
            double num3 = num1 / num2;
            Console.WriteLine($"The result of the division with Division() method is: {num3}");
        }
        static void Calculator(char operators, double num1, double num2)
        {
            if (operators == '+')
            {
                double num3 = num1 + num2;
                Console.WriteLine($"The result of the sum with Calculator() method is: {num3}");
            }
            else if (operators == '-')
            {
                double num3 = num1 - num2;
                Console.WriteLine($"The result of the substraction with Calculator() method is: {num3}");
            }
            else if (operators == '*')
            {
                double num3 = num1 * num2;
                Console.WriteLine($"The result of the multiplication with Calculator() method is: {num3}");
            }
            else if (operators == '/')
            {
                double num3 = num1 / num2;
                Console.WriteLine($"The result of the division with Calculator() method is: {num3}");
            }
        }
    }
}
