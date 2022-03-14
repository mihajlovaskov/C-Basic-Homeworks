using System;

namespace PrintNumbersTo80ExclDiv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any positive integer:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("This is a list of integers below 80, excluding numbers divisible by 5: ");
            for (int i = 1; i <= number; i++)
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
