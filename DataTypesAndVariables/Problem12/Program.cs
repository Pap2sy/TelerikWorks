using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
//    Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
    class Program
    {
        static void Main(string[] args)
        {
            int? nullInt = null;
            double? nullDouble = null;
            Console.WriteLine("Null int = {0} , null double  = {1}",nullInt , nullDouble);
            nullInt = 5;
            nullDouble = 8;
            Console.WriteLine("NullInt = {0}  , nullDouble = {1}",nullInt , nullDouble);

        }
    }
}
