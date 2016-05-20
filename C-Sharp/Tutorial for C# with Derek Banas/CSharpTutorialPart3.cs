// Followed along with the author's tutorial and added notes provided in his guide for reference.

// ---------- GENERIC CLASS ----------


    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }

        public void showData()
        {
            Console.WriteLine("{0} is {1}", this.key, this.value);
        }
    }

// With Generics you don't have to specify the data type of an element in a class or method
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");
            superman.key = "Superman";
            superman.value = "Clark Kent";
            superman.showData();
 
            // Now use completely different types
            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0, "");
            samsungTV.key = 123456;
            samsungTV.value = "a 50in Samsung TV";
            samsungTV.showData();
 
            Console.Write("Hit Enter to Exit");
            string exitApp = Console.ReadLine();
 
        }
    }
}

 

// ---------- ENUMS ----------

    // Enums are unique types with symbolic names and associated values
 
public enum Temperature
{
    Freeze,
    Low,
    Warm,
    Boil
}
 
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

struct Customers
{
    private string name;
    private double balance;
    private int id;

    public void createCust(string n, double b, int i)
    {
        name = n;
        balance = b;
        id = i;
    }

    public void showCust()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Balance : " + balance);
        Console.WriteLine("ID : " + id);
    }
}
            Customers bob = new Customers();

            bob.createCust("Bob", 15.50, 12345);
 
            bob.showCust();
 
            // ---------- ANONYMOUS METHODS ----------
            // An anonymous method has no name and its return type is defined by the return used in the method
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate double GetSum(double num1, double num2);
// defined outside of the class

namespace ConsoleApplication3
{
    class Animal
    {
        static void Main(string[] args)
        {
            GetSum sum = delegate (double num1, double num2)
        {
            return num1 + num2;
        };
        Console.WriteLine("5 + 10 = " + sum(5, 10));
        }
    }
}
 
            // ---------- LAMBDA EXPRESSIONS ----------
            // A lambda expression is used to act as an anonymous function or expression tree
 
            // You can assign the lambda expression to a function instance
            using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate double GetSum(double num1, double num2);
// defined outside of the class

namespace ConsoleApplication3
{
    class Animal
    {
        static void Main(string[] args)
        {
            Func<int, int, int> getSum = (x, y) => x + y;

            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));
        }
    }
}
 
// Get odd numbers from a list
    List<int> numList = new List<int> { 5, 10, 15, 20, 25 };

// With an Expression Lambda the input goes in the left (n) and the statements go on the right
    List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();
 
    foreach(int num in oddNums)
    {
        Console.WriteLine(num + ", ");
    }
 
// ---------- FILE I/O ----------
// The StreamReader and StreamWriter allows you to create text files while reading and
// writing to them

class Animal
{
    static void Main(string[]) args)
    {
     
        string[] custs = new string[] { "Tom", "Paul", "Greg" };
 
        using (StreamWriter sw = new StreamWriter("custs.txt"))
        {
            foreach(string cust in custs)
            {
                sw.WriteLine(cust);  // sw = StreamWriter
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