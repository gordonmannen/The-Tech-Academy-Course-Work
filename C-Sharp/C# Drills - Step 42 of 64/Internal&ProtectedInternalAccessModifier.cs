using System;


// Access Modifiers:  public, protected, internal, private, & protected internal.

class Program
{
    static void Main()
    {
        // Adding internal keyword limits access, it does not allow access from external programs 
        //(it 'hides' the internal 'type' from external programs)
        // Internal can be accessed fine from within the same assembly, but is not accessible from
        // a different assembly.
        TestI testI = new TestI();
        testI._x = 1;

        TestPI testPI = new TestPI();
        testPI._y = 1;
    }
}

// Internal type example

internal class TestI
{
    public int _x;
}


// Protected Internal type example

// If access is being attempted from a different assembly by a class that has NOT inherited the originating assembly class - NO
// If access is being attempted from a different assembly by a class that HAS inherited the originating assembly class - YES

protected internal class TestPI
{
    public int _y;
}
