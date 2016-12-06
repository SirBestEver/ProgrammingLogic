using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public Boolean HasSpouse = false;

        public void CreateSpouse()
        {
            System.Console.Write("Do you have a spouse? (y/n) ");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                Spouse = new Person();
                System.Console.Write("Please Enter His/Her Name. ");
                Spouse.FirstName = System.Console.ReadLine();
                System.Console.Write("Enter His/Her's Age. ");
                Spouse.Age = int.Parse(Console.ReadLine());
                Spouse.LastName = LastName;
                HasSpouse = true;
            }

        }



        public static double SumOfAllAges;

        public string GetFullName()
        {

            string FullName = FirstName + " " + LastName;
            return FullName;
           
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(LastName + "," + " " + FirstName + " " + "(" + Age + ")");

        }


    }
}
