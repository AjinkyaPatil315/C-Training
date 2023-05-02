using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LearningGit.Assignment_3
{
    using System;

    public class Maths
    {
        public void Sum(long num1, long num2)
        {
            long Sum = num1 + num2;
            Console.WriteLine("Sum of the given numbers is " + Sum);
        }

        public void Sum(double num1, double num2)
        {
            double Sum = num1 + num2;
            Console.WriteLine("Sum of the given numbers is " + Sum);
        }

        public void Sum(params long[] nums)
        {
            long sum = 0;
            foreach (long num in nums)
            {
                sum += num;
            }
            Console.WriteLine("Sum of the given numbers is " + sum);
        }

        public void Sum(params double[] nums)
        {
            double sum = 0;
            foreach (double num in nums)
            {
                sum += num;
            }
            Console.WriteLine("Sum of the given numbers is " + sum);
        }

        public void Product(long num1, long num2)
        {
            long Product = num1 * num2;
            Console.WriteLine("Product of the given numbers is " + Product);
        }

        public void Product(double num1, double num2)
        {
            double Product = num1 * num2;
            Console.WriteLine("Product of the given numbers is " + Product);
        }

        public void Product(params long[] nums)
        {
            long product = 1;
            foreach (long num in nums)
            {
                product *= num;
            }
            Console.WriteLine("Product of the given numbers is " + product);
        }

        public void Product(params double[] nums)
        {
            double product = 1;
            foreach (double num in nums)
            {
                product *= num;
            }
            Console.WriteLine("Product of the given numbers is " + product);
        }

        public void Difference(long num1, long num2)
        {
            long Difference = num1 - num2;
            Console.WriteLine("Difference of the given number is " + Difference);
        }

        public void Difference(double num1, double num2, long num3)
        {
            double Difference = num1 - num2 - num3;
            Console.WriteLine("Difference of the given number is " + Difference);
        }

        public void Division(long num1, long num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                long Division = num1 / num2;
                Console.WriteLine("Division of the given number is " + Division);
            }
        }

        public void Division(double num1, double num2, double num3)
        {
            if (num3 == 0 || num2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                double Division = (num1 / num2) / num3;
                Console.WriteLine("Division of the given number is " + Division);
            }
        }

        public void Modulus(long num1, long num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                long Modulus = num1 % num2;
                Console.WriteLine("Modulus of the given number is " + Modulus);
            }
        }

        public void Modulus(double num1, double num2, double num3)
        {
            if (num3 == 0 || num2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                double Modulus = (num1 % num2) % num3;
                Console.WriteLine("Modulus of the given number is " + Modulus);
            }
        }

        //public void SumProduct(long num1, long num2, out long product)
        //{
        //    long Sum = num1 + num2;
        //    product = num1 * num2;
        //    Console.WriteLine("Sum of the given number is " = + Sum + " and Product of the given number = " + product);
        //}

        //public void SumProduct(long num1, long num2)
        //{
        //    long product;
        //    SumProduct(num1, num2, out product);
        //    return Sum(num1, num2);
        //}
    }

}
