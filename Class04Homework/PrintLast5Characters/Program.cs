using System;

namespace PrintLast5Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string long at least 5 characters:");
            string anyString;
            for (; ;){
                anyString = Console.ReadLine();
                if (anyString.Length < 5)
                {
                    Console.WriteLine("Your string has less than 5 characters, please try again");
                }
                else if (anyString.Length >= 5)
                {
                    Console.WriteLine("Great! Your string is valid");
                    break;
                }
            }
            string lastFiveCharInAnyString = anyString.Substring(anyString.Length - 5);
            Console.WriteLine($"The last five characters of your string are: {lastFiveCharInAnyString}");
            Console.WriteLine("This is a list of those characters:");
            int counter = 1;
            foreach (char characters in lastFiveCharInAnyString)
            {
                Console.WriteLine($"{counter++}. {characters}");
            }
        }
    }
}
