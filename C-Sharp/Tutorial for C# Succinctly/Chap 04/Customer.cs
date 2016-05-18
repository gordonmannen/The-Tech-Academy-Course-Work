// An example to illustrate how to control reference type equality.

public class Customer
{
    int id;
    string name;

    public Customer(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;

        if (obj.GetType() != typeof(Customer))
            return false;

        Customer cust = obj as Customer;

        return id == cust.id;
    }

    public static bool operator ==(Customer cust1, Customer cust2)
    {
        return cust1.Equals(cust2);
    }

    public static bool operator !=(Customer cust1, Customer cust2)
    {
        return !cust1.Equals(cust2);
    }

    public override int GetHashCode()
    {
        return id;
    }

    public override string ToString()
    {
        return $"{{ id: {id}, name: {name} }}";
    }
}

// When overriding Equals, check for null & type equality before working with the
// objects to prevent callers from accidentally comparing null or incompatible types.


// Below is an example of how to check equality of Customer instances.
// ReferenceEquals is an object method that is useful because it allows reference equality
// checking in case the type defined a custom Equals override.

using System;

class Program
{
    static void Main()
    {
        Customer cust1 = new Customer(1, "May");
        Customer cust2 = new Customer(2, "Joe");
        Console.WriteLine($"cust1 == cust2: {cust1 == cust2}");
        Customer cust3 = new Customer(1, "May");
        Console.WriteLine($"\ncust1 == cust3: {cust1 == cust3}");
        Console.WriteLine($"cust1.Equals(cust3): {cust1.Equals(cust3)}");
        Console.WriteLine($"object.ReferenceEquals(cust1, cust3):
   { object.ReferenceEquals(cust1, cust3)}
        ");
    Console.WriteLine($"\ncust1: {cust1}");
        Console.WriteLine($"cust2: {cust2}");
        Console.WriteLine($"cust3: {cust3}");
        Console.ReadKey();
    }
}

