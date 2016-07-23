using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            char key;
            Console.Write("Press a number key:");
            key = (char)Console.Read();
            switch (key)
            {
                case '0': Console.WriteLine("You pressed 0"); break;
                case '1': Console.WriteLine("You pressed 1"); break;
                case '2': Console.WriteLine("You pressed 2"); break;
                case '3': Console.WriteLine("You pressed 3"); break;
                case '4': Console.WriteLine("You pressed 4"); break;
                case '5': Console.WriteLine("You pressed 5"); break;
                case '6': Console.WriteLine("You pressed 6"); break;
                case '7': Console.WriteLine("You pressed 7"); break;
                case '8': Console.WriteLine("You pressed 8"); break;
                case '9': Console.WriteLine("You pressed 9"); break;
                default: Console.WriteLine("Not allowed!"); break;

            }
        }
    }
}
