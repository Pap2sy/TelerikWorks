using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
//    Quotes in Strings

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.
    class Program
    {
        static void Main(string[] args)
        {
            string message1 = "The \"use\" of quotations causes difficulties.";
            string message3 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(message1);
            Console.WriteLine(message3);
        }
    }
}
