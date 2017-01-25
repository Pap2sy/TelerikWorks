using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
//    A marketing company wants to keep record of its employees. Each record would have the following
//    characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//    Use descriptive names. Print the data at the console.
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Hristo";
            string lastName = "Karakov";
            byte age = 32;
            char sex = 'M';
            long iDNumber = 8411064428;
            uint uniqueNum = 27561111;
            Console.WriteLine("First Name = {0} \n Last name = {1} \n Age = {2} \n Gender is {3} \n Your ID = {4} \n Unique number is {5}",firstName,lastName,age,sex,iDNumber,uniqueNum);

        }
    }
}
