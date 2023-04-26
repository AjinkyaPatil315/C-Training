using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Exercise_Day2
{
    public class StudentExamMarks
    {
        private string name ;
        private string address = "";
        private double math, physics, chemistry, biology;
        private double totalNumberOfSubjects = 4;
        public StudentExamMarks(double math, double physics, double chemistry, double biology)
        {
            this.math = math;
            this.physics = physics;
            this.chemistry = chemistry;
            this.biology = biology;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value;}
        }

       public double GetTotalMarks()
        {
           double total = math + physics + chemistry + biology;
           Console.WriteLine("Total marks secured by "+ name + " is " + total );
            return total;
        }

        public void GetAverageMarks() 
        { 
            double averageMark = ( math + physics + chemistry + biology ) / totalNumberOfSubjects;
            Console.WriteLine("Average mark of the student : " + name + " is " + averageMark);
        }

        public void GetPercentage() {

            double totalSubjectMark = totalNumberOfSubjects * 100;
            double percentage = ( GetTotalMarks()/totalSubjectMark ) * 100;
            Console.WriteLine("Percentage gained by " + name + " is " + percentage + " %");
        }
    }
}
