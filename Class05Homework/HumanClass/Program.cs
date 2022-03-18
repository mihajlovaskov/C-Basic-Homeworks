using HumanClassCreation;// za mene komentar - ova mora da stoi tuka za da moze da se instancira objekt definiran so Class vo Human.cs
using System;
using System.Text.RegularExpressions;// ova go dodadov za da mozam da go koristam Regex.IsMatch

namespace HumanClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name of any person:");
            string firstName;//probav tuka da ne go deklariram, tuku vo linija 15 i da go deklariram i da go inicijaliziram, ama posle ne go prepoznava nadvor od for ciklusite, a mi e potreben
            for (; ; ) 
            {
                firstName = Console.ReadLine();
                if (String.IsNullOrEmpty(firstName))
                {
                    Console.WriteLine("You haven't entered anything! Please enter the first name of any person!");
                }
                else if (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))//dozvoluva samo bukvi vo ime i prezime.
                {
                    Console.WriteLine("First name is expected to contain letters only! Please enter valid first name of any person!");
                }
                else 
                { 
                    break; 
                }
            }
            Console.WriteLine("Enter the last name of the same person:");
            string lastName;//probav tuka da ne go deklariram, tuku vo linija 33 i da go deklariram i da go inicijaliziram, ama posle ne go prepoznava nadvor od for ciklusite, a mi e potreben
            for (; ; )
            {
                lastName = Console.ReadLine();
                if (String.IsNullOrEmpty(lastName))
                {
                    Console.WriteLine("You haven't entered anything! Please enter the last name of the person!");
                }
                else if (!Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))//dozvoluva samo bukvi
                {
                    Console.WriteLine("Last name is expected to contain letters only! Please enter valid last name of the person!");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Enter person age:");
            int age;//probav tuka da ne go deklariram, tuku vo linija 51 i da go deklariram i da go inicijaliziram, ama posle ne go prepoznava nadvor od for ciklusite, a mi e potreben
            for (; ; )
            {
                bool checkAge = int.TryParse(Console.ReadLine(), out age);
                if (!checkAge)
                {
                    Console.WriteLine("You've entered invalid number! Please try again!");
                }
                else if (age <= 0)
                {
                    Console.WriteLine("You've entered a negative number! Please try again");
                }
                else if (age > 100)//ako vnese deka ima nad 100 godini go prasuva uste ednas za potvrda da ja vnese vozrasta. ako vnesenata vozrast e validna, se izleguva od ciklusot nezavisno sto mozebi povtorno ke se vnese broj nad 100
                {
                    Console.WriteLine("Your person is over 100 years old! Are you sure about your entry? Please enter person age one more time!");
                    for(; ; )
                    {
                        checkAge = int.TryParse(Console.ReadLine(), out age);
                        if (!checkAge)
                        {
                            Console.WriteLine("You've entered invalid number! Please try again!");
                        }
                        else if (age <= 0)
                        {
                            Console.WriteLine("You've entered a negative number! Please try again");
                        }
                        else if (checkAge)
                        {
                            break;
                        }
                    }
                    break;
                }
                else if (checkAge)
                {
                    break;
                }
            }
            Human human = new Human(firstName, lastName, age);
            Console.WriteLine(human.GetPersonStats());
            //Human human = new Human(); // za mene komentar - ova ne se izvrsuva. za da se izvrsi, ne treba da ima definirano nikakov konstruktor so parametri vo Class Human, ili treba da ima definirano konstruktor no bez parametri.
            //human.FirstName = firstName;
            //human.LastName = lastName;  
            //human.Age = age;
        }
    }
}
