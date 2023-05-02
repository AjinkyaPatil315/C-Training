using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Exercise_Day2;

namespace Training_C_.Exercise_Day3
{
    public class Cube : Shape_3D
    {
        double length, width, height;
        public Cube(double length, double width, double height) : base(length, width, height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public void Area()
        {
            double area = 2 * (length * length);
            Console.WriteLine("Area of the given Cube with length as " + length + " is " + area);
        }
    }
}
