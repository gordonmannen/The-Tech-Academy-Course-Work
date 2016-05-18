// Followed along with the author's tutorial and added notes provided in his guide for reference.

// using declares the namespaces and functions which will be used in the file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ---------- EXCEPTION HANDLING ----------
            // All the exceptions
            // msdn.microsoft.com/en-us/library/system.systemexception.aspx#inheritanceContinued
 
                try
                {
                    Console.Write("Divide 10 by ");
                    int num = int.Parse(Console.ReadLine());
Console.WriteLine("10 / {0} =  {1}", num, (10/num));
 
                }
 
                // Specifically catches the divide by zero exception
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Can't divide by zero");
 
                    // Get additonal info on the exception
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
 
                    // Throw the exception to the next inline
                    // throw ex;
 
                    // Throw a specific exception
                    throw new InvalidOperationException("Operation Failed", ex);
                }
 
                // Catches any other exception
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
 
            // ---------- CLASSES & OBJECTS ----------

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++;

        }

        public Animal(double heigh, double weight, string name, string sound)
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weight {2} lbs and likes to say {3}",name,height,weight,sound);

        }

        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "Spot", "Woof");

            Console.WriteLine("{0} say {1}", spot name, spot sound);

            Console.WriteLine("Number of Animals" + Animal.getNumOfAnimals());

            Console.WriteLine(spot.toString());



        }
    }
}
 
            Animal bulldog = new Animal(13, 50, "Spot", "Woof");

Console.WriteLine("{0} says {1}", bulldog.name, bulldog.sound);
 
            // Console.WriteLine("No. of Animals " + Animal.getNumOfAnimals());
 
            // ---------- ENUMS ----------
 
            Temperature micTemp = Temperature.Low;
Console.Write("What Temp : ");
 
            Console.ReadLine();
 
            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;
 
                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;
 
                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;
 
                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }
 
            // ---------- STRUCTS ----------
            Customers bob = new Customers();

bob.createCust("Bob", 15.50, 12345);
 
            bob.showCust();
 
            // ---------- ANONYMOUS METHODS ----------
            // An anonymous method has no name and its return type is defined by the return used in the method
 
            GetSum sum = delegate (double num1, double num2) {
                return num1 + num2;
            };

Console.WriteLine("5 + 10 = " + sum(5, 10));
 
            // ---------- LAMBDA EXPRESSIONS ----------
            // A lambda expression is used to act as an anonymous function or expression tree
 
            // You can assign the lambda expression to a function instance
            Func<int, int, int> getSum = (x, y) => x + y;
Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));
 
            // Get odd numbers from a list
            List<int> numList = new List<int> { 5, 10, 15, 20, 25 };

// With an Expression Lambda the input goes in the left (n) and the statements go on the right
List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();
 
            foreach (int num in oddNums) {
                Console.Write(num + ", ");
            }
 
            // ---------- FILE I/O ----------
            // The StreamReader and StreamWriter allows you to create text files while reading and
            // writing to them
 
            string[] custs = new string[] { "Tom", "Paul", "Greg" };
 
            using (StreamWriter sw = new StreamWriter("custs.txt"))
            {
                foreach(string cust in custs)
                {
                    sw.WriteLine(cust);
                }
            }
 
            string custName = "";
            using (StreamReader sr = new StreamReader("custs.txt"))
            {
                while ((custName = sr.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }
 
            Console.Write("Hit Enter to Exit");
            string exitApp = Console.ReadLine();
 
        }
    }
}