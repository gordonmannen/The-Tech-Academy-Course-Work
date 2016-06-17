using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ranguess();

            Console.ReadLine();

        }

        public static void ranguess()
        {
            int yn, rn;
            Random rd = new Random(); //create random object

            Console.Write("Enter your guess number:");
            yn = int.Parse(Console.ReadLine());
            rn = rd.Next(1, 7);//generate random number from 1 t 6
            Console.WriteLine(rn);
            if (yn == rn)
            {
                Console.WriteLine("You won.");

            }
            else
            {
                Console.WriteLine("You lost.");
                Console.WriteLine("My number is {0}.", rn);

            }
        }
    }
}
