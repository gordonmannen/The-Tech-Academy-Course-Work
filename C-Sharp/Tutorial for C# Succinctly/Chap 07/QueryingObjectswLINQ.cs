// Querying Objects with LINQ
// LINQ (Language-Integrated Query) allows you to query data with SQL-like syntax.
// LINQ is used with many different types of data & Microsoft & 3rd parties have built
// LINQ providers to be able to access a broad range of data sources.
// LINQ to Objects is the basis by which we can learn the syntax which applies to the other LINQ
// providers as well (or it is at least similar).

using System.Collections.Generic;  // System.Linq namespace needs to be included in the using declarations when working with LINQ.
public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
}
public class Order
{
    public int CustomerID { get; set; }
    public string Description { get; set; }
}
public static class Company
{
    static Company()
    {
        Customers = new List<Customer>
         {
             new Customer { ID = 0, Name = "May" },
             new Customer { ID = 1, Name = "Gary" },
             new Customer { ID = 2, Name = "Jennifer" }
         };
        Orders = new List<Order>
         {
             new Order { CustomerID = 0, Description = "Shoes" },
             new Order { CustomerID = 0, Description = "Purse" },
             new Order { CustomerID = 2, Description = "Headphones" }
         };
    }

    public static List<Customer> Customers { get; set; }
    public static List<Order> Orders { get; set; }

}

// Querying Collections

using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public void Main()
    {
        IEnumerable<Customer> customers =
        from cust in Company.Customers
        select cust;
        foreach (Customer cust in customers)
            Console.WriteLine(cust.Name);
    }
}

// LINQ to Objects queries result in a collection of type IEnumberable<T>.
// A collection of Customer objects in the example above.

// Query Custom name
IEnumerable<string> customers2 =
 from cust2 in Company
 select cust2.Name;

// Example where you need a whole different object, to define the object:
public class CustomerViewModel
{
    public string Name { get; set; }
}

// New projection:

IEnumerable<CustomerViewModel> customerVMs =
from custVM in Company.Customers
select new CustomerViewModel // instantiates a new CustomerViewModel
{
Name = custVM.Name // Populates values, using object initialization syntax
};

// The result will be a collection of type CustomerViewModel.

// Using an anonymous type:

var customers3 =
    from cust3 in Company.Customers
    select new // new without a type name:  an anonymous type
    {
        Name = cust3.Name
    };
 foreach (var cust3 in customers3)  // var keyword is the type
    Console.WriteLine(cust3.Name);

// Another common way to use var:
var customer = new Customer();

// Example where the object type of the variable is unclear, it would be more maintainable code by
// specifying the type.
var response = DoSomethingAndReturnResults();

// When you use var, the code is still strongly typed.  Once you assign a value to a variable of type var,
// you can't assign any other type to that variable.

// Filtering Data

// Example filtering a collection with the where clause:
var customers4 =
    from cust4 in Company.Customers
    where cust4.Name.Length > 3 && !cust4.Name.StartsWith("G")
    select cust4;
 foreach (var cust4 in customers4)
    Console.WriteLine(cust4.Name);

// In LINQ to Objects you can various means of creating complex conditions:
 // logical operators
 // parentheses for grouping
 // other logic to filter results
 // call another method that will evaluate the current object being evaluated

// The result of the where clause must evaluate to a bool.
// Other LINQ providers may have a different set of resrictions.

// Ordering Collections

// Example sorting collection results using orderby clause:
var customers5 =
    from cust5 in Company.Customers
    orderby cust5.Name descending // default is ascending
    select cust5;
foreach (var cust5 in customers5)
    Console.WriteLine(cust5.Name);

    // Example result:
    // May
    // Jennifer
    // Gary

// Joining Objects

// Example joining two different collections of objects or related tables in a database together:
var customerOrders =
    from cust in Company.Customers
    join ord in Company.Orders
        on cust.ID equals ord.CustomerID
    select new
    {
        ID = cust.ID,
        Customer = cust.Name,
        Item = ord.Description
    };
foreach (var custOrd in customerOrders)
    Console.WriteLine(
        $"Customer: {custOrd.Customer}, Item: {custOrd.Item}");

// Example is the 'equivalent' of a left join

var customerOrders2 =
    from cust in Company.Customers
    join ord in Company.Orders.DefaultIfEmpty() // DefaultIfEmpty() is the difference
        on cust.ID equals ord.CustomerID
    select new
    {
        ID = cust.ID,
        Customer = cust.Name,
        Item = ord.Description
    };
foreach (var custOrd2 in customerOrders)
    Console.WriteLine(
        $"Customer: {custOrd2.Customer}, Item: {custOrd2.Item}");

// Using Standard Operators
// There are literally dozens of standard query operators (see bookmarks for a list)

// Some examples using standard query operators:
// This is a ToList example
var custList =
    (from cust in Company.Customers
     select cust)
    .ToList();
custList.ForEach(cust => Console.WriteLine(cust.Name));

// The ForEach method on List<T> lets  you pass a lambda.
// LINQ queries use deferred execution, meaning it will not execute until you execute a foreach loop or call one of the
// standard query operators, like ToList, that requests the data.

// Example of Where and Select operators which mirror the where and select language syntax clauses:

var customers6 =
    Company.Customers
        .Where(cust => cust.Name.StartsWith("J"));
foreach (var cust6 in customers6)
    Console.WriteLine(cust6.Name);

var customers7 =
    Company.Customers.Select(cust => cust.Name);
foreach (var cust7 in customers7)
    Console.WriteLine(cust7);

// The Where lambda must evaluate to a bool and the Select lambda lets you specify the projection.

// You can also perform set operations like Union, Except, & Intersect.

// Example using Union:

var additionalCustomers =
    new List<Customer>
    {
        new Customer { ID = 1, Name = "Gary" }
    };
var customerUnion =
    Company.Customers
        .Union(additionalCustomers)
        .ToArray();
foreach (var cust in customerUnion)
    Console.WriteLine(cust.Name);

// Pass a compatible collection and Union will produce a combined collection of all objects.
// In the above example, ToArray operator will result in an array of the collection type, Customer.

// Some useful operators:  First, FirstOrDefault, Single, SingleOrDefault, Last, & LastOrDefault
// Example using First:
Console.WriteLine(Company.Customers.First().Name);

// Example using SingleOrDefault
var empty =
    Company.Customers
        .Where(cust => cust.ID == 999)
        .SingleOrDefault();
if (empty == null)
    Console.WriteLine("No values returned.");