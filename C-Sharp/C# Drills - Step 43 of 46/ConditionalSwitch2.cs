using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalSwitch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the correct way to declare a variable to store an integer value in C#?");
            Console.WriteLine("a. int 1x=10");
            Console.WriteLine("b. int x=10");
            Console.WriteLine("c. float x=10.0f");
            Console.WriteLine("d. string x=\"10\"");
            Console.WriteLine("Choose the answer letter:");
            char ans = (char)Console.Read();
            switch (ans)
            {
                case 'a': Console.WriteLine("Invalid choice!"); break;
                case 'b': Console.WriteLine("Congratulation!"); break;
                case 'c': Console.WriteLine("Invalid choice!"); break;
                case 'd': Console.WriteLine("Invalid choice!"); break;
                default: Console.WriteLine("Bad choice!"); break;


            }
        }
    }
}
