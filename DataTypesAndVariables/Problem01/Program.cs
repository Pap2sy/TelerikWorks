using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        //        Problem 1. Declare Variables

        //Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short,
        //ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
        //Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
        static void Main(string[] args)
        {
            ushort us = 52130;
            sbyte sb = -115;
            int i = 4825932;
            byte b = 97;
            short sh = -10000;
            Console.WriteLine("ushort {0} , sbyte {1} , int {2} , byte {3} , short {4} ", us, sb, i, b, sh);
        }
    }
}
