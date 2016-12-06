using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
           
             

            System.Console.Write("Enter Information for p1.\n ");
            System.Console.WriteLine();
            System.Console.Write("Please Enter Your First Name. " );
            p1.FirstName =  System.Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("Enter Your Last Name. ");
            p1.LastName  = System.Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("Enter Your Age. ");
            p1.Age = int.Parse( Console.ReadLine());
            System.Console.WriteLine();
            p1.CreateSpouse();
            

        

           

            // end of p1 code
            System.Console.WriteLine();
            Person p2 = new Person();
            
           
            System.Console.WriteLine();
            System.Console.Write("Enter Information for p2.\n ");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("Please Enter Your First Name. ");
            p2.FirstName = System.Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("Enter Your Last Name. ");
            p2.LastName = System.Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("Enter Your Age. ");
            p2.Age = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            p2.CreateSpouse();

            System.Console.WriteLine();
           
            System.Console.WriteLine();

            // end of p2 code

            System.Console.WriteLine();

            p1.PrintNameAndAge();
            System.Console.WriteLine();
            if (p1.HasSpouse)
            {
                p1.Spouse.PrintNameAndAge();
            }
            System.Console.WriteLine();
            p2.PrintNameAndAge();
            System.Console.WriteLine();
            if (p2.HasSpouse)
            {
                p2.Spouse.PrintNameAndAge();
            }
            System.Console.WriteLine();

            Person.SumOfAllAges = p1.Age + p2.Age;
            if (p1.HasSpouse)
            {
                Person.SumOfAllAges += p1.Spouse.Age;
            }
            if (p2.HasSpouse)
            {
                Person.SumOfAllAges += p2.Spouse.Age;
            }
            System.Console.WriteLine("Average Age" + " " + Person.SumOfAllAges/4.0);
            System.Console.WriteLine();





            System.Console.ReadLine();

        }
    }
}
