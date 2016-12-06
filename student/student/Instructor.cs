using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Instructor
    {
        //private string Name;
        private string name;
        private string CourseName;
        
        public Instructor()
        {
            name = "";
            CourseName = "Study Hall";
        }

        public Instructor( string a, string s)
        {

            name = a;
            CourseName = s;

        }       

        public void ShowInfo()
        {
            System.Console.WriteLine( name + " " + CourseName );
        }

        public void SetStudentGrade(Student x, int y)
        {
            x.SetGrade(y);
           

        }



    }

}

