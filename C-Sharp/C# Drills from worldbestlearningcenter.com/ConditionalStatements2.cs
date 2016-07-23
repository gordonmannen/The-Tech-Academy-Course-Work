using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements2
{
    class Program
    {
        static void Main(string[] args)
        {
            float quiz_score;
            float mid_score;
            float final_score;
            float avg;
            Console.Write("Enter quiz score:");
            quiz_score = float.Parse(Console.ReadLine());
            Console.Write("Enter mid-term score:");
            mid_score = float.Parse(Console.ReadLine());
            Console.Write("Enter final score:");
            final_score = float.Parse(Console.ReadLine());
            avg = (quiz_score + mid_score + final_score) / 3;

            if (avg >= 90) Console.WriteLine("Grade A");
            else if ((avg >= 70) && (avg < 90)) Console.WriteLine("Grade B");
            else if ((avg >= 50) && (avg < 70)) Console.WriteLine("Grade C");
            else if (avg < 50) Console.WriteLine("Grade F");
            else Console.WriteLine("Invalid input");


            Console.ReadLine();
        }
    }
}
