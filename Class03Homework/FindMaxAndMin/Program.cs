using System;

namespace FindMaxAndMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[10];
            Console.WriteLine("Enter 1st integer and click enter:");
            bool promptInteger = int.TryParse(Console.ReadLine(), out integerArray[0]);
            Console.WriteLine("Enter 2nd integer and click enter:");
            bool promptInteger2 = int.TryParse(Console.ReadLine(), out integerArray[1]);
            Console.WriteLine("Enter 3rd integer and click enter:");
            bool promptInteger3 = int.TryParse(Console.ReadLine(), out integerArray[2]);
            Console.WriteLine("Enter 4th integer and click enter:");
            bool promptInteger4 = int.TryParse(Console.ReadLine(), out integerArray[3]);
            Console.WriteLine("Enter 5th integer and click enter:");
            bool promptInteger5 = int.TryParse(Console.ReadLine(), out integerArray[4]);
            Console.WriteLine("Enter 6th integer and click enter:");
            bool promptInteger6 = int.TryParse(Console.ReadLine(), out integerArray[5]);
            Console.WriteLine("Enter 7th integer and click enter:");
            bool promptInteger7 = int.TryParse(Console.ReadLine(), out integerArray[6]);
            Console.WriteLine("Enter 8th integer and click enter:");
            bool promptInteger8 = int.TryParse(Console.ReadLine(), out integerArray[7]);
            Console.WriteLine("Enter 9th integer and click enter:");
            bool promptInteger9 = int.TryParse(Console.ReadLine(), out integerArray[8]);
            Console.WriteLine("Enter 10th integer and click enter:");
            bool promptInteger10 = int.TryParse(Console.ReadLine(), out integerArray[9]);
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
