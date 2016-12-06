using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Night_at_the_Movies
{
    class Program
    {
        static void Main(string[] args)
        {

           double peoplePrice = 0;
           double foodPrice =0;
           double totalPrice =0;
           int totalPeople =0;
           double child =0, adult = 0, senior =0;
           double discountedprice =0;
           int numberofkids = 0;
           int numberofadults =0;
           int numberofseniors =0;
           
            
           string time;
           string concessions;
           string price;

           System.Console.WriteLine("What time is it? (Matinee/Eveing)");
           time = System.Console.ReadLine();
           Boolean Matinee = time.Equals("Matinee");
           Boolean Evening = time.Equals("Evening");
           if (Matinee)
           {
                child = 3.99;
                adult = 5.99;
                senior = 4.50;
                
           }
           else if (Evening)
           {
               child = 6.99;
               adult = 10.99;
               senior = 8.50;
           }
           else
           {
                System.Console.WriteLine("Pick one of the two!");

           }


           System.Console.WriteLine("How many children are coming?");
           numberofkids = int.Parse(System.Console.ReadLine());
           
           System.Console.WriteLine("How many adults are coming?");
           numberofadults = int.Parse(System.Console.ReadLine());

           System.Console.WriteLine("How many seniors are coming?");
           numberofseniors = int.Parse(System.Console.ReadLine());

           peoplePrice += (numberofkids * child);
           peoplePrice += (numberofadults * adult);
           peoplePrice += (numberofseniors * senior);

           if (numberofkids + numberofadults + numberofseniors >= 3)
           {
               System.Console.WriteLine("You get a free bag of popcorn :) \n");
           } 


           System.Console.WriteLine("Will you be buying anything from the concession stand?");
           concessions = System.Console.ReadLine();
           Boolean Yes = concessions.Equals("Yes");
           Boolean No = concessions.Equals("No");
        
           if (Yes)
           {
               System.Console.WriteLine("How many Small Sodas would you like? They cost $3.50");
               int smallSoda = int.Parse(System.Console.ReadLine());
            
               System.Console.WriteLine("How many Large Sodas would you like? They cost $5.99");
               int largeSoda = int.Parse(System.Console.ReadLine());
            
               System.Console.WriteLine("How many Hot Dogs would you like? They cost $3.99");
               int hotDogs = int.Parse(System.Console.ReadLine());
            
               System.Console.WriteLine("How much Popcorn would you like? They cost $4.50");
               int popcorn = int.Parse(System.Console.ReadLine());
            
               System.Console.WriteLine("How many Candy would you like? They cost $1.99");
               int candy = int.Parse(System.Console.ReadLine());
           
               foodPrice  = (smallSoda * 3.50) + (largeSoda * 5.99) + (hotDogs * 3.99) * (popcorn * 4.50) + (candy * 1.99);
            
               if (popcorn >= 1 && largeSoda >= 1) 
               {
                   foodPrice -= 2;
                
               }
            
               if (candy % 3 == 0)
               {
                   System.Console.WriteLine("You get " + candy / 3 + " free bag(s) of candy :)");
               }
            
           }
        
           else if (No) 
           {
               System.Console.WriteLine("Yeah the prices are a little outrageous.");
            
           }

            totalPrice = discountedprice + totalPrice + peoplePrice;
            System.Console.WriteLine("Your total price is $" + totalPrice + ".");

   

            System.Console.ReadLine();
        }
    }
}
            