using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Exercise_Day2
{
    public class AreaPerimeter
    {
       public void AreaOfTriangle(double baseLength, double height )
        {
           double area = 0.5 * baseLength * height;
           Console.WriteLine("Area of the given triangle with length as " + baseLength + " and height as " + height + " is " + area);
        }

        public void AreaOfSquare(double length) 
        {
            double area =  length * length;
            Console.WriteLine("Area of the given square with length as " + length + " is " + area);
        }

        public void AreaOfRectangle(double length, double width) {
        
            double area = length * width;
            Console.WriteLine("Area of the given rectangle with length as " + length + " and width as "+ width + " is " + area);
        }

        public void PerimeterOftriangle(double side1 , double side2 , double baselength) { 
        
            double perimeter =  side1 + side2 + baselength;
            Console.WriteLine("Perimeter of a Triangle is " + perimeter);
        }
    
        public void CircumferenceOfCircle(double radius)
        {
            double pie = 3.14159;
            double circumference = 2 * pie * radius;
            Console.WriteLine("Circumference of a Circle is " + circumference);
        }
        public void PerimeterOfRectangle(double length , double width) {
            double perimeter = 2 * (length + width );
            Console.WriteLine("Perimeter of a Rectangle is " + perimeter);
        }
    }
}
