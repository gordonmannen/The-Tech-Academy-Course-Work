using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordPrefixGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring multi-dimensional array to store words, prefixes, and descriptions
            //Each default answer is incorrect
            //we store 4 works, 4 prefixes, and 4 default answers
            string[,] terms = new string[4, 3];
            int row = 0;
            terms[row, 0] = "substring";
            terms[row, 1] = "sub";
            terms[row, 2] = "incorrent";
            row++;

            terms[row, 0] = "hypertext";
            terms[row, 1] = "hyper";
            terms[row, 2] = "incorrent";

            row++;

            terms[row, 0] = "antivirus";
            terms[row, 1] = "anti";
            terms[row, 2] = "incorrent";

            row++;

            terms[row, 0] = "immutable";
            terms[row, 1] = "im";
            terms[row, 2] = "incorrent";
            //play the first two words 
            int numrows = 0;
            playnext(terms, numrows);
            //allow the user to play the next two words
            Console.Write("Next? press y for next play:");
            string next = Console.ReadLine();
            if (next.CompareTo("y") == 0)
            {
                Console.Clear();//clear screen
                numrows += 2;
                playnext(terms, numrows);
            }


            Console.ReadLine();


        }

        static void playnext(string[,] terms, int rows)
        {
            Console.WriteLine(".............................................................");
            Console.WriteLine("\t\t\tENGLISH WORD PREFIX GAME");
            Console.WriteLine(".............................................................");
            //collect answer and make comparison then update the array
            for (int i = rows; i < rows + 2; i++)
            {
                Console.Write("What is the correct prefix of {0}:", terms[i, 0]);
                string ans = Console.ReadLine();
                if (terms[i, 1].ToLower().CompareTo(ans.ToString().ToLower()) == 0)
                    terms[i, 2] = "correct";
                Console.WriteLine();


            }


            //Print report
            Console.WriteLine("CHECK YOUR ANSWERS");
            Console.WriteLine("=============================================");
            Console.WriteLine("Word\t\tPrefix\tDescription");
            Console.WriteLine("=============================================");

            for (int i = rows; i < rows + 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}\t", terms[i, j]);
                Console.WriteLine();
            }
        }
    }
}
