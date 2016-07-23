using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOperators2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            Console.WriteLine("Result:");
            Console.WriteLine("x value\t\ty value\t\tExpressions\tResult");
            Console.WriteLine("{0,-8}\t{1,-8}\tx+=y \t x={2,-8}", x, y, x+y);
            Console.WriteLine("{0,-8}\t{1,-8}\tx-=y-2 \t x={2,-8}", x, y, x-y+2);
            Console.WriteLine("{0,-8}\t{1,-8}\tx*=y*5 \t x={2,-8}", x, y, x*y*5);
            Console.WriteLine("{0,-8}\t{1,-8}\tx/=x/y \t x={2,-8}", x, y, (float)x/(x / y));
            Console.WriteLine("{0,-8}\t{1,-8}\tx%=y \t x={2,-8}", x, y, x%y);

            Console.ReadLine();
        }
    }
}
