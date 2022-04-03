using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> doubleQueue = new Queue<double>();
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"Choose number no.{i} and click enter:");
                bool check = double.TryParse(Console.ReadLine(), out double num);
                while (!check)
                {
                    Console.WriteLine("You've entered an invalid number! Please try again!");
                    check = double.TryParse(Console.ReadLine(), out num); 
                    if (check)
                    {
                        break;
                    }
                }
                doubleQueue.Enqueue(num);
            }
            Console.WriteLine("\nThe members of your queue are:\n");
            int n = 1;
            foreach (double member in doubleQueue)
            {
                Console.WriteLine($"{n++}. {member}");
            }

        }
    }
}
