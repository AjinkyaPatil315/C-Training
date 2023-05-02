using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Exercise_Day2
{
    public abstract class Shape_2D
    {
        double length, width;
        public Shape_2D(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
    }
}
