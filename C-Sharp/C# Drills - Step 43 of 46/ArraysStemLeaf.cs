using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStemLeaf
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter number of data points:");
            n = int.Parse(Console.ReadLine());
            if (n < 3)
            {
                Console.WriteLine("The number of data points should be greater than 2.");

            }
            else
            {

                //declare an array of n size to store integral data points
                int[] dataset = new int[n];
                //allow user inputs
                int i = 0;
                for (i = 0; i < n; i++)
                {
                    Console.Write("[{0}]:", i);
                    dataset[i] = int.Parse(Console.ReadLine());
                }

                //sort the data set
                bubblesort(dataset, n);
                //show data in stem and leaf display
                //Display sorted array
                Console.WriteLine("The sorted array is:");
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}\t", dataset[i]);
                    if (i % 5 == 0 && i != 0) Console.Write("\n");
                }

                //store stem and leaf in a 2D array
                int[,] stem_leaf = new int[n, 2];
                for (i = 0; i < n; i++)
                {
                    stem_leaf[i, 0] = dataset[i] / 10;
                    stem_leaf[i, 1] = dataset[i] % 10;
                }

                //initialize 2D array storing numbers of occurences, and values
                int[,] mode = new int[n, 2];

                for (i = 0; i < n; i++)
                    for (int j = 0; j < 2; j++) mode[i, j] = 0;

                mode[0, 0] = 1;
                //find mode

                int count = 1;
                for (i = count - 1; i < n; i++)
                {
                    for (int j = count - 1; j < n - 1; j++)
                    {
                        if (stem_leaf[i, 0] == stem_leaf[j + 1, 0]) { count++; mode[i, 0]++; mode[i, 1] = stem_leaf[i, 0]; }
                        else if (i == 0) mode[i, 1] = stem_leaf[i, 0];
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Stem and Leaf Display:");
                Console.WriteLine("Frequency\tStem\tLeaf");
                Console.WriteLine("================================");
                int c = 0, leaf = 0;
                for (i = 0; i < n; i++)
                {
                    if (mode[i, 1] != 0)
                    {
                        leaf += mode[i, 0];

                        Console.Write("{0,-18}", mode[i, 0]);
                        Console.Write("{0,-6}", mode[i, 1]);
                        for (int j = c; j < leaf; j++)
                        {
                            Console.Write("{0}", stem_leaf[j, 1]);
                        }

                        c = leaf;
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadLine();
        }

        static void bubblesort(int[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = n - 1; j > i; j--)
                    if (dataset[j] < dataset[j - 1])
                    {
                        int temp = dataset[j];
                        dataset[j] = dataset[j - 1];
                        dataset[j - 1] = temp;
                    }

        }

    }
}