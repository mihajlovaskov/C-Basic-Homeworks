using System;

namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[6];
            Console.WriteLine("Enter first integer and click enter:");
            bool promptInteger = int.TryParse(Console.ReadLine(), out integerArray[0]);
            Console.WriteLine("Enter second integer and click enter:");
            bool promptInteger2 = int.TryParse(Console.ReadLine(), out integerArray[1]);
            Console.WriteLine("Enter third integer and click enter:");
            bool promptInteger3 = int.TryParse(Console.ReadLine(), out integerArray[2]);
            Console.WriteLine("Enter fourth integer and click enter:");
            bool promptInteger4 = int.TryParse(Console.ReadLine(), out integerArray[3]);
            Console.WriteLine("Enter fifth integer and click enter:");
            bool promptInteger5 = int.TryParse(Console.ReadLine(), out integerArray[4]);
            Console.WriteLine("Enter sixth integer and click enter:");
            bool promptInteger6 = int.TryParse(Console.ReadLine(), out integerArray[5]);
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
