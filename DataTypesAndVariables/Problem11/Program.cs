using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
////    Problem 11. Bank Account Data

////A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
//    bank name, IBAN, 3 credit card numbers associated with the account.
////Declare the variables needed to keep the information for a single bank account using the appropriate data types 
//    and descriptive names.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter your First name!");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your Middle name!");
            string middleName = Console.ReadLine();
            Console.WriteLine("Please enter your Last name!");
            string lastName = Console.ReadLine();
            object holderName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine("enter your amount of money");
            long balance = long.Parse(Console.ReadLine());
            Console.WriteLine(balance);
            Console.WriteLine("Enter your bank institution");
            string bankName = Console.ReadLine();
            Console.WriteLine("Enter your IBAN");
            string iban = Console.ReadLine();
            long creditCard1 = 4003500260017000;
            long creditCard2 = 5004600370028001;
            long creditCard3 = 6004700380029001;

            Console.WriteLine("Welcome mr/mrs {0} \n Your amount of money is {1} in {2} \n Your IBAN is {3} \n your credit cards numbers are: \n {4} \n {5} \n {6}",holderName, balance, bankName, iban, creditCard1, creditCard2, creditCard3 );



        }
    }
}
