using System;

namespace FindStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer and click enter:");
            int num1;
            for (; ; )
            {
                bool promptInt = int.TryParse(Console.ReadLine(), out num1);
                if (!promptInt)
                {
                    Console.WriteLine("You've entered an invalid integer! Please try again!");
                }
                else if (promptInt)
                {
                    break;
                }
            }
            Console.WriteLine("Enter another integer and click enter:");
            int num2;
            for (; ; )
            {
                bool promptInt2 = int.TryParse(Console.ReadLine(), out num2);

                if (!promptInt2)
                {
                    Console.WriteLine("You've entered an invalid integer! Please try again!");
                }
                else if (promptInt2)
                {
                    break;
                }
            }
            if (num1 % 2==0 && num2 % 2 == 0)
            {
                int num3 = num1 + num2;
                Console.WriteLine($"Both integers are even numbers. Accordingly, the required operation is as follows: {num1} + {num2} = ??, whereas the final result is: {num3}");
            }
            else if(num1 % 2 != 0 && num2 % 2 != 0)
            {
                int num3 = num1 * num2;
                Console.WriteLine($"Both integers are odd numbers. Accordingly, the required operation is as follows: {num1} * {num2} = ??, whereas the final result is: {num3}");
            }
            else
            {
                int num3 = num1 - num2;
                Console.WriteLine($"Only one of the integers is an odd number. Accordingly, the required operation is as follows: {num1} - {num2} = ??, whereas the final result is: {num3}");
            }
        }
    }
}
