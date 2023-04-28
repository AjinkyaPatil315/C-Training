using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Exercise;
using Training_C_.Exercise_Day2;

namespace Training_C_
{
    public class RunMainClass
    {
        static void Main()
        {
            //Assignment 1 programs 
            Consonants consonants = new Consonants();
            Console.WriteLine("Assignment-1 : First Program \n ");
            consonants.findConsonants("Rrrrrajhhanssa".ToLower());//Input value should be from Console And Handle special character
            Fibonacci fibonacci = new Fibonacci();
            Console.WriteLine("Assignment-1 : Second Program \n ");
            fibonacci.findFibonacciSeries(3, 40);
            Pyramid pyramid = new Pyramid();
            Console.WriteLine("Assignment-1 : Third Program \n ");
            pyramid.PrintPyramid(28);
            ReverseInteger reverse = new ReverseInteger();
            Console.WriteLine("Assignment-1 : Fourth Program \n ");
            reverse.reverseInteger(123456);
            SquareRoot root = new SquareRoot();
            Console.WriteLine("Assignment-1 : Fifth Program \n ");
            root.findSquareRoot(7);
            root.findSquareRoot(50);
            root.findSquareRoot(21);
            

            //Assignment 2 programs
            AreaPerimeter formula = new AreaPerimeter();
            Console.WriteLine("Assignment-2 : First Program \n ");
            formula.AreaOfTriangle(11, 24); 
            formula.AreaOfSquare(10);
            formula.AreaOfRectangle(28, 12);
            
            formula.PerimeterOftriangle(23, 21, 39);
            formula.CircumferenceOfCircle(21);
            formula.PerimeterOfRectangle(49, 69);

            StudentExamMarks stu = new StudentExamMarks( 75, 56, 39, 80);
            Console.WriteLine("\n");
            Console.WriteLine("Assignment-2 : Second Program \n ");
            stu.Name = "Ajinkya Patil";
            stu.Address = "Pune";
            stu.GetTotalMarks();
            stu.GetAverageMarks();
            stu.GetPercentage();

        }
    }
}
