using System;

namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[6];
            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine($"Enter integer no. {i + 1} and click enter:");
                for (; ; ) { 
                bool promptInteger = int.TryParse(Console.ReadLine(), out integerArray[i]);
                    if (!promptInteger)
                    {
                        Console.WriteLine("You've entered an invalid number! Please try again!");
                    }
                    else if (promptInteger)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("The final list of integers in your integer array is: ");
            foreach (int members in integerArray)
            {
                Console.WriteLine($"{members}");
            }
            int sumOfEven = 0; 
            for (int i = 0; i < integerArray.Length; i++)
            {
                if (integerArray[i] % 2 == 0)
                {
                    sumOfEven += integerArray[i];
                }
            }
            if (Array.TrueForAll(integerArray, value =>
            {
               return value % 2 != 0;
            }))
            {
                Console.WriteLine("All of your integers are odd numbers");
            }
            else
            {
                Console.WriteLine($"The sum of all even numbers in the array is: {sumOfEven}");
            }
        }
    }
}
