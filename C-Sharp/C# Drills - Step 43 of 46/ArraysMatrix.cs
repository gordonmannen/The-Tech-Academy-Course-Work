using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            int i, j;

            for (i = 0; i < 5; i++) //assign values to the matrix

                for (j = 0; j < 5; j++)

                { //if row=column=> fill the matrix with 0

                    if (i == j) matrix[i, j] = 0;//if row>columns=> fill matrix with -1

                    else if (i > j) matrix[i, j] = -1;//if row<columns=> fill matrix with 1

                    else matrix[i, j] = 1;

                }



            for (i = 0; i < 5; i++)

            { //print the matrix

                for (j = 0; j < 5; j++)

                    Console.Write("{0}\t", matrix[i, j]);

                Console.WriteLine();

            }
        }
    }
}
