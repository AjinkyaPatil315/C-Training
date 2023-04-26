using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Exercise
{
    public class Pyramid
    {
        public void PrintPyramid(int maxBase)
        {
           
            for (int i = 1; i <= maxBase; i++)
            {
                for (int j = 1; j <= maxBase - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
        }
    }
}
