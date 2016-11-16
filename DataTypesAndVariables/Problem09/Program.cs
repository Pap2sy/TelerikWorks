using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09
{
    class Program
    {
//       Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            //Console.WriteLine("a = " +a);
            //Console.WriteLine("b ={0}",b);
            Console.WriteLine("a = {0}\nb = {1}",a,b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
        }
    }
}
