using System;

namespace AgeCalculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday in the following format mm/dd/yyyy (e.g. June 3, 2011 = 6/3/2011):");

            string yourBirthday;
            for (; ; )
            {

                yourBirthday = Console.ReadLine();
                if (!DateTime.TryParse(yourBirthday, out var value))
                {
                    Console.WriteLine("You've entered an invalid date! Please try again in the following format mm/dd/yyyy (e.g. June 3, 2011 = 6/3/2011)");
                }
                else if (DateTime.Parse(yourBirthday) > DateTime.Now)
                {
                    Console.WriteLine("According to your entry, you are still not born! Please try again, in the following format mm/dd/yyyy (e.g. June 3, 2011 = 6/3/2011)!");
                }
                else if((DateTime.TryParse(yourBirthday, out value)))
                {
                    break;
                }
            }
            AgeCalculator(yourBirthday);
        }
        static void AgeCalculator(string birthdayDate)
        {
            DateTime parsedBirthdayDate = DateTime.Parse(birthdayDate);
            if (parsedBirthdayDate.Year < DateTime.Now.Year && parsedBirthdayDate.Month > DateTime.Now.Month)
            {
                int ageYears = DateTime.Now.Year - parsedBirthdayDate.Year - 1;
                Console.WriteLine($"You are {ageYears} years old.");
            }
            else if (parsedBirthdayDate.Year < DateTime.Now.Year && parsedBirthdayDate.Month == DateTime.Now.Month && parsedBirthdayDate.Day > DateTime.Now.Day)
            {
                int ageYears = DateTime.Now.Year - parsedBirthdayDate.Year - 1;
                Console.WriteLine($"You are {ageYears} years old.");
            }
            else if (parsedBirthdayDate.Year < DateTime.Now.Year && parsedBirthdayDate.Month == DateTime.Now.Month && parsedBirthdayDate.Day <= DateTime.Now.Day)
            {
                int ageYears = DateTime.Now.Year - parsedBirthdayDate.Year;
                Console.WriteLine($"You are {ageYears} years old.");
            }
            else if (parsedBirthdayDate.Year < DateTime.Now.Year && parsedBirthdayDate.Month < DateTime.Now.Month)
            {
                int ageYears = DateTime.Now.Year - parsedBirthdayDate.Year;
                Console.WriteLine($"You are {ageYears} years old.");
            }

            else if (parsedBirthdayDate.Year == DateTime.Now.Year && parsedBirthdayDate.Month < DateTime.Now.Month)
            {
                int ageMonths = DateTime.Now.Month - parsedBirthdayDate.Month;
                Console.WriteLine($"You are {ageMonths} month(s) old.");
            }
            else if (parsedBirthdayDate.Year == DateTime.Now.Year && parsedBirthdayDate.Month == DateTime.Now.Month && parsedBirthdayDate.Day <= DateTime.Now.Day)
            {
                int ageDays = DateTime.Now.Day - parsedBirthdayDate.Day;
                Console.WriteLine($"You are {ageDays} day(s) old.");
            }
        }
    }
}
