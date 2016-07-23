using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 }; //data set
            int pos, target;
            Console.Write("Enter value to find:");
            target = int.Parse(Console.ReadLine());
            pos = seqsearch(arr, target, 10);
            if (pos != -1)
                Console.WriteLine("The target item was found at location:{0}", pos);
            else
                Console.WriteLine("The target item was not found in the list.\n");
            Console.ReadLine();

        }
        ///sequential search
        static int seqsearch(int[] dataset, int target, int n)
        {
            int found = 0;
            int i;
            int pos = -1;
            for (i = 0; i < n && found != 1; i++)
                if (target == dataset[i]) { pos = i; found = 1; }

            return pos;
        }
    }
}
