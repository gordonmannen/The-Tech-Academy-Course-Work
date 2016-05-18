// Object Lifetime
// Lifetime of a value type (struct or enum) depends on where it is allocated.

// Parameter/variable value type instances - reside on the stack and exist for
// as long as they are in scope.

// Reference type instances (class) begin life when their constructors execute.  The CLR
// allocates their spaced on the managed heap, and they exist until the CLR garbage collector
// (GC) cleans them up.


// static constructor and two instance constructor overloads.
using System;
public class Calculator
{
    static double pi = Math.PI;
    double startAngle = 0;
    public DateTime Created { get; } = DateTime.Now;
    static Calculator()
    {
        Console.WriteLine("static Calculator()");
    }
    public Calculator()
    {
        Console.WriteLine("public Calculator()");
    }
    public Calculator(int val)
    {
        Console.WriteLine("public Calculator(int)");
    }
}
// a derived class with similar members.
using System;

public class ScientificCalculator : Calculator
{
    static double pi = Math.PI;
    double startAngle = 0;

    static ScientificCalculator()
    {
        Console.WriteLine("static ScientificCalculator()");
    }

    public ScientificCalculator() : this(0)
    {
        Console.WriteLine("public ScientificCalculator()");
    }

    public ScientificCalculator(int val)
    {
        Console.WriteLine("public ScientificCalculator(int)");
    }

    public ScientificCalculator(int val, string word) : base(val)
    {
        Console.WriteLine("public ScientificCalculator(int, string)");
    }

    public double EndAngle { get; set; }
}