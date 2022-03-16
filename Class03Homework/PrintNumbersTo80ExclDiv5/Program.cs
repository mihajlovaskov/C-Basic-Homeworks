using System;

namespace PrintNumbersTo80ExclDiv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any positive integer:");
            int positiveInteger;
            for (; ; )
            {
                bool check = int.TryParse(Console.ReadLine(), out positiveInteger);
                if (!check)
                {
                    Console.WriteLine("You've entered an invalid number. Please try again!");
                }
                else if (positiveInteger <= 0)
                {
                    Console.WriteLine("You've entered a negative integer. Please try again!");
                }
                else if (check && positiveInteger > 0) 
                {
                    Console.WriteLine("Great! Your number is valid!");
                    break;
                }
            }
            Console.WriteLine("This is a list of integers below 80, excluding numbers divisible by 5: ");
            for (int i = 1; i <= positiveInteger; i++)
            {
                if (i == 80)
                {
                    Console.WriteLine("The limit is reached!");
                    break;
                }
                if (i % 5 == 0)
                {
                    continue;
                }
                Console.WriteLine($"{i}");
            }
        }
    }
}
