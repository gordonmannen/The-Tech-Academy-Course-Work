using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string con = "y";
            Console.WriteLine("What is the command keyword to exit a loop in C#?");
            Console.WriteLine("a.quit");
            Console.WriteLine("b.continue");
            Console.WriteLine("c.break");
            Console.WriteLine("d.exit");


            while (con == "y")
            {
                Console.Write("Enter your choice:");
                choice = Console.ReadLine();

                if (choice == "c")
                {
                    Console.WriteLine("Congratulation!");
                }
                else if (choice == "q" || choice == "e") { Console.WriteLine("Exiting...!"); break; }
                else Console.WriteLine("Incorrect!");

                Console.Write("Again? press y to continue:");
                con = Console.ReadLine().ToString();

            }
        }
    }
}
