// Working with Collections & Generics

// Using generic collections is standard practice in .NET today.

// Using Collections
// For different situations for .NET collections you might use an array, a list, a queue, a stack,
// a dictionary, etc.

// With generics you can build your own, but should first check System.Collections.Generic namespace to see if the collection
// you need has already been written.

// Example using a List
using System;
using System.Collections.Generic;
public class Company
{
    public string Name { get; set; }
}
public class Program{
    public static void Main()
    {
        List<string> names = new List<string>();
        names.Add("Joe");
        names.Insert(0, "Car");
        names.Add("Jill");
        names[0] = "Building";
        names.RemoveAt(0);
        Console.WriteLine($"First name: {names[0]}");
        IList<Company> companies = new List<Company>
 {
 new Company { Name = "Syncfusion" },
 new Company { Name = "Microsoft" },
 new Company { Name = "Acme" }
 };
        foreach (Company cmp in companies)
            Console.WriteLine(cmp.Name);
        Console.ReadKey();
    }
}// foreach loop is used above, but could also use ForEach method of List, see below:
List<Company> companyList = companies as List<Company>;
companyList.ForEach(cmp => Console.WriteLine(cmp.Name));// Example using Dictionaryusing System;
using System.Collections.Generic;
public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
}
public class Program
{
    public static void Main()
    {
        Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
        Customer jane = new Customer { ID = 0, Name = "Jane" };
        Customer joe = new Customer { ID = 1, Name = "Joe" };
        customers.Add(jane.ID, jane);
        customers[joe.ID] = joe;
        foreach (int key in customers.Keys)
            Console.WriteLine(customers[key].Name);
        Dictionary<int, Customer> customers2 = new Dictionary<int, Customer>
        {
            [0] = new Customer { ID = 0, Name = "Chris" },
            [1] = new Customer { ID = 1, Name = "Alex" }
        };
        Console.ReadKey();
    }
}

// Writing Generic Code
// If you write a generic linked list, you will need a Node class to hold an object and reference the
// next in the list, and a LinkedList collection class that performed list operations.

// Example Node class containing an object instance
class Node<T>  // the <T> indicates that it is a generic Node class.
{
    public T Item { get; set; }
    public Node<T> Next;
    public Node(T item)
    {
        Item = item;
    }
}// To instantiate a Node<T>Node<string> name = new Node<string>(“May”);// it is now strongly typed, it will only hold strings.Using System;
using System.Collections;
using System.Collections.Generic;
public class LinkedList<T> : IList<T>
{
    Node<T> head;
    Node<T> tail;
    public void Add(T item)
    {
        var node = new Node<T>(item);
        if (head == null)
            head = node;
        else
            tail.Next = node;
        tail = node;
    }
    // Other IList members…
}// Example of instantiating LinkedList<T>public class Program
{
    public static void Main()
    {
        var llist = new LinkedList<string>();
        llist.Add("Jamie");
        llist.Add("Ron");
        //...
        Node<string> name = new Node<string>("May");
    }
}

// Example generic methods (a couple factory methods; one is type object, the other is generic)
using System;
public class CustomerReport
{
    public DateTime Date { get; set; }
}
public class OrdersReport
{
    public DateTime Date { get; set; }
}
public class ReportFactory
{
    public static object Create(Type reportType)
    {
        switch (reportType.ToString())
        {
            case "CustomerReport":
                var custRpt = new CustomerReport();
                custRpt.Date = DateTime.Now;
                return custRpt;
            default:
            case "OrdersReport":
                var ordsRpt = new OrdersReport();
                ordsRpt.Date = DateTime.Now;
                return ordsRpt;
        }
    }
}
public class Program
{
    public static void Main()
    {
        var rpt = (CustomerReport)ReportFactory.Create(typeof(CustomerReport));
        Console.ReadKey();
    }
}

// The above ReportFactory implementation contains a lot of duplication in the code and the use of cast
// and typeof operators in the Main method (more syntax that necessary, not very maintainable as complexity
// grows.

// Example showing how to refactor the Create method into a generic method:

using System;
public abstract class Report { }
public class CustomerReport : Report
{
    public DateTime Date { get; set; }
}
public class OrdersReport : Report
{
    public DateTime Date { get; set; }
}
public class ReportFactory
{
    public static TReport Create<TReport>()
    where TReport : Report
    {
        switch (typeof(TReport).Name)
        {
            case "CustomerReport":
                var custRpt = new CustomerReport();
                custRpt.Date = DateTime.Now;
                return (TReport)(Report)custRpt;
            default:
            case "OrdersReport":
                var ordsRpt = new OrdersReport();
                ordsRpt.Date = DateTime.Now;
                return (TReport)(Report)ordsRpt;
        }
    }
}
public class Program
{
    public static void Main()
    {
        var rpt2 = ReportFactory.Create<CustomerReport>();
        Console.ReadKey();
    }
}

// The Create method has a new type paramter, TReport.
// The generic constraint helps simplify the calling code.

// The Create<TReport> method is still longer than it has to be and contains too much
// duplication.  That can be resolved by using generic constraints.

// Generic Type Constraints
// 1) interface
// 2) base class
// 3) class
// 4) struct
// 5) new

// Further simplification using two constraints:  interface and new.
using System;
public interface IReport
{
    DateTime Date { get; set; }
}
public class CustomerReport : IReport
{
    public DateTime Date { get; set; }
}
public class OrdersReport : Report, IReport
{
    public DateTime Date { get; set; }
}
public class ReportFactory
{
    public static TReport Create<TReport>()
    where TReport : IReport, new()
    {
        return new TReport() { Date = DateTime.Now };
    }
}
public class Program
{
    public static void Main()
    {
        var rpt2 = ReportFactory.Create<CustomerReport>();
        Console.ReadKey();
    }
}

// The new interface is IReport, which CustomerReport and OrdersReport derive from.

// The above refined example takes care of the issues of duplicated and excessive code, simplifies
// it with generic code in both implementation and use.

// Note:  You can also use generic delegates.  First seek to reuse types already present in the FCL.
// For example, the popular EventHandler<TEventArgs>
// .NET collection classes are more versatile than arrays and allow you to manage your objects in a way that
// better help the design of your application.