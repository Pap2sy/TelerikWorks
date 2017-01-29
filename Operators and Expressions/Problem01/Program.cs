using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
//    Odd or Even Integers

//Write an expression that checks if given integer is odd or even.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a nuber");
            int number = int.Parse(Console.ReadLine());
            bool checker;
            if (number % 2 == 0) // checks if is even
            {
                checker = true;
                Console.WriteLine(checker + " The number is even");
            }
            else
            {
                checker = false;
                Console.WriteLine(checker + " The number is Odd");
            }
        }
    }
}
