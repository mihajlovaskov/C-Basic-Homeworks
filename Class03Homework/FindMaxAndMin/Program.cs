using System;

namespace FindMaxAndMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[10];
            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine($"Enter integer no. {i + 1} and click enter:");
                for (; ; )
                {
                    bool promptInteger = int.TryParse(Console.ReadLine(), out integerArray[i]);
                    if (!promptInteger)
                    {
                        Console.WriteLine("You've entered an invalid integer! Please try again!");
                    }
                    else if (promptInteger)
                    {
                        break;
                    }
                };
            }
            Console.WriteLine("The final list of integers in your integer array is: ");
            foreach (int members in integerArray)
            {
                Console.WriteLine($"{members}");
            }
            double max = double.NegativeInfinity;
            double min = double.PositiveInfinity;
            for (int i = 0; i < integerArray.Length; i++)
            {
                if (integerArray[i] >= max)
                {
                    max = integerArray[i];
                }
                if (integerArray[i] <= min)
                {
                    min = integerArray[i];
                }
            }
            Console.WriteLine($"The maximum integer in the array is: {max}, whereas the minimum integer in the same array is: {min}");
        }
    }
}
