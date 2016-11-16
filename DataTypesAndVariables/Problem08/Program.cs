using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    class Program
    {
//        Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©Isosceles Triangle
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            char copyright = '\u00A9';
            
            Console.WriteLine("   {0}",copyright);
            Console.WriteLine("  {0} {0}",copyright);
            Console.WriteLine(" {0}   {0}",copyright);
            Console.WriteLine("{0} {0} {0} {0}",copyright);
            //second variant
            Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", copyright);
        }
    }
}
