
namespace student
{
    class Program
    {
        static void Main(string[] args)
        {

            Instructor t1 = new Instructor("John","English");
            
            Instructor t2 = new Instructor("Mike", "Math");
           
            Student s1 = new Student("Jane", t1);
           
            Student s2 = new Student("Joe", t1);

            Student s3 = new Student("Melissa", t2);

            Student s4 = new Student("Melissa", t2);

            t1.SetStudentGrade(s1, 95);
            t1.SetStudentGrade(s2, 85);
            t2.SetStudentGrade(s3, 90);
            t2.SetStudentGrade(s4, 92);

            s1.ShowInfo();
            s2.ShowInfo();
            s3.ShowInfo();
            s4.ShowInfo();







            System.Console.ReadLine();

        }
    }
}
