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
            consonants.findConsonants("Rrrrrajhhanssa".ToLower());
            Fibonacci fibonacci = new Fibonacci();
            Console.WriteLine("Assignment-1 : Second Program \n ");
            fibonacci.findFibonacciSeries(5, 30);
            Pyramid pyramid = new Pyramid();
            Console.WriteLine("Assignment-1 : Third Program \n ");
            pyramid.PrintPyramid(35);
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
            formula.AreaOfSquare(10);
            formula.AreaOfRectangle(25.658, 10);
            formula.AreaOfTriangle(13.5, 25);
            formula.PerimeterOftriangle(26, 26, 30);
            formula.CircumferenceOfCircle(26);
            formula.PerimeterOfRectangle(56, 96);
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
