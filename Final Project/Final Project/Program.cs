using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            Passeger A1 = new Passeger("A1", 180);
            Passeger A2 = new Passeger("A2", 220);
            elevator1.AddOccupant(A1, 0);
            elevator1.AddOccupant(A2, 1);

            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();
            System.Console.WriteLine(elevator1IsOverMaxCapacity);

            Elevator elevator2 = new Elevator(3, 600);
            A1 = new Passeger ("A1", 200);
            A2 = new Passeger ("A2", 200);
            Passeger A3 = new Passeger("A3", 201); 
            elevator2.AddOccupant(A1, 0);
            elevator2.AddOccupant(A2, 1);
            elevator2.AddOccupant(A3, 2);

            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();
            System.Console.WriteLine(elevator2IsOverMaxCapacity);



            System.Console.ReadLine();
        }
    }
}
