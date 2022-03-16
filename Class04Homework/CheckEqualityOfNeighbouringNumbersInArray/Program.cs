using System;

namespace CheckEqualityOfNeighbouringNumbersInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of array members and click enter:");
            int numberOfMembers = 0;
            int[] arrayOfNumbers = new int[numberOfMembers];
            for (; ; )
            {
                bool check = int.TryParse(Console.ReadLine(), out numberOfMembers);
                if (!check)
                {
                    Console.WriteLine("You've entered an invalid number for number of array members. Try again!");
                }
                else if (check)
                {
                    arrayOfNumbers = new int[numberOfMembers];
                    break;
                }
            }  
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.WriteLine($"Enter member no. {i + 1} of your integer array and click enter:");
                for (; ; )
                {
                    bool promptInteger = int.TryParse(Console.ReadLine(), out arrayOfNumbers[i]);
                    if (!promptInteger)
                    {
                        Console.WriteLine("You've entered an invalid integer as member of your integer array. Please try again!");
                    }
                    else if (promptInteger)
                    {
                        break;
                    }
                }   
            }
            Console.WriteLine("The final list of integers in your integer array is: ");
            foreach (int members in arrayOfNumbers)
            {
                Console.WriteLine($"{members}");
            }
            Console.WriteLine("Choose an integer from your array and check if there is another neighbouring integer with the same value...");
            int chosenNumberInArray;
            for (; ; )
            {
                bool checkk = int.TryParse(Console.ReadLine(), out chosenNumberInArray);
                if (!checkk) 
                {
                    Console.WriteLine("The chosen integer is not a valid number. Please try again!");
                }
                else if (Array.IndexOf(arrayOfNumbers, chosenNumberInArray) == -1)
                {
                    Console.WriteLine("The chosen integer is not a member of your integer array. Please try again!");
                }
                else if (checkk && Array.IndexOf(arrayOfNumbers, chosenNumberInArray) != -1)
                {
                    break;
                }
            }
            int counter = 0;
            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] == chosenNumberInArray && arrayOfNumbers[i-1] == chosenNumberInArray)
                {
                    counter++;
                    }
            }
            Console.WriteLine($"{counter} times there are {chosenNumberInArray}s next to each other");
        }
    }
}
