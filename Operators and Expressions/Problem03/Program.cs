using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
//    Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time
    class Program
    {
        static void Main()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            bool checker = false;
            if (number % 5 == 0 && number % 7 == 0)
            {
                checker = true;
            }
            else
            {
                checker = false;
            }
            Console.WriteLine((checker).ToString().ToLower());

            
               
        }
    }
}
