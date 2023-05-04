using C_LearningGit.Assignment_3;
using C_LearningGit.Assignment_4;
using C_LearningGit.Assignment_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Exercise;
using Training_C_.Exercise_Day2;
using Training_C_.Exercise_Day3;
using Training_C_.Exercise_Day4;

namespace Training_C_
{
    public class RunMainClass
    {
        static void Main()
        {
            ////Assignment 1 programs 
            //Consonants consonants = new Consonants();
            //Console.WriteLine("Assignment-1 : First Program \n ");
            //consonants.findConsonants("Rrrrrajhhanssa".ToLower());//Input value should be from Console And Handle special character
            //Fibonacci fibonacci = new Fibonacci();
            //Console.WriteLine("Assignment-1 : Second Program \n ");
            //fibonacci.findFibonacciSeries(3, 40);
            //Pyramid pyramid = new Pyramid();
            //Console.WriteLine("Assignment-1 : Third Program \n ");
            //pyramid.PrintPyramid(28);
            //ReverseInteger reverse = new ReverseInteger();
            //Console.WriteLine("Assignment-1 : Fourth Program \n ");
            //reverse.reverseInteger(123456);
            //SquareRoot root = new SquareRoot();
            //Console.WriteLine("Assignment-1 : Fifth Program \n ");
            //root.findSquareRoot(7);
            //root.findSquareRoot(50);
            //root.findSquareRoot(21);


            ////Assignment 2 programs
            //AreaPerimeter formula = new AreaPerimeter();
            //Console.WriteLine("Assignment-2 : First Program \n ");
            //formula.AreaOfTriangle(11, 24);
            //formula.AreaOfSquare(10);
            //formula.AreaOfRectangle(28, 12);

            //formula.PerimeterOftriangle(23, 21, 39);
            //formula.CircumferenceOfCircle(21);
            //formula.PerimeterOfRectangle(49, 69);

            //StudentExamMarks stu = new StudentExamMarks(75, 56, 39, 80);
            //Console.WriteLine("\n");
            //Console.WriteLine("Assignment-2 : Second Program \n ");
            //stu.Name = "Ajinkya Patil";
            //stu.Address = "Pune";
            //stu.GetTotalMarks();
            //stu.GetAverageMarks();
            //stu.GetPercentage();

            ////Assignment 3 program
            //Console.WriteLine("\n");
            //Console.WriteLine("Assignment-3 : First Program \n ");
            //Square square = new Square(15, 15, 15);
            //square.Area(16);
            //square.Perimeter(10, 10, 10, 10);
            //Rectangle rect = new Rectangle(30, 40);
            //rect.Area();
            //rect.Perimeter();
            //Cuboid cuboid = new Cuboid(7, 7, 10);
            //cuboid.Area();
            //Cube cube = new Cube(3.5, 3.5, 1);
            //cube.Area();



            //Console.WriteLine("\n");
            //Console.WriteLine("Assignment-3 : Second Program \n ");
            //Maths math = new Maths();
            //math.Sum((long)18, (long)17);
            //math.Sum(250, 201, 159);
            ////double output = maths.SumProduct(20, 35);
            ////Console.WriteLine("Sum Product returns sum of the values = " + output);
            //math.Difference(105, 1515);
            //math.Difference(20.25, 30.35, 25);
            //math.Division(1000, 25);
            //math.Division(1000, 0);
            //math.Division(10, 10, 2);
            //math.Division(10, 10, 0);
            //math.Product(25, 25);
            //math.Product(10, 10, 5);
            //math.Modulus(1258, 100);
            //math.Modulus(12588, 1256, 0);


            //Assignment 4 program
            //Console.WriteLine("\n");
            //Console.WriteLine("Assignment-4 : First Program \n ");
            //new ReadExcel().ReadExcelData();

            //Console.WriteLine("\n");
            //Console.WriteLine("Assignment-4 : Second Program \n ");
            //new UpdateExcelData().UpdateExcelDataAssign();

            //Console.WriteLine("\n");
            //Console.WriteLine("Assignment-4 : Third Program \n ");
            //new ReadSQlData().ReadSQlDataAssign();

            //Console.WriteLine("\n");
            //Console.WriteLine("Assignment-4 : Fourth Program \n ");
            //new UpdateSQLData().UpdateSQLData1();

            //Assignment 5 program
            //Console.WriteLine("\n");
            //Console.WriteLine("Assignment-5 : First and Second Program \n ");
            //new CreateAndStore().CreateAndStoreExcelData();

            //Console.WriteLine("\n");
            //Console.WriteLine("Assignment-5 : Third Program \n ");
            //new PrintRelEmpDet().PrintRelEmpDetAssign();

            //Console.WriteLine("\n");
            //Console.WriteLine("Assignment-5 : Fourth Program \n ");
            //new ReadAndStore().ReadAndStoreAssign();

            Console.WriteLine("\n");
            Console.WriteLine("Assignment-5 : Fifth Program \n ");
            new ClearDB().ClearDBData();
        }
    }
}
