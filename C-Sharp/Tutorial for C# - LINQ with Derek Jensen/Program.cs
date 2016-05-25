using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sample = "I enjoy writing uber software in C#";
            var people = new List<Person>
            {
                new Person{FirstName = "John", LastName = "Doe", Age = 25},
                new Person{FirstName = "Jane", LastName = "Doe", Age = 26},
                new Person{FirstName = "John", LastName = "Williams", Age = 40},
                new Person{FirstName = "Samantha", LastName = "Williams", Age = 34},
                new Person{FirstName = "Bob", LastName = "Walters", Age = 12},
            };

            var result = from p in people
                             //where p.Age < 25 && p.LastName = "Doe"
                             //where p.Age < 30
                             //where p.Age < 30 && p.LastName == "Doe"
                         orderby p.LastName descending
                         group p by p.LastName;
                         //select p;
                
                
                         //from c in sample.ToLower()
                         //where c == 'a' || c == 'e' || c == 'o' || c == 'i' || c == 'u'
                         //orderby c
                         //orderby c descending
                         //group c by c;
                         //select c; // when using group/by, compiler assumes it is the last statement, so no select typically.
            foreach (var item in result)
            {
                //Console.WriteLine(item);
                //Console.WriteLine(item.Key);
                //Console.WriteLine("{0} - {1}", item.Key, item.Count());
                //Console.WriteLine("{0} - {1}", item.FirstName, item.LastName);
                //Console.WriteLine("{0}, {1}", item.LastName, item.FirstName);
                Console.WriteLine(item.Key + " - " + item.Count());
                foreach (var p in item)
                {
                    Console.WriteLine("\t{0}, {1}", p.LastName, p.FirstName);
                }
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
