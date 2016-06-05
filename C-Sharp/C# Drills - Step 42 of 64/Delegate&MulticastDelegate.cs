// Creation and use of a delegate
// A reference type that invokes one or more methods through the delegate instance.
// Holds a reference of the methods.  Delegate types are both sealed and immutable type.

class Program
{
    // Declare the delegate
    delegate double CalculateRetailPrice(double p, double t);
    static CalculateRetailPrice RP = getTotalPrice;

    static void Main(string[] args)
    {
        CalculateRetailPrice D = new CalculateRetailPrice(getTotalPrice);
        totalPrice = D(25.95, 1.096);
        Console.WriteLine("Total Price is {0}", totalPrice);
        Console.ReadKey();
    }

    static double getTotalPrice(double p, double t)
    {
        return (p*t);
    }
}

// Creation and use of a multicast delegate
// Can be used to invoke multiple methods.

class Program
{
    // Declare the delegate
    delegate double CalculateRetailPrice(double para1, double para2, double para3);
    static CalculateRetailPrice dObjRP = getTotalPrice;

    static void Main(string[] args)
    {
        double RP;
        dObjRP += new Program.CalculateRetailPrice(getTotalHolidayPrice);
        double Holiday = dObjRP.Invoke(RP, 0.9);
        Console.WriteLine("Holiday Price is {0}", HolidayPrice);

        Console.ReadKey();
    }

    static double getTotalPrice(double p, double t)
    {
        return (p*t);
    }

    static double getTotalHolidayPrice(double RP, double h)
    {
        return (RP * h);
    }
}