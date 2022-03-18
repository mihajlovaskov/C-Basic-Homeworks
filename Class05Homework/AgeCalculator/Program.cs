using System;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the year of your birthday:");
            int yourYear = 0;//probav tuka da ne ja kreiram tuku tamu kade ja koristam (na linija 13), ama posle taa varijabla mi vleguva vo nekoi for-ovi i ne mi ja prepoznava vo toj scope.
            for (; ; )
            {
                bool checkYear = int.TryParse(Console.ReadLine(), out yourYear);
                if (!checkYear)
                {
                    Console.WriteLine("You've entered an invalid data! Please try again!");
                }
                else if (yourYear > DateTime.Now.Year)
                {
                    Console.WriteLine("You've entered an invalid year (birth year > current year)! Please try again!");
                }
                else if (yourYear < DateTime.Now.Year - 100)//ako e postar od 100 godini da potvrdi preku uste eden vnes na godinata na ragjanje
                {
                    Console.WriteLine("Are you sure about your birth year? Are you over 100 years old? To confirm, please enter your birth year one more time!");
                    for (; ; )
                    {
                        checkYear = int.TryParse(Console.ReadLine(), out yourYear);
                        if (!checkYear)
                        {
                            Console.WriteLine("You've entered an invalid data! Please try again!");
                        }
                        else if (yourYear > DateTime.Now.Year)
                        {
                            Console.WriteLine("You've entered an invalid year (birth year > current year)! Please try again!");
                        }
                        else if (yourYear > DateTime.Now.Year - 5)//ako pri povtoren vnes vnese deka e pomal od 5 godini, ke go prasa da potvrdi preku uste eden vnes
                        {
                            Console.WriteLine("Are you sure about your birth year? Are you less than 5 years old? To confirm, please enter your birth year one more time!");//i da e pomal od 5 godini i da e postar od 100 godini ovoj pat izleguva od ciklusot i prodolzuva so vnes na mesec
                            for (; ; )
                            {
                                checkYear = int.TryParse(Console.ReadLine(), out yourYear);
                                if (!checkYear)
                                {
                                    Console.WriteLine("You've entered an invalid data! Please try again!");
                                }
                                else if (yourYear > DateTime.Now.Year)
                                {
                                    Console.WriteLine("You've entered an invalid year (birth year > current year)! Please try again!");
                                }
                                else if (checkYear)
                                {
                                    break;
                                }
                            }
                            break;
                        }
                        else if (checkYear)
                        {
                            break;
                        }
                    }
                    break;
                }
                else if (yourYear > DateTime.Now.Year - 5)//ako e pomal od 5 godini, da potvrdi preku uste eden vnes na godinata na ragjanje
                {
                    Console.WriteLine("Are you sure about your birth year? Are you less than 5 years old? To confirm, please enter your birth year one more time!");
                    for (; ; )
                    {
                        checkYear = int.TryParse(Console.ReadLine(), out yourYear);
                        if (!checkYear)
                        {
                            Console.WriteLine("You've entered an invalid data! Please try again!");
                        }
                        else if (yourYear > DateTime.Now.Year)
                        {
                            Console.WriteLine("You've entered an invalid year (birth year > current year)! Please try again!");
                        }
                        else if (yourYear < DateTime.Now.Year - 100)//ako e postar od 100 godini da potvrdi preku uste eden vnes na godinata na ragjanje
                        {
                            Console.WriteLine("Are you sure about your birth year? Are you over 100 years old? To confirm, please enter your birth year one more time!");//i da e pomal od 5 godini i da e postar od 100 godini ovoj pat izleguva od ciklusot i prodolzuva so vnes na mesec
                            for (; ; )
                            {
                                checkYear = int.TryParse(Console.ReadLine(), out yourYear);
                                if (!checkYear)
                                {
                                    Console.WriteLine("You've entered an invalid data! Please try again!");
                                }
                                else if (yourYear > DateTime.Now.Year)
                                {
                                    Console.WriteLine("You've entered an invalid year (birth year > current year)! Please try again!");
                                }
                                else if (checkYear)
                                {
                                    break;
                                }
                            }
                            break;
                        }
                        else if (checkYear)
                        {
                            break;
                        }
                    }
                    break;
                }
                else if (checkYear)
                {
                    break;
                }
            }
            
            Console.WriteLine("Please enter the month of your birthday in number format (from 1: January to 12: December):");
            int yourMonth = 0;
            for (; ; )
            {
                bool checkMonth = int.TryParse(Console.ReadLine(), out yourMonth);
                if (!checkMonth)
                {
                    Console.WriteLine("You've entered an invalid data! Please try again!");
                }
                else if (yourMonth > 12 || yourMonth <= 0)
                {
                    Console.WriteLine("You've entered an invalid month (month > 12 or month <= 0)! Please try again!");
                }
                else if (yourMonth > DateTime.Now.Month && yourYear == DateTime.Now.Year)
                {
                    Console.WriteLine("You've entered an invalid month or year (birth year = current year, but birth month > current month)! Please enter your birth month again or if you've entered wrong birth year, close the console app and run the program again!!!");
                }
                else if (checkMonth)
                {
                    break;
                }
            }
            Console.WriteLine("Please enter the day of your birthday in number format (from 1 to 31):");
            int yourDay = 0;
            for (; ; )
            {
                bool checkDay = int.TryParse(Console.ReadLine(), out yourDay);
                if (!checkDay)
                {
                    Console.WriteLine("You've entered an invalid data! Please try again!");
                }
                else if (yourDay <= 0 || yourDay > 31)
                {
                    Console.WriteLine("You've entered an invalid day (0 > birth day > 31)! Please enter your birth day again!");
                }
                else if (yourDay > DateTime.Now.Day && yourMonth == DateTime.Now.Month && yourYear == DateTime.Now.Year)
                {
                    Console.WriteLine("You've entered an invalid day, month or year (birth year = current year, birth month = current month, but birth day > current day)! Please enter your birth day again or if you've entered wrong birth year or birth month, close the console app and run the program again!!!");
                }
                else if (((yourMonth == 4 || yourMonth == 6 || yourMonth == 9 || yourMonth == 11) && yourDay == 31) || (yourMonth == 2 && (yourDay == 30 || yourDay == 31)))//proverka za meseci so broj na denovi <31
                {
                    Console.WriteLine("You've entered an invalid day or month (your birth day > number of days in your birth month! Please enter your birth day again or if you've entered wrong birth month, close the console app and run the program again!");
                }
                else if (yourYear % 4 > 0 && yourMonth == 2 && yourDay == 29)//proverka na godini sto ne se prestapni (site osven za poslednite godini od vekovite)
                {
                    Console.WriteLine("You've entered an invalid day or month (your birth day in February > number of days in your birth February! Please enter your birth day again or if you've entered wrong birth month, close the console app and run the program again!");
                }
                else if (yourYear % 4 == 0 && yourYear % 100 == 0 && yourYear % 400 > 0 && yourMonth == 2 && yourDay == 29)//proverka na godini sto ne se prestapni i se posledni godini od vekovite
                {
                    Console.WriteLine("You've entered an invalid day or month (your birth day in February > number of days in your birth February! Please enter your birth day again or if you've entered wrong birth month, close the console app and run the program again!");
                }
                else if (checkDay)
                {
                    break;
                }
            }
            AgeCalculator(yourYear, yourMonth, yourDay);
            static void AgeCalculator(int birthYear, int birthMonth, int birthDay)
            {
                string birthday = $"{birthDay}.{birthMonth}.{birthYear}";//znam deka ova poinaku se pravi. no pri testiranje primetiv deka isfrla greska ako hipoteticki korisnikot vnese negativna godina (godina od pred novata era). teoretski korisnikot mozebi saka da proveri kolku godini pominale od nekoj nastan ili necie ragjanje sto se slucile vo nekoja godina od pred novata era
                Console.WriteLine($"Your birthday is on {birthday}.");
                if (birthYear < DateTime.Now.Year && birthMonth > DateTime.Now.Month)
                {
                    int ageYears = DateTime.Now.Year - birthYear - 1;
                    Console.WriteLine($"You are {ageYears} year(s) old.");
                }
                else if (birthYear < DateTime.Now.Year && birthMonth == DateTime.Now.Month && birthDay > DateTime.Now.Day)
                {
                    int ageYears = DateTime.Now.Year - birthYear - 1;
                    Console.WriteLine($"You are {ageYears} years old.");
                }
                else if (birthYear < DateTime.Now.Year && birthMonth == DateTime.Now.Month && birthDay <= DateTime.Now.Day)
                {
                    int ageYears = DateTime.Now.Year - birthYear;
                    Console.WriteLine($"You are {ageYears} years old.");
                }
                else if (birthYear < DateTime.Now.Year && birthMonth < DateTime.Now.Month)
                {
                    int ageYears = DateTime.Now.Year - birthYear;
                    Console.WriteLine($"You are {ageYears} years old.");
                }

                else if (birthYear == DateTime.Now.Year && birthMonth < DateTime.Now.Month)
                {
                    int ageMonths = DateTime.Now.Month - birthMonth;
                    Console.WriteLine($"You are {ageMonths} month(s) old.");
                }
                else if (birthYear == DateTime.Now.Year && birthMonth == DateTime.Now.Month && birthDay <= DateTime.Now.Day)
                {
                    int ageDays = DateTime.Now.Day - birthDay;
                    Console.WriteLine($"You are {ageDays} day(s) old.");
                }
            }
        }
    }
}
