using System;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number and click enter");
            double oneNumber;//da bidat dozvoleni ne samo celi tuku i decimalni broevi
            for ( ; ; )
            {
                bool checkNumber = double.TryParse(Console.ReadLine(), out oneNumber);
                if (!checkNumber)
                {
                    Console.WriteLine("Your number is not valid, please try again");
                }
                else if (checkNumber)
                {
                    Console.WriteLine("Great! You've entered a valid number");
                    break;
                }
            }
            double anyNumber = Math.Abs(oneNumber);//ako vnese negativen da go pretvori vo pozitiven broj
            double diff = anyNumber - Math.Floor(anyNumber);//presmetkite mi se razlicni ako korisnikot vnese
            // cel broj (pr. 53), odnosno broj so decimala ednakva na nula (53.0) ili decimalen broj kade
            // decimalata e razlicna od nula (pr. 53.5).
            if (diff > 0)//vo ovoj del se presmetkite za zbir na cifri na decimalen broj,
                         //kade posle decimalnata zapirka ima nekoja cifra razlicna od nula
            {
                string anyNumberToString = Convert.ToString(anyNumber);//go pretvaram vo string za da mozam da mu
                                                                       //napravam Split na mestoto na decimalnata
                                                                       //zapirka (.)
                string[] anyNumberToStringInArray = anyNumberToString.Split(".");
                string intBeforeSign = anyNumberToStringInArray[0];
                string intAfterSign = anyNumberToStringInArray[1];
                int sum = 0;
                foreach (char digits in intBeforeSign)//zbir na cifri od brojot pred decimalnata zapirka
                {
                    string charDigitsToString = digits.ToString(); //ne moze direktno od char vo int,
                                                                   //pa odam indirektno preku string
                    int integerNumbers = Convert.ToInt32(charDigitsToString);
                    sum += integerNumbers;
                }
                int sum2 = 0;
                foreach (char digits in intAfterSign)//zbir na cifri od brojot posle decimalnata zapirka
                {
                    string charDigitsToString = digits.ToString();
                    int integerNumbers = Convert.ToInt32(charDigitsToString);
                    sum2 += integerNumbers;
                }
                int sumOfAllDigits = sum + sum2;
                Console.WriteLine($"The sum of all digits in your number is: {sumOfAllDigits}");
            }
            else if (diff == 0)//vo ovoj del se presmetkite za zbirot na cifri ako korisnikot vnese cel broj bez
            //decimalna zapirka ili vnese decimalen broj no posle decimalnata zapirka ima nula ili nuli
            {
                string intBeforeSign = anyNumber.ToString();
                int sum = 0;
                foreach (char digits in intBeforeSign)
                {
                    string charDigitsToString = digits.ToString(); 
                    int integerNumbers = Convert.ToInt32(charDigitsToString);
                    sum += integerNumbers;
                }
                Console.WriteLine($"The sum of all digits in your number is: {sum}");
            }
        }
    }
}
