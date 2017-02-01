using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    //    Rectangles

    //Write an expression that calculates rectangle’s perimeter and area by given width and height.
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter width");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("enter height");
            double height = double.Parse(Console.ReadLine());
            double perimeter = (width * 2) + (height * 2);
            double area = width * height;
            Console.WriteLine("perimeter is:" +perimeter);
            Console.WriteLine("area is :" + area);


        }
    }
}
