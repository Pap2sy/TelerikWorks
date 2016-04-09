using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
//        Problem 5. Boolean Variable

//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.
        static void Main(string[] args)
        {
            string firstName = "Pesho";
            string lastName = "Ivanov";
            string gender = "Male";
            bool isFemale;

            if (gender == "Male")
            {
                isFemale = false;

            }
            else
            {
                isFemale = true;
            }
            Console.WriteLine("isFemale = " + isFemale);
        }
    }
}
