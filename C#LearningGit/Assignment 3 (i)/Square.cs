﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Exercise_Day2;

namespace Training_C_.Exercise_Day3
{
    public class Square : Shape_2D
    {
        public Square(double side ,double length, double width) : base(length, width)
        {
        }

        public void Area(double length)
        {
            double area = length * length;
            Console.WriteLine("Area of the given square with length as " + length + " is " + area);
        }

        public void Perimeter(double side1, double side2, double side3, double side4)
        {
            double perimeter = side1 + side2 + side3 + side4;
            Console.WriteLine("Perimeter of the given square with length as " + side1 + " is " + perimeter);
        }
    }
}
