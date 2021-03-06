﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStatisticalInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float mean, median, std;
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


                //calculate the mean
                int sum = 0;
                int j = 0;
                while (j < n)
                {
                    sum = sum + dataset[j];
                    j++;
                }

                mean = (float)sum / n;

                //calculate median
                //If n is odd, median=dataset[n/2]
                //If n is even, median=(dataset[n/2]+dataset[1+n/2])/2
                //The index of array starts from 0, so you need to subtract 1 from the           //indices   used in calculating the median
                if (n % 2 != 0) median = dataset[n / 2];
                else median = (dataset[(n / 2) - 1] + dataset[n / 2]) / (float)2;

                //calculate the mode
                int[,] mode = new int[n, 2];
                //initialize 2D array storing numbers of occurences, and values
                for (i = 0; i < 2; i++)
                    for (j = 0; j < n; j++) mode[j, i] = 0;
                mode[0, 0] = 1;

                for (i = 0; i < n; i++)
                    for (j = 0; j < n - 1; j++)
                        if (dataset[i] == dataset[j + 1]) { ++mode[i, 0]; mode[i, 1] = dataset[i]; }

                int max;
                int k = 0;
                max = mode[0, 0];
                for (j = 0; j < n; j++)
                    if (max < mode[j, 0]) { max = mode[j, 0]; k = j; }


                //calculate standard deviation, std
                float temp = 0.0f;

                for (j = 0; j < n; j++)
                {
                    temp = temp + (float)Math.Pow(dataset[j] - mean, 2);
                }

                std = (float)Math.Sqrt(temp / (n - 1));

                //Show results

                Console.WriteLine("Statistical Information:");
                Console.WriteLine("..................................................");
                Console.WriteLine("Arithmetic mean:{0}", mean);
                Console.WriteLine("Median:{0}", median);
                if (mode[k, 1] != 0)
                    Console.WriteLine("Mode:{0}", mode[k, 1]);
                else Console.WriteLine("Mode: no mode");
                Console.WriteLine("Standard deviation:{0}", std);


            }
            Console.ReadLine();

        }

        ///bubble sort

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
