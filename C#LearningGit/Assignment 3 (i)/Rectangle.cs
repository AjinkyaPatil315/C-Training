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
        private int side1, side2;

        public Rectangle(double length, double width) : base(length, width)
        {
            this.length = length;
            this.width = width;
        }

        public void Area()
        {
            double area = length * width;
            Console.WriteLine("Area of the given Rectangle with length as " + length + " and width as" + width + " is " + area);
        }

        public void Perimeter()
        {
            double perimeter = 2 * length + 2 * width;
            Console.WriteLine("Perimeter of the given Rectangle with length as " + length + " and width as " + width + " is " + perimeter);
        }
    }
}
