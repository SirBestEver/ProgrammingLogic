using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Student
    {
        private string name;

        private Instructor teacher;
        private int grade =0;

        public Student()
        {
            name = "Unkown";
            teacher = new Instructor();
             
        }

        public Student( string x, Instructor z)
        {
            name = x;
            teacher = z;
            grade = 0;

        }

        public void SetGrade(int r)
        {
            grade = r;
            System.Console.WriteLine("Grade set to!" + " " + r);
        }

        public void ShowInfo()
        {
            System.Console.WriteLine(name + " " + grade);
            teacher.ShowInfo();
        }
       
        
    }
}
