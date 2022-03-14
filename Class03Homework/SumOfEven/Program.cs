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
                bool promptInteger = int.TryParse(Console.ReadLine(), out integerArray[i]);
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
