using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
//     Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b 
//    because of the nature of the floating-point arithmetic. Therefore, 
//    we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter \"a\"");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter \"b\"");
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool equal;
            if (Math.Abs(a - b) <= eps)
            {
                equal = true;
            }
            else
            {
                equal = false;
            }
            Console.WriteLine(equal.ToString().ToLower()); //that makes the output from 'F'alse to 'f'alse
        }
    }
}
