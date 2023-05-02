﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Exercise_Day2;

namespace Training_C_.Exercise_Day3
{
    public class Cuboid : Shape_3D
    {
        double length, width, height;
        public Cuboid (double length, double width, double height) : base(length, width, height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public void Area()
        {
            double area = (2 * (length * width)) + (2 * (length * height)) + (2 * (width * height));
            Console.WriteLine("Area of the given Cuboid with length as " + length + " and height as " + height + " and width as " + width + " is " + area);
        }
    }
}
