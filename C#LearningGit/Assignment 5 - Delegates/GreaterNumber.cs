using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Exercise_Day5
{
    public class GreaterNumber
    {
        public void IsGreaterThan<T>(T first, T second) where T : IComparable
        {
           bool check =  first.CompareTo(second) > 0;

            if (check)
            {
                Console.WriteLine($"{first} is greater than {second}");
            }
            else
            {
                Console.WriteLine($"{first} is not greater than {second}");
            }
        }
    }
}
