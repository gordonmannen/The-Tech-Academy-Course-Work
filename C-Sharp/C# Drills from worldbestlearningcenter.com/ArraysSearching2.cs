using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSearching2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 }; //unsorted data set
            int pos, target;
            Console.Write("Enter value to find:");
            target = int.Parse(Console.ReadLine());
            pos = binsearch(arr, 23, 10);
            if (pos != -1)
                Console.WriteLine("The target item was found at location:{0}", pos);
            else
                Console.WriteLine("The target item was not found in the list.\n");
            Console.ReadLine();

        }

        ///binary search
        static int binsearch(int[] dataset, int target, int l, int u)
        {
            insertsort(dataset, dataset.Length);//make sure the list sorted
            while (u >= l)
            {

                int mid = (l + u) / 2;

                if (target == dataset[mid]) return mid;

                else if (target > dataset[mid]) l = mid + 1;

                else if (target < dataset[mid]) u = mid - 1;

            }
            return -1;
        }


        static void insertsort(int[] dataset, int n)
        {

            int i, j;
            for (i = 1; i < n; i++)
            {
                int pick_item = dataset[i];
                int inserted = 0;
                for (j = i - 1; j >= 0 && inserted != 1;)
                {
                    if (pick_item < dataset[j])
                    {
                        dataset[j + 1] = dataset[j];
                        j--;
                        dataset[j + 1] = pick_item;
                    }
                    else inserted = 1;
                }
            }

        }
    }
}

// this one won't work - u parameter and binsearch are causing an issue.
