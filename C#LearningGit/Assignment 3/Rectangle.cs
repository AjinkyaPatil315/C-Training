using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Exercise_Day2;

namespace Training_C_.Exercise_Day3
{
    public class Rectangle : Shape_2D
    {
        double length, width;
        public Rectangle(double length, double width) : base(length, width)
        {
            this.length = length;
            this.width = width;
        }

        public void Area()
        {
            double area = length * length;
            Console.WriteLine("Area of the given square with length as " + length + " is " + area);
        }

        public void Perimeter()
        {
            double perimeter = length + width;
            Console.WriteLine("Perimeter of a Triangle is " + perimeter);
        }
    }
}
