using System;

class Program
{
    static void Main()
    {
        var calc4 = new Calculator4();

        calc4.GetNumber("First");
        calc4.GetNumber("Second");

        calc4.AddNumbers();

        PrintResult(calc4);

        Console.ReadKey();
    }

    static void PrintResult(Calculator4 calc)
    {
        Console.WriteLine();
        Console.WriteLine($"\nYour result is {calc.Result}.");
    }
}

// Main method creates a new instance of Calculator4 and calls public methods.
// The internals of Calculator4 are hidden and Main is only concerned with the
// public interface, revealing Calculator4 services for reuse.

    // PrintResult method reads the Calculator4 instance Result propert.
    // This is a key benefit of methods & properties:  callers can use
    // a class without knowing or caring about exactly how that class does
    // what it does.