using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
//    Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight on Earth" );
            double eartWeight = double.Parse(Console.ReadLine());
            double moonWeight = eartWeight * 0.17;
            Console.WriteLine( "Your weight on moon will be {0}",moonWeight);

        }
    }
}
