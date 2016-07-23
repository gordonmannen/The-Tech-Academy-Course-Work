using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.Write("Enter value 1:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter value 2:");
            y = int.Parse(Console.ReadLine());
            Console.Write("Enter value 3:");
            z = int.Parse(Console.ReadLine());

            if (x > y)
                if (x > z) Console.Write("The greatest value is:{0}.", x);
                else Console.Write("The greatest value is:{0}.", z);
            else if (y > z) Console.Write("The greatest value is:{0}.", y);
                else Console.Write("The greatest value is:{0}.",z);

            Console.ReadLine();
        }
    }
}
