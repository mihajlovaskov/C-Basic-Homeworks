using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> doubleList = new List<double>();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Choose number no.{i} and click enter:");
                bool checkList = double.TryParse(Console.ReadLine(), out double number);
                while (!checkList)
                {
                    Console.WriteLine("You've entered an invalid number! Please try again!");
                    checkList = double.TryParse(Console.ReadLine(), out number);
                    if (checkList)
                    {
                        break;
                    }
                }
                doubleList.Add(number);
            }
            Console.WriteLine("\nThe members of your list are:\n");
            int m = 1;
            foreach (double member in doubleList)
            {
                Console.WriteLine($"{m++}. {member}");
            }
            List<double> doubleListOfSquares = doubleList.Select(n => n * n).ToList();//ne sum siguren dali dobro
            //ja sfativ zadacata. Treba da se formira lista od kvadratite od broevite vo prethodnata lista?
            Console.WriteLine("\nThe members of the list of squares of the numbers in the previous list are:\n");
            int k = 1;
            foreach (double squares in doubleListOfSquares)
            {
                Console.WriteLine($"{k++}. {squares}");
            }
        }
    }
}
