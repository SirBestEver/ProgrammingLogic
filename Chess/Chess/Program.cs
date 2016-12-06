using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[8,8]     {

                {"X","X","X","X","X","X","X","X"},
                {"X","X","X","X","X","X","X","X"},
                {" "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "},
                {"X","X","X","X","X","X","X","X"},
                {"X","X","X","X","X","X","X","X"},

            };

            showBoard(board);

            System.Console.WriteLine("Enter Target X Coordubate Between 0 and 7 :");
            int a = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Enter Target y Coordubate Between 0 and 7 :");
            int b = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Enter Destinaton X Coordubate Between 0 and 7 :");
            int c = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Enter Destinaton X Coordubate Between 0 and 7 :");
            int d = int.Parse(System.Console.ReadLine());

            moving(board, a, b, c, d);
            
            showBoard(board);
            Console.Clear();

            while (true)
            {
                showBoard(board);

                System.Console.WriteLine("Enter Target X Coordubate Between 0 and 7 :");
                a = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Enter Target y Coordubate Between 0 and 7 :");
                b = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Enter Destinaton X Coordubate Between 0 and 7 :");
                c = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Enter Destinaton X Coordubate Between 0 and 7 :");
                d = int.Parse(System.Console.ReadLine());

                moving(board, a, b, c, d);
                
                showBoard(board);
                Console.Clear();
            }




        }
        public static void showBoard(string[,] board)
        {
            string horizontal = ("+---+---+---+---+---+---+---+---+");
          

            for(int i = 0; i<8; i++)
            {
                System.Console.WriteLine(horizontal);

                for(int j=0; j<8; j++)
                {
                    System.Console.Write("| " + board[i,j] + " ");
                   
                }
                System.Console.WriteLine("|");
             
            }
            System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
          
        }

        public static void moving(string[,] board, int a, int b, int c, int d)
        {
            board[c, d] = board[a, b];
            board[a, b] =" ";

            if (a > 7 || a < 0)
            {
                Environment.Exit(0);
            }

            if (b > 7 || b < 0)
            {
                Environment.Exit(0);
            }

            if (c > 7 || c < 0)
            {
                Environment.Exit(0);
            }

            if (d > 7 || d < 0)
            {
                Environment.Exit(0);
            }





        }


    }


}
