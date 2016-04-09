using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class Program
    {
//        Problem 6. Strings and Objects

//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables 
//    (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable
//    (you should perform type casting)
        static void Main(string[] args)
        {
            string message1 = "Hello";
            string message2 = " World";

            object sumMsg = message1 + message2;
            Console.WriteLine(sumMsg);
            string msg3 = (string)sumMsg;
            Console.WriteLine(msg3);
        }
    }
}
