using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);
            Console.ReadLine();
        }
    }
}
