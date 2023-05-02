using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Exercise_Day2
{
    public abstract class Shape_3D
    {
        double length, width, height;
        public Shape_3D(double length, double width , double height )
        {
            this.length = length;
            this.width = width;
            this.height = height;

        }
    }
}
