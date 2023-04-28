using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Exercise_Day2
{
    public abstract class Shape_3D
    {

        public Shape_3D(double length, double width , double height )
        {

        }
        public void Area(double length)
        {
            double area = length * length;
            Console.WriteLine("Area of the given square with length as " + length + " is " + area);
        }

        public void Perimeter(double side1, double side2, double baselength)
        {
            double perimeter = side1 + side2 + baselength;
            Console.WriteLine("Perimeter of a Triangle is " + perimeter);
        }
    }
}
