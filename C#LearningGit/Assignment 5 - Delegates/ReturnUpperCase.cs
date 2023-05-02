using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Exercise_Day5
{
    public class ReturnUpperCase
    {
        public string ConvertToUpperCase(string input)
        {
            // return new string(input.Where(char.IsUpper).ToArray());
            return new string(input.Where(c => char.IsUpper(c)).ToArray());
        }
    }
}
