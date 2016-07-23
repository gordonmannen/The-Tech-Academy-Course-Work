using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOperators3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Enter a value:");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("The value of a is {0}.", a);

            b = ++a;

            Console.WriteLine("The value of ++a is {0}.", b);
            Console.WriteLine("The value of a is {0}.", a);
            b = a++;

            Console.WriteLine("The value of a++ is {0}.", b);
            Console.WriteLine("The value of a is {0}.", a);

            b = --a;

            Console.WriteLine("The value of --a is {0}.", b);
            Console.WriteLine("The value of a is {0}.", a);


            b = a--;

            Console.WriteLine("The value of a-- is {0}.", b);
            Console.WriteLine("The value of a is {0}.", a);


            Console.ReadLine();
        }
    }
}
