using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
//        Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of type double:
//        34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.
        static void Main(string[] args)
        {
            float fl1 = 12.345f;
            float fl2 = 3456.091f;
            double dl1 = 34.567839023;
            double dl2 = 8923.1234857;
            Console.WriteLine(" {0} , {1} ,  {2} , {3}", fl1,fl2, dl1, dl2);
        }
    }
}
